using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Transactions;

namespace HashTable.classes
{
    public class HashTableDS
    {
        private LinkedList<Node>[] Map { get; set; }


        public HashTableDS(int size)
        {
            Map = new LinkedList<Node>[size];
        }
        public int Hash(int key)
        {
            return 1024;
        }

        public void Add(int key, string value)
        {
            int hashkey = Hash(key);

            if (Map[hashkey] == null)
            {
                Map[hashkey] = new LinkedList<Node>();
            }
            Map[hashkey].AddFirst(new Node(key, value));
        }

        public void Print()
        {
            for (int i = 0; i < Map.Length; i++)
            {
                if (Map[i] != null)
                {
                    Console.Write($"Bucket: {i}");
                    foreach (var value in Map[i])
                    {
                        Console.Write($"{value.Key} : {value.Value} => ");
                    }
                    Console.WriteLine("null");
                }

            }
        }
        public string GetValue(int key)
        {
            int hashkey = Hash(key);

            if (Map[hashkey] != null)
            {
                foreach (var val in Map[hashkey])
                {
                    if (val.Key == key)
                    {
                        return val.Value;
                    }
                };
            }

            return "not found";
        }
        public bool Contains(int key)
        {
            int hashkey = Hash(key);

            if (Map[hashkey] == null)
            {
                Map[hashkey] = new LinkedList<Node>();

                return false;
            }
            return true;
        }
    }
}
