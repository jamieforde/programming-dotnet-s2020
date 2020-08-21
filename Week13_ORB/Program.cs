using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13_ORB
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Product foundProduct = db.Products.Single(p => p.ProductID == 1);

            Console.WriteLine($"Found product {foundProduct.ProductID}, {foundProduct.ProductName}");

            var orderList =
                from order in db.Order_Details
                where order.OrderID >= 10250 && order.OrderID <= 10255
                select order;

            Console.WriteLine("\nProduct Orders between 10250 and 10255");

            foreach (var order in orderList)
            {
                Console.WriteLine($"ID: {order.OrderID}\tQty: {order.Quantity}\tProduct: {order.Product.ProductName}");
            }

            



            Console.ReadKey();
        }
    }
}
