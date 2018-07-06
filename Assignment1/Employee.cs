using System;

namespace Assignment1 {
    /// <summary>
    /// This class creates an employee with Name, age and vehicle information
    /// It can also calculate the birth year and earning of the employee
    /// Can output all information using printData()
    /// </summary>
    abstract class Employee {

        #region Attributes
        private String _name;
        private int _age;
        public Vehicle v;
        #endregion

        #region Constructors
        /// <summary>
        /// Default employee: Empty name, 0 age, null vehicle
        /// </summary>
        public Employee() {
            _name = "";
            _age = 0;
            v = null;
        }

        /// <summary>
        /// Employee requires Name, age, and vehicle
        /// </summary>
        /// <param name="pName">String Name</param>
        /// <param name="pAge">int Age</param>
        /// <param name="pV">Vehicle class</param>
        public Employee (String pName, int pAge, Vehicle pV) {
            this._name = pName;
            this._age = pAge;
            this.v = pV;
        }
        #endregion

        #region Mutators and Accessors
        /// <summary>
        /// Gets name as String
        /// Sets name as String, can be empty
        /// </summary>
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// Gets age as int
        /// Sets age to 0 if less than 0, otherwise value
        /// </summary>
        public int Age {
            get {
                return this._age;
            } set {
                if (value < 0) {
                    this._age = 0;
                } else {
                    this._age = value;
                }
            }
        }

        /// <summary>
        /// Gets vehicle as Vehicle
        /// Sets vehicle as Vehicle, can be null
        /// </summary>
        public Vehicle Vehicle { get => this.v; set => this.v = value; }
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Calculates the birth year of the employee using DateTime from System
        /// </summary>
        /// <returns>Year in int</returns>
        public int calcBirthYear() {
            return (DateTime.Now.Year - this.Age);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual int calcEarnings() {
            return 1000;
        }

        /// <summary>
        /// Outputs the employee attributes
        /// </summary>
        public virtual String printData() {
            String name = String.Format("{0, -20} {1, 20}\n", "Name:", this._name);
            String age = String.Format("{0, -20} {1, 20}\n", "Age:", this._age);
            String birthYear = String.Format("{0, -20} {1, 20}\n", "Year of Birth:", this.calcBirthYear());
            String vehicle = "";
            if (this.v is null) {
                vehicle = "Employee doesn't have a vehicle\n";
            } else {
                vehicle = "Employee has a " + this.v.GetType().Name + "\n";
            }
            return name + age + birthYear + vehicle;
        }
        #endregion
    }
}