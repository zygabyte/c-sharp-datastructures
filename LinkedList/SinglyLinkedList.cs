using System;

namespace LinkedList
{
    public class SinglyLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Size { get; private set; }

        public bool IsEmpty() => Size == 0;

        public T First()
        {
            if (IsEmpty()) throw new ArgumentNullException($"Cannot access first elemenet in empty list");
            return _head.Element;
        }
        
        public T Last()
        {
            if (IsEmpty()) throw new ArgumentNullException($"Cannot access last elemenet in empty list");
            return _tail.Element;
        }

        public void AddFirst(T element)
        {
            _head = new Node<T>(element, _head);
            if (Size == 0) _tail = _head;
            Size++;
        }
        
        public void AddLast(T element)
        {
            var newest = new Node<T>(element, null);
            if (IsEmpty()) _head = newest;
            else _tail.Next = newest;
            
            _tail = newest;
            Size++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty()) throw new ArgumentNullException($"Cannot delete first elemenet in empty list");
            T element = _head.Element;
            _head = _head.Next;
            Size--;

            if (Size == 0) _tail = null;
            return element;
        }

        public void RemoveValue(T value)
        {
            if (value == null) throw new ArgumentNullException($"Cannot delete a null value");
            if (IsEmpty()) throw new ArgumentNullException($"Cannot delete any elemenet in an empty list");

            if (_head.Element.Equals(value))
            {
                RemoveFirst();
                Size--;
                return;
            }

            var tempNode = _head;

            while (tempNode.Next != null)
            {
                if (tempNode.Next.Element.Equals(value))
                {
                    tempNode.Next = tempNode.Next.Next;
                    Size--;
                    break;                    
                }
                tempNode = tempNode.Next; // traversing
            }
        }
        
        public void PrintList(string head = "HEAD", string tail = "TAIL", string direction = " -> " )
        {
            Console.Write($"({head}) ");
            var current = _head;
            while (current != null)
            {
                Console.Write(current.Element);
                
                switch (head)
                {
                    case "FIRST" when current.Next != null:
                    case "HEAD":
                        Console.Write($" {direction} ");
                        break;
                }

                current = current.Next;
            }
            if (head == "HEAD")
                Console.Write("null");
            Console.WriteLine($" ({tail})\n");
        }
    }
}