using System;
using System.Collections.Generic;

namespace Midterm {
    class Program {
        static void Main(string[] args) {
            List<Client> Clients = new List<Client>();

            #region Clients
            BankAccount[] pBA = new BankAccount[2];
            pBA[0] = new CheckingAccount(0, 3, 3000);
            pBA[1] = new SavingsAccount(3, 2000);
            Client peterW = new Client(1, "Peter Wallet", pBA);
            Clients.Add(peterW);

            BankAccount[] sBA = new BankAccount[1];
            sBA[0] = new CheckingAccount(500, 5, 1000);
            Client susanB = new Client(2, "Susan Baker", sBA);
            Clients.Add(susanB);

            Client chrisA = new Client(1, "Christopher Aytona", null);
            Clients.Add(chrisA);
            #endregion

            for (int i = 0; i < Clients.Count; ++i) {
                Console.WriteLine(Clients[i].PrintData());
            }
        }
    }
}
