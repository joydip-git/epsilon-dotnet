using System;
using HRMSAPP.Entities;
using HRMSAPP.BusinessLayer;

namespace HRMSAPP.UserInterface
{
    class Program
    {
        //EmployeeBo employeeBo;

        static void ShowMenu()
        {
            Console.WriteLine("1. Add an Employee Record");
            Console.WriteLine("2. Fetch an employee record");
            Console.WriteLine("3. Fetch all records");
        }
        static int GetManinMenuChoice()
        {
            Console.Write("\nEnter Choice[1/2/3]: ");
            return int.Parse(Console.ReadLine());
        }
        //Employee is a concrete class
        static Employee Create(int empChoice)
        {
            Employee employee = null;

            Console.Write("\nName: ");
            string employeeName = Console.ReadLine();

            Console.Write("\nId: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Locaton: ");
            string employeeLocation = Console.ReadLine();

            Console.Write("Project Name: ");
            string projectName = Console.ReadLine();

            Console.Write("Basic Pay: ");
            decimal employeeBasicPayemnt = decimal.Parse(Console.ReadLine());

            Console.Write("Da Pay: ");
            decimal employeeDaPayemnt = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Pay: ");
            decimal employeeHraPayemnt = decimal.Parse(Console.ReadLine());

            switch (empChoice)
            {
                case 1:
                    Console.Write("Incentive Pay: ");
                    decimal incentivePayemnt = decimal.Parse(Console.ReadLine());
                    employee = new Developer(id, employeeName, employeeLocation, projectName, employeeBasicPayemnt, employeeDaPayemnt, employeeHraPayemnt, incentivePayemnt);
                    break;

                case 2:
                    Console.Write("Gratuity Pay: ");
                    decimal gratuityPayemnt = decimal.Parse(Console.ReadLine());
                    employee = new Hr(id, employeeName, employeeLocation, projectName, employeeBasicPayemnt, employeeDaPayemnt, employeeHraPayemnt, gratuityPayemnt);
                    break;

                default:
                    break;
            }

            return employee;
        }
        static void Main()
        {
            //EmployeeBo employeeBo = new EmployeeBo();
            ShowMenu();
            int choice = GetManinMenuChoice();

            Employee[] employees = new Employee[4];

            for (int i = 0; i < employees.Length; i++)
            {
                ShowEmployeeSubMenu();
                int empChoice = GetEmployeeChoice();
                Employee employee = Create(empChoice);
                employees[i] = employee;
            }
            foreach (Employee e in employees)
            {
                e.CalculateSalary();
                Console.WriteLine($"Salary of {e.EmployeeName} is {e.EmployeeSalary}");
                //is operator checks the actual type of reference stored in a variable                
                //if (e is Developer)
                //{
                //    //Developer d = (Developer)e;
                //    //as operator is used to do downcsting in case of reference variable
                //    Developer d = e as Developer;
                //    d.CalculateSalary();
                //    Console.WriteLine($"Salary of {d.EmployeeName} is {d.EmployeeSalary}");
                //}
                //if (e is Hr)
                //{
                //    //Developer d = (Developer)e;
                //    //as operator is used to do downcsting in case of reference variable
                //    Hr hr = e as Hr;
                //    hr.CalculateSalary();
                //    Console.WriteLine($"Salary of {hr.EmployeeName} is {hr.EmployeeSalary}");
                //}
            }

            //switch (choice)
            //{
            //    case 1:
            //        ShowEmployeeSubMenu();
            //        int empChoice = GetEmployeeChoice();
            //        Employee employee = Create(empChoice);
            //        //bool addStatus = employeeBo.AddRecord(employee);
            //        //Console.WriteLine($"{(addStatus ? "Added Successfully" : "Failed")}");
            //        break;

            //    default:
            //        break;
            //}
        }

        private static void ShowEmployeeSubMenu()
        {
            Console.WriteLine("\n1. Developer");
            Console.WriteLine("2. Hr");
        }
        private static int GetEmployeeChoice()
        {
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
