using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public class Stack
    {
        private SinglyLinkedList _list;

        public Stack()
        {
            _list = new SinglyLinkedList();
        }
        public void Push(object value)
        {
            _list.Add(value);
        }

        public object Pop()
        {
            object value = _list.Head?.Value;
            if (value != null)
            {
                _list.Remove(value);
            }
            return value;
        }

        public object Peek()
        {
            return _list.Head?.Value;
        }
    }
}
