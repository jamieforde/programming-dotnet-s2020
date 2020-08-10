using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList integers = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Example One:");

            foreach(var integer in integers)
            {
                Console.WriteLine($"\t{integer}");
            }

            Console.WriteLine("Example Two:");
            integers.Add("Eleven");

            //int three = integers[2];

            foreach (var integer in integers)
            {
                Console.WriteLine($"\t{(int) integer * 2}");
            }

            Console.ReadKey();

        }
    }
}
