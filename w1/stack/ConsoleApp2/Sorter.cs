using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Lists;

namespace Sorter
{
    public class Sorter
    {
        private DoubleLinkedList _sorterList;
        public void Sort(string commaSeperatedString)
        {
            List<int> elements = commaSeperatedString.Split(',').Select(x => int.Parse(x)).ToList();
            _sorterList = new DoubleLinkedList();

            foreach (var element in elements)
            {
                if (_sorterList.Head == null)
                {
                    _sorterList.Add(element);
                }
                else
                {
                    Node node = _sorterList.Head;
                    while (node.Next != null && (int)node.Value < element)
                    {
                        node = node.Next;
                    }

                    if ((int) node.Value < element)
                    {
                        _sorterList.InsertAfter(node.Value, element);
                    }
                    else
                    {
                        _sorterList.InsertBefore(node.Value, element);
                    }
                }
            }
        }

        public override string ToString()
        {
            var output = string.Empty;

            Node node = _sorterList.Head;
            while (node != null)
            {
                if (node == _sorterList.Head)
                {
                    output = $"{node.Value}";
                }
                else
                {
                    output = output + $", {node.Value}";
                }
                node = node.Next;
            }

            return output;
        }
    }
}
