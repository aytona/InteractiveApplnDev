using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemJan2018 {
    class FullTime : Employee {
        private int _salary;
        private int _bonus;

        public FullTime() : base() {
            //this.Name = "";
            //this.Age = 0;
            this._salary = 0;
            this._bonus = 0;
        }

        public FullTime (String ppName, int ppAge, int pSal, int pBonus): base(ppName, ppAge) {
            // this.Name = pName;
            // this.Age = pAge;
            
            this._salary = pSal;
            this._bonus = pBonus;
        }

        public int Salary { get => _salary; set => _salary = value; }
        public int Bonus { get => _bonus; set => _bonus = value; }

        public override int calcEarnings() {
            return (_salary + _bonus);
        }

        public override void printData() {
            base.printData();
            Console.WriteLine("This is an FullTime");
            Console.WriteLine("Salary: " + this._salary);
            Console.WriteLine("Bonus: " + this._bonus);
        }
    }
}