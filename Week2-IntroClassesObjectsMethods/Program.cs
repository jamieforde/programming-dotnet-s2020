
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Week2_IntroClassesObjectsMethods;

namespace Week2_Intro
{

    class Program
    {
        static void Main(string[] args)
        {
            var d1 = 10.0;
            var d2 = 23.5;
            var d3 = 12.9;
            var d4 = 343.98;

            Console.WriteLine(Average(d1,d2));
            Console.WriteLine(Average(d1,d2,d3,d4));
            Console.WriteLine(Average(d1,d3,d4));
            Console.WriteLine(Average());

            Console.ReadKey();
        }

        static double Average(params double[] numbers)
        {
            var total = 0.0;

            foreach (var d in numbers)
            {
                total += d;
            }

            return numbers.Length != 0 ? total / numbers.Length : 0.0;
        }


        static void SquareRef(ref int x)
        {
            x = x * x;
        }

        static void Square(int x)
        {
            x = x * x;
        }
        //static void 

        static int Power(int baseValue, int exponentValue = 2)
        {
            int result = 1;

            for (int i = 1; i <= exponentValue; ++i)
            {
                result *= baseValue;
            }

            return result;
        }

    }
}
