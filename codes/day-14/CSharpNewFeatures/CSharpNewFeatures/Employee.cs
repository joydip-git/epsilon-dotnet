using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNewFeatures
{
    class Employee
    {
        private readonly int id;
        private string name;

        //public int Id { set => id = value; get => id; }
        public int Id => id;

        public string Name { get => name; set => name = value; }

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            //this.id = id;
            this.id = id;
            this.name = name;
        }
        
    }
    class Test
    {
        public void Create()
        {
            Employee emp1 = new Employee(1, "anil");
            Employee emp2 = new Employee(2, "sunil");
            //emp.Id = 2;
        }
    }
}
