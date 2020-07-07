using System;
using System.IO;

namespace Week5_Exceptions
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer numerator: ");

            
            var isValidNumerator = int.TryParse(Console.ReadLine(), out var numerator);
            
            //Outputing to the console 
            Console.WriteLine("Enter an integer denominator: ");
            
            var isValidDenominator = int.TryParse(Console.ReadLine(), out var denominator);

            isValidNumerator.GetHashCode();

            if (isValidDenominator && isValidNumerator)
            {

                var result = numerator / denominator;
                Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}");
            } else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();












            //using (StreamReader streamReader = new StreamReader(@"C:\Users\Jamie Forde\Desktop\customers.txt"))
            //{




            //}

            //Employee employee = new Employee();

            //employee.BaseSalary = 100M;

            ////employee.FirstName = "Frank";

            //string firstName = employee.FirstName ?? "Bob";

            //decimal? salary = employee?.BaseSalary;

            //Console.WriteLine(employee.FirstName);

            //Console.WriteLine($"{salary.Value:C}");



            //try
            //{

            //    while (!streamReader.EndOfStream)
            //    {
            //        Console.WriteLine(streamReader.ReadLine());
            //    }

            //    streamReader = null;


            //    //Console.WriteLine("Enter an integer: ");
            //    //var numerator = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("Enter an integer: ");
            //    //var denominator = int.Parse(Console.ReadLine());
            //    //Test();
            //    //var result = numerator / denominator;
            //    //Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}");

            //    Console.ReadKey();
            //}
            //catch (FormatException formatException)
            //{
            //    Console.WriteLine(formatException.Message);
            //    Console.WriteLine("You must enter numbers only");
            //}
            //catch (DivideByZeroException divideByZero)
            //{
            //    Console.WriteLine(divideByZero.Message);
            //    Console.WriteLine("You must enter numbers greater than 0 for the denominator");
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine("There was an issue");
            //}
            //finally
            //{
            //    Console.WriteLine("A final action");

            //    streamReader?.Close();


            //}
        }

        public static void Test()
        {
            Console.WriteLine("This is a test");
        }
    }
}
