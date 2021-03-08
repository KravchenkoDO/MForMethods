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





        public static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
