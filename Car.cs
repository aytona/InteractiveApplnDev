using System;

namespace Assignment1 {
    /// <summary>
    /// This class records the car body type and transmission
    /// </summary>
    sealed class Car : Vehicle{

        #region Attributes
        private String _body;
        private String _transmission;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor that sets body and tranmission to empty Strings
        /// </summary>
        public Car() : base() {
            this._body = "";
            this._transmission = "";
        }

        /// <summary>
        /// Car requires body type, transmission, make, and model as all String
        /// </summary>
        /// <param name="cBody">Body as String</param>
        /// <param name="cTransmission">Transmission as String</param>
        /// <param name="ppMake">Make as String</param>
        /// <param name="ppModel">Model as String</param>
        public Car(String cBody, String cTransmission, String ppMake, String ppModel) : base(ppMake, ppModel) {
            this._body = cBody;
            this._transmission = cTransmission;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Sets body as String
        /// Gets body as String
        /// </summary>
        public String Body { get => this._body; set => this._body = value; }

        /// <summary>
        /// Sets transmission as String
        /// Gets transmission as String
        /// </summary>
        public String Transmission { get => this._transmission; set => this._transmission = value; }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Outputs the Car body type and Transmission type
        /// </summary>
        public override String printData() {
            String vehicle = base.printData();
            String body = String.Format("{0, -20} {1, 20}\n", "Body type:", this._body);
            String transmission = String.Format("{0, -20} {1, 20}\n", "Transmission:", this._transmission);
            return vehicle + body + transmission;
        }
        #endregion
    }
}