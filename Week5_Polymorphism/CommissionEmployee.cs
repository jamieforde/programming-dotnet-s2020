using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Polymorphism
{
    /// <summary>
    /// Represent a Commission Employee.  
    /// </summary>
    public class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private decimal commissionRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public decimal GrossSales
        {
            get => grossSales;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                grossSales = value;
            }
        }

        public decimal CommissionRate
        {
            get => commissionRate;
            set
            {
                if (value < 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                commissionRate = value;
            }
        }

        public override decimal Earnings() => CommissionRate * GrossSales;

        public override string ToString() =>
            $"commission employee: {base.ToString()}\n" +
            $"gross sales: {GrossSales:C}\n" +
            $"commission rate: {CommissionRate:F2}";
    }
}

