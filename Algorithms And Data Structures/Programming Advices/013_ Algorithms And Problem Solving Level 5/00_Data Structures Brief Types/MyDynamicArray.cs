using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class MyDynamicArray<T>
    {
        int _size = 0;
        bool isIndexOutOfArrayRange(int index) => index < 0 || index > _size;

        public T[] orginalArray;
        public T[] tempArray;

        public MyDynamicArray(int size)
        {
            if (size < 0)
                size = 0;

            _size = size;
            orginalArray = new T[_size];
        }
        public bool setItem(int index, T value)
        {
            if (isIndexOutOfArrayRange(index))
                return false;

            orginalArray[index] = value;
            return true;
        }
        public int size() => _size;
        public bool isEmpty() => _size == 0;
        public void printList()
        {
            for (int i = 0; i < _size; i++)
                Console.Write(orginalArray[i] + " ");

            Console.WriteLine();
        }
        public void resize(int newSize)
        {
            if (newSize < 0)
                newSize = 0;

            if (newSize < _size)
                _size = newSize;

            tempArray = new T[newSize];

            for (int i = 0; i < _size; i++)
                tempArray[i] = orginalArray[i];

            _size = newSize;
            orginalArray = tempArray;

        }
        public T getItemByIndex(int index) => isIndexOutOfArrayRange(index) ? default(T)! : orginalArray[index];
        public void reverse()
        {
            int j = 0;
            tempArray = new T[_size];

            for (int i = _size - 1; i >= 0; i--)
            {
                tempArray[j] = orginalArray[i];
                j++;
            }
            orginalArray = tempArray;
        }
        public void clear()
        {
            _size = 0;
            orginalArray = new T[_size];
            tempArray = new T[_size];
        }
        public bool deleteItemByIndex(int index)
        {
            if (isIndexOutOfArrayRange(index))
                return false;

            tempArray = new T[_size - 1];
            int j = 0;

            for (int i = 0; i < _size; i++)
            {
                if (i != index)
                {
                    tempArray[j] = orginalArray[i];
                    j++;
                }
            }

            orginalArray = tempArray;
            _size--;

            return true;
        }
        public bool deleteFirstItem() => deleteItemByIndex(0);
        public bool deleteLastItem() => deleteItemByIndex(_size - 1);
        public int getItemIndex(T data)
        {
            for (int i = 0; i < _size; i++)
                if (orginalArray[i].Equals(data))
                    return i;

            return -1;
        }
        public bool deleteItem(T data)
        {
            int itemIndex = getItemIndex(data);

            if (itemIndex == -1)
                return false;

            deleteItemByIndex(itemIndex);
            return true;
        }
        public bool insertElementAtIndex(int index, T data)
        {
            if (isIndexOutOfArrayRange(index))
                return false;

                tempArray = new T[_size + 1];


                for (int i = 0; i < index; i++)
                    tempArray[i] = orginalArray[i];

                tempArray[index] = data;

                for (int i = index; i < _size; i++)
                    tempArray[i + 1] = orginalArray[i];

                orginalArray = tempArray;

                _size++;

            return true;
        }
        public bool insertElementAtBegining(T data) => insertElementAtIndex(0, data);
        public bool insertBeforeIndex(int index, T data) => insertElementAtIndex(index-1, data);
        public bool insertAfterIndex(int index, T data) => insertElementAtIndex(index + 1, data);
        public bool insertElementAtEnd(T data) => insertElementAtIndex(_size, data);
    }
}