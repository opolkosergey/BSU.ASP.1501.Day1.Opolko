using System;

namespace Task2
{
    public static class Sort
    {
        public delegate int ResultInRow(int[] array);

        /// <summary>
        /// Method to sort the rows of the matrix in order of increasing (decreasing) by tag and direction
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="compare"></param>
        public static void BubbleSort(int[][] array, ResultInRow compare)
        {
            if (array == null) throw new ArgumentNullException();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (compare(array[i]) > compare(array[j]))
                    {
                        ReplaceRows(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void ReplaceRows(ref int[] a, ref int[] b)
        {
            int[] helpInts = a;
            a = b;
            b = helpInts;
        }
    }
}
