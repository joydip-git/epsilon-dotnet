using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicDemo
{
    class Person
    {
        private dynamic _address;
        public Person()
        {
            _address = new System.Dynamic.ExpandoObject();
        }
        public string Name { get; set; }
        public dynamic Address { get => _address; }
    }
    
    class Program
    {
        static void Main()
        {
            dynamic d = new Person();
            d.Name = "Joy";
            //d.Address = new { };
            d.Address.City = "Bangalore";
            d.Address.Street = "80 feet road";
            d.Address.Pin = 560001;
            
            Console.WriteLine(d.Address.City);
            Console.WriteLine(d.Address.State);
        }
        static dynamic Get<T>(Func<T,bool> logic)
        {
            List<T> list = new List<T>();
            return list.Where(logic);
        }
    }
}
