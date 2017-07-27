using System;

namespace Task2
{
    public static class Sort
    {
        public delegate int ResultInRow(int[] array);

        /// <summary>
        /// Allow to sort the matrix rows using bubble algorithm.
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="compare">Method of calculating the value for which you want to sort the rows </param>
        public static void BubbleSort(int[][] array, ResultInRow compare)
        {
	        if (array == null)
	        {
				throw new ArgumentNullException(nameof(array));
			}                

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
