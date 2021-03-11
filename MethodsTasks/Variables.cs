using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    public class Variables
    {
        private static double DivideTwoNumbers(double numberAd, double numberBd)
        {
            double result = 0;
            if (numberBd == 0)
            {
                throw new Exception("Number B can not be equal to 0");
            }
            else
            {
                result = numberAd / numberBd;
            }
            return result;
        }
        private static double ReminderOfTheDivision(double numberAd, double numberBd)
        {
            double result = 0;
            result = numberAd % numberBd;
            return result;
        }
        public static double FindExpressionValue(double numberAd, double numberBd)
        {
            double resultd = 0;
            if (numberAd == numberBd)
            {
                throw new Exception("Parameter B can not be equal parameter A");
            }
            else
            {
                resultd = (5 * numberAd + numberBd * numberBd) / (numberBd - numberAd);
            }
            return resultd;
        }
        public static void SwapNumbers(ref double numberAd, ref double numberBd)
        {
            double numberCd = 0;
            numberCd = numberBd;
            numberBd = numberAd;
            numberAd = numberCd;
        }
        public static double[] DivideTwoNumbersAndReminderOfTheDivision(double numberAd, double numberBd)
        {
            double[] result = new double[2] { 0, 0 };
            if (numberBd == 0)
            {
                throw new Exception("Number B can not be equal to 0");
            }
            else
            {
                result[0] = Variables.DivideTwoNumbers(numberAd, numberBd);
                result[1] = Variables.ReminderOfTheDivision(numberAd, numberBd);
            }
            return result;
        }
        public static double SolveLinearEquation(double numberAd, double numberBd, double numberCd)
        {
            double result = 0;
            if (numberAd == 0)
            {
                throw new Exception("Number A can not be equal to 0");
            }
            else
            {
                result = (numberCd - numberBd) / numberAd;
            }
            return result;
        }
        public static double[] DeriveEquationOfStraightLinePassingThroughPoints (double abscissaA, double ordinateA, double abscissaB, double ordinateB)
        {

            /* 
            * Y = AX + B;
            * A = (y1 - y2) / (x1 - x2);
            * B = y2 - A * x2;
            */
            double[] result = new double[2];

            if (abscissaA == abscissaB)
            {
                throw new Exception("Abscissa of point A can't be equal to abscissa of point B");      
            }
            else
            {
                result[0] = (ordinateA - ordinateB) / (abscissaA - abscissaB);
                result[1] = ordinateB - result[0] * abscissaB;
            }
            return result;
        }

        




    }
}
