using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpNewFeatures
{
    class Person
    {
        //private string name;
        //public string Name { get => name; set => name = value; }
        //public abstract string Name { set; get; }

        //automatic or auto-implemented property 
        //private readonly string _NameField;
        //public string Name { set=>_NameField = value; get=>_NameField; }
        public string Name { set; get; }
        public int Id { get; set; }

        public Person()
        {

        }
        public Person(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
    class Program
    {
        //var a;
        //static var Test(var x)
        //{

        //}
        static void Main()
        {
            var x = 10; //implcitly typed local variable (type inference)
            //x = false;
            Console.WriteLine(x.GetType().Name);
            //var a;
            var list = new List<int>();
            var arr = new[] { 1, 2, 3, 4 };//implcitly typed array local variable
            Console.WriteLine(arr.GetType().Name);

            var joydip = new Person("Joydip", 1);
            //joydip.Name = "joydip";

            //var dellXps = new Product();
            //dellXps.ProductName = "Dell XPS";
            //dellXps.ProductId = 1;
            //dellXps.Price=1000;
            //dellXps.Description="new laptop";
            //var dellXps = new Product(1, "del xps", 1000, "");

            //object initializer
            var dellXps = new Product { ProductId = 1, ProductName = "dell xps", Price = 1000, Description = "new laptop" };
            //collection-initializer
            var numberList = new List<int> { 1, 2, 3, 4 };

            /*
            Product laptop = new Product();
            laptop.Description = "";
            laptop.ProductName = "";
            laptop.Price = 0;
            laptop.ProductId = 1;

            Product mobile = new Product();
            mobile.Description = "";
            mobile.ProductName = "";
            mobile.Price = 0;
            mobile.ProductId = 2;

            List<Product> products = new List<Product>();
            products.Add(laptop);
            products.Add(mobile);
            */

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, Description="", Price=0, ProductName=""},
                new Product{ProductId=2, Description="", Price=0, ProductName=""},
                new Product{ProductId=3, Description="", Price=0, ProductName=""},
            };

            //foreach (var p in products)
            //{

            //}
            //p->range variable
            //products-->source of data
            //var query = from <range-variable> in <source-of-data>
            //delayed/deferred execution
            var query = from p in products
                        where p.Price > 1000
                        orderby p.ProductName ascending
                        select p.ProductName;
            foreach (var item in query)
            {

            }

            var query1 = products
                .Where(p => p.Price > 1000)
                .OrderBy(p => p.ProductName)
                .Select(p => new { p.ProductName, p.Price });
            //select new { ProductName = p.ProductName, Price = p.Price });

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //Collection<Group<char,Product>>
            //IEnumerable<IGrouping<char,Product>> groupQuery = from p in products
            //                 group p by p.ProductName[0];
            var groupQuery = from p in products
                             group p by p.ProductName[0];

            var q = from p in products
                    select new { Name = p.ProductName, Price = p.Price };

            foreach (var item in q)
            {
                Console.WriteLine($"{item.Name} and {item.Price}");
            }

            var statistics = new { Average = products.Average(p => p.Price), MaxPrice = products.Max(p => p.Price), MinPrice = products.Min(p => p.Price) };
            Console.WriteLine(statistics.MaxPrice);

            //select avg(price) as AvgPrice, min(price) as MinPrice, max(price) as MaxPrice from products

            //anonymous type
            // a class with two properties and backing fields will be created
            //but they are readonly backing field
            var doctor = new { Name = "anil", Profession = "Ortho" };
            //doctor.Name = "sunil";
            Console.WriteLine(doctor.GetType().Name);

            /*
             * class Unknown
             * {
             *   private readonly string NameBF;
             *   private readonly string ProfessionBF;
             *   public Unknown(){}
             *   public Unknown(string name, string prof)
             *   {
             *      NameBF = name;
             *      ProfessionBF = prof;
             *   }
             *   public string Name=>NameBF;
             *   public string Profession=>ProfessionBF
             * }
             */
        }
    }
}
