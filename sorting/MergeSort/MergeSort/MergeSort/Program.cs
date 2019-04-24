using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int MergeSort(int[] array)
        {
            int n = array.Length;
            int mid = array.Length / 2;
            int[] b = array[array < mid];
        }
    }
}
