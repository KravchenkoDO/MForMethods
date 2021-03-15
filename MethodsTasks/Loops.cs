using System;

namespace MethodsTasks
{
    public class Loops
    {
        public static double Exponentiation(double numberAd, double numberBd)
        {
            double resultd = 1.0;
            if (numberAd == 0 && numberBd < 0)
            {
                throw new ArgumentException("Number A can not be equal to 0 when number B less then 0!!!");
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
            double[] array;
            if (numberA == 0)
            {
                throw new DivideByZeroException("Number A can not be equal to 0!!!");
            }
            else
            {
                array = new double[1000 / numberA];
                for (int i = numberA, k = 0; i <= 1000; i += numberA)
                {
                    array[k++] = i;
                }
            }

            return array;
        }

        public static int FindCountPositiveIntegerElementsThatSquareLessThenNumberA(double numberA)
        {
            double sqrtA;
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
            if (numberA == 0 || numberA == 1 || numberA == -1)
            {
                throw new ArgumentException("Try insert another argument!!!");
            }
            else
            {
                for (int i = (Math.Abs(numberA) - 1); i > 0; i--)
                {
                    if (numberA % i == 0)
                    {
                        divider = i;
                        break;
                    }
                }
            }

            return divider;
        }

        public static int GetSumNumbersFromAToBThatDividedBySeven(int numberA, int numberB)
        {
            int summ = 0;
            if (numberA > numberB)
            {
                for (int i = numberB; i <= numberA; i++)
                {
                    if (i % 7 == 0)
                    {
                        summ += i;
                    }
                }
            }
            else
            {
                for (int i = numberA; i <= numberB; i++)
                {
                    if (i % 7 == 0)
                    {
                        summ += i;
                    }
                }
            }

            return summ;
        }

        public static int FindNumberFibonacci(int numberN)
        {
            int fib = 0;
            int a = 1, b = 1;
            if (numberN < 1)
            {
                throw new ArgumentException();
            }

            if (numberN == 1 || numberN == 2) return 1;
            for (int i = 3; i <= numberN; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }

            return fib;
        }

        public static int FindGreatestCommonDividerByEvclidAlgorithm(int numberA, int numberB)
        {
            numberB = Math.Abs(numberB);
            numberA = Math.Abs(numberA);
            if (numberA == 0 || numberB == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                while (numberA != numberB)
                {
                    if (numberA > numberB)
                    {
                        numberA = numberA - numberB;
                    }
                    else
                    {
                        numberB = numberB - numberA;
                    }
                }
            }

            return numberA;
        }

        public static long FindNumberByHalfDivisionMethod(int numberN)
        {
            long left = 1;
            long right = numberN;
            long center = (right + left) / 2;
            while (center * center * center != numberN)
            {
                if (center * center * center > numberN)
                {
                    right = center;
                }
                else
                {
                    left = center;
                }
                center = (right + left) / 2;
            }

            return center;

        }

        public static int CountOddNumeralsOfNumber(int numberA)
        {
            int partOfA;
            int counter = 0;

            while (!(numberA == 0))
            {
                partOfA = numberA % 10;
                if (partOfA % 2 == 1)
                {
                    counter++;
                }

                numberA = numberA / 10;
            }

            return counter;
        }

        public static int FindMirrorNumber(int numberN)
        {
            int mirrorNumber = 0;
            int part;

            while (Math.Abs(numberN) > 0)
            {
                part = numberN % 10;
                mirrorNumber = (part + mirrorNumber * 10);
                numberN = numberN / 10;
            }

            return mirrorNumber;
        }

        public static double[] FindNumbersWhereSumEvenNumeralsGreaterThenSumOddNumerals(int numberN)
        {
            int nextNumber;
            int part;
            int sumEven;
            int sumOdd;
            double[] array;

            array = numberN == 2 ? new double[numberN / 2] : new double[numberN / 2 -1];

            for (int i = 1, k = 0; i <=numberN; i++)
            {


                sumEven = 0;
                sumOdd = 0;
                nextNumber = i;
                while (nextNumber > 0)
                {
                    part = nextNumber % 10;

                    if (part % 2 == 0)
                    {
                        sumEven += part;
                    }
                    else
                    {
                        sumOdd += part;
                    }

                    nextNumber /= 10;
                }

                if (sumEven > sumOdd)
                {
                    array[k] = i;
                    ++k;
                }
            }

            return array;

        }

        public static string HaveTheSameNumerals(int numberA, int numberB)
        {
            int temp;
            int partA;
            int partB;
            string answer;
            bool findAnswer = false;

            answer = "NO";
            while ((numberA > 0) && (findAnswer == false))
            {
                partA = numberA % 10;
                temp = numberB;
                while (temp > 0)
                {
                    partB = temp % 10;
                    if (partA == partB)
                    {
                        answer = "YES";
                        findAnswer = true;
                        break;
                    }

                    temp = temp / 10;
                }

                numberA = numberA / 10;
            }

            return answer;
        }
    }
}
