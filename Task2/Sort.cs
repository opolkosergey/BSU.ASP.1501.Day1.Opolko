namespace Task2
{
    public static class Sort
    {
        /// <summary>
        /// Method to sort the rows of the matrix in order of increasing (decreasing) by tag and direction
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="tag">Allowed only values : "bySum","byMin","byMax"</param>
        /// <param name="direction">A positive number for ascending sort.A negative number for descending sort</param>
        public static void SortByTag(int[][] array, string tag,  int direction)
        {
            if (array == null) return;
            if (direction == 0) return;

            if (tag == "bySum" || tag == "byMin" || tag == "byMax")
            {
                if (direction > 0) direction = 1;   // Чтобы не было переполнения засчет направления сортировки
                if (direction < 0) direction = -1;  // нам важен только знак

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        switch (tag)
                        {
                            case "bySum":
                                if (ArrayHelper.CalculateSumOfRow(array[i], direction) > ArrayHelper.CalculateSumOfRow(array[j], direction))
                                {
                                    ReplaceRows(ref array[i], ref array[j]);
                                }
                                break;

                            case "byMin":
                                if (ArrayHelper.FindMinInRow(array[i], direction) > ArrayHelper.FindMinInRow(array[j], direction))
                                {
                                    ReplaceRows(ref array[i], ref array[j]);
                                }
                                break;

                            case "byMax":
                                if (ArrayHelper.FindMaxInRow(array[i], direction) > ArrayHelper.FindMaxInRow(array[j], direction))
                                {
                                    ReplaceRows(ref array[i], ref array[j]);
                                }
                                break;
                        }
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
