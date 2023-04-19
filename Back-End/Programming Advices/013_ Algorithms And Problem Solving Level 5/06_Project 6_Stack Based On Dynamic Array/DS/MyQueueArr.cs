using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class MyQueueArr<T>
    {
        MyDynamicArray<T> MyDynamicArray = new MyDynamicArray<T>(0);
        protected MyDynamicArray<T> myDynamicArray() => MyDynamicArray;
        public void push(T data) => MyDynamicArray.insertElementAtEnd(data);
        public void pop() => MyDynamicArray.deleteFirstItem();
        public void print() => MyDynamicArray.printList();
        public int size() => MyDynamicArray.size();
        public T front() => MyDynamicArray.getItemByIndex(0);
        public T back() => MyDynamicArray.getItemByIndex(size() - 1);
        public T getNodeByIndex(int index) => MyDynamicArray.getItemByIndex(index);
        public void reverse() => MyDynamicArray.reverse();
        public void updateNodeByIndex(int index, T data) => MyDynamicArray.setItem(index, data);
        public void insertAfterNodeIndex(int index, T data) => MyDynamicArray.insertAfterIndex(index, data);
        public void insertAtFront(T data) => MyDynamicArray.insertElementAtBegining(data);
        public void insertAtBack(T data) => MyDynamicArray.insertElementAtEnd(data);
        public void clear() => MyDynamicArray.clear();
    }
}
