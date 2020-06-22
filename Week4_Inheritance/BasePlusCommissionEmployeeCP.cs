using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Inheritance
{
    // This code illustrates how to implement the BasePlusCommissionEmployee without inheritance.  
    // We cut and pasted the code and then made some alterations.   
    // Lots of code duplication - both classes differ on one instance variable and a property.
    // Can be a nightmare to extend or change.  Need to make changes in 2 places.  What if there 50 different employee
    // types.


    /// <summary>
    /// Represents an employee who is paid a percentage of their sales
    /// </summary>
    public class BasePlusCommissionEmployeeCP
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; set; }
        private decimal grossSales;
        private decimal commissionRate;
        private decimal baseSalary;

        public BasePlusCommissionEmployeeCP(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate, decimal baseSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
            BaseSalary = baseSalary;
        }

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
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(baseSalary)} must be >= 0");
                }

                baseSalary = value;
            }

        }

        public decimal Earnings() => baseSalary + (CommissionRate * GrossSales);

        public override string ToString() =>
            $"commission employee: {FirstName} {LastName}\n" +
            $"social security number: {SocialSecurityNumber}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"commission rate: {CommissionRate}\n" + 
            $"base salary:  {BaseSalary}";
    }
}

