using System;
using business_account.Entities;

namespace business_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine("Normal account:" + acc1.Balance + " - Saving Account:" + acc2.Balance);
        }
    }
}