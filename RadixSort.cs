using System;
using System.Collections;
using System.IO;
namespace csqueue
{
    class Class1
    {
        enum DigitType
        {
            ones = 1,
            tens = 10,
            hund = 100
        }

        static void DisplayArray(int[] n)
        {
            for (int x = 0; x <= n.GetUpperBound(0); x++)
                Console.Write(n[x] + " "); 
        }
        static void RSort(Queue[] que, int[] n, DigitType digit)
        {
            int snum;
            for (int x = 0; x <= n.GetUpperBound(0); x++)
            {
                if (digit == DigitType.ones)
                    snum = n[x] % 10;

                else if (digit == DigitType.tens)
                {
                    snum = n[x] / 10;
                    snum = snum % 10;
                }
                else
                    snum  = n[x]/ 100;
                que[snum].Enqueue(n[x]);
            }
        }
        static void BuildArray(Queue[] que, int[] n)
        {
            int y = 0;
            int x = 0;

            for (x = 0; x <= 9; x++)
            {
                while (que[x].Count > 0)
                {
                    n[y] = Int32.Parse(que[x].Dequeue().ToString());
                    y++;
                }
            }
        }
        static void Main(string[] args)
        {
            Queue[] numQueue = new Queue[10];
            int[] nums = new int[] { 912, 46, 8, 155, 92, 345, 381, 122 };
            int[] random = new Int32[99];
            // Display original list
            for (int i = 0; i < 10; i++)
                numQueue[i] = new Queue();
            RSort(numQueue, nums, DigitType.ones);
            //numQueue, nums, 1
            BuildArray(numQueue, nums);
            Console.WriteLine();
            Console.WriteLine("First pass results: ");
            DisplayArray(nums);
            // Second pass sort
            RSort(numQueue, nums, DigitType.tens);
            BuildArray(numQueue, nums);
            Console.WriteLine();
            Console.WriteLine("Second pass results: ");
            // Display final results
            DisplayArray(nums);
            // Second pass sort
            RSort(numQueue, nums, DigitType.hund);
            BuildArray(numQueue, nums);
            Console.WriteLine();
            Console.WriteLine("Third pass results: ");
            // Display final results
            DisplayArray(nums);
            Console.WriteLine();
            Console.Write("Press enter to quit");
            Console.Read();
        }
    }
}