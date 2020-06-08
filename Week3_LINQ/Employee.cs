using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_LINQ
{
    /// <summary>
    /// 
    /// </summary>
    public class Employee
    {
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            this.monthlySalary = monthlySalary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal monthlySalary { get; set; }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0)
                {
                    monthlySalary = value;
                }
            }
        }

        public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }
}