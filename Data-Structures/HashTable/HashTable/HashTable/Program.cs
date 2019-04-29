using HashTable.classes;
using System;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTableDS ht = new HashTableDS(1024);

            ht.Add(1, "Awesome");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            Console.ReadKey();
            ht.Print();
            var output2 = ht.GetValue(1);
            var output = ht.Contains(3);
            Console.WriteLine(output);
            Console.WriteLine(output2);
            Console.WriteLine("============");
            
            Console.ReadLine();
        }
    }
}
