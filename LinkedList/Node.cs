namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Element { get; }

        public Node(T element, Node<T> next)
        {
            Element = element;
            Next = next;
        }
        
    }
}