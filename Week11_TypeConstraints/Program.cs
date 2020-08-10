using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_TypeConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Maximum of 5, 120, -189: {Maximum(5, 120, -189)}");
            Console.WriteLine($"Maximum of 3.14, 2.67, 1.99: {Maximum(3.14, 2.67, 1.99)}");        
            Console.WriteLine($"Maximum of pear, apple, orange: {Maximum("pear", "apple", "orange")}");

            Console.ReadKey();
        }

        public static T Maximum<T> (T x, T y, T z) where T : IComparable<T>
        {
            var max = x;

            if (y.CompareTo(max) > 0)
            {
                max = y;
            }

            if (z.CompareTo(max) >0) {
                max = z;
            };

            return max;

        }
    }
}
