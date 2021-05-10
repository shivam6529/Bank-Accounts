using System;
using System.Collections.Generic;

namespace Bank_Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount saving = new Savings();
            IAccount current = new CurrentAccount();
            IAccount rrsp = new RecurringDeposit();
            
            saving.Deposit(100);
            saving.Withdraw(10);
            saving.Bal();
            
            current.Deposit(110);
            current.Withdraw(30);
            current.Bal();
            
            rrsp.Deposit(200);
            rrsp.Withdraw(20);  
            rrsp.Bal();

            // IList<IAccount> accounts = new List<IAccount>();
            // accounts.Add(new Savings());
            // accounts.Add(new CurrentAccount());
            // accounts.Add(new ReccuringDeposit());

            // foreach (var acc in accounts){
            //     acc.Deposit(500);
            //     acc.Withdraw(100);
            //     acc.Bal();
            // }
        }
    }
}
