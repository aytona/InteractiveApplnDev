using System;
using System.Collections.Generic;
using System.Globalization;

namespace Midterm {
    abstract class BankAccount {
        private static List<int> bIDs = new List<int>();  // Contains all the account IDs

        private int _id;
        private float _balance;

        public BankAccount() {
            this._id = 0;
            this._balance = 0;
        }

        public BankAccount(int ID, float Balance) {
            if (bIDs.Contains(ID)) {
                int tempID;
                Console.WriteLine("ID already exists");
                tempID = ++bIDs[bIDs.Count - 1];
                Console.WriteLine(String.Format("{0} {1}", "Generating new ID:", tempID));
                bIDs.Add(tempID);
                this._id = tempID;
            } else {
                bIDs.Add(ID);
                bIDs.Sort();
                this._id = ID;
            }
            this._balance = Balance;
        }

        public virtual void Withdraw(float amount) {
            if (this._balance - amount >= 0) {
                this._balance -= amount;
            } else {
                Console.WriteLine("Not enough funds");
            }
        }

        public void Deposit(float amount) {
            if (amount >= 0) {
                this._balance += amount;
            } else {
                Console.WriteLine("Cannot deposit a negative amount");
            }
        }

        protected float Balance {
            get {
                return this._balance;
            }
        }

        /// <summary>
        /// Made to be overriden, assuming all accounts have some sort of interest rate
        /// </summary>
        /// <returns>Returns the balance for calculations</returns>
        public virtual float CalculateInterestRate() {
            return this._balance;
        }

        public virtual String PrintData() {
            String aID = String.Format("{0, -30} {1, 30}\n", "Account ID:", this._id);
            String aB = String.Format("{0, -30} {1, 30}\n", "Balance:", this._balance.ToString("C", CultureInfo.CurrentCulture));
            return aID + aB;
        }
    }
}
