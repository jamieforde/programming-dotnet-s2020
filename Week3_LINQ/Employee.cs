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
            lastNameField = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal monthlySalary { get; set; }

        private string lastNameField;

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

        public void SetLastNameField(string name)
        {
            lastNameField = name;
        }

        public string GetLastNameField()
        {
            return lastNameField;
        }


        public override string ToString() =>
            $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }
}