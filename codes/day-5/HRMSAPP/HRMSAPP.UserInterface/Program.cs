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
        static Employee Create(int empChoice)
        {
            Employee employee = new Employee();

            Console.Write("\nName: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Locaton: ");
            employee.EmployeeLocation = Console.ReadLine();

            Console.Write("Project Name: ");
            employee.ProjectName = Console.ReadLine();

            Console.Write("Basic Pay: ");
            employee.EmployeeBasicPayemnt = decimal.Parse(Console.ReadLine());

            Console.Write("Da Pay: ");
            employee.EmployeeDaPayemnt = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Pay: ");
            employee.EmployeeHraPayemnt = decimal.Parse(Console.ReadLine());

            return employee;
        }
        static void Main()
        {
            EmployeeBo employeeBo = new EmployeeBo();
            ShowMenu();
            int choice = GetManinMenuChoice();

            Employee[] employees = new Employee[4];

            switch (choice)
            {
                case 1:
                    ShowEmployeeSubMenu();
                    int empChoice = GetEmployeeChoice();
                    Employee employee = Create(empChoice);
                    //bool addStatus = employeeBo.AddRecord(employee);
                    //Console.WriteLine($"{(addStatus ? "Added Successfully" : "Failed")}");
                    break;

                default:
                    break;
            }
        }

        private static void ShowEmployeeSubMenu()
        {
            Console.WriteLine("\n1. Developer");
            Console.WriteLine("2. Hr");
        }
        private static int GetEmployeeChoice()
        {
            Console.Write("\nEnter Choice[D/H/d/h]: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
