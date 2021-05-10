using System;

namespace Bank_Accounts{
    class ReccuringDeposit : IAccount
	{
		private decimal balance;
		public void Deposit(decimal amount)
		{
			balance += amount;
		}
		
		public void Withdraw(decimal amount)
		{
			if (balance - amount < 0)
				throw new Exception(string.Format("Withdrawing {0} would not be possible because u have only {1} in your account.",amount,balance));
			balance -= amount;
		}
		
		public decimal Balance { get { return balance; } }
         public void Bal(){

            Console.WriteLine("The balance in ur reccuring deposit account is {0}",balance);
        }
	}
}