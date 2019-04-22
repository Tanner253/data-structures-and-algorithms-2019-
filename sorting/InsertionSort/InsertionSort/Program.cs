using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] InsertionSortInts(int[] valueArray)
        {
            for (int i = 0; i < valueArray.Length; i++)
            {
                int j = i - 1;
                int temp = valueArray[i];
                while (j >= 0 && temp < valueArray[j])
                {
                    valueArray[j + 1] = valueArray[j];
                    j = j - 1;
                }

                valueArray[j + 1] = temp;

            }
            return valueArray;

        }
    }
}
