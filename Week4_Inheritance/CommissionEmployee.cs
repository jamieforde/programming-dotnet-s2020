using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Inheritance
{

    /// <summary>
    /// Represents an employee who is paid a percentage of their sales
    /// </summary>
    public class CommissionEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public string Title { get; set; }
        private decimal grossSales;
        private decimal commissionRate;

        /// <summary>
        /// Represents an commission only employee
        /// </summary>
        /// <param name="firstName">Represent the employee's first name</param>
        /// <param name="lastName">Represent the employee's last name</param>
        /// <param name="socialSecurityNumber">Represent the employee's social security number</param>
        /// <param name="grossSales">Represents the employee's total sales in currency</param>
        /// <param name="commissionRate">Represents the percentage of grossSales</param>
        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        /// <summary>
        /// Represents the total sales of an employee without adjustment
        /// </summary>
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(grossSales)} must be >= 0");
                }

                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(grossSales)} must be > 0 and < 1");
                }

                commissionRate = value;
            }
        }

        /// <summary>
        /// Calculates the total earnings of the employee 
        /// </summary>
        /// <returns>Decimal representing the commissionRate * GrossSales</returns>
        // Note that the method needs to be labelled as virtual for it to be redefined (overriden) by the derived class
        public virtual decimal Earnings() => CommissionRate * GrossSales;

        /// <summary>
        /// String representation of a Commission employee
        /// </summary>
        /// <returns>String</returns>
        // Note that we do not specifiy that this method is virtual
        // This is because this method is inherited from the object class.  Where it is labelled as virtual.  
        public override string ToString() =>
            $"commission employee: {FirstName} {LastName}\n" +
            $"social security number: {SocialSecurityNumber}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"commission rate: {CommissionRate}";
    }
}

