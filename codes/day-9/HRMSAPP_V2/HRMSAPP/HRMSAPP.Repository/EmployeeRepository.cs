using System;
using System.Collections.Generic;
using HRMSAPP.Entities;

namespace HRMSAPP.Repository
{
    /// <summary>
    /// Reposiroty of employee instances
    /// </summary>
    //static class must have all static members, such as - static ctor, static method, static data, static property
    //static class object can not be created
    public static class EmployeeRepository
    {
        static HashSet<Employee> employees;//= new Employee[10];

        static EmployeeRepository()
        {
            employees = new HashSet<Employee>();
        }

        //public static Employee[] Employees
        //{
        //    get { return employees;}
        //}
        //public static Employee[] Employees
        //{
        //    get => employees;
        //}

        //use this syntax if the property has only GET accessor
        /// <summary>
        /// readonly property--gets the employee repository
        /// </summary>
        public static HashSet<Employee> Employees => employees;
    }
}
