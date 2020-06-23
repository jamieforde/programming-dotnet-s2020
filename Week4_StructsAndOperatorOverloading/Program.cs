using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_StructsAndOperatorOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newFraction = new Fraction(1, 2);

            var fraction2 = -newFraction;

            var fraction3 = newFraction + fraction2;



            Console.WriteLine(newFraction);
            Console.WriteLine(fraction2);
            Console.WriteLine(fraction3);



            Console.ReadKey();
        }
    }
}
