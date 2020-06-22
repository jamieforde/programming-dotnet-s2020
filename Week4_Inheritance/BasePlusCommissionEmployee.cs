using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Inheritance
{
    // This is implmentation of a new employee who receives a base salary and a commission.
    // This illustrates inheritance with proper software engineering process 
    // Contrast this with the copy and paste class.  

    /// <summary>
    /// Represents an employee who receives a base salaray plus commission
    /// </summary>
    
    // We use ':' to indicate that this class inherits from CommissionEmployee
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        // Only need to declare the instance variables that specific to the derived class
        private decimal baseSalary;

        // Class constructor
        // Note the explict call to CommissionEmployee Constructor
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary) :
            base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        // Property for the the baseSalary instance variable
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(BaseSalary)} must be greater than 0");
                }
                baseSalary = value;
            }
        }
        /// <summary>
        /// Calculates the total earnings.
        /// </summary>
        /// <returns>Total earnings as a decimal</returns>
        // Note that we get the commission component from the base class method that is using
        // code that we have tested and know to be correct.
        // Keyword override - we are redefining the Earnings method.  Note that the method needs to be labelled
        // as virtual in the base class.  
        public override decimal Earnings() => BaseSalary + base.Earnings();

        /// <summary>
        /// Method to generate a string representation of class
        /// </summary>
        /// <returns></returns>
        // Note that we are also calling the base ToString method.
        public override string ToString() =>
            $"base-salaried  {base.ToString()}\nbase salary: {baseSalary:C}";
    }
}
