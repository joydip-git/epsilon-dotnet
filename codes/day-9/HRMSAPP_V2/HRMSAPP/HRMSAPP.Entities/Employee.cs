using System;
using System.Diagnostics.CodeAnalysis;

namespace HRMSAPP.Entities
{
    /// <summary>
    /// Employee Business Entity
    /// </summary>
    public class Employee : IComparable<Employee>
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
        public Employee(int employeeId, string employeeName, string employeeLocation, string projectName, decimal employeeBasicPayemnt, decimal employeeDaPayemnt, decimal employeeHraPayemnt)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeLocation = employeeLocation;
            this.projectName = projectName;
            this.employeeBasicPayemnt = employeeBasicPayemnt;
            this.employeeDaPayemnt = employeeDaPayemnt;
            this.employeeHraPayemnt = employeeHraPayemnt;
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
            protected set => employeeSalary = value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to calculate total salary of an employee
        /// </summary>
        public virtual void CalculateSalary()
        {
            //employeeSalary
            EmployeeSalary = employeeBasicPayemnt + employeeDaPayemnt + employeeHraPayemnt;
        }

        /// <summary>
        /// Checks whether one employee is greater than another or not
        /// </summary>
        /// <param name="other">the other employee to check equality with the current employee</param>
        /// <returns>
        /// true, if current employee preceds the other, false value if other employee preceds the current
        /// </returns>
        public bool Equals(Employee other)
        {
            if (other != null)
            {
                if (this == other)
                    return true;

                if (this.employeeId == other.employeeId)
                    return true;
                else
                    return false;
            }
            else
                throw new NullReferenceException($"you have passed null reference");
        }
        #endregion

        #region Object Class Methods
        public override int GetHashCode()
        {
            return this.employeeId.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Employee)
                {
                    Employee other = obj as Employee;

                    if (this == other)
                        return true;

                    if (this.employeeId == other.employeeId)
                        return true;
                    else
                        return false;
                }
                else
                    throw new ArgumentException($"you have passed argument of type {obj.GetType().Name}, expected {nameof(Employee)}");
            }
            else
                throw new NullReferenceException($"you have passed null reference");
        }
        public override string ToString()
        {
            return $"Name:{employeeName} and Id: {employeeId}";
        }
        #endregion

        #region Comparable Interface Implementation
        public int CompareTo([AllowNull] Employee other)
        {
            return this.employeeId.CompareTo(other.employeeId);
        }
        #endregion
    }
}
