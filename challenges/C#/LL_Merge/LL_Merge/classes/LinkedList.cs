using System;
using System.Collections.Generic;
using System.Text;

namespace LL_Merge.classes
{
    class LinkedList
    {
        public Node Current { get; set; }
        public Node Head { get; set; }

        public void MergeTwoLinkedLists(LinkedList first, LinkedList second)
        {
            Node LL1 = new Node();
            Node LL2 = new Node();
            Node LL1_Next = new Node();
            Node LL2_Next = new Node();
            Current = Head;
            while (LL1 != null && LL2 != null)
            {
                LL1_Next = LL1.Next;
                LL2_Next = LL2.Next;
                LL2.Next = LL1_Next;
                LL1.Next = LL2;
                LL1 = LL1_Next;
                LL2 = LL2.Next;


            }

        }
        public void Append(int value)
        {
            Node Append = new Node();
            Append.Value = value;
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = Append;
            Append.Next = null;


        }
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
    }
}

