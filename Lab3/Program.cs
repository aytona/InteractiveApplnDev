using System;
using System.Collections.Generic;

namespace Lab3 {
    class Program {
        static void Main(string[] args) {
            List<PrintManager> pmList = new List<PrintManager>();

            PrintManager pm = PrintManager.Instance;
            pm.ID = "My blah blah";
            pmList.Add(pm);

            PrintManager pm2 = PrintManager.Instance;
            pm2.ID = "bleah bleah";
            pmList.Add(pm2);

            PrintManager pm3 = PrintManager.Instance;
            pmList.Add(pm3);

            PrintManager pm4 = PrintManager.Instance;
            pmList.Add(pm4);

            PrintManager pm5 = PrintManager.Instance;
            pmList.Add(pm5);

            foreach(PrintManager i in pmList) {
                Console.WriteLine(i.GetID());
                Console.WriteLine(i.ID);
            }

            Console.ReadKey();
        }
    }
}
