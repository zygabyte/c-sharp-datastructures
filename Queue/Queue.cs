namespace Queue
{
    public interface Queue<T>
    {
        int Size();
        bool IsEmpty();
        T First();
        void Enqueue(T value);
        T Dequeue();
        void PrintQueue();
    }
}