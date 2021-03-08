using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSAPP.Entities
{
    /// <summary>
    /// developer class
    /// </summary>
    public class Developer : Employee
    {
        #region Data Members
        decimal incentivePayment;
        #endregion

        #region Constructors
        /// <summary>
        /// default constructor
        /// </summary>
        public Developer()
        {
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="developerId">id of an developer</param>
        /// <param name="developerName">name of an developer</param>
        /// <param name="developerLocation">location of an developer</param>
        /// <param name="projectName">name of project of an developer</param>
        /// <param name="developerBasicPayemnt">basic payment of an developer</param>
        /// <param name="developerDaPayemnt">da payment of an developer</param>
        /// <param name="developerHraPayemnt">hra payment of an developer</param>
        /// <param name="incentivePayment">incentive payment of a developer</param>
        public Developer(int developerId, string developerName, string developerLocation, string projectName, decimal developerBasicPayemnt, decimal developerDaPayemnt, decimal developerHraPayemnt, decimal incentivePayment)
            : base(developerId, developerName, developerLocation, projectName, developerBasicPayemnt, developerDaPayemnt, developerHraPayemnt)
        {
            this.incentivePayment = incentivePayment;
        }

        #endregion

        #region Properties
        /// <summary>
        /// gets or sets the incentive payement of a developer
        /// </summary>
        public decimal IncentivePayment
        {
            get => incentivePayment;
            set => incentivePayment = value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to calculate total salary of a developer
        /// </summary>
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            //employeeSalary
            EmployeeSalary = EmployeeSalary + incentivePayment;
        }
        #endregion
    }
}
