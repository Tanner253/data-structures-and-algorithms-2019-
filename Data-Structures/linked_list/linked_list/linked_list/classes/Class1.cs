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
        /// <summary>
        /// Inserts a value at begining of LL 
        /// </summary>
        /// <param name="data">The value store in the node</param>
        public void Insert(int data)
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
        /// <summary>
        /// Prints all the values of each node in the linked list
        /// </summary>
        public List<int> Print()
        {

        
        
                List<int> list = new List<int>();
            try
            {
                Node Current = Head;
                while (Current != null)
                {
                    list.Add(Current.Value);
                    Current = Current.Next;
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }
        /// <summary>
        /// Check a linked list for a specific value and its presence
        /// </summary>
        /// <param name="value">the value checking for</param>
        /// <returns>True or false</returns>
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
        /// <summary>
        /// adds a node to the end of a list
        /// </summary>
        /// <param name="value">The value of the node</param>
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
            InsertValue.Next = InsertBeforeThisValue;
            Current = Head;
            while (Current.Next.Value != insertBefore)
            {
                Current = Current.Next;
            }
            Current = Current.Next;
            Current.Next = InsertValue;
        }

    }
}

