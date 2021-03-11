using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HRMSAPP.Entities
{
    /// <summary>
    /// developer class
    /// </summary>
    public class Developer : Employee, IComparable<Developer>
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
        /// <summary>
        /// Checks whether one developer is greater than another or not
        /// </summary>
        /// <param name="other">the other developer to check equality with the current developer</param>
        /// <returns>
        /// true, if current developer preceds the other, false value if otherwise
        /// </returns>
        public bool Equals(Developer other)
        {
            return base.Equals(other);
        }
        #endregion

        /*
        #region Overrinding Object Class Methods inherited from Employee
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
        */

        #region Comparable Interface Implementation
        public int CompareTo([AllowNull] Developer other)
        {
            return base.CompareTo(other);
        }
        #endregion
    }
}
