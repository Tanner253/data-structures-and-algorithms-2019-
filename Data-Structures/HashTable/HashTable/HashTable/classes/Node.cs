using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.classes
{
    public class Node
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public Node(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
