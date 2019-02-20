using System;
using System.Collections.Generic;
using System.Text;
using Lists;

namespace Queue
{
    public class Queue<T>
    {
        private DoubleLinkedList _queueList;

        public Queue()
        {
            _queueList = new DoubleLinkedList();
        }

        public T Dequeue()
        {
            var element = _queueList.Head.Value;
            _queueList.Delete(_queueList.Head.Value);
            return (T) element;
        }

        public void Enqueue(T element)
        {
            _queueList.AddToTail(element);
        }
    }
}
