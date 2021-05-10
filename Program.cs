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
            IAccount rrsp = new ReccuringDeposit();
            
            saving.Deposit(100);
            saving.Withdraw(10);
            Console.WriteLine("Balance in your savings account is {0} ",saving.Balance);
            
            current.Deposit(110);
            current.Withdraw(30);
            Console.WriteLine("Balance in your current account account is {0} ",current.Balance);
            
            rrsp.Deposit(200);
            rrsp.Withdraw(20);  
            Console.WriteLine("Balance in your reccuring deposit account is {0} ",rrsp.Balance);

            // IList<IAccount> accounts = new List<IAccount>();
            // accounts.Add(new Savings());
            // accounts.Add(new CurrentAccount());
            // accounts.Add(new ReccuringDeposit());

            // foreach (var acc in accounts){
            //     acc.Withdraw(100);
            //     acc.Deposit(500);
            //     Console.WriteLine(acc.Balance);
            // }
        }
    }
}
