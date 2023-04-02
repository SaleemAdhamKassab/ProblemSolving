namespace Lab
{
    internal class clsDblLinkedList<T>
    {
        private int _Size = 0;

        public clsDblLinkedList() => Head = Tail = null;
        public class Node
        {
            public T Data { get; set; }
            public Node Previous { get; set; }
            public Node Next { get; set; }
        }
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void insertAtBeging(T data)
        {
            if (Head == null)
            {
                Head = new Node();
                Head.Data = data;
                Tail = Head;
            }
            else
            {
                Node newNode = new Node();
                newNode.Data = data;
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }

            _Size++;
        }
        public void insertAfter(Node prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine(
                    "The given previous node cannot be NULL ");
                return;
            }

            Node newNode = new Node();
            newNode.Data = data;


            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;

            newNode.Previous = prevNode;

            if (newNode.Next != null)
                newNode.Next.Previous = newNode;

            _Size++;
        }
        public void insertAtEnd(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;
            newNode.Previous = null;

            if (Head == null)
                Head = newNode;
            else
            {
                Node temp = new Node();
                temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;
                newNode.Previous = temp;
            }

            _Size++;
        }
        public void deleteNode(T data)
        {
            Node node = Head;
            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    node.Previous.Next = node.Next;
                    node.Next.Previous = node.Previous;
                    return;
                }
                else
                    node = node.Next;
            }

            _Size--;
        }
        public void deleteFirstNode()
        {
            if (this.Head != null)
            {
                Node temp = this.Head;
                this.Head = this.Head.Next;
                temp = null;
                if (this.Head != null)
                    this.Head.Previous = null;

                _Size--;
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

                _Size--;
            }
        }
        public Node find(T data)
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
        public void printList()
        {
            Node node = Head;

            Console.Write("Head -> ");
            while (node != null)
            {
                Console.Write(node.Data);
                Console.Write(" -> ");
                node = node.Next;
            }
            Console.Write("NULL");
            Console.WriteLine();
            Console.WriteLine();
        }
        public int size() => _Size;
        public bool isEmpty() => _Size == 0 ? true : false;
    }
}
