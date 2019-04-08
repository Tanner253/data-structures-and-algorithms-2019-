using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch.classes
{
    public class Node
    {
        public Node Root { get; set; }
        public Node LChild { get; set; }
        public Node RChild { get; set; }
        public int Value { get; set; }

        public Node (int value)
        {
            Value = value;
        }
    }
}
