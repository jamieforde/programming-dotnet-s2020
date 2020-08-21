using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_GenericClasses
{
    public class StackTest
    {
        private static double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
        private static int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private static Stack<double> doubleStack;
        private static Stack<int> intStack;

        static void Main(string[] args)
        {
            doubleStack = new Stack<double>();
            intStack = new Stack<int>();

            TestPush(nameof(doubleStack), doubleStack, doubleElements);
            TestPop(nameof(doubleStack), doubleStack);
            TestPush(nameof(intStack), intStack, intElements);
            TestPop(nameof(intStack), intStack);

            Console.ReadKey();
        }

        private static void TestPush<T>(string name, Stack<T> stack, IEnumerable<T> elements)
        {
            try
            {
                Console.WriteLine($"\nPushing elements onto {name}");

                foreach(var element in elements)
                {
                    Console.Write($"{element} ");
                    stack.Push(element);
                }

            } catch(FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage:  {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        private static void TestPop<T>(string name, Stack<T> stack)
        {
            try
            {
                Console.WriteLine($"\nPopping elements from {name}");
                T popValue;

                while(true)
                {
                    popValue = stack.Pop();
                    Console.Write($"{popValue} ");
                }
            } catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage:  {exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
    }
}
