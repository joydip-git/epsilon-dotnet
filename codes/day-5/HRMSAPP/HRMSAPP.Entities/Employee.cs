using System;

namespace HRMSAPP.Entities
{
    /// <summary>
    /// Employee Business Entity
    /// </summary>
    public class Employee
    {
        #region Data Members
        int employeeId;
        string employeeName;
        string employeeLocation;
        string projectName;
        decimal employeeBasicPayemnt;
        decimal employeeDaPayemnt;
        decimal employeeHraPayemnt;
        decimal employeeSalary;
        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="employeeId">id of an employee</param>
        /// <param name="employeeName">name of an employee</param>
        /// <param name="employeeLocation">location of an employee</param>
        /// <param name="projectName">name of project of an employee</param>
        /// <param name="employeeBasicPayemnt">basic payment of an employee</param>
        /// <param name="employeeDaPayemnt">da payment of an employee</param>
        /// <param name="employeeHraPayemnt">hra payment of an employee</param>
        /// <param name="employeeSalary"></param>
        public Employee(int employeeId, string employeeName, string employeeLocation, string projectName, decimal employeeBasicPayemnt, decimal employeeDaPayemnt, decimal employeeHraPayemnt, decimal employeeSalary)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeLocation = employeeLocation;
            this.projectName = projectName;
            this.employeeBasicPayemnt = employeeBasicPayemnt;
            this.employeeDaPayemnt = employeeDaPayemnt;
            this.employeeHraPayemnt = employeeHraPayemnt;
            this.employeeSalary = employeeSalary;
        }
        #endregion

        #region Properties
        /// <summary>
        /// gets or sets the id of an employee
        /// </summary>
        public int EmployeeId
        {
            set => employeeId = value; 
            get => employeeId; 
        }
        /// <summary>
        /// gets or sets name of an employee
        /// </summary>
        public string EmployeeName
        { 
            get => employeeName; 
            set => employeeName = value; 
        }
        /// <summary>
        /// gets or sets location of an employee
        /// </summary>
        public string EmployeeLocation 
        { 
            get => employeeLocation; 
            set => employeeLocation = value; 
        }
        /// <summary>
        /// gets or sets project name of an employee
        /// </summary>
        public string ProjectName 
        { 
            get => projectName; 
            set => projectName = value; 
        }
        /// <summary>
        /// gets or sets basic payment of an employee
        /// </summary>
        public decimal EmployeeBasicPayemnt 
        { 
            get => employeeBasicPayemnt; 
            set => employeeBasicPayemnt = value; 
        }
        /// <summary>
        /// gets or sets da payment of an employee
        /// </summary>
        public decimal EmployeeDaPayemnt 
        { 
            get => employeeDaPayemnt; 
            set => employeeDaPayemnt = value; 
        }
        /// <summary>
        /// gets or sets hra payment of an employee
        /// </summary>
        public decimal EmployeeHraPayemnt 
        { 
            get => employeeHraPayemnt; 
            set => employeeHraPayemnt = value; 
        }
        /// <summary>
        /// gets or privately sets totala salary of an employee
        /// </summary>
        public decimal EmployeeSalary 
        { 
            get => employeeSalary; 
            private set => employeeSalary = value; 
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to calculate total salary of an employee
        /// </summary>
        public void CalculateSalary()
        {
            //employeeSalary
            EmployeeSalary = employeeBasicPayemnt + employeeDaPayemnt + employeeHraPayemnt;
        }
        #endregion
    }
}
