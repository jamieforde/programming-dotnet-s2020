using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassesAndObjectsDeeperLook
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Time2(19);
            var t2 = new Time2(21, 32);

            // Object Initializer
            var t5 = new Time2() {
               Hour = 12,
               Minute = 23,
               Second = 54
            };

            var t3 = t2.AddHours(2);

            var newTime = new Time2(12, 12, 12);
            var fixedTime = new Time2(23, 12, 12);
            var newTime2 = new Time2(fixedTime);

            Console.WriteLine(newTime);
            Console.WriteLine(fixedTime);
            Console.WriteLine(newTime2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t5);

            Console.ReadKey();
        }
    }
}
