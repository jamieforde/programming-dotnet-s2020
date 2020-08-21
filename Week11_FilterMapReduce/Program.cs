using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Week11_FilterMapReduce
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<int> { 3, 10, 6, 1, 4, 8, 2, 5, 9, 7 };


            //var filtered =
            //    from value in values
            //    where value > 6
            //    select value;

            var filtered = values.Where(e => e > 6);


            Console.WriteLine($"Original Values:");
            values.Display();

            Console.WriteLine($"\nMin:  {values.Min()}");
            Console.WriteLine($"\nMax:  {values.Max()}");
            Console.WriteLine($"\nSum:  {values.Sum()}");
            Console.WriteLine($"\nAverage:  {values.Average()}");

            var aggregateProduct = values.Aggregate(0, (x, y) => x + y * y);
            Console.WriteLine($"\nProduct using Aggregate method: {aggregateProduct}");

            Console.Write("\nEven values from our list: ");
            values.Where(x => x % 2 == 0)
                  .OrderBy(x => x)
                  .Display();

            Console.Write("\nOdd values multipled by 10: ");
            values.Where(value => value % 2 != 0)
                  .Select(value => value * 10)
                  .Display();

            Console.WriteLine($"Original Values:");
            values.Display();

            Console.ReadKey();
        }
    }

    static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> data)
        {
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
