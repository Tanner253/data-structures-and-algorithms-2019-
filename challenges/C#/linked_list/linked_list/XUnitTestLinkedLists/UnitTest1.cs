using System;
using Xunit;
using linked_list.classes;
using linked_list;

namespace XUnitTestLinkedLists
{
    public class UnitTest1
    {
        [Fact]
        //i cannot figure out how to test these methods!! will ask in lecture of after class -
        public void CanMakeLinkedList()
        {
            LinkedList newVar = new LinkedList();
            Assert.NotNull(newVar);
        }
        [Fact]
        public void CanInsertIntoLinkedList()
        {
            
        }
    }
}
