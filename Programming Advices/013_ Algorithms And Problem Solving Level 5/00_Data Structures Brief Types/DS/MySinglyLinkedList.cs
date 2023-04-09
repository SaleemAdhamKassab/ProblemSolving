namespace Lab.DS
{
    public class MySinglyLinkedList<T>
    {
        private int _size = 0;

        public MySinglyLinkedList() => Head = Tail = null;
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void insertAtBeging(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Head == null)
                Head = Tail = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            _size++;
        }
        public void insertAfter(Node prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be NULL!!");
                return;
            }
            else
            {
                Node newNode = new Node();
                newNode.Data = data;
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;

                _size++;
            }
        }
        public void insertAfter(int nodeIndex, T data) => insertAfter(getNodeByIndex(nodeIndex), data);
        public void insertAtEnd(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Head == null)
                Head = Tail = newNode;
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            _size++;
        }
        public void deleteNodeByData(T data)
        {
            if (getNodeByData(data) != null)
            {
                Node current = Head,
                     prevNode = Head;

                for (int i = 0; i < _size; i++)
                {
                    if (current.Data.Equals(data))
                    {
                        prevNode.Next = current.Next;
                        current = null;
                        _size--;
                        break;
                    }

                    prevNode = current;
                    current = current.Next;
                }
            }
            else
                Console.WriteLine("Not Found The Node with Data: (" + data + ')');
        }
        public void deleteFirstNode()
        {
            if (Head != null)
            {
                Head = Head.Next;
                _size--;
            }
        }
        public void deleteLastNode()
        {
            if (Head != null)
            {
                Node current = Head,
                     prevNode = Head;

                for (int i = 0; i < _size; i++)
                {
                    if (current.Next == null)
                    {
                        prevNode.Next = null;
                        current = null;
                    }
                    else
                    {
                        prevNode = current;
                        current = current.Next;
                    }
                }

                _size--;
            }
        }
        public bool isNodeIndexInListRange(int nodeIndex) => nodeIndex < 0 || nodeIndex > _size - 1;
        public Node getNodeByData(T data)
        {
            Node node = Head;

            while (node != null)
            {
                if (node.Data.Equals(data))
                    return node;
                else
                    node = node.Next;
            }
            return null;
        }
        public Node getNodeByIndex(int index)
        {
            Node current = Head;

            for (int i = 0; i < _size; i++)
                if (i == index)
                    return current;

            return null;
        }
        public void updateNodeByIndex(int index, T newData) => getNodeByIndex(index).Data = newData;
        public void printList()
        {
            Node current = Head;

            Console.Write("Head -> ");
            for (int i = 0; i < _size; i++)
            {
                Console.Write(current.Data);
                Console.Write(" -> ");
                current = current.Next;
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
        public int size() => _size;
        public bool isEmpty() => _size == 0;
        public void clear()
        {
            while (_size > 0)
                deleteFirstNode();
        }
    }
}