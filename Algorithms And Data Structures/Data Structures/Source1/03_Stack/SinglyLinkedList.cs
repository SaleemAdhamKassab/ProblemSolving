using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    internal class SinglyLinkedList
    {
        protected int Length { get; set; }
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void addFirst(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Head;
            Head = newNode;
            Length++;
        }
        public void append(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (Length == 0)
                Head = newNode;
            else
            {
                Node current = Head;

                for (int i = 0; i < Length - 1; i++)
                    current = current.Next;

                current.Next = newNode;
            }

            Length++;
        }
        public int indexOf(int value)
        {
            Node current = Head;

            for (int i = 0; i < Length; i++)
                if (current.Value == value)
                    return i;
                else
                    current = current.Next;

            return -1;
        }
        public Node getNodeByIndex(int index)
        {
            Node result = new Node(),
                 current = Head;

            for (int i = 0; i < Length; i++)
                if (i == index)
                {
                    result = current;
                    break;
                }
                else
                    current = current.Next;

            return result;
        }
        public void delete(int value)
        {
            if (Length == 0)
            {
                Console.WriteLine("cannot Delete From Empty List!!");
                return;
            }

            Node current = Head, prev = Head;

            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    if (i == 0)
                        Head = Head.Next;
                    else
                        prev.Next = current.Next;

                    current = null;
                    Length--;
                    return;
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }
            }

            Console.WriteLine("Element Doesnot Exsist!!");
        }
        public void deleteFirst()
        {
            if (Length == 0)
            {
                Console.WriteLine("Cannot delete from Empty List!!");
                return;
            }

            Head = Head.Next;
            Head = null;
            Length--;
        }
        public void deleteLast()
        {
            if (Length == 0)
            {
                Console.WriteLine("Cannot delete from Empty List!!");
                return;
            }

            delete(getNodeByIndex(Length - 1).Value);
        }
        public void print()
        {
            Node current = Head;

            Console.Write("Head-> ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }

    }
}
