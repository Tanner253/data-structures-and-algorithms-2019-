using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine("Hello World!");
            
            BinarySearch(array);
        }
        /// <summary>
        /// runs conditionals to decide what output should be
        /// </summary>
        /// <param name="array">array of intigers the logic is run against</param>
        /// <returns>an index value or -1 for doesn't exist</returns>
        public static int BinarySearch(int[] array)
        {
            PrintOptions(array);
            Console.WriteLine("choose a number");
            string rawNum = Console.ReadLine();
            int num = Convert.ToInt32(rawNum);
            int start = 0;
            int end = array.Length ;
            int index = (start + end) / 2;
            do
            {

                if (array[index] == num)
                {
                    return index;

                }
                else if (array[index] > num)
                {
                    end = index - 1;

                }
                else if (array[index] < num)
                {
                    start = index + 1;
                }

            }
            while (start <= end);
            return -1;
            
        }
        /// <summary>
        /// prints every value in the array to the console
        /// </summary>
        /// <param name="array">array of available ints</param>
        public static void PrintOptions(int[] array)
        {
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
