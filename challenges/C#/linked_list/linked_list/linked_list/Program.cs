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
            try
            {
                Console.WriteLine("Add First:");
                LinkedList myList = new LinkedList();

                myList.AddFirst(1);
                myList.AddFirst(5);
                myList.AddFirst(22);
                myList.PrintAllNode();
                string ans = Console.ReadLine();
                int ansInt = Convert.ToInt32(ans);
                Console.WriteLine(myList.Contains(ansInt));
                
                Console.WriteLine("append an element");
                int answer =   Convert.ToInt32(Console.ReadLine());
                myList.Append(answer);
                myList.PrintAllNode();
                Console.ReadLine();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
      
      
      
        
    }
}
