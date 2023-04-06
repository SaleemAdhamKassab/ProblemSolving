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
        bool isIndexOutOfArrayRange(int index) => index < 0 || index > _size - 1;

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
    }
}
