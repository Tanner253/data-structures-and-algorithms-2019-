using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace linked_list.classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void AddFirst(int data)
        {
            Node toAdd = new Node();

            toAdd.Value = data;
            toAdd.Next = Head;

            Head = toAdd;
        }
        
        public void PrintAllNode()
        {

            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
        public bool Contains(int value)
        {
            Node current = Head;

            while (current.Next != null)
            {
                if (value == current.Value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
