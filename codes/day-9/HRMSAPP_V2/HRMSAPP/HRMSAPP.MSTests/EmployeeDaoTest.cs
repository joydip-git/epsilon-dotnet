using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRMSAPP.Entities;
using HRMSAPP.DataAccessLayer;

namespace HRMSAPP.MSTests
{
    [TestClass]
    public class EmployeeDaoTest
    {
        EmployeeDao employeeDao;

        [TestInitialize]
        public void Initialize()
        {
            employeeDao = new EmployeeDao();
        }

        [TestCleanup]
        public void Clear()
        {
            employeeDao = null;
        }

        [TestMethod]
        public void InsertEmployeePositiveTest()
        {
            //EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = new Employee(1, "joy", "Bng", "CITA", 1000, 2000, 3000);
            bool status = employeeDao.Insert(employee);
            Assert.AreEqual(true, status);
            //employeeDao = null;
        }

        [TestMethod]
        public void InsertEmployeeNegativeTest()
        {
            //EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = null;
            bool status = employeeDao.Insert(employee);
            Assert.AreEqual(false, status);
            //employeeDao = null;
        }

        [TestMethod]
        public void GetARecordPositiveTest()
        {
            //EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(1);
            Assert.AreEqual(null, employee);
            //employeeDao = null;
        }

        [TestMethod]
        public void GetARecordNegativeValueTest()
        {
            //EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(-1);
            Assert.AreEqual(null, employee);
            //employeeDao = null;
        }

        [TestMethod]
        public void GetARecordZeroValueTest()
        {
            //EmployeeDao employeeDao = new EmployeeDao();
            Employee employee = employeeDao.GetARecord(0);
            Assert.AreEqual(null, employee);
            //employeeDao = null;
        }
    }
}
