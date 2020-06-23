using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Polymorphism
{
    /// <summary>
    /// Represents an employee who recieves a base pay and commission.
    /// </summary>
    public class BasePlusCommissionEmployee : CommissionEmployee // Note: This class is level below in the inheritance heirarchy
    {
        private decimal baseSalary;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName">Represents an employee's first name</param>
        /// <param name="lastName">Represents an employee's last name</param>
        /// <param name="socialSecurityNumber">Represents an employee's social security number</param>
        /// <param name="grossSales">Represents an employee's gross sales as currency</param>
        /// <param name="CommissionRate">Represents the percentage of gross sales the employee is paid</param>
        /// <param name="baseSalary">Represents an employee's base salary</param>
        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal CommissionRate, decimal baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, CommissionRate)
        {
            BaseSalary = baseSalary;
        }

        public decimal BaseSalary
        {
            get => baseSalary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                baseSalary = value;
            }
        }

        /// <summary>
        /// Represents the employee's earnings.  
        /// </summary>
        /// <returns></returns>
        public override decimal Earnings() => baseSalary + base.Earnings();

        /// <summary>
        /// The string representation of the class.
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"base plus commission employee: {base.ToString()}\nbase salary: {BaseSalary:C2}";
    }
}