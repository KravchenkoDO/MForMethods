using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] array;
            //array = OneDimentionalArrays.InitializeAndFill(15);
            //OneDimentionalArrays.Print(array);
            //Console.WriteLine();

            //int[,] twoDimentionalArray;
            //twoDimentionalArray = TwoDimentionalArrays.InitializeAndFill(4, 6);
            //TwoDimentionalArrays.Print(twoDimentionalArray);

            //Console.WriteLine("Numbe elements that larger then their neighbors = {0}",
            //    TwoDimentionalArrays.CountElementsThatLargerThenNeighbors(twoDimentionalArray));

            //Console.WriteLine();
            //int[,] transposeMatrix;
            //transposeMatrix = TwoDimentionalArrays.Transpose(twoDimentionalArray);
            //TwoDimentionalArrays.Print(transposeMatrix);

            //double[] array = BranchingStructures.OutputInAscendingOrder(11, 2, 0);
            //OneDimentionalArrays.Print(array);

            //int [,] array = TwoDimentionalArrays.InitializeAndFill(5, 5);
            //TwoDimentionalArrays.Print(array);
            //int[] index = TwoDimentionalArrays.GetIndexOfMaxElement(array);
            //OneDimentionalArrays.Print(index);
            //index = TwoDimentionalArrays.GetIndexOfMinElement(array);
            //OneDimentionalArrays.Print(index);

            double[] array = OneDimentionalArrays.InitializeAndFill(10);
            OneDimentionalArrays.Print(array);
            Console.WriteLine();
            double[] invertArray = OneDimentionalArrays.Reverse(ref array);
            OneDimentionalArrays.Print(invertArray);
            //Console.WriteLine("\nMin value {1} with min index {0}",OneDimentionalArrays.FindIndexOfMinValue(array), OneDimentionalArrays.FindMinValue(array));
            //Console.WriteLine("Max value {1} with max index {0}", OneDimentionalArrays.FindIndexOfMaxValue(array), OneDimentionalArrays.FindMaxValue(array));
            //Console.WriteLine("\n" + OneDimentionalArrays.SumElementsWithOddIndex(array));
            Console.ReadKey();

        }
    }
}
