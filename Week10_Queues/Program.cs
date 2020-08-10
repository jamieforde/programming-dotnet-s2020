using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                intQueue.Enqueue(i * 5);
            }


            Console.Write("The values in intQueue: ");
            foreach(var integer in intQueue)
            {
                Console.Write($"{integer} ");
            }


            Console.WriteLine($"\nDequeue: {intQueue.Dequeue()}");

            Console.Write("The values in intQueue: ");
            foreach (var integer in intQueue)
            {
                Console.Write($"{integer} ");
            }

            Console.WriteLine($"\nPeek: {intQueue.Peek()}");
            foreach (var integer in intQueue)
            {
                Console.Write($"{integer} ");
            }

            Console.ReadKey();
        }
    }
}
