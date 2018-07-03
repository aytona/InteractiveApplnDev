using System;

namespace Assignment1 {
    /// <summary>
    /// This class records the motorcycle CC and tranmission speed
    /// </summary>
    sealed class Motorcycle : Vehicle {

        #region Attributes
        private int _cc;
        private int _transmission;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor that initializes CC and transmission speed of motorcycle to 0
        /// </summary>
        public Motorcycle() : base() {
            this._cc = 0;
            this._transmission = 0;
        }

        /// <summary>
        /// Motorcycle constructor that requires the CC and Transmission speed
        /// </summary>
        /// <param name="mCC">CC in int</param>
        /// <param name="mTrans">Transmission in int</param>
        /// <param name="ppMake">Make in String</param>
        /// <param name="ppModel">Model in String</param>
        public Motorcycle(int mCC, int mTrans, String ppMake, String ppModel) : base(ppMake, ppModel) {
            this._cc = mCC;
            this._transmission = mTrans;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Gets CC as int
        /// Sets CC as int, cannot be less than 0
        /// </summary>
        public int CC {
            get {
                return this._cc;
            } set {
                if (value < 0) {
                    this._cc = 0;
                } else {
                    this._cc = value;
                }
            }
        }

        /// <summary>
        /// Gets Transmission as int
        /// Sets Transmission as int, cannot be less than 0
        /// </summary>
        public int Transmission {
            get {
                return this._transmission;
            } set {
                if (value < 0) {
                    this._transmission = 0;
                } else {
                    this._transmission = value;
                }
            }
        }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Outputs the motorcycle CC and Tranmission speed
        /// </summary>
        public override String printData() {
            String vehicle = base.printData();
            String cc = String.Format("{0, -20} {1, 20}", "CC:", this._cc);
            String transmission = String.Format("{0, -20} {1, 20}", "Transmission:", this._transmission);
            return vehicle + cc + transmission;
        }
        #endregion
    }
}