using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Object_Demo
{
    /// <summary>
    /// employee class
    /// </summary>
    class Employee
    {
        int employeeId;
        string employeeName;
        string employeeLocation;
        decimal employeeBasicPayment;
        decimal employeeDaPayment;
        decimal employeeHraPayment;
        string projectName;
        decimal totalSalary;

        /// <summary>
        /// default ctor
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// parameterized ctor
        /// </summary>
        /// <param name="id">id of an employee</param>
        /// <param name="name">name of an employee</param>
        /// <param name="location">location of an employee</param>
        /// <param name="basicPay">basicPay of an employee</param>
        /// <param name="daPay">daPay of an employee</param>
        /// <param name="hraPay">hrapay of an employee</param>
        /// <param name="projectName">project name of an employee</param>
        public Employee(int id, string name, string location, decimal basicPay, decimal daPay, decimal hraPay, string projectName)
        {
            employeeId = id;
            employeeLocation = location;
            employeeName = name;
            employeeBasicPayment = basicPay;
            employeeDaPayment = daPay;
            employeeHraPayment = hraPay;
            this.projectName = projectName;
        }

        /// <summary>
        /// gets or sets the name of an employee
        /// </summary>
        public string EmployeeName
        {
            //public string GetEmployeeName()
            get
            {
                return employeeName;
            }
            //public void SetEmployeeName(string value)
            set
            {
                employeeName = value;
            }
        }

        public void CalculateSalary()
        {
            totalSalary = employeeBasicPayment + employeeDaPayment + employeeHraPayment;
        }


        //public void SetProjectName(string project)
        //{
        //    projectName = project;
        //}
    }
}
