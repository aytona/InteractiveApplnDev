using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemJan2018 {
    class Program {
        static void Main(string[] args) {
            List<Employee> aEmp = null;
            aEmp = new List<Employee>();

            FullTime ft1 = null;
            ft1 = new FullTime();

            ft1.Name = "Jayce";
            ft1.Age = 20;
            ft1.Salary = 20000;
            ft1.Bonus = 2000;

            Vehicle v1 = new Vehicle("Honda", "Civic");

            ft1.v = v1;

            // add to array of Employees
            aEmp.Add(ft1);

            FullTime ft2 = null;
            ft2 = new FullTime("upma", 55, 90000, 10000);

            Vehicle v2 = new Vehicle("Porsche", "Carrera");
            ft2.v = v2;

            aEmp.Add(ft2);

            PartTime pt1 = null;
            pt1 = new PartTime("duncan", 55, 2 ,1500);

            // Vehicle v3 = new Vehicle("Pontiac", "Sunfire");
            pt1.v = null;
            // pt1.v = v3;

            aEmp.Add(pt1);

            int totalPR = 0;
            int currentPay = 0;

            for (int counter=0; counter < aEmp.Count ; counter = counter + 1 ) {
                currentPay = aEmp[counter].calcEarnings();
                totalPR = totalPR + currentPay;

                aEmp[counter].printData();

                Console.WriteLine("You were born in " + aEmp[counter].calcBirthYear());
                Console.WriteLine("You make: " + currentPay);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("Total Payroll: " + totalPR);
        }
    }
}