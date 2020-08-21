using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* SQL is a powerful tool for working with data
 * However SQL commands do not integrate with C# 
 * They are after all two different languages
 * Last week we saw the use of ADO.NET 
 * Needed DataAdapter and DataSet objects
 *  
 * LINQ To SQL
 * Functionality in .NET framework that allows
 * us to use relational data (data in a database) 
 * as objects. 
 * 
 * Requires a data context object that 
 * 
 * 
*/



namespace Week13_LinqToSql
{
    class Program
    {
        // Always need to a data context
        // Easier to do with LINQ to SQL 

        static void Main(string[] args)
        {
            // DataContext 
            // Takes a connection string used to connect to a database
            DataContext db = new DataContext(@"server=.\sqlexpress;database=Northwind;Integrated Security=True");

            // GetTable method how we retreive data from the database and 
            // assign to a generic Table collection
            Table<Employee> employees = db.GetTable<Employee>();

            //var employeeQuery =
            //    from emp in employees
            //    select emp;

            var employeeQuery = employees.Select(emp => emp);


            /* Do lots of work here
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
            */

            foreach (var employee in employeeQuery)
            {
                Console.WriteLine($"{employee.EmployeeId}, {employee.FirstName}, {employee.LastName}");
            }

            Console.ReadKey();
        }
    }
}
