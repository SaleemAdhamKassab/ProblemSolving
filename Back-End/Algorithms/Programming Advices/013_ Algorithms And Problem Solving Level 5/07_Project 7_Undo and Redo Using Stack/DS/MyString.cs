using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.DS
{
    internal class MyString
    {
        MyStack<string> _undoStack = new MyStack<string>();
        MyStack<string> _redoStack = new MyStack<string>();

        private string _value;

        public string value
        {
            get => _undoStack.top();

            set
            {
                _value = value;
                _undoStack.push(value);
            }
        }
        public void undo()
        {
            if (!_undoStack.isEmpty())
            {
                _redoStack.push(_undoStack.top());
                _undoStack.pop();
            }
        }
        public void redo()
        {
            if (!_redoStack.isEmpty())
            {
                _undoStack.push(_redoStack.top());
                _redoStack.pop();
            }
        }
        public void printValue() => Console.WriteLine("s = {0}", value);
    }
}
