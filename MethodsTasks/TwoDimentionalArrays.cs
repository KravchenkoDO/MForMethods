using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    class TwoDimentionalArrays
    {
        public static int[,] InitializeAndFill(int rows, int columns)
        {
            Random random = new Random();
            int[,] array = new int[rows, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 101);
                }
            }
            return array;
        }
        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] <= 9)
                    {
                        Console.Write("{0}   ", array[i, j]);
                    }
                    else if (array[i, j] >= 9 && array[i, j] <= 99)
                    {
                        Console.Write("{0}  ", array[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public static int GetMaxElement (int [,] array)
        {
           int maxValue = array[0, 0];
           for (int i = 0; i < array.GetLength(0); i++)
           {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] > maxValue)
                    {
                        maxValue = array[i, j];
                    }
                }
           }
           return maxValue; 
        }
        public static int GetMinElement (int [,] array)
        {
            int minValue = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                    }
                }
            }
            return minValue;
        }
        public static int[] GetIndexOfMaxElement(int[,] array)
        {
            int maxValue = array[0, 0];
            int[] maxArrIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxValue)
                    {
                        maxArrIndex[0] = i;
                        maxArrIndex[1] = j;
                    }
                }
            }
            return maxArrIndex;
        }
        public static int[] GetIndexOfMinElement(int[,] array)
        {
            int minValue = array[0, 0];
            int[] minArrIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minArrIndex[0] = i;
                        minArrIndex[1] = j;
                    }
                }
            }
            return minArrIndex;
        }
        public static int CountElementsThatLargerThenNeighbors(int[,] array)
        {
            int counter = 0;
            int rowCount = array.GetLength(0) - 1;
            int columnCount = array.GetLength(1) - 1;
            //Analize
            for (int i = 0; i <= rowCount; i++)
            {
                for (int j = 0; j <= columnCount; j++)
                {
                    //Upper row
                    if (i == 0 && j == 0)
                    {
                        if ((array[i, j] > array[i + 1, j])
                            && (array[i, j] > array[i, j + 1])) counter++;
                    }
                    else if ((i == 0) && (j > 0) && (j < columnCount))
                    {
                        if ((array[i, j] > array[i, j - 1])
                            && (array[i, j] > array[i, j + 1])
                            && (array[i, j] > array[i + 1, j])) counter++;
                    }
                    else if ((i == 0) && (j == columnCount))
                    {
                        if ((array[i, j] > array[i, j - 1])
                            && (array[i, j] > array[i + 1, j])) counter++;
                    }
                    //Left column
                    else if ((i > 0) && (i < rowCount) && (j == 0))
                    {
                        if ((array[i, j] > array[i - 1, j])
                            && (array[i, j] > array[i + 1, j])
                            && (array[i, j] > array[i, j + 1])) counter++;
                    }
                    //Right column
                    else if ((i > 0) && (i < rowCount) && (j == rowCount))
                    {
                        if ((array[i, j] > array[i, j - 1])
                            && (array[i, j] > array[i - 1, j])
                            && (array[i, j] > array[i + 1, j])) counter++;
                    }
                    //Lower row
                    else if ((i == rowCount) && (j == 0))
                    {
                        if ((array[i, j] > array[i - 1, j])
                            && (array[i, j] > array[i, j + 1])) counter++;
                    }
                    else if ((i == rowCount) && (j > 0) && (j < columnCount))
                    {
                        if ((array[i, j] > array[i - 1, j])
                            && (array[i, j] > array[i, j + 1])
                            && (array[i, j] > array[i, j - 1])) counter++;
                    }
                    else if ((i == rowCount) && (j == columnCount))
                    {
                        if ((array[i, j] > array[i - 1, j])
                            && (array[i, j] > array[i, j - 1])) counter++;
                    }
                    //Middle
                    else
                    {
                        if (array[i, j] > array[i - 1, j] &&
                            array[i, j] > array[i + 1, j] &&
                            array[i, j] > array[i, j - 1] &&
                            array[i, j] > array[i, j + 1]) counter++;
                    }
                }
            }
            return counter;
        }
        public static int[,] Transpose(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] result = new int[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

    }
}
