using System;
using System.Globalization;
using System.Collections.Generic;
using business_account.Entities;

namespace business_account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new BusinessAccount(1001, "Deyvison", 500.0, 200.0));
            list.Add(new SavingsAccount(1002, "Sara", 500.0, 0.01));
            list.Add(new BusinessAccount(1003, "Nami", 500.0, 200.0));
            list.Add(new SavingsAccount(1004, "Jhin", 500.0, 0.01));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.WithDraw(10.0);
            }
            foreach(Account acc in list)
            {
                Console.WriteLine("Update balance for account: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}