using System;
using System.Globalization;

namespace Assignment1 {
    /// <summary>
    /// This class records a FullTime employee's yearly Salary and bonus
    /// Can also calculate the total amount of an employee's earnings
    /// </summary>
    sealed class FullTime : Employee {

        #region Attributes
        private int _salary;
        private int _bonus;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor: 0 Salary and bonus
        /// </summary>
        public FullTime() : base() {
            this._salary = 0;
            this._bonus = 0;
        }

        /// <summary>
        /// FullTime employee requires Name, Age, Vehicle class, Salary, Bonus
        /// </summary>
        /// <param name="ppName">Name as String</param>
        /// <param name="ppAge">Age as int</param>
        /// <param name="ppV">Vehicle as Vehicle</param>
        /// <param name="pSal">Salary as int</param>
        /// <param name="pBonus">Bonus as int</param>
        public FullTime (String ppName, int ppAge, Vehicle ppV, int pSal, int pBonus) : base(ppName, ppAge, ppV) {
            this._salary = pSal;
            this._bonus = pBonus;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Gets Salary as int
        /// Sets Salary as int
        /// </summary>
        public int Salary { get => _salary; set => _salary = value; }

        /// <summary>
        /// Sets Bonus as int
        /// Gets Bonus as int
        /// </summary>
        public int Bonus { get => _bonus; set => _bonus = value; }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Calculates employee's total earnings: including salary and bonus
        /// </summary>
        /// <returns>Total as int</returns>
        public override int calcEarnings() {
            return (_salary + _bonus);
        }

        /// <summary>
        /// Outputs base attributes and includes Salary and Bonus
        /// </summary>
        public override String printData() {
            String emp = base.printData();
            String full = "Employee is FullTime\n";
            String salary = String.Format("{0, -20} {1, 20}\n", "Salary:", this._salary.ToString("C", CultureInfo.CurrentCulture));
            String bonus = String.Format("{0, -20} {1, 20}\n", "Bonus:", this._bonus.ToString("C", CultureInfo.CurrentCulture));
            return emp + full + salary + bonus;
        }
        #endregion
    }
}