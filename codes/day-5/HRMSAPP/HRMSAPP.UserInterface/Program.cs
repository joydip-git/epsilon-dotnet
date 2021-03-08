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
            //Employee employee = new Employee();

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
                    new Developer(id, employeeName, employeeLocation, projectName, employeeBasicPayemnt, employeeDaPayemnt, employeeHraPayemnt, incentivePayemnt);
                    break;

                case 2:
                    Console.Write("Gratuity Pay: ");
                    decimal gratuityPayemnt = decimal.Parse(Console.ReadLine());
                    new Hr(id, employeeName, employeeLocation, projectName, employeeBasicPayemnt, employeeDaPayemnt, employeeHraPayemnt, gratuityPayemnt);
                    break;

                default:
                    break;
            }

            return employee;
        }
        static void Main()
        {
            EmployeeBo employeeBo = new EmployeeBo();
            ShowMenu();
            int choice = GetManinMenuChoice();

            

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
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
