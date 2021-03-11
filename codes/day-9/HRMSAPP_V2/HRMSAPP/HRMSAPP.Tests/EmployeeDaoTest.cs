using System;
using Xunit;
using HRMSAPP.Entities;
using HRMSAPP.DataAccessLayer;
using System.Collections.Generic;

namespace HRMSAPP.Tests
{
    public class EmployeeDaoTest
    {
        [Fact]
        public void InsertEmployeePositiveTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = new Employee(1, "joy", "Bng", "CITA", 1000, 2000, 3000);
            bool status = employeeDao.Insert(employee);
            Assert.True(status);
            employeeDao = null;
        }

        [Fact]
        public void GetARecordPositiveTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(1);
            Assert.Equal<Employee>(new Employee(), employee);
            employeeDao = null;
        }

        [Fact]
        public void GetAllRecordsPositiveTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            List<Employee> employee = employeeDao.GetAllRecords();
            Assert.Null(employee);
            employeeDao = null;
        }
    }
}
