using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
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
        /// Prints all the values of each node in the linked list - jason showed me list<int>
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
       /// <summary>
       /// inserts after a chosen value
       /// </summary>
       /// <param name="insertAfter">value to insert after</param>
       /// <param name="insert">inert value</param>


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
        /// <summary>
        /// inserts a value before another value
        /// </summary>
        /// <param name="insertBefore">value to assign before</param>
        /// <param name="insert">value to assign</param>
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
            
            Current.Next = InsertValue;
        }
        /// <summary>
        /// get the value "Kth " from the end of the list
        /// </summary>
        /// <param name="K">will define what node we land on </param>
        /// <returns>returns the value of the current node</returns>
        public int GetKthFromEnd(int K)
        {
           
            int counter = 0;
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
                counter++;
            }
            Current = Head;
            for(int i = 0; i < counter - K; i++)
            {
                Current = Current.Next;
            }
            return Current.Value;
        }
     
            
        }


    }
}

