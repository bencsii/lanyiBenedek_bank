using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankos_ottohn
{
    internal class Bank
    {
        private List<BankAccount> accounts;

        public Bank(int accountNum) 
        {
            accounts = new List<BankAccount>(accountNum);
        }

        public double TotalBalance(Owner owner)
        {


            double avgBalance = 0;
            if (accounts != null)
            {
                foreach (var account in accounts)
                {
                    if (account != null)
                    {
                        avgBalance += account.Balance;
                    }
                }
            }
            return avgBalance;

            

        }

        public BankAccount? MaximalBalanceAccount(Owner owner)
        {
            return accounts?.Where(a => a.Owner == owner).OrderByDescending(a => a.Balance).FirstOrDefault();
        }


        public double TotalCreditLimit()
        {
            double totalCredit = 0;
            if (accounts != null)
            {
                foreach (var account in accounts)
                {
                    if (account is CreditAccount creditAccount)
                    {
                        totalCredit += creditAccount.Creditlimit;
                    }
                }
            }
            return totalCredit;
        }


    }
}
