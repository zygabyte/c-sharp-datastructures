using LinkedList;

namespace Queue
{
    public class LinkedQueue<T> : Queue<T>
    {
        private readonly SinglyLinkedList<T> _linkedList = new SinglyLinkedList<T>();

        public int Size() => _linkedList.Size;

        public bool IsEmpty() => _linkedList.IsEmpty();

        public T First() => _linkedList.First();

        public void Enqueue(T value) => _linkedList.AddLast(value);

        public T Dequeue() => _linkedList.RemoveFirst();
        
        public void PrintQueue() => _linkedList.PrintList("FIRST", "LAST", "<-");
    }
}