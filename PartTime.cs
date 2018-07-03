using System;

namespace Assignment1 {
    /// <summary>
    /// Base class for all PartTime employees
    /// Records hours worked, and hourly rates
    /// </summary>
    abstract class PartTime : Employee {

        #region Attributes
        private int _nHoursWorked;
        private int _rate;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes Hoursworked and Rate to 0
        /// </summary>
        public PartTime() : base() {
            this._nHoursWorked = 0;
            this._rate = 0;
        }

        /// <summary>
        /// PartTime employee requires Name, Age, Vehicle, HoursWorked, and Rate
        /// </summary>
        /// <param name="ppName">Name as String</param>
        /// <param name="ppAge">Age as int</param>
        /// <param name="ppV">Vehicle as Vehicle</param>
        /// <param name="pHoursWorked">HoursWorked as int</param>
        /// <param name="pRate">Rate as int</param>
        public PartTime(String ppName, int ppAge, Vehicle ppV, int pHoursWorked, int pRate) : base(ppName, ppAge, ppV) {
            this._nHoursWorked = pHoursWorked;
            this._rate = pRate;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Gets Hours Worked as int
        /// Sets Hours Worked as int, cannot be below 0
        /// </summary>
        public int NHoursWorked {
            get {
                return this._nHoursWorked;
            } set {
                if (value < 0) {
                    this._nHoursWorked = 0;
                } else {
                    this._nHoursWorked = value;
                }
            }
        }

        /// <summary>
        /// Gets Rate as int
        /// Sets Rate as in, cannot be below 0
        /// </summary>
        public int Rate {
            get {
                return this._nHoursWorked;
            } set {
                if (value < 0) {
                    this._nHoursWorked = 0;
                } else {
                    this._nHoursWorked = value;
                }
            }
        }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Calculates PartTimer earnings using HoursWorked and Rate
        /// </summary>
        /// <returns>Total as int</returns>
        public override int calcEarnings() {
            return (this._rate * this._nHoursWorked);
        }

        /// <summary>
        /// Outputs the base attributes
        /// </summary>
        public override String printData(){
            String emp = base.printData();
            String part = "Employee is PartTime / ";
            return emp + part;
        }
        #endregion
    }
}