using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_bank_uj
{
	internal class CreditAccount : BankAccount
	{
		double creditLimit;
		public double Creditlimit { get; }

		public CreditAccount(Owner owner, double creditlimit) : base(owner)
		{
			this.creditlimit = creditlimit;
		}

		public override bool Withdraw(double amount)
		{
			if (this.Balance - amount >= creditlimit)
			{
				this.Balance -= amount;
				return true;
			}
			return false;
		}
	}
}
