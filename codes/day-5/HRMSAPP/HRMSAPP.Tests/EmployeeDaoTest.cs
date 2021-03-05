using System;
using Xunit;
using HRMSAPP.Entities;
using HRMSAPP.DataAccessLayer;

namespace HRMSAPP.Tests
{
    public class EmployeeDaoTest
    {
        //EmployeeDao employeeDao;      
       
        //public void Initialize()
        //{
        //    employeeDao = new EmployeeDao();
        //}

        //public void Clear()
        //{
        //    employeeDao = null;
        //}

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
        public void InsertEmployeeNegativeTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = null;
            bool status = employeeDao.Insert(employee);
            Assert.False(status);
            employeeDao = null;
        }

        [Fact]
        public void GetARecordPositiveTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(1);
            Assert.Null(employee);
            employeeDao = null;
        }

        [Fact]
        public void GetARecordNegativeValueTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(-1);
            Assert.Null(employee);
            employeeDao = null;
        }

        [Fact]
        public void GetARecordZeroValueTest()
        {
            EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(0);
            Assert.Null(employee);
            employeeDao = null;
        }
    }
}
