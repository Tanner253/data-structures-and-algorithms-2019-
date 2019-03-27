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
            try
            {
                Console.WriteLine("Add First:");
                LinkedList myList = new LinkedList();

                myList.Insert(1);
                myList.Insert(5);
                myList.Insert(22);
                myList.Print();
                Console.WriteLine("Does this list contain the number: ");
                string ans = Console.ReadLine();
                int ansInt = Convert.ToInt32(ans);
                Console.WriteLine(myList.Contains(ansInt));
                
                Console.WriteLine("append an element");
                int answer =   Convert.ToInt32(Console.ReadLine());
                myList.Append(answer);
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("This is your newly made list: ");
                myList.Print();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.ReadLine();
             
             
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Choose one of the numbers in the list - your number will come BEFORE the next value");
                int answer3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number to add into the list before your value!");
                int answer4 = Convert.ToInt32(Console.ReadLine());
                myList.InsertBeforeValue(answer3, answer4);
                Console.WriteLine("--------------------------------------------------------------------");
                myList.Print();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.ReadKey();
                


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }




        }
      
      
      
        
    }
}
