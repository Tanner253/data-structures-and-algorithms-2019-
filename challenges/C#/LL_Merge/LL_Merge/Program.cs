using System;
using System.Collections.Generic;
using LL_Merge.classes;
namespace LL_Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Hello World!");
            LinkedList LL = new LinkedList();
            LinkedList LL2 = new LinkedList();
            Console.WriteLine("This is the first linked list:");
            Console.WriteLine("{1, 2, 3, 4}");

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);
            LL.Append(4);

            Console.WriteLine("==========================");
            Console.WriteLine("this is your second linked list:");
            Console.WriteLine("{5,6,7,8}");
            LL2.Append(5);
            LL2.Append(6);
            LL2.Append(7);
            LL2.Append(8);



            Console.WriteLine("==========================");

            LL.MergeTwoLinkedLists(LL, LL2);
            list = LL.Print();
            foreach (int value in list)
            {
                Console.WriteLine($" this is your merged list! {value}");
            }

        }
   

        }
}

    