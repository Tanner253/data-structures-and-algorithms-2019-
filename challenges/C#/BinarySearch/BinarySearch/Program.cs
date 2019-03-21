using System;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine("Hello World!");
            int num = Selection();
            
            Console.WriteLine(BinarySearchValid(array, num));
        }
        /// <summary>
        /// retrieves users input
        /// </summary>
        /// <returns>int input</returns>
        public static int Selection()
        {
            Console.WriteLine("choose a number");
            string rawNum = Console.ReadLine();
            int num = Convert.ToInt32(rawNum);
           
            return num;
        }
        /// <summary>
        /// runs conditionals to decide what output should be
        /// </summary>
        /// <param name="array">array of intigers the logic is run against</param>
        /// <returns>an index value or -1 for doesn't exist</returns>
        
        public static int BinarySearchValid(int[] array , int num)
        {

            
            int start = 0;
            int end = array.Length ;
            do
            {

                int index = (start + end) / 2;
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
       
       
        
    }
}
