using System;
using HRMSAPP.Entities;
using HRMSAPP.DataAccessLayer;

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

        public Employee[] FetchAllRecords()
        {
            employeeDao = new EmployeeDao();
            return employeeDao.GetAllRecords();
        }
    }
}
