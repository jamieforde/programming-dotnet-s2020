using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* LINQ To SQL
 * Funcitonality in .NET framwork that allows
 * us to use relational data (data in a database) 
 * as objects. 
 * 
 * Requires a data context object that acts as a bridge
 * between LINQ and the database
 * 
 * LINQ calls are translated to SQL queries and executed on a specific database
*/

namespace Week12_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection string
            var connectionString = @"server=.\sqlexpress;database=Northwind;Integrated Security=True";

            SqlCommand sqlCommand = new SqlCommand();


            sqlCommand.CommandText = "Select top 10 * from Customers";
            sqlCommand.Connection = new SqlConnection(connectionString);

            //Bridge between our app and our data source
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            foreach(DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine($"Company Name: {dataRow["CompanyName"]}" +
                    $" Contact: {dataRow["ContactName"]}");
            }

            Console.ReadKey();
        }
    }
}
