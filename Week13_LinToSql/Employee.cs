using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Note the use of attributes
 * Provide extra modifiers to classes
 * The table attribute indicates that the class is drawn from a table
 * Each of the properties in the class has a column attribute
* Associates the property is associated with a column in a table
*/


namespace Week13_LinqToSql
{
    [Table(Name = "Employees")]
    public class Employee
    {
        [Column]
        public int EmployeeId { get; set; }
        [Column]
        public string FirstName { get; set; }
        [Column]
        public string LastName { get; set; }
    }
}

