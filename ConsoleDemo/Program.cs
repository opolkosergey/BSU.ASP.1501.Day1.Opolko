using System;
using Task1;
using Task2;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Demo task1
            //double a, precision;
            //int power;

            //Console.Write("Enter A (double):");
            //var isAParsedCorrectly = double.TryParse(Console.ReadLine(), out a);
            //Console.Write("Enter power (int):");
            //var isPowerParsedCorrectly = int.TryParse(Console.ReadLine(), out power);
            //Console.Write("Enter a precision (double):");
            //var isPrecisionParsedCorrectly = double.TryParse(Console.ReadLine(), out precision);

            //if (isAParsedCorrectly && isPowerParsedCorrectly && isPrecisionParsedCorrectly)
            //    Console.WriteLine("Result = {0}", Newton.Root(a, power, precision));
            //else Console.WriteLine("Error(s) of parsing");
            //#endregion

            //#region Demo task2
            //int[][] jaggedArray = new int[][] 
            //            {
            //               new int[] {11,3,0},
            //               new int[] {5,2,46,60},
            //               new int[] {},
            //               new int[] {10,45}
            //            };

            //ArrayHelper.DisplayArray(jaggedArray);
            //Sort.SortByTag(jaggedArray,"byMax", 1);
            //ArrayHelper.DisplayArray(jaggedArray);
            //#endregion
            int value = 780000000;
            checked
            {
                try
                {
                    // Square the original value.
                    int square = value * value;
                    Console.WriteLine("{0} ^ 2 = {1}", value, square);
                }
                catch (OverflowException)
                {
                    double square = Math.Pow(value, 2);
                    Console.WriteLine("Exception: {0} > {1:E}.",
                                      square, Int32.MaxValue);
                }
            }
            Console.ReadKey();
        }  
    }
}
