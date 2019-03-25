using System;
using System.Net.Http.Headers;
using System.Transactions;

namespace linked_list
{
    class Program
    {
        public class Node
        {
            public Node next;
            public int data;
        }
        public class LinkedList
        {
            private Node head;
        public void PrintAllNodes()
        {
            Node current = head;
            while(current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        public void AddFirst(int data)
        {
                Node toAdd = new Node
                {
                    data = data,
                    next = head
                };
            }
            public void AddLast(int data)
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
                    while(current.next != null)
                    {
                        current = current.next;

                    }
                    current.next = toAdd;

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
