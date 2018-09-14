using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Queue implementation with C# by @zygabyte");

                Console.WriteLine("_____________ArrayQueue Implementation_____________");
                var arrayQueue = new ArrayQueue<string>(10);
                Console.WriteLine("Initial queue");
                arrayQueue.Enqueue("first");
                arrayQueue.Enqueue("second");
                arrayQueue.Enqueue("third");
                arrayQueue.Enqueue("fourth");
                arrayQueue.Enqueue("fifth");
                arrayQueue.Enqueue("sixth");
                arrayQueue.Enqueue("seventh");
                arrayQueue.Enqueue("eighth");
            
                arrayQueue.PrintQueue();
                
                Console.WriteLine("Is Queue empty? ");
                Console.WriteLine(arrayQueue.IsEmpty());
                Console.WriteLine();

                Console.WriteLine("First element in queue");
                Console.WriteLine(arrayQueue.First());
            
                Console.WriteLine("\nDequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
                
                Console.WriteLine("Enqueuing...");
                arrayQueue.Enqueue("random dude");
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                arrayQueue.Dequeue();
                arrayQueue.PrintQueue();
                
                Console.WriteLine("Is Queue empty? ");
                Console.WriteLine(arrayQueue.IsEmpty());
                Console.WriteLine();

                Console.WriteLine("Enqueuing again");
                arrayQueue.Enqueue("1");
                arrayQueue.Enqueue("second");
                arrayQueue.Enqueue("3");
                arrayQueue.Enqueue("fourth");
                arrayQueue.Enqueue("5");
                arrayQueue.Enqueue("sixth");
                arrayQueue.Enqueue("7");
                arrayQueue.Enqueue("8");
                arrayQueue.Enqueue("9");
                arrayQueue.Enqueue("10");
                arrayQueue.PrintQueue();
                Console.WriteLine("_____________End ArrayQueue Implementation_____________");
                Console.WriteLine();

                
                
                Console.WriteLine("_____________LinkedQueue Implementation_____________");
                var linkedQueue = new LinkedQueue<string>();
                Console.WriteLine("Initial queue");
                linkedQueue.Enqueue("first");
                linkedQueue.Enqueue("second");
                linkedQueue.Enqueue("third");
                linkedQueue.Enqueue("fourth");
                linkedQueue.Enqueue("fifth");
                linkedQueue.Enqueue("sixth");
                linkedQueue.Enqueue("seventh");
                linkedQueue.Enqueue("eighth");
            
                linkedQueue.PrintQueue();
                
                Console.WriteLine("Is Queue empty? ");
                Console.WriteLine(linkedQueue.IsEmpty());
                Console.WriteLine();

                Console.WriteLine("First element in queue");
                Console.WriteLine(linkedQueue.First());
            
                Console.WriteLine("\nDequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
                
                Console.WriteLine("Enqueuing...");
                linkedQueue.Enqueue("random dude");
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
            
                Console.WriteLine("Dequeuing...");
                linkedQueue.Dequeue();
                linkedQueue.PrintQueue();
                
                Console.WriteLine("Is Queue empty? ");
                Console.WriteLine(linkedQueue.IsEmpty());
                Console.WriteLine();
               
                Console.WriteLine("Enqueuing again");
                linkedQueue.Enqueue("1");
                linkedQueue.Enqueue("second");
                linkedQueue.Enqueue("3");
                linkedQueue.Enqueue("fourth");
                linkedQueue.Enqueue("5");
                linkedQueue.Enqueue("sixth");
                linkedQueue.Enqueue("7");
                linkedQueue.Enqueue("8");
                linkedQueue.Enqueue("9");
                linkedQueue.Enqueue("10");
                linkedQueue.PrintQueue();
                Console.WriteLine("_____________End LinkedQueue Implementation_____________");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}