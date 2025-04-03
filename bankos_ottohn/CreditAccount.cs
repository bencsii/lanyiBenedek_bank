using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankos_ottohn
{
    internal class CreditAccount : BankAccount
    {
        double creditLimit;
        public double Creditlimit { get => creditLimit;}

        public CreditAccount(Owner owner, double creditlimit) : base(owner)
        {
            this.creditLimit = creditlimit;
        }

        public override bool Withdraw(double amount)
        {
            if (this.Balance - amount >= creditLimit)
            {
                this.Balance -= amount;
                return true;
            }
            return false;
        }

    }
}
