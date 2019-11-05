using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist NumList = new Linkedlist();

            Console.WriteLine("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            var Splitnum = num.ToString().Select(x => int.Parse(x.ToString()));

            foreach (var x in Splitnum)
            {
                NumList.AddFirst(x);
            }
            NumList.printAllNodes();
            Console.ReadLine();
        }

    }
    public class Node
    {
        public Node next;
        public object data;
    }
    public class Linkedlist
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

    }
    
}
