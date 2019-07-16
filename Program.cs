using System;
using business_account.Entities;

namespace business_account
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8080, "Deyvison", 200.00, 400.00);

            Console.WriteLine(account.Balance);
        }
    }
}
