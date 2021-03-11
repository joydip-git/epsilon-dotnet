using System;
using HRMSAPP.Entities;
using HRMSAPP.DataAccessLayer;
using System.Collections.Generic;

namespace HRMSAPP.BusinessLayer
{
    public class EmployeeBo
    {
        EmployeeDao employeeDao;

        public bool AddRecord(Employee employee)
        {
            if (employee != null)
            {
                //get the last employee's id and increase by 1 and assign it to the employee id
                //if no employee exists, then start assign from 100
                try
                {
                    employeeDao = new EmployeeDao();
                    int id = employeeDao.GetLastEmployeeId();
                    if (id == 0)
                    {
                        employee.EmployeeId = 100;
                    }
                    else
                    {
                        employee.EmployeeId = id + 1;
                    }

                    //calculate salary
                    employee.CalculateSalary();

                    return employeeDao.Insert(employee);
                }
                catch (NullReferenceException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                return false;
        }

        public Employee FetchARecord(int employeeId)
        {
            if (employeeId > 0)
            {
                employeeDao = new EmployeeDao();
                return employeeDao.GetARecord(employeeId);
            }
            else
                return null;
        }

        public List<Employee> FetchAllRecords(int choice)
        {
            employeeDao = new EmployeeDao();
            List<Employee> employees = employeeDao.GetAllRecords();

            if (employees != null && employees.Count > 1)
            {
                EmployeeComparison employeeComparison = new EmployeeComparison(choice);
                employees.Sort(employeeComparison);                
            }
            return employees;
        }
    }
}
