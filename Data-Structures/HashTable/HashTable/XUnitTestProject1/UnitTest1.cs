using HashTable.classes;
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private LinkedList<Node>[] Map { get; set; }

       // [Fact]
        public void CanAddToHashTable()
        {
            HashTableDS ht = new HashTableDS(100);
            ht.Add(1, "Tanner");
            int hashkey = 1;
            int key = 1;
            bool output = false;
            if (Map[hashkey] != null)
            {
                foreach (var val in Map[hashkey])
                {
                    if (val.Key == key)
                    {
                        output = true;
                    }
                };
            }
            Assert.True(output);
        }
    }
}
