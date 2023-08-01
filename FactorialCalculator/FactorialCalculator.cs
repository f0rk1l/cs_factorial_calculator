using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculator
{
    class FactorialCalculator
    {

        private static bool IsPrime(double number)
        {
            for (int i = 2; i <= (int) Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static double[] GetFib(int amount)
        {
            double[] Numbers = new double[amount];

            Numbers[0] = 1;

            Numbers[1] = 1;

            for (int i = 2; i < amount; i++)
            {
                Numbers[i] = (Numbers[i - 1] + Numbers[i - 2]);
            }

            return Numbers;
        }


        public static double Factorial(double number)
        {
            int Result = 1;

            for (int i = 1; i <= number; i++)
            {
                Result *= i;
            }

            return Result;
        }

        public static double DoubleFactorial(double number)
        {
            bool IsEven = number % 2 == 0;

            double Result = 1;

            for (int i = 1; i <= number; i++)
            {
                if ((i % 2 == 0) == IsEven)
                {
                    Result *= i;
                }
            }

            return Result;
        }

        public static double Primorial(double number)
        {
            double Result = 1;

            for (int i = 1; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Result *= i;
                }

            }

            return Result;
        }

        public static double SuperFactorial(double number)
        {
            double Result = 1;

            for (double i = 1; i <= number; i++)
            {
                Result *= Factorial(i);
            }

            return Result;
        }

        public static double Fibonarial(double number)
        {
            double Result = 1;

            foreach (double i in GetFib((int) number))
            {
                Result *= i;
            }

            return Result;
        }

    }

}
