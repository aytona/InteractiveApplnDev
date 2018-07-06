using System;
using System.Globalization;

namespace Midterm {
    sealed class CheckingAccount : BankAccount {
        private float _overdraft;

        public CheckingAccount() : base() {
            this._overdraft = 0;
        }

        public CheckingAccount(float OverDraft, int ID, float Balance) : base(ID, Balance) {
            this._overdraft = OverDraft;
        }

        public float OverDraft { get => this._overdraft; set => this._overdraft = value; }

        public override void Withdraw(Single amount) {
            float buffer = this.Balance + _overdraft;
            base.Withdraw(buffer);
        }

        public override String PrintData() {
            String cType = "Checking Account\n";
            String aOD = String.Format("{0, -30} {1, 30}\n", "Overdraft:", _overdraft.ToString("C", CultureInfo.CurrentCulture));
            return base.PrintData() + cType + aOD;
        }
    }
}