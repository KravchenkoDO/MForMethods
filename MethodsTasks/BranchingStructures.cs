using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    public class BranchingStructures
    {
        private static int SumTwoNumbers(int numberA, int numberB)
        {
            return numberA + numberB;
        }
        private static int MultiplyTwoNumbers(int numberA, int numberB)
        {
            return numberA * numberB;
        }
        private static int SubtractionTwoNumbers(int numberA, int numberB)
        {
            return numberA - numberB;
        }
        private static int CalcDiscriminant(int numberA, int numberB, int numberC)
        {
            int discriminant = numberB * numberB - 4 * numberA * numberC;

            if (discriminant < 0)
            {
                throw new Exception("Discriminant must be greater or equal to 0");
            }
            else return discriminant;
        }
        public static int SumOrMultiplyOrSubstraction(int numberA, int numberB)
        {
            int result = 0;
            if (numberA == numberB)
            {
                result = BranchingStructures.MultiplyTwoNumbers(numberA, numberB);
            }
            else
            {
                result = numberA > numberB ? BranchingStructures.SumTwoNumbers(numberA, numberB)
                : BranchingStructures.SubtractionTwoNumbers(numberA, numberB);
            }
            return result;
        }
        public static int DefiningQuarterOnCoordinatePlane(int X, int Y)
        {
            int planeQuarter;
            if (X == 0 || Y == 0) planeQuarter = 0;
            else if (X > 0) planeQuarter = Y > 0 ? 1 : 4;
            else planeQuarter = Y > 0 ? 2 : 3;
            return planeQuarter;
        }
        public static double[] OutputInAscendingOrder(double numberAd, double numberBd, double numberCd)
        {
            //TODO: Fix this Bull Shit!!!
            double[] result = new double[3];
            if (numberAd > numberBd && numberAd > numberCd)
            {
                if (numberBd > numberCd)
                {
                    result[0] = numberAd;
                    result[1] = numberBd;
                    result[2] = numberCd;
                }
                else
                {
                    result[0] = numberAd;
                    result[1] = numberCd;
                    result[2] = numberBd;
                }
            }
            else if (numberBd > numberAd && numberBd > numberCd)
            {
                if (numberAd > numberCd)
                {
                    result[0] = numberBd;
                    result[1] = numberAd;
                    result[2] = numberCd;
                }
                else
                {
                    result[0] = numberBd;
                    result[1] = numberCd;
                    result[2] = numberAd;
                }
            }
            else
            {
                if (numberAd > numberBd)
                {
                    result[0] = numberCd;
                    result[1] = numberAd;
                    result[2] = numberBd;
                }
                else
                {
                    result[0] = numberCd;
                    result[1] = numberBd;
                    result[2] = numberAd;
                }
            }
            return result;
        }
        public static double[] SolveQuadraticEquation(int numberA, int numberB, int numberC)
        {
            double[] result = new double[2];
            int discriminant = BranchingStructures.CalcDiscriminant(numberA, numberB, numberC);
            if (discriminant < 0)
            {
                throw new Exception("Discriminant must be greater or equal to 0");
            }
            else if (discriminant > 0)
            {
                result[0] = ((-1) * numberB + Math.Sqrt(discriminant)) / (2 * numberA);
                result[1] = ((-1) * numberB - Math.Sqrt(discriminant)) / (2 * numberA);
            }
            else
            {
                result[0] = (-1) * numberB / 2 * numberA;
            }
            return result;
        }

        public static string OutputNumberInWords(int numberInt)
        {
            string numberStr = string.Empty;
            string strTens = string.Empty;
            string strOnes = string.Empty;
            if (numberInt < 10 || numberInt > 99)
            {
                throw new Exception("Number must be from 10 to 99 interval");
            }
            else if (numberInt < 20)
            {
                switch (numberInt)
                {
                    case 10:
                        numberStr = "Ten";
                        break;
                    case 11:
                        numberStr = "Eleven";
                        break;
                    case 12:
                        numberStr = "Twelve";
                        break;
                    case 13:
                        numberStr = "Thirteen";
                        break;
                    case 14:
                        numberStr = "Fourteen";
                        break;
                    case 15:
                        numberStr = "Fifteen";
                        break;
                    case 16:
                        numberStr = "Sixteen";
                        break;
                    case 17:
                        numberStr = "Seventeen";
                        break;
                    case 18:
                        numberStr = "Eighteen";
                        break;
                    case 19:
                        numberStr = "Nineteen";
                        break;
                }
            }
            else
            {
                switch (numberInt / 10 * 10)
                {
                    case 20:
                        strTens = "Twenty";
                        break;
                    case 30:
                        strTens = "Thirty";
                        break;
                    case 40:
                        strTens = "Fourty";
                        break;
                    case 50:
                        strTens = "Fifty";
                        break;
                    case 60:
                        strTens = "Sixty";
                        break;
                    case 70:
                        strTens = "Seventy";
                        break;
                    case 80:
                        strTens = "Eighty";
                        break;
                    case 90:
                        strTens = "Ninety";
                        break;
                }

                switch (numberInt % 10)
                {
                    case 0:
                        strOnes = "";
                        break;
                    case 1:
                        strOnes = "One";
                        break;
                    case 2:
                        strOnes = "Two";
                        break;
                    case 3:
                        strOnes = "Three";
                        break;
                    case 4:
                        strOnes = "Four";
                        break;
                    case 5:
                        strOnes = "Five";
                        break;
                    case 6:
                        strOnes = "Six";
                        break;
                    case 7:
                        strOnes = "Seven";
                        break;
                    case 8:
                        strOnes = "Eight";
                        break;
                    case 9:
                        strOnes = "Nine";
                        break;
                }

                numberStr = strTens + " " + strOnes;
            }

            return numberStr;
        }
    }
}
