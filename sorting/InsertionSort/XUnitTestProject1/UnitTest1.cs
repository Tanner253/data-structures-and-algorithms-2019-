using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using static InsertionSort.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void RandomArrayReturnsSorted()
        {

            int[] randomArray = { 7, 3, 6, 4, 2, 1, 5 };
            int[] output = new int[7];

            output = InsertionSortInts(randomArray);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, output);
        }
        [Fact]
        public void SinglyArrayReturnsSorted()
        {

            int[] randomArray = { 1 };
            int[] output = new int[7];

            output = InsertionSortInts(randomArray);
            Assert.Equal(new int[] { 1 }, output);
        }
        [Fact]
        public void SortedArrayReturnsSorted()
        {

            int[] randomArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] output = new int[7];

            output = InsertionSortInts(randomArray);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, output);
        }
        [Fact]
        public void EmptyArrayReturnsSorted()
        {

            int[] randomArray = { };
            int[] output = new int[0];

            output = InsertionSortInts(randomArray);
            Assert.Equal(new int[] { }, output);
        }
        [Fact]
        public void BackwardsOrderReturnsSorted()
        {

            int[] randomArray = { 7, 6, 5, 4, 3, 2, 1 };
            int[] output = new int[7];

            output = InsertionSortInts(randomArray);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7 }, output);
        }


    }
}
