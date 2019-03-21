using System;
using Xunit;
using static BinarySearch.Program;

namespace XUnitTestlab03
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnNumber()
        {
            int[] array = { 1, 2, 3 };
            int selection = 2;

            int output = BinarySearchValid(array, selection);

            Assert.Equal(1, output);
        }
        /*[Fact]
        public void CannotEnterNegativeNumber()
        {
            int[] array = { 1, 2, 3 };
            int selection = -2;

            int output = BinarySearchValid(array, selection);
            

            Assert.Equal("please enter a valid number", output);
        }*/
    }
}
