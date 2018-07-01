using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemJan2018 {
    class PartTime : Employee {

        private int _nHoursWorked;
        private int _rate;

        public PartTime() : base() {
            //this.Name = "";
            //this.Age = 0;
            this._nHoursWorked = 0;
            this._rate = 0;
        }

        public PartTime(String ppName, int ppAge, int pHoursWorked, int pRate) : base(ppName, ppAge) {
            // this.Name = pName;
            // this.Age = pAge;

            this._nHoursWorked = pHoursWorked;
            this._rate = pRate;
        }

        public override int calcEarnings() {
            return (_rate * NHoursWorked);
        }

        public override void printData(){
            base.printData();
            Console.WriteLine("This is an PartTime");
            Console.WriteLine("Hours Worked: " + this._nHoursWorked);
            Console.WriteLine("Rate: " + this._rate);
        }

        public int NHoursWorked { get => _nHoursWorked; set => _nHoursWorked = value; }
        public int Rate { get => _rate; set => _rate = value; }
    }
}