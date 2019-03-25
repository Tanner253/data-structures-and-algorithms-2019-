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
            try
            {
                Node toAdd = new Node();

                toAdd.Value = data;
                toAdd.Next = Head;

                Head = toAdd;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintAllNode()
        {
            try
            {

                Node current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool Contains(int value)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;

        }
    }
}

