﻿using System;
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
            string ans = Console.ReadLine();
            int ansInt = Convert.ToInt32(ans);
            Console.WriteLine(myList1.Contains(ansInt));
            Console.WriteLine();

            Console.ReadLine();

        }
      
      
      
        
    }
}
