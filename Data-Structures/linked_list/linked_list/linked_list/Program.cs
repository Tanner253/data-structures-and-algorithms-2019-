using System;
using System.Collections.Generic;
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
                List<int> list = new List<int>();
                myList.Insert(1);
                myList.Insert(5);
                myList.Insert(22);
                list = myList.Print();
                foreach (int value in list)
                {
                    Console.Write($"{value}, ");
                }
                Console.WriteLine("Does this list contain the number: ");
                string ans = Console.ReadLine();
                int ansInt = Convert.ToInt32(ans);
                Console.WriteLine(myList.Contains(ansInt));
                Console.ReadLine();
                
                Console.WriteLine("append an element");
                int answer =   Convert.ToInt32(Console.ReadLine());
                myList.Append(answer);
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("This is your newly made list: ");
                list = myList.Print();
                foreach (int value in list)
                {
                    Console.Write($"{value}, ");
                }
               
                Console.ReadLine();
             
             
                
                Console.WriteLine("Choose one of the numbers in the list - your number will come BEFORE this number");
                int answer3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number to add into the list ");
                int answer4 = Convert.ToInt32(Console.ReadLine());
                myList.InsertBeforeValue(answer3, answer4);
                Console.WriteLine("--------------------------------------------------------------------");
                
                foreach (var value in list)
                {
                    Console.Write($"{value}, ");
                }
                
                Console.WriteLine("choose one of the numbers in the list");
                int K = Convert.ToInt32(Console.ReadLine());
                int output = myList.GetKthFromEnd(K);
                Console.WriteLine(output);
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
