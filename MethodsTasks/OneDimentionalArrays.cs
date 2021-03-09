using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    class OneDimentionalArrays
    {
        public static double[] InitializeAndFill(int size)
        {
            Random random = new Random();
            double[] array = new double[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
            }
            return array;
        }
        public static double FindMinValue(double[] array)
        {
            double arrayMinValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < arrayMinValue)
                {
                    arrayMinValue = array[i];
                }
            }
            return arrayMinValue;
        }
        public static double FindMaxValue(double[] array)
        {
            double arrayMaxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > arrayMaxValue)
                {
                    arrayMaxValue = array[i];
                }
            }
            return arrayMaxValue;
        }
        public static int FindIndexOfMinValue(double[] array)
        {
            int arrayIndexMinValue = 0;
            double arrayMinValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < arrayMinValue)
                {
                    arrayMinValue = array[i];
                    arrayIndexMinValue = i;
                }
            }
            return arrayIndexMinValue;
        }
        public static int FindIndexOfMaxValue(double[] array)
        {
            int arrayIndexMaxValue = 0;
            double arrayMaxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > arrayMaxValue)
                {
                    arrayMaxValue = array[i];
                    arrayIndexMaxValue = i;
                }
            }
            return arrayIndexMaxValue;
        }
        public static double SumElementsWithOddIndex(double [] array)
        {
            double SumOdd = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                SumOdd += array[i];
            }
            return SumOdd;
        }
        public static double[] Reverse(ref double[] array)
        {
            double tmp = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }
            return array;
        }
        public static int CountOddElements (double [] array)
        {
            int arrayOddCounter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    arrayOddCounter++;
                }
            }
            return arrayOddCounter;
        }
        public static double[] ReverseHalf(ref double [] array)
        {
            double tmp = 0;
            int midle = 0;
            int halfSize = array.Length / 2;
            if (array.Length % 2 == 0)
            {
                midle = halfSize;
            }
            else midle = halfSize + 1;

            for (int i = 0; i < halfSize; i++)
            {
                tmp = array[i];
                array[i] = array[midle + i];
                array[midle + i] = tmp;
            }
            return array;
        }
        public static double[] SortBubble(ref double[] array, bool ascending)
        {
            double tmp = 0;
            if (ascending)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                        if (array[j - 1] > array[j])
                        {
                            tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                        }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                        if (array[j - 1] < array[j])
                        {
                            tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                        }
                }
            }
            return array;
        }
        public static double[] SortSelect(ref double[] array, bool ascending)
        {
            int lessIndex;
            int greateIndex;
            double lessValue;
            double greateValue;
            if (ascending)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    lessIndex = i;
                    lessValue = array[i];
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < lessValue)
                        {
                            lessIndex = j;
                            lessValue = array[j];
                        }
                    }
                    array[lessIndex] = array[i];
                    array[i] = lessValue;
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    greateIndex = i;
                    greateValue = array[i];
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > greateValue)
                        {
                            greateIndex = j;
                            greateValue = array[j];
                        }
                    }
                    array[greateIndex] = array[i];
                    array[i] = greateValue;
                }
            }
            return array;
        }
        public static double[] SortInsert(ref double[] array, bool ascending)
        {
            double tmp = 0;
            int k = 0;

            if (ascending)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    tmp = array[i];
                    for (k = i - 1; k >= 0 && array[k] > tmp; k--)
                    {
                        array[k + 1] = array[k];
                    }
                    array[k + 1] = tmp;
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    tmp = array[i];
                    for (k = i - 1; k >= 0 && array[k] < tmp; k--)
                    {
                        array[k + 1] = array[k];
                    }
                    array[k + 1] = tmp;
                }
            }
            return array;
        }
        public static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
    //TODO: chek all methods in Program.cs;
}
