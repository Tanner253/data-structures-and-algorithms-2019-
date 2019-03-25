using System;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Transactions;
using linked_list.classes;
namespace linked_list
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst(1);
            myList1.AddFirst(5);
            myList1.AddFirst(22);
            myList1.PrintAllNode();

            Console.WriteLine();

            Console.ReadLine();

        }
      
      
            //add a node to the beginning of the list
         
        
          /*  public void PrintAllNodes()
            {
                //sets current head, and while not null then write current data on next node until no more node
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
            //int value = 0;
            /*
            public bool Contains(int value)
            {
               
                while(current.next != null)
                {
                    if(value == current)
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
            */
            //add a node to the end of a list not applicable
           /* public void AddLast(int data)
            {
                if (head == null)
                {
                    head = new Node();
                    head.data = data;
                    head.next = null;

                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = data;
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;

                    }
                    current.next = toAdd;
                  
                } 
            }*/
        
    }
}
