using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankos_ottohn
{
    internal class SavingsAccount : BankAccount
    {
        static double baseInterest;
        public static double interest { get => baseInterest; set => baseInterest = value; }
        public SavingsAccount(Owner owner) : base(owner)
        {
            interest = baseInterest;
        }

        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void AddInterest()
        {
            Balance += Balance * (interest / 100);
        }


    }
}
