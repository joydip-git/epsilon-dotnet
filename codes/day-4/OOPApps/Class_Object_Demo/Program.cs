using System;

namespace Class_Object_Demo
{
    class Program
    {
        static Employee EnterEmployeeData()
        {
            Console.Write("name: ");
            string name = Console.ReadLine();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Location: ");
            string location = Console.ReadLine();
            Console.Write("Basic Salary: ");
            decimal basicSalary = decimal.Parse(Console.ReadLine());
            Console.Write("DA Salary: ");
            decimal daSalary = decimal.Parse(Console.ReadLine());
            Console.Write("HRA Salary: ");
            decimal hraSalary = decimal.Parse(Console.ReadLine());
            Console.Write("Project: ");
            string project = Console.ReadLine();

            Employee employeeRef = new Employee(id, name, location, basicSalary, daSalary, hraSalary, project);
            //Console.WriteLine(employeeRef.GetEmployeeName());
            //employeeRef.SetProjectName("CITA");
            //employeeRef.EmployeeName = "anil";
            //Console.WriteLine(employeeRef.EmployeeName);
            return employeeRef;
        }
        static void Main(string[] args)
        {
            //A. INSERTION OPERATION
            //1. create an array of certian size
            //2. create an instance of an employee class
            //3. store every instance of employee in that array
            for (int i = 0; i < 10; i++)
            {
               Employee employee = EnterEmployeeData();
               //static members are accessed with the class name, since they are not part of any instance of that class
               System.Console.WriteLine(Employee.JoiningBonus);
            }

            //B. 
            //iterate through the array of employees
            //calculate salary of an individual employee
            //display the same

            //foreach (var item in collection)
            //{
            //    //decimal sal =item.CS()
            //}
            /**
             * Anil gets 1000 as salary
             */

            //C. MODIFICATION
            //1. ask user to enter an id of an employee to modify
            //2. check that employee exits in that array or not
            //3. if exists display the info about the employee
            //4. write code to accept new values for the employee (Except ID, TOTAL SALRY)
            //5. in that array update that employee

            //d. DELETION
            //ask user to enter an id of an employee to delete
            //simply delete that employee record from the array and don't leave any NULL reference in that array space
        }
    }
}
