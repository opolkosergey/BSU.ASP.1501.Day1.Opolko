using System;

namespace Task1
{
    public static class Newton
    {
        /// <summary>
        /// Method of calculating the root of the n-th degree among the Newton method with a given accuracy
        /// </summary>
        /// <param name="a">The number under the root</param>
        /// <param name="power">The degree of root</param>
        /// <param name="precision">Necessary accuracy of calculation</param>
        /// <returns></returns>
        public static double Root(double a, int power, double precision)
        {
            double possibleResult = 1;
            double intermediateResult = Math.Pow(possibleResult, power);

            while (Math.Abs(a - intermediateResult) > precision)
            {
                possibleResult = ((power - 1) * possibleResult + a / Math.Pow(possibleResult, power - 1)) / power;
                intermediateResult = Math.Pow(possibleResult, power);
            }
            return possibleResult;
        }
    }
}
