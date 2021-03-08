using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    class BranchingStructures
    {
        private static int SumTwoNumbers(int numberA, int numberB)
        {
            return numberA + numberB;
        }
        private static int MultiplyTwoNumbers (int numberA, int numberB)
        {
            return numberA * numberB;
        }
        private static int SubtractionTwoNumbers(int numberA, int numberB)
        {
            return numberA - numberB;
        }
        private static int CalcDiscriminant (int numberA, int numberB, int numberC)
        {
            int discriminant = numberB * numberB - 4 * numberA * numberC;
            
            if (discriminant<0)
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
                BranchingStructures.MultiplyTwoNumbers(numberA, numberB);
            }
            else
            {
                result  = numberA > numberB ? BranchingStructures.SumTwoNumbers(numberA, numberB) 
                : BranchingStructures.SubtractionTwoNumbers(numberA, numberB);
            }
            return result;
        }
        public static void DefiningQuarterOnCoordinatePlane (int X, int Y)
        {
            string planeQuarter = string.Empty;
            if (X == 0 || Y == 0) planeQuarter = " lay on axis";
            else if (X > 0) planeQuarter = Y > 0 ? " in first quarter" : " in fourth quarter";
            else planeQuarter = Y > 0 ? " in second quarter" : " in third quarter";
            Console.WriteLine("Point A[{0},{1}]{2}", X, Y, planeQuarter);
        }
        public static double[] OutputInAscendingOrder(int numberA, int numberB, int numberC)
        {
            double[] result = new double[3];
            if (numberA > numberB && numberA > numberC)
            {
                if (numberB > numberC)
                {
                    result[0] = numberA;
                    result[1] = numberB;
                    result[2] = numberC;
                }
                else
                {
                    result[0] = numberA;
                    result[1] = numberC;
                    result[2] = numberB;
                }
            }
            else if (numberB > numberA && numberB > numberC)
            {
                if (numberA > numberC)
                {
                    result[0] = numberB;
                    result[1] = numberA;
                    result[2] = numberC;
                }
                else
                {
                    result[0] = numberB;
                    result[1] = numberC;
                    result[2] = numberA;
                }
            }
            else
            {
                if (numberA > numberB)
                {
                    result[0] = numberC;
                    result[1] = numberA;
                    result[2] = numberB;
                }
                else
                {
                    result[0] = numberC;
                    result[1] = numberB;
                    result[2] = numberA;
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

            /*
                Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.

             */

    }
}
