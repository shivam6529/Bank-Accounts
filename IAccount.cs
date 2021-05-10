namespace Bank_Accounts
{
    public interface IAccount
    {
        decimal Balance { get; }
		void Deposit(decimal amount);
		void Withdraw(decimal amount);
        void Bal();
    }
}