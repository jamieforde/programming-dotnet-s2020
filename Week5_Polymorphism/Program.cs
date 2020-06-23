using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Polymorphism
{
    /*
    Polymorphism
    *  Process objects that share a base class as if there were all objects of the base class.
    *  Allows us to program in the general
    *  The same message sent to a variety of objects has many forms of results. 
    *  Promotes extensibility:
        * Add new classes without changing the polymorphic portions of the app.
        * The only parts of the app that need to change are the code that needs specific 
        * knowledge of the class. 
     */

    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate objects of each type
            var salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-111", 800.00M);
            var hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 15.75M, 40.0M);
            var commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000.00M,
                0.4M, 300.00M);

            Console.WriteLine("Employees processed individually:");
            Console.WriteLine($"{salariedEmployee}\nearned: " +
                $"{salariedEmployee.Earnings()}\n");
            Console.WriteLine($"{hourlyEmployee}\nearned: " +
                $"{hourlyEmployee.Earnings():C}\n");
            Console.WriteLine($"{commissionEmployee}\nearned: " +
                $"{commissionEmployee.Earnings():C}\n");
            Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
                $"{basePlusCommissionEmployee.Earnings():C}\n");

            //Create a list of employees
            var employees = new List<Employee>() { salariedEmployee, hourlyEmployee, commissionEmployee, basePlusCommissionEmployee };
         
            Console.WriteLine("Process employee polymorphically:");
            foreach (var currentEmployee in employees)
            {
                // The type of actual reference object, not the type of the reference, determines which method is called
                // While polymorphism allows us to program "in the general"
                // We can also work on specific types of objects 
                // Note the 'is' operator
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    // Downcasting 
                    // The next line could through an exception so should be wrapped in a try catch
                    // var employeeRaise = (BasePlusCommissionEmployee)employee;

                    // Another approach is to downcast using the as operator
                    // This will NOT through an exception if the cast fails the variable is null.
                    var employee = currentEmployee as BasePlusCommissionEmployee;

                    // Give BasPlusCommissionEmployee's a 10% raise
                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine($"new base salary after raise: {employee.BaseSalary:C}");
                }

                Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");
            }

            Console.WriteLine("Illustrating that each object knows it's type:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.GetType()}");
            }

            // Create a list of objects that implement the IPayable Interface
            // Note the use of the collection initializer
            var payableObjects = new List<IPayable> {
                new Invoice("01234", "seat", 2, 375.00M),
                new Invoice("56789", "tire", 3, 79.95M),
                new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M),
                new SalariedEmployee("Lisa", "Barnes", "888-88-8888", 1200.00M)
            };


            // Processing objects that process IPayable interface programatically
            Console.WriteLine($"\nProcessing IPayable objects polymorphically:");
            foreach (var payable in payableObjects)
            {
                Console.WriteLine($"{payable}");
                Console.WriteLine($"payment due:  {payable.GetPaymentAmount():C}");
            }

            Console.ReadKey();
        }
    }
}
