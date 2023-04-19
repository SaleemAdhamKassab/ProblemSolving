namespace Lab
{
    public class MyDblLinkedList<T>
    {
        private int _size = 0;
        public MyDblLinkedList() => Head = null;
        public class Node
        {
            public T Data { get; set; }
            public Node Previous { get; set; }
            public Node Next { get; set; }
        }
        public Node Head { get; set; }
        public void insertAtBeging(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Head == null)
                Head = newNode;
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }

            _size++;
        }
        public void insertAfter(Node prevNode, T data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = prevNode.Next;
            newNode.Previous = prevNode;
            prevNode.Next = newNode;


            _size++;
        }
        public void insertAfter(int nodeIndex, T data) => insertAfter(getNodeByIndex(nodeIndex), data);
        public void insertAtEnd(T data) => insertAfter(getNodeByIndex(_size - 1), data);
        public void deleteNodeByData(T data)
        {
            Node current = Head,
                  prev = Head;

            for (int i = 0; i < _size; i++)
                if (current.Data.Equals(data))
                {
                    prev.Next = current.Next;
                    current = null;
                    break;
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }

            _size--;
        }
        public void deleteFirstNode()
        {
            Head = Head.Next;

            if (Head != null)
            {
                Head.Previous = null;
                _size--;
            }

        }
        public void deleteLastNode()
        {
            if (this.Head != null)
            {
                if (this.Head.Next == null)
                    this.Head = null;
                else
                {
                    Node temp = new Node();
                    temp = this.Head;
                    while (temp.Next.Next != null)
                        temp = temp.Next;

                    Node lastNode = temp.Next;
                    temp.Next = null;
                    lastNode = null;
                }

                _size--;
            }
        }
        public Node getNodeByData(T data)
        {
            Node current = Head;

            for (int i = 0; i < _size; i++)
                if (current.Data.Equals(data))
                    return current;
                else
                    current = current.Next;

            return null;
        }
        public Node getNodeByIndex(int nodeIndex)
        {
            Node current = Head;

            for (int i = 0; i < _size; i++)
                if (i == nodeIndex)
                    return current;
                else
                    current = current.Next;

            return null;
        }
        public void UpdateNodeByIndex(int nodeIndex, T newData) => getNodeByIndex(nodeIndex).Data = newData;
        public void printList()
        {
            Node current = Head;

            Console.Write("Head ");
            for (int i = 0; i < _size; i++)
            {
                Console.Write(" -> ");
                Console.Write(current.Data);
                current = current.Next;
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
        public void reverse()
        {
            Node current = Head;
            Node temp = new Node();

            while (current != null)
            {
                temp = current.Previous;
                current.Previous = current.Next;
                current.Next = temp;
                current = current.Previous;
            }

            if (temp != null)
                Head = temp.Previous;
        }
        public int size() => _size;
        public bool isEmpty() => _size == 0 ? true : false;
        public void clear()
        {
            while (_size > 0)
                deleteFirstNode();
        }
        public bool isNumberOutOfListrange(int nodeIndex) => nodeIndex > _size - 1 || nodeIndex < 0;
    }
}
