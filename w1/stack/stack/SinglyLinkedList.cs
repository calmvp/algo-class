using System;

namespace Lists 
{
    public class SinglyLinkedList
    {
        public Node Head;

        public void Add(object value)
        {
            Node node = new Node();
            node.Value = value;
            node.Next = Head;
            Head = node; 
        }

        public void Remove(object value)
        {
            Node node = Head;

            if (node.Value == value)
            {
                Head = node.Next;
                return;
            }
            while (node?.Next != null && node.Next.Value != value)
            {
                node = node.Next;
            }
            if (node?.Next != null)
            {
                node.Next = node.Next.Next;
            }
        }
        public bool Contains(object value)
        {
            Node node = Find(value);
            if (node != null)
            {
                return true;
            }
            return false;
        }

        private Node Find(object value)
        {
            Node node = Head;
            while (node != null && node.Value != value)
            {
                node = node.Next;
            }
            return node;
        }
    }
}
