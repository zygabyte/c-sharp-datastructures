using System;

namespace Queue
{
    public class ArrayQueue<T> : Queue<T>
    {
        private readonly T[] _data;
        private int _front;
        private int _size;
        private int _vacant; 

        public ArrayQueue(int capacity)
        {
            _data = new T[capacity];
        }

        public int Size() => _size;

        public bool IsEmpty() => _size == 0;
        
        public T First()
        {
            if (IsEmpty()) throw new NullReferenceException($"Cannot access first element in empty array");
            return _data[_front];
        }

        public void Enqueue(T value)
        {
            if (_size == _data.Length) throw new IndexOutOfRangeException($"Queue already full");
            _vacant = (_front + _size) % _data.Length;
            _data[_vacant] = value;
            _size++;
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new NullReferenceException($"Queue is empty");
            var value = _data[_front];
            _data[_front] = default(T);
            _front = (_front + 1) % _data.Length;
            _size--;

            return value;
        }

        public void PrintQueue()
        {
            Console.Write("(FIRST) ");
            for (int i = _front; i < _data.Length && _data[i] != null; i++)
            {
                Console.Write(_data[i]);
                if (i + 1 < _data.Length && _data[i + 1] != null)
                    Console.Write(" <- ");
            }
            Console.WriteLine(" (LAST)\n");
        }
    }
}