using System;

namespace Assignment1 {
    /// <summary>
    /// This class creates a Vehicle with make and model attributes
    /// </summary>
    abstract public class Vehicle {

        #region Attributes
        private String _make;
        private String _model;
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor that sets Make and Model as empty Strings
        /// </summary>
        public Vehicle() {
            this.Make = "";
            this.Model = "";
        }

        /// <summary>
        /// Vehicle constructor that takes the Make and Model of the vehicle
        /// </summary>
        /// <param name="pMake">Make as String</param>
        /// <param name="pModel">Model as String</param>
        public Vehicle (String pMake, String pModel) {
            this.Make = pMake;
            this.Model = pModel;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Gets Make as String
        /// Sets Make as String, can be empty
        /// </summary>
        public string Make { get => _make; set => _make = value; }

        /// <summary>
        /// Gets Model as String
        /// Sets Make as String, can be empty
        /// </summary>
        public string Model { get => _model; set => _model = value; }

        #endregion

        #region Methods and Functions
        /// <summary>
        /// Outputs the Vehicle attributes
        /// </summary>
        public virtual String printData() {
            String make = String.Format("{0, -20} {1, 20}\n", "Make:", this._make);
            String model = String.Format("{0, -20} {1, 20}\n", "Model:", this._model);
            return make + model;
        }
        #endregion
    }
}