using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lists
{
    public class DoubleLinkedList
    {
        public Node Head;
        public Node Tail;

        public void Add(object value)
        {
            Node node = new Node
            {
                Value = value
            };

            if (Head != null)
            {
                node.Next = Head;
                Head.Previous = node;
                
            }
            else
            {
                Tail = node;
            }
            Head = node;
        }

        public void Delete(object value)
        {
            Node deleteNode = Find(value);
            if (deleteNode == Head)
            {
                deleteNode.Next.Previous = null;
                Head = deleteNode.Next;
            }
            else if (deleteNode == Tail)
            {
                deleteNode.Previous.Next = null;
                Tail = deleteNode.Previous;
            }
            else
            {
                deleteNode.Previous.Next = deleteNode.Next;
                deleteNode.Next.Previous = deleteNode.Previous;
            }
        }

        public void InsertBefore(object valueToInsertBefore, object newValue)
        {
            Node newNode = new Node
            {
                Value = newValue
            };

            if (Head.Value == valueToInsertBefore)
            {
                Add(newValue);
            }
            else
            {
                Node nodeToInsertBefore = Find(valueToInsertBefore);
                nodeToInsertBefore.Previous.Next = newNode;
                newNode.Previous = nodeToInsertBefore.Previous;
                newNode.Next = nodeToInsertBefore;
                nodeToInsertBefore.Previous = newNode;
            }
        }

        public void InsertAfter(object valueToInsertAfter, object newValue)
        {
            Node newNode = new Node
            {
                Value = newValue
            };

            Node nodeToInsertAfter = Find(valueToInsertAfter);

            if (nodeToInsertAfter.Next != null)
            {
                nodeToInsertAfter.Next.Previous = newNode;
                newNode.Next = nodeToInsertAfter.Next;
            }
            else
            {
                AddToTail(newNode); 
            }
            
            newNode.Previous = nodeToInsertAfter;
            nodeToInsertAfter.Next = newNode;
        }


        public void AddToTail(object value)
        {
            Node node = new Node
            {
                Value = value
            };

            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
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
