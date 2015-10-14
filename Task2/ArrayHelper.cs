using System;
using System.Linq;

namespace Task2
{
    public static class ArrayHelper
    {
        public static int CalculateSumOfRow(int[] row, int direction)
        {
            if (row.Length == 0) return int.MaxValue;  //С учетом того что пустую строку кидаем вниз матрицы
            return direction * row.Sum();
        }

        public static int FindMaxInRow(int[] row, int direction)
        {
            if (row.Length == 0) return int.MaxValue;  //С учетом того что пустую строку кидаем вниз матрицы
            return direction * row.Max();
        }

        public static int FindMinInRow(int[] row, int direction)
        {
            if (row.Length == 0) return int.MaxValue;  //С учетом того что пустую строку кидаем вниз матрицы
            return direction * row.Min();
        }

        public static void DisplayArray(int[][] array)
        {
            foreach (int[] row in array)
            {
                foreach (int element in row)
                    Console.Write("{0}{1}", element, element.ToString().Length == 1 ? "   " : " ");

                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------");
        } 
    }
}
