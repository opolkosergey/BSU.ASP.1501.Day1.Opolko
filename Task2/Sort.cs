namespace Task2
{
    public static class Sort
    {
        /// <summary>
        /// Method to sort the rows of the matrix in order of increasing ( decreasing ) the amounts of elements rows of the matrix
        /// </summary>
        /// <param name="array">Input jaggedArray</param>
        /// <param name="direction">A positive number for ascending sort.A negative number for descending sort</param>
        public static void SortBySum(int[][] array, int direction)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (ArrayHelper.CalculateSumOfRow(array[i], direction) > ArrayHelper.CalculateSumOfRow(array[j], direction))
                    {
                        int[] helpInts = array[i];
                        array[i] = array[j];
                        array[j] = helpInts;
                    }
                }
            }
        }


    }
}
