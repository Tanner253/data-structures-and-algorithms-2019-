using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("+++++++++++++++++++++++++");
            MergeSort(array);
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine(array);
            Console.WriteLine("+++++++++++++++++++++++++");



        }
        public static void MergeSort(int[] array)
        {
            MergeSort(array, new int[array.Length], 0 , array.Length - 1);
        }
        public static void MergeSort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }
            int middle = leftStart + rightEnd / 2;
            MergeSort(array, temp, leftStart, rightEnd);
            MergeSort(array, temp, middle + 1, rightEnd);
            MergeSort(array, temp, leftStart, rightEnd);
        }
        public static int[] DoMergeAction(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;

            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;

                }
                else
                {
                    temp[index] = array[right];
                    right++;
                }
                index++;
            }

            return array;
            
        }
    }
}
