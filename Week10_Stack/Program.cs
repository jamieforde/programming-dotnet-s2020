using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();

            for (var i = 0; i < 10; i++)
            {
                intStack.Push(i);
            }

            Console.Write("Contents of the stack: ");
            foreach(var integer in intStack)
            {
                Console.Write($"{integer} ");
            }

            Console.Write($"\nPop: {intStack.Pop()}");
            Console.Write("\nContents of the stack: ");
            foreach (var integer in intStack)
            {
                Console.Write($"{integer} ");
            }

            Console.Write($"\nPeek: {intStack.Peek()}");
            Console.Write("\nContents of the stack: ");
            foreach (var integer in intStack)
            {
                Console.Write($"{integer} ");
            }

            Console.ReadKey();
        }
    }
}
