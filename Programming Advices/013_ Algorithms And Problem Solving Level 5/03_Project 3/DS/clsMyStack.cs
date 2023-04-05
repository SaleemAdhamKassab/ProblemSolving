using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    public class clsMyStack<T> : clsMyQueue<T>
    {
        public void push(T data) => MyList().insertAtBeging(data);
        public T top() => front();
        public T bottom() => back();
    }
}
