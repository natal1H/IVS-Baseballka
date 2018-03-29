using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class MatLib
    {
        public static double add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static long factorial(int number)
        {
            long res = 1;
            for (int i = 2; i <= number; i++)
            {
                res = res * i;
            }
            return res;
        }

        public static double square(double number)
        {
            return number * number;
        }

        public static double power(double number, int exp)
        {
            return System.Math.Pow(number, exp);
        }

        public static double sqrt(double number)
        {
            return System.Math.Sqrt(number);
        }

        public static double genroot(double number, int root)
        {
            return System.Math.Pow(number, 1.0 / root);
        }

        public static double log10(double number)
        {
            return System.Math.Log10(number);
        }
    }
}
