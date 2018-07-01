using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemJan2018 {
    abstract class Employee {
        private String _name;
        private int _age;
        public Vehicle v;

        // method overloading = same method name , different parameters, within the same class
        public Employee() {
            _name = "";
            _age = 0;
            v = null;
        }

        public Employee (String pName, int pAge) {
            this._name = pName;
            this._age = pAge;
        }

        public string Name { get => _name; set => _name = value; }
        // public int Age { get => _age; set => _age = value; }

        public int Age {
            set {
                if (value > 0)
                    _age = value;
                else
                    _age = 0;
            }
            get { return _age; }
        }

        public int calcBirthYear() {
            return (2018 - this.Age);
        }

        public virtual int calcEarnings() {
            return 1000;
        }

        public virtual void printData() {
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Age: " + this._age);
            Console.WriteLine("Vehicle in the parking lot");
            if (v != null) {
                this.v.printData();
            } else {
                Console.WriteLine("Emp has no vehicle registered in the Parking lot");
            }
        }
    }
}