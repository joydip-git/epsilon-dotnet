using System;
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
            bool operationStatus = false;
            //get the repository
            Employee[] records = EmployeeRepository.Employees;

            //check whether array is empty or not
            bool empty = IsEmpty(records);
            if (!empty)
            {
                //check the employee already exists or not
                bool exists = Exists(employee.EmployeeId, records);
                if (!exists)
                {
                    for (int i = 0; i < records.Length; i++)
                    {
                        if (records[i] == null)
                        {
                            records[i] = employee;
                            operationStatus = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                records[0] = employee;
                operationStatus = true;
            }

            return operationStatus;
        }

        /// <summary>
        /// Method to fetch all employees
        /// </summary>
        /// <returns>
        /// returns array of employee records if not empty else a blank array if empty
        /// </returns>
        public Employee[] GetAllRecords()
        {
            //get the repository
            Employee[] records = EmployeeRepository.Employees;

            //check whether array is empty or not
            bool empty = IsEmpty(records);
            if (empty)
            {
                return new Employee[0];
            }
            else
            {
                return records;
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
            //get the repository
            Employee[] records = EmployeeRepository.Employees;

            //check whether array is empty or not
            bool empty = IsEmpty(records);

            if (empty)
            {
                return null;
            }
            else
            {
                //check the employee already exists or not and also get the employee reference if exists
                Employee found = null;
                FetchEmployee(employeeId, records, ref found);
                return found;
                //bool exists = Exists(employeeId, records, ref found);
                //if (exists)
                //{
                //return FetchEmployee(employeeId, records);
                //return found;
                //}
                //else
                //{
                //    return null;
                //}
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
            Employee[] records = EmployeeRepository.Employees;
            int id = 0;
            if (IsEmpty(records))
            {
                return 0;
            }

            for (int i = 0; i < records.Length; i++)
            {
                if (records[i] == null)
                {
                    id = records[i - 1].EmployeeId;
                }
                else
                {
                    id = records[records.Length - 1].EmployeeId;
                }
            }
            return id;
        }
        #endregion

        #region Helper Methods
        private bool Exists(int employeeId, Employee[] employees)
        {
            bool exists = false;

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    if (employee.EmployeeId == employeeId)
                    {
                        exists = true;
                        break;
                    }
                }
            }

            return exists;
        }

        private bool IsEmpty(Employee[] employees)
        {
            bool isEmpty = true;
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    isEmpty = false;
                    break;
                }
            }
            return isEmpty;
        }

        private void FetchEmployee(int employeeId, Employee[] employees, ref Employee found)
        {
            //Employee found = null;
            foreach (Employee e in employees)
            {
                if (e != null)
                {
                    if (e.EmployeeId == employeeId)
                    {
                        found = e;
                        break;
                    }
                }
            }
        }
    }
    #endregion
}
