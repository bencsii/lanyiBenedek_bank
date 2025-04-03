using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankos_ottohn
{
    internal class BankCard
    {
        int cardNumber;
        double accountBalance;

        public double AccountBalance { get => accountBalance;}
        public int CardNumber { get => cardNumber;}

        public BankCard(Owner owner, double accountBalance, int cardNumber)
        {
            this.accountBalance = accountBalance;
            this.cardNumber = cardNumber;
        }

        public bool Purchase(double amount)
        {
            if (accountBalance - amount >= 0)
            {
                accountBalance -= amount;
                return true;
            }
            return false;
        }
    }
}
