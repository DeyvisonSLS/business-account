using System;
using business_account.Entities;

namespace business_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01); //1% of interest rating

            //DOWNCATING -- Unsafety operation
            BusinessAccount acc4 = (BusinessAccount)acc2; //Compiler don't know that the  content can be a BusinessAccount, so we tell him (casting)
            acc4.Loan(100.0);
            //acc2.Load(200.0); Compiler don't know that inside acc2 it have a BusinessAccount with the method Loan
           // BusinessAccount acc5 = (BusinessAccount)acc3; /// InvalidCastException, SavingsAccount is not compatible with BusinessAccount
           //The Compiler don't know, even
           //use "is" to make downcasting more safety 
           if(acc3 is BusinessAccount)
           {
               BusinessAccount acc5 = (BusinessAccount)acc3;
               acc5.Loan(100.0);
               Console.WriteLine("Loan!");
           }
           if(acc3 is SavingsAccount)
           {
               SavingsAccount acc5 = (SavingsAccount)acc3;
               acc5.UpdateBalance();
               Console.WriteLine("Updated!");
           }
        }
    }
}