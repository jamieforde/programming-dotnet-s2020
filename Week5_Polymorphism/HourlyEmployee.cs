using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Polymorphism
{
    public class HourlyEmployee : Employee
    {
        private decimal wage;
        private decimal hours;

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, decimal wage, decimal hours)
            : base(firstName, lastName, socialSecurityNumber)
        {
            Wage = wage;
            Hours = hours;
        }

        public decimal Wage
        {
            get => wage;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                wage = value;
            }
        }
        public decimal Hours
        {
            get => hours;
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                hours = value;
            }
        }

        public override decimal Earnings()
        {
            if (Hours <= 40)
            {
                return Wage * Hours;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * Wage * 1.5M);
            }
        }

        public override string ToString() =>
            $"hourly employee: {base.ToString()}\n" +
            $"hourly wage: {Wage:C}\nhours worked: {Hours:F2}";
    }
}