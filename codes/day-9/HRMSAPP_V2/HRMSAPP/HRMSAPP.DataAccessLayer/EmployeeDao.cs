using System;
using System.Collections.Generic;
using HRMSAPP.Entities;
using HRMSAPP.Repository;

namespace HRMSAPP.DataAccessLayer
{
    /// <summary>
    /// Data Access Object containing methods to add, update, delete or return all the records
    /// </summary>
    public class EmployeeDao
    {
        #region Public Methods
        /// <summary>
        /// Method to insert an employee record
        /// </summary>
        /// <param name="employee">employee data</param>
        /// <returns>
        /// boolean, returns true if operation is successful and fale if operation is unsucessful 
        /// </returns>
        public bool Insert(Employee employee)
        {
            HashSet<Employee> records = null;
            try
            {
                //get the repository
                records = EmployeeRepository.Employees;
                bool status = records.Add(employee);
                return status;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to fetch all employees
        /// </summary>
        /// <returns>
        /// returns array of employee records if not empty else a blank array if empty
        /// </returns>
        public List<Employee> GetAllRecords()
        {
            HashSet<Employee> records = null;
            List<Employee> employees = null;

            try
            {
                //get the repository
                records = EmployeeRepository.Employees;
                ConvertSetToList(records, ref employees);
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to return record of an employee given the employee id
        /// </summary>
        /// <param name="employeeId">id of an employee to fetch</param>
        /// <returns>
        /// returns employee instance if the record is found else null if not
        /// </returns>
        public Employee GetARecord(int employeeId)
        {
            HashSet<Employee> records = null;
            Employee found = null;
            try
            {
                //get the repository
                records = EmployeeRepository.Employees;
                if (records.Count > 0)
                {
                    foreach (Employee employee in records)
                    {
                        if (employee.EmployeeId == employeeId)
                        {
                            found = employee;
                            break;
                        }
                    }
                }
                return found;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to get the id of the last employee
        /// </summary>
        /// <returns>
        /// returns id of the last employee
        /// </returns>
        public int GetLastEmployeeId()
        {
            HashSet<Employee> records = null;
            int lastEmployeeId = 0;
            try
            {
                records = EmployeeRepository.Employees;
                if (records.Count > 0)
                {
                    List<Employee> tempList = null;
                    ConvertSetToList(records, ref tempList);

                    Employee lastEmployee = tempList[tempList.Count - 1];
                    lastEmployeeId = lastEmployee.EmployeeId;
                }
                return lastEmployeeId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Helper Methods
        private void ConvertSetToList(HashSet<Employee> records, ref List<Employee> employees)
        {
            if (records.Count > 0)
            {
                employees = new List<Employee>();
                foreach (Employee employee in records)
                {
                    employees.Add(employee);
                }
            }
        }
        #endregion
    }
}
