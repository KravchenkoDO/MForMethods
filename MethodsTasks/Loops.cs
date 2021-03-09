using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    class Loops
    {
        public static double Exponentiation(double numberAd, double numberBd)
        {
            double resultd = 1.0;
            if (numberAd == 0 && numberBd < 0)
            {
                throw new Exception("Number A can not be equal to 0 when number B less then 0!!!");
            }
            else if (numberBd >= 0)
            {
                for (int i = 0; i < numberBd; i++)
                {
                    resultd = numberAd * resultd;
                }
            }
            else
            {
                for (int i = 0; i < Math.Abs(numberBd); i++)
                {
                    resultd = 1.0 / numberAd * resultd;
                }
            }
            return resultd;
        }
        public static double[] GetNumbersDividedByNumberA(int numberA)
        {
            double[] array = new double[1000 / numberA];
            if (numberA == 0)
            {
                throw new Exception("Number A can not be equal to 0!!!");
            }
            else
            {
                for (int i = numberA, k = 0; i <= 1000; i += numberA)
                {
                    array[k++] = i;
                }
            }
            return array;
        }
        public static int FindCountPositiveIntegerElementsThatSquareLessThenNumberA(double numberA)
        {
            double sqrtA = 0;
            int counter = 0;
            sqrtA = Math.Sqrt(numberA);
            for (int i = 1; i < sqrtA; i++)
            {
                if (i * i < numberA)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int GetGreaterDivider(int numberA)
        {
            int divider = 1;
            for (int i = (numberA - 1); i > 0; i--)
            {
                if (numberA % i == 0)
                {
                    divider = i;
                    break;
                }
            }
            return divider;
        }

    }
}
