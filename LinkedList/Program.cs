using System;
//using Services;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var linkedList = new SinglyLinkedList<string>();
            
            Console.WriteLine("Initial List");
            linkedList.AddLast("first");
            linkedList.AddLast("second");
            linkedList.AddLast("third");
            linkedList.AddLast("fourth");
            linkedList.PrintList();
            
            Console.WriteLine("Added '1' to head");
            linkedList.AddFirst("1");
            linkedList.PrintList();

            Console.WriteLine("Removed from head");
            linkedList.RemoveFirst();
            linkedList.PrintList();
            
            Console.WriteLine("Added '5' to tail");
            linkedList.AddLast("5");
            linkedList.PrintList();
            
            Console.WriteLine("Removed value 'third'");
            linkedList.RemoveValue("third");
            linkedList.PrintList();

        }
    }
}