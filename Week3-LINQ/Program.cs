using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week3_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var filterList1 = new int[100];

            Console.WriteLine("Adding numbers greater than 4 to a new array");
            foreach (var value in values)
            {
                if (value > 4)
                {
                    filterList1.Append(value);
                }
            }

            Console.WriteLine("Ouput numbers greater than 4");

            foreach (var value in filterList1)
            {
                Console.Write($"{value} ");
            }

            // Introducting LINQ 










            Console.ReadKey();
        }
    }
}
