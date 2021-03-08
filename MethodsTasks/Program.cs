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
            double result = Variables.SolveLinearEquation(0,12,3);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
