using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Types
            var values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var filter =
                from value in values
                orderby value descending
                where value > 4
                select value;

            foreach(var value in filter)
            {
                Console.WriteLine(value);
            }

            //Reference Types
            var employees = new[]
{
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Matthew", "Indigo", 3587.5M),
                new Employee("James", "Indigo", 4700.77M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 3200M),
                new Employee("Wendy", "Brown", 4236.4M)
            };

            var between4K6K =
                from employee in employees
                where (employee.MonthlySalary >= 4000M) && (employee.MonthlySalary <= 6000M)
                select employee;

            Console.WriteLine($"\nEmployees earning in the range {4000:C} and {6000:C} per month:");
            foreach (var employee in between4K6K)
            {
                Console.WriteLine($"\t{employee}");
            }

            var nameSorted =
                from employee in employees
                orderby employee.LastName, employee.FirstName
                select employee;

            Console.WriteLine("\nEmployees in Name Order:");

            foreach (var employee in nameSorted)
            {
                Console.WriteLine($"\t{employee}");
            }

            Console.WriteLine("\nDemonstrating Any and First Extension Method:");
            if (nameSorted.Any())
            {
                Console.WriteLine($"\t{nameSorted.First()}");
            } else
            {
                Console.WriteLine("Not Found");
            }

            var lastNames =
                from employee in employees
                select employee.LastName;

            Console.WriteLine("\nUnique Last Names");
            foreach(var name in lastNames.Distinct())
            {
                Console.WriteLine($"\t{name}");
            }

            var anon =
                from e in employees
                select new { e.LastName, e.FirstName };

            Console.WriteLine("\nDemonstrating Anonymous Types");
            Console.WriteLine($"\t{anon.First().GetType()}");
            Console.ReadKey();
        }
    }
}
