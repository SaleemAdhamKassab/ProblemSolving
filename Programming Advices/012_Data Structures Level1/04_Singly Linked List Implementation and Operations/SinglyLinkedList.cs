using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    public class SinglyLinkedList
    {
        private int _size = 0;

        public SinglyLinkedList() => Head = Tail = Current = null;
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
        }

        public Node Head { get; set; }
        public Node Current { get; set; }
        public Node Tail { get; set; }

        public void insertAtBeging(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Head == null)
            {
                Head = Tail = newNode;
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            _size++;
        }
        public void insertAtEnd(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = null;

            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            _size++;
        }
        public void insertAfterNode(Node prevNode, int data)
        {
            if (Head == null)
                Console.WriteLine("Cannot Insert " + data + " In Empty List!!");
            else
            {
                Node newNode = new Node(),
                     current = Head;

                newNode.Data = data;

                for (int i = 0; i < _size; i++)
                {
                    if (current.Data == prevNode.Data)
                    {
                        newNode.Next = prevNode.Next;
                        current.Next = newNode;
                        break;
                    }
                    else
                        current = current.Next;
                }

                _size++;
            }
        }
        public Node find(int data)
        {
            Node nodeToReturn = new Node(),
                 current = Head;

            while (current.Next != null)
            {
                current = current.Next;

                if (current.Data == data)
                    return current;
            }

            nodeToReturn.Data = -999;
            return nodeToReturn;
        }
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
    }
}
