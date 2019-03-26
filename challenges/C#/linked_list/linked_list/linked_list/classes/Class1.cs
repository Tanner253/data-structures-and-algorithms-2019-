using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace linked_list.classes
{
    public class LinkedList
    {
        public Node Current { get; set; }
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
                Current = Head;

                while (Current != null)
                {
                    if (value == Current.Value)
                    {
                        return true;
                    }
                   
                Current = Current.Next;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;

        }
        public void Append(int value)
        {
            Node Append = new Node();
            Append.Value = value;
            Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = Append;
            Append.Next = null;
          
            
        }
        /*public void InsertBeforeValue(int insertBefore, int insert)
        {
            Node theNode = new Node();
            Node insertBeforeNode = new Node();
            insertBeforeNode.Value = insertBefore;
            theNode.Value = insert;
            Current = Head;
            while (Current.Next != insertBeforeNode)
            {
                Current = Current.Next;
            }
            Current.Next = theNode;
            theNode.Next = insertBeforeNode;
        }*/


        public void InsertAfterValue(int insertAfter, int insert)
        {
            Node InsertValue = new Node();
            InsertValue.Value = insert;

            Node InsertAfterThisValue = new Node();
            InsertAfterThisValue.Value = insertAfter;
            Current = Head;
            while(Current.Next != InsertAfterThisValue)
            {
                Current = Current.Next;
            }
            InsertValue = Current.Next;
            InsertAfterThisValue.Next = InsertValue;
        }

        //refactored insert before
        public void InsertBeforeValue(int insertBefore, int insert)
        {
            Node InsertValue = new Node();
            InsertValue.Value = insert;

            Node InsertBeforeThisValue = new Node();
            InsertBeforeThisValue.Value = insertBefore;
            Current = Head;
            while (Current.Next.Value != insert)
            {
                Current = Current.Next;
            }
            InsertValue = Current.Next;
            InsertValue = InsertBeforeThisValue;
        }

    }
}

