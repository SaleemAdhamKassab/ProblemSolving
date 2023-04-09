using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    public class MyQueue<T>
    {
        MyDblLinkedList<T> myList = new MyDblLinkedList<T>();

        //used To Build Stack
        protected MyDblLinkedList<T> MyList() => myList;

        public void push(T data) => myList.insertAtEnd(data);
        public void pop() => myList.deleteFirstNode();
        public void print() => myList.printList();
        public int size() => myList.size();
        public bool isEmpty() => myList.isEmpty();
        public T front() => myList.getNodeByIndex(0).Data;
        public T back() => myList.getNodeByIndex(size() - 1).Data;
        public T getNodeByIndex(int nodeIndex) => myList.getNodeByIndex(nodeIndex).Data;
        public void reverse() => myList.reverse();
        public void updateNodeByIndex(int nodeIndex, T data) => myList.UpdateNodeByIndex(nodeIndex, data);
        public void insertAfterNodeIndex(int nodeIndex, T data) => myList.insertAfter(nodeIndex, data);
        public void insertAtFront(T data) => myList.insertAtBeging(data);
        public void insertAtBack(T data) => myList.insertAtEnd(data);
        public void clear() => myList.clear();
    }
}