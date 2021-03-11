using HRMSAPP.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HRMSAPP.BusinessLayer
{
    internal class EmployeeComparison : IComparer<Employee>
    {
        private int choice;
        public EmployeeComparison()
        {

        }

        public EmployeeComparison(int choice)
        {
            this.choice = choice;
        }

        public int Compare([AllowNull] Employee x, [AllowNull] Employee y)
        {
            int result = 0;
            switch (choice)
            {
                case 1:
                    result = x.EmployeeName.CompareTo(y.EmployeeName);
                    break;

                case 2:
                    result = x.EmployeeSalary.CompareTo(y.EmployeeSalary);
                    break;

                default:
                    result = x.EmployeeId.CompareTo(y.EmployeeId);
                    break;
            }
            return result;
        }
    }
}
