using System;
using System.Globalization;

namespace Assignment1 {
    /// <summary>
    /// This class records the part timer comission amount
    /// </summary>
    sealed class ComissionBasedPartTime : PartTime{

        #region Attributes
        private int _comission;
        private String _product;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor, initialize comission as 0 and product as None
        /// </summary>
        public ComissionBasedPartTime() : base() {
            this._comission = 0;
            this._product = "None";
        }

        /// <summary>
        /// Sets part timer comission, product, name, age, vehicle, hours, and rate
        /// </summary>
        /// <param name="pComission">Comission as int</param>
        /// <param name="pProduct">Product as String</param>
        /// <param name="pppName">Name as String</param>
        /// <param name="pppAge">Age as int</param>
        /// <param name="pppV">Vehicle as Vehicle</param>
        /// <param name="ppHoursWorked">HoursWorked as int</param>
        /// <param name="ppRate">Rate as int</param>
        public ComissionBasedPartTime(int pComission, String pProduct, String pppName, int pppAge, Vehicle pppV, int ppHoursWorked, int ppRate) : base(pppName, pppAge, pppV, ppHoursWorked, ppRate) {
            this._comission = pComission;
            this._product = pProduct;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Gets comission percentage as int
        /// Sets comission percentage as int, can only be between 0 and 100
        /// </summary>
        public int Comission {
            get {
                return this._comission;
            } set {
                if (value < 0) {
                    this._comission = 0;
                } else if (value > 100) {
                    this._comission = 100;
                } else {
                    this._comission = value;
                }
            }
        }

        /// <summary>
        /// Gets Product name as String
        /// Sets Product name as String
        /// </summary>
        public String Product { get => this._product; set => this._product = value; }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Outputs the Comission based part timer attributes
        /// </summary>
        public override String printData() {
            String part = base.printData();
            String pcom = "Comission Based\n";
            String hours = String.Format("{0, -20} {1, 20}\n", "Hours Worked:", this.NHoursWorked);
            String rate = String.Format("{0, -20} {1, 20}\n", "Rate:", this.Rate.ToString("C", CultureInfo.CurrentCulture));
            String comission = String.Format("{0, -20} {1, 19}%\n", "Comission:", this._comission);
            String product = String.Format("{0, -20} {1, 20}\n", "Product sold:", this._product);
            return part + pcom + hours + rate + comission + product;
        }
        #endregion
    }
}