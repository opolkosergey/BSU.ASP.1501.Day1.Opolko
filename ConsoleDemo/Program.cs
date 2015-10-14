using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Demo task1
            double a, precision;
            int power;

            Console.Write("Enter A (double):");
            var isAParsedCorrectly = double.TryParse(Console.ReadLine(),out a);
            Console.Write("Enter power (int):");
            var isPowerParsedCorrectly = int.TryParse(Console.ReadLine(), out power);
            Console.Write("Enter a precision (double):");
            var isPrecisionParsedCorrectly = double.TryParse(Console.ReadLine(), out precision);

            if (isAParsedCorrectly && isPowerParsedCorrectly && isPrecisionParsedCorrectly)
                Console.WriteLine("Result = {0}",Newton.Root(a,power,precision));
            else Console.WriteLine("Error(s) of parsing");
            #endregion

            Console.ReadKey();
        }
    }
}
