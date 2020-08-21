using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50, 60, 70 };

            var sum = 10;

            for (var i = 1; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }

            Console.WriteLine($"\tSum of the: {sum}");

            Console.ReadKey();
        }
    }
}
