using System;
using System.Collections.Generic;

namespace Assignment1 {
    class Program {
        static void Main(string[] args) {
            List<Employee> aEmp = new List<Employee>();     // List of all Employees
            int totalPR = 0;                                // Total payroll

            #region Vehicles
            Motorcycle Ninja = new Motorcycle(600, 6, "Ninja", "ZX-6R");
            Motorcycle Harley = new Motorcycle(500, -1, "Harley Davidson", "Street 500");
            Car Civic = new Car("Sedan", "Manual", "Honda", "Civic");
            Car Ford = new Car("Pickup", "Automatic", "Ford", "F-150");
            Car Tesla = new Car("Sedan", "Automatic", "Tesla", "Model X");
            #endregion

            #region Employees
            ComissionBasedPartTime e1 = new ComissionBasedPartTime(10, "Cellphone", "John", 21, Ford, 10, 30);
            aEmp.Add(e1);
            ComissionBasedPartTime e2 = new ComissionBasedPartTime(15, "Real Estate", "Smith", 37, null, 35, 60);
            aEmp.Add(e2);
            FixedBasedPartTime e3 = new FixedBasedPartTime(40, "Marketing", "Cindy", 39, Civic, 10, 40);
            aEmp.Add(e3);
            FixedBasedPartTime e4 = new FixedBasedPartTime(80, "Management", "Carl", 55, Tesla, 20, 100);
            aEmp.Add(e4);
            FullTime e5 = new FullTime("Matthew", 18, Ninja, 40000, 5000);
            aEmp.Add(e5);
            FullTime e6 = new FullTime("Bob", 48, Harley, 60000, 5000);
            aEmp.Add(e6);
            #endregion

            // Prints all Employee details and calculates total payroll
            for (int counter=0; counter < aEmp.Count ; counter = counter + 1 ) {
                totalPR += aEmp[counter].calcEarnings();
                Console.WriteLine(aEmp[counter].printData());
                Console.WriteLine("==========================================");
            }
            Console.WriteLine(String.Format("{0, -20} {1, 19}$", "Total Payroll:", totalPR));
        }
    }
}