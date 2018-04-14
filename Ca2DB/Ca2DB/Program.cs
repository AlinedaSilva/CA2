using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca2DB
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpDatabase();
            Console.WriteLine("Created");
            Console.ReadKey();               
        }

        private static void SetUpDatabase()
        {
            Customer c1 = new Customer { CustomerId = 1, CustomerName = "Aline", CustomerAddress = "Road 1, Dublin 7", CustomerEmail = "abc@gmail.com", ProductId = 1 };
            Customer c2 = new Customer { CustomerId = 2, CustomerName = "Rafal", CustomerAddress = "Road 2 Dublin 8", CustomerEmail = "dfg@gmail.com", ProductId = 2 };
            Customer c3 = new Customer { CustomerId = 3, CustomerName = "Niall", CustomerAddress = "Road 4, Dublin 10", CustomerEmail = "hjk@gmail.com", ProductId = 1 };

            StockContext db = new StockContext();
            db.Customers.Add(c1);
            db.Customers.Add(c2);
            db.Customers.Add(c3);
            db.SaveChanges();

            Product p1 = new Product { ProductId = 1, ProductName = "TV", ProductDescription = "40 inches TV" };
            Product p2 = new Product { ProductId = 2, ProductName = "Socks", ProductDescription = "Smelly" };

            StockContext db1 = new StockContext();
            db1.Products.Add(p1);
            db1.Products.Add(p2);
            db1.SaveChanges();
        }
    }
}
