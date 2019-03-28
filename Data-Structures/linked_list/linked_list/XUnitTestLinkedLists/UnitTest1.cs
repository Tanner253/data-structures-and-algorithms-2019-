using System;
using Xunit;
using linked_list.classes;
using  linked_list;
using System.Collections.Generic;

namespace XUnitTestLinkedLists
{
    public class UnitTest1
    {
        [Fact]
        
        public void CanMakeLinkedList()
        {
            LinkedList newVar = new LinkedList();
            Assert.NotNull(newVar);
        }

       [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkedList LL = new LinkedList();

            int data = 55;
            
            LL.Insert(data);

            bool result = LL.Contains(data);

            Assert.True(result);
        }

        [Fact]
        public void CanAddHeadNode()
        {
            LinkedList LL = new LinkedList();
            int data = 5;

            LL.Insert(data);

            bool result = LL.Contains(data);

            Assert.True(result);
        }

        [Fact] 
        public void ReturnTrueIfLinkedListContainsValue()
        {
            LinkedList LL = new LinkedList();
            int data = 5;
            LL.Insert( data);

            bool result = LL.Contains(data);
            Assert.True(result);
        }
       // [Fact] how to make independant test  insert multiple values?
        public void CanInsertMultipleNumbers()
        {
            LinkedList LL = new LinkedList();
            int data = 5;
            int data2 = 10;
            LL.Insert(data);
            LL.Insert(data2);


        }
        [Fact]
        public void ReturnFalseIfLinkedListDoesNotContainValue()
        {
            LinkedList LL = new LinkedList();
            int data = 5;
            LL.Insert(data);

            bool result = LL.Contains(10);
            Assert.False(result);
        }
        [Fact]
        public void CanReturnCollectionOfNodes()
        {
            LinkedList LL = new LinkedList();
            int data = 5;
            LL.Insert(data);
            int data2 = 22;
            LL.Insert(data2);
            List<int> output = LL.Print();

            Assert.Equal(5, output[1]);
        }
        [Fact] 
        public void CanGetKthFromTheEnd()
        {
            LinkedList LL = new LinkedList();
            LL.Insert(1);
            LL.Append(3);
            LL.Append(4);
            int K = 1;
            int output = LL.GetKthFromEnd(K);
            Assert.Equal(3, output);
        }

      // [Fact]
       public void CanMErgeTwoLinkedLists()
        {
            //setup
            LinkedList LL = new LinkedList();
            LL.Insert(1);
            LL.Append(3);
            LL.Append(4);
            LL.Append(5);
            LinkedList LL2 = new LinkedList();
            LL2.Insert(1);
            LL2.Append(3);
            LL2.Append(4);
            LL2.Append(5);
            

            //act
            LL.MergeTwoLinkedLists(LL, LL2);
            var output = LL.Print();
           // Assert.Equals(output, );
        }
    }
}
