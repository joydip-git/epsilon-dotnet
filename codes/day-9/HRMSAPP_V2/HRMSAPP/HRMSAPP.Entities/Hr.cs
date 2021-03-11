using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSAPP.Entities
{
    /// <summary>
    /// Hr class
    /// </summary>
    public class Hr : Employee
    {
        #region Data Members
        decimal gratuityPayment;
        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Hr()
        {
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="hrId">id of an hr</param>
        /// <param name="hrName">name of an hr</param>
        /// <param name="hrLocation">location of an hr</param>
        /// <param name="projectName">name of project of an hr</param>
        /// <param name="hrBasicPayemnt">basic payment of an hr</param>
        /// <param name="hrDaPayemnt">da payment of an hr</param>
        /// <param name="hrHraPayemnt">hra payment of an hr</param>
       ///<param name="gratuityPayment">gratuity payment of an hr</param>
        public Hr(int hrId, string hrName, string hrLocation, string projectName, decimal hrBasicPayemnt, decimal hrDaPayemnt, decimal hrHraPayemnt, decimal gratuityPayment)
            : base(hrId, hrName, hrLocation, projectName, hrBasicPayemnt, hrDaPayemnt, hrHraPayemnt)
        {
            this.gratuityPayment = gratuityPayment;
        }

        #endregion

        #region Properties
        /// <summary>
        /// gets or sets the gratuity payment of an hr
        /// </summary>
        public decimal GratuityPayment
        {
            get => gratuityPayment;
            set => gratuityPayment = value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to calculate total salary of an HR
        /// </summary>
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            //employeeSalary
            EmployeeSalary = EmployeeSalary + gratuityPayment;
        }
        /// <summary>
        /// Checks whether one employee is greater than another or not
        /// </summary>
        /// <param name="other">the other employee to check equality with the current employee</param>
        /// <returns>
        /// true, if current employee preceds the other, false value if other employee preceds the current
        /// </returns>
        public bool Equals(Hr other)
        {
           return base.Equals(other);
        }
        #endregion
    }
}
