using System;
using System.Globalization;

namespace Midterm {
    sealed class SavingsAccount : BankAccount {
        private static float _rate = 10f;   // Assuming all Savings accounts have the same 10% rate

        public SavingsAccount() : base() {

        }

        public SavingsAccount(int ID, float Balance) : base(ID, Balance) {

        }

        public override Single CalculateInterestRate() {
            float percent = 1 + (_rate / 100f);
            return base.CalculateInterestRate() * percent;
        }

        public override String PrintData() {
            String aType = "Savings Account\n";
            String aRate = String.Format("{0, -30} {1, 29}%\n", "Rate:", _rate);
            String calc = String.Format("{0, -30} {1, 30}\n", "With Interest:", CalculateInterestRate().ToString("C", CultureInfo.CurrentCulture));
            return base.PrintData() + aType + aRate + calc;
        }
    }
}