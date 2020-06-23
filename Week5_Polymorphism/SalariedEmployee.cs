using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Polymorphism
{
    /// <summary>
    /// Represents a salaried employee
    /// </summary>
    public class SalariedEmployee : Employee, IPayable   //Note:  Class inherits from employee and implements the IPayable interface
    {
        private decimal weeklySalary;

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, decimal weeklySalary) 
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                weeklySalary = value;
            }
        }

        public override decimal Earnings() => WeeklySalary;

        public override string ToString() =>
            $"salaried employee: {base.ToString()}\n" +
            $"weekly salaried: {WeeklySalary:C}";

        public decimal GetPaymentAmount() => Earnings();
    }
}
