using System;

namespace PayrollSystemJan2018 {
    public class Vehicle {

        private String _make;
        private String _model;

        public Vehicle() {
            this.Make = "";
            this.Model = "";
        }

        public Vehicle (String pMake, String pModel) {
            this.Make = pMake;
            this.Model = pModel;
        }

        public void printData() {
            Console.WriteLine("Make: " + this._make);
            Console.WriteLine("Make: " + this._model);
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
    }
}