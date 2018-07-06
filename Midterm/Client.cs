using System;
using System.Collections.Generic;

namespace Midterm {
    sealed class Client {
        private static List<int> cIDS = new List<int>();

        private int _id;
        private String _name;
        private BankAccount[] _acc;

        public Client() {
            this._id = 0;
            this._name = "";
            this._acc = DefaultAccount();
        }

        public Client(int ID, String Name, BankAccount[] Accounts) {
            if (cIDS.Contains(ID)) {
                int tempID;
                Console.WriteLine("ID already exists");
                tempID = ++cIDS[cIDS.Count - 1];
                Console.WriteLine(String.Format("{0} {1}", "Generating new ID:", tempID));
                cIDS.Add(tempID);
                this._id = tempID;
            } else {
                cIDS.Add(ID);
                cIDS.Sort();
                this._id = ID;
            }
            this._name = Name;
            if (Accounts == null) {
                this._acc = DefaultAccount();
            } else {
                this._acc = Accounts;
            }
        }

        public int ID { get => this._id; set => this._id = value; }
        public String Name { get => this._name; set => this._name = value; }
        public BankAccount[] Accounts {
            get {
                return this._acc;
            }
            set {
                if (value == null) {
                    this._acc = DefaultAccount();
                } else {
                    this._acc = value;
                }
            }
        }

        private BankAccount[] DefaultAccount() {
            BankAccount[] def = new BankAccount[1];
            def[0] = new CheckingAccount();
            return def;
        }

        public String PrintData() {
            String cID = String.Format("{0, -30} {1, 30}\n", "Customer ID:", this._id);
            String cName = String.Format("{0, -30} {1, 30}\n", "Client Name:", this._name);
            String cAccs = "";
            for (int i = 0; i < this._acc.Length; ++i) {
                cAccs += this._acc[i].PrintData();
            }
            return cID + cName + cAccs;
        }
    }
}
