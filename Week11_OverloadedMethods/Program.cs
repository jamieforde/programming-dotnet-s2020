using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OverloadedMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 0, 34, 55, 765, 432, 12, 1, 9 };
            double[] doubleArray = { 3.14, 2.67, 19.87, 99.54, -45.44 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            DisplayArray(intArray);
            DisplayArray(doubleArray);
            DisplayArray(charArray);

            Console.ReadKey();
        }

        private static void DisplayArray (int[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        private static void DisplayArray(double[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        private static void DisplayArray(char[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }




    }
}
