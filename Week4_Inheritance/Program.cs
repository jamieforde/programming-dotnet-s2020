using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Inheritance
{
 /*

    Inheritance Review:
     One of the foundations of OOP
     New classes can absorb existing class members and add its own fields and methods
     Reuse software that is known to work
    Definitions:
     Base Class = exisiting class. 
     Derived Class = new class. 
     is-a relationship = an object of derived class can be treated as an object of its base class.
     Inheritance Heirarchy = relationship tree with specialized types branching of from more generalized.
    Override = derived class can redefine the base class method.  
    Private = base class private members ARE inherited but NOT directly accessible
    Protected = can be access members of the base class AND by members of derived classes.  
    Constructors are not inherited.  We can call them:
     Explicitly - called using 'base' key word
     Implicitly - compiler generates a call to the base class parameterless constructor if there is one.
    
*/

    public class Program
    {
        static void Main(string[] args)
        {
            var commissionEmployee = new CommissionEmployee("Sue", "Jones", "222-22-222", 10000.00M, 0.6M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-333", 10000.00M, .04M, 300.00M);

            Console.WriteLine("Commission Employee:");
            Console.WriteLine(commissionEmployee);
            Console.WriteLine($"earnings:  {commissionEmployee.Earnings():C}\n");


            Console.WriteLine("Base Plus Commission Employee:");
            Console.WriteLine(basePlusCommissionEmployee);
            Console.WriteLine($"earnings:  {basePlusCommissionEmployee.Earnings():C}");

            Console.ReadKey();
        }
    }
}
