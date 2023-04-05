using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class clsMyQueue<T>
    {
        clsDblLinkedList<T> myList = new clsDblLinkedList<T>();

        public void push(T data) => myList.insertAtEnd(data);
        public void pop() => myList.deleteFirstNode();
        public void print() => myList.printList();
        public int size() => myList.size();
        public bool isEmpty() => myList.isEmpty();
        public T front() => myList.getNodeByIndex(0).Data;
        public T back() => myList.getNodeByIndex(size() - 1).Data;
    }
}
