using System;
using System.Globalization;

namespace Assignment1 {
    /// <summary>
    /// This class records the part timer fixed amount salary
    /// </summary>
    sealed class FixedBasedPartTime : PartTime{

        #region Attributes
        private int _fixedAmount;
        private String _department;
        #endregion
        
        #region Constructors
        /// <summary>
        /// Initializes fixed amount to 0 and department as empty String
        /// </summary>
        public FixedBasedPartTime() : base() {
            this._fixedAmount = 0;
            this._department = "";
        }

        /// <summary>
        /// Sets part timer fixed amount, department, name, age, vehicle, hours, and rate
        /// </summary>
        /// <param name="pFixedAmount">Fixed amount as int</param>
        /// <param name="pDepartment">Department as String</param>
        /// <param name="pppName">Name as String</param>
        /// <param name="pppAge">Age as int</param>
        /// <param name="pppV">Vehicle as Vehicle</param>
        /// <param name="ppHoursWorked">Hours worked as int</param>
        /// <param name="ppRate">Rate as int</param>
        public FixedBasedPartTime(int pFixedAmount, String pDepartment, String pppName, int pppAge, Vehicle pppV, int ppHoursWorked, int ppRate) : base(pppName, pppAge, pppV, ppHoursWorked, ppRate) {
            this._fixedAmount = pFixedAmount;
            this._department = pDepartment;
        }
        #endregion

        #region Mutators and Accessors

        /// <summary>
        /// Gets fixed amount as int
        /// Sets fixed amount as int, cannot be below 0
        /// </summary>
        public int FixedAmount {
            get {
                return this._fixedAmount;
            } set {
                if (value < 0) {
                    this._fixedAmount = 0;
                } else {
                    this._fixedAmount = value;
                }
            }
        }

        /// <summary>
        /// Gets department name as String
        /// Sets department name as String
        /// </summary>
        public String Department { get => this._department; set => this._department = value; }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Outputs the Fixed based part timer attributes
        /// </summary>
        public override String printData() {
            String part = base.printData();
            String fix = "Fixed Based\n";
            String hours = String.Format("{0, -20} {1, 20}\n", "Hours Worked:", this.NHoursWorked);
            String rate = String.Format("{0, -20} {1, 20}\n", "Rate:", this.Rate.ToString("C", CultureInfo.CurrentCulture));
            String amount = String.Format("{0, -20} {1, 20}\n", "Fixed amount:", this._fixedAmount.ToString("C", CultureInfo.CurrentCulture));
            String dept = String.Format("{0, -20} {1, 20}\n", "Department:", this._department);
            return part + fix + hours + rate + amount + dept;
        }
        #endregion
    }
}