using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class MyStackArr<T>:MyQueueArr<T>
    {
        public void push(T data) => myDynamicArray().insertElementAtBegining(data);
        public T top() => front();
        public T bottom() => back();
    }
}
