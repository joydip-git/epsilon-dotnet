using System.Linq.Expressions;
using System;
using HRMSAPP.Entities;
using HRMSAPP.BusinessLayer;
using System.Collections.Generic;

namespace HRMSAPP.UserInterface
{
    class Program
    {
        //EmployeeBo employeeBo;

        static void ShowMenu()
        {
            Console.WriteLine("\n1. Add an Employee Record");
            Console.WriteLine("2. Fetch an employee record");
            Console.WriteLine("3. Fetch all records");
        }

        static int GetManinMenuChoice()
        {
            Console.Write("\nEnter Choice[1/2/3]: ");
            return int.Parse(Console.ReadLine());
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

        //Employee is a concrete class
        static Employee Create(int empChoice)
        {
            Employee employee = null;

            Console.Write("\nName: ");
            string employeeName = Console.ReadLine();

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
                    employee = new Developer(0, employeeName, employeeLocation, projectName, employeeBasicPayemnt, employeeDaPayemnt, employeeHraPayemnt, incentivePayemnt);
                    break;

                case 2:
                    Console.Write("Gratuity Pay: ");
                    decimal gratuityPayemnt = decimal.Parse(Console.ReadLine());
                    employee = new Hr(0, employeeName, employeeLocation, projectName, employeeBasicPayemnt, employeeDaPayemnt, employeeHraPayemnt, gratuityPayemnt);
                    break;

                default:
                    break;
            }

            return employee;
        }

        static int GetEmployeeIdFromUser()
        {
            Console.WriteLine("\nEnter Employee Id to Search: ");
            return int.Parse(Console.ReadLine());
        }

        static void Main()
        {
            EmployeeBo employeeBo = null;

            try
            {
                char toContinue = 'n';
                do
                {
                    ShowMenu();
                    int choice = GetManinMenuChoice();
                    employeeBo = new EmployeeBo();

                    switch (choice)
                    {
                        case 1:
                            ShowEmployeeSubMenu();
                            int empChoice = GetEmployeeChoice();
                            Employee newEmployee = Create(empChoice);
                            bool status = employeeBo.AddRecord(newEmployee);
                            Console.WriteLine($"{(status ? "Record added successfully" : "Either record exists or some other error. could not add record")}");
                            break;

                        case 2:
                            int empId = GetEmployeeIdFromUser();
                            Employee employee = employeeBo.FetchARecord(empId);
                            Console.WriteLine($"{(employee != null ? $"found record of {employee.EmployeeName}" : $"No record found with id: {empId}")}");
                            break;

                        case 3:
                            ShowSortMenu();
                            int sortChoice = GetSortChoice();
                            List<Employee> records = employeeBo.FetchAllRecords(sortChoice);
                            if (records.Count > 0)
                            {
                                foreach (Employee e in records)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            else
                                Console.WriteLine("No records found...");
                            break;

                        default:
                            break;
                    }

                    Decide(ref toContinue);

                } while (toContinue != 'n' && toContinue == 'y');
            }
            catch (NullReferenceException ex)
            {
                System.Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }

        private static int GetSortChoice()
        {
            Console.Write("\nEnter Choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }

        private static void ShowSortMenu()
        {
            Console.WriteLine("\n1. Sort by Name");
            Console.WriteLine("\n2. Sort by Salary");
        }

        private static void Decide(ref char toContinue)
        {
            Console.WriteLine("\nContinue?[y/Y/n/N]: ");
            toContinue = char.Parse(Console.ReadLine());
            if (char.IsUpper(toContinue))
            {
                toContinue = char.ToLower(toContinue);
            }
        }
    }
}
