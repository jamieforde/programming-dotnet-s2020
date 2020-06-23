using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Polymorphism
{
    /*
     * Useful to declare classes which are not going to instantitate objects.
     * Primarily to provide an appropriate base class for from which
     * other classes can inherit and share a common design.
     * Note: An Employee cannot be instantiated as the definition is incomplete.
     * Classes that inherit from this abstract class must define the missing pieces.
     */

    /// <summary>
    /// Represents an employee.
    /// </summary>
    public abstract class Employee
    {
        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        /// <summary>
        /// String representation of an Employee
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"{LastName} {FirstName}\n" +
            $"social security number: {SocialSecurityNumber}";

        /// <summary>
        /// Abstract method 
        /// </summary>
        /// <returns></returns>
        public abstract decimal Earnings();  //Note: No implementation
    }
}
