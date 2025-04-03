namespace bankos_ottohn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();

            owner.ownerName = "Someone";
            Console.WriteLine(owner.ownerName);


            Bank bank = new Bank(3);
            BankAccount account1 = bank.NewAccount(owner, 50000);
            BankAccount account2 = bank.NewAccount(owner, 1000);
            account1.NewCard(234545642);
            account2.NewCard(966678642);

            account1.Deposit(1000);
            account2.Deposit(3000);


            BankCard card1 = new BankCard(owner, 5000, 234545642);
            BankCard card2 = new BankCard(owner, 5000, 966678642);

            card1.Purchase(2000);
            card2.Purchase(1500);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine(card1.AccountBalance);
            Console.WriteLine(card2.AccountBalance);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine(bank.TotalBalance(owner));
            //Console.WriteLine(bank.MaximalBalanceAccount(owner)); // ???
            Console.WriteLine(bank.TotalCreditLimit());

        }
    }
}
