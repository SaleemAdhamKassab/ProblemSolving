using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class SaleemStack : SinglyLinkedList
    {
        public void pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Cannot Delete From Empty Stack!!");
                return;
            }

            deleteLast();
        }
        public void push(int value) => append(value);
        public int top()
        {
            if (isEmpty())
            {
                Console.WriteLine("Cannot get From Empty Stack!!");
                return -1;
            }

            return getNodeByIndex(Length-1).Value;
        }
        public bool isEmpty() => Length == 0;
    }
}
