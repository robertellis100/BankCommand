using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Deposit : ITransaction
    {
        private Account account;
        private decimal amount;
        public bool Completed { get; set; }
        public Deposit(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public void Execute()
        {
            account.Balance += amount;
            Console.WriteLine("Current Balance: " + account.Balance);
            Completed = true;
        }

        public void Undo()
        {
            if (Completed)
            {
                account.Balance -= amount;
                Console.WriteLine("Current Balance: " + account.Balance);
            }
        }
    }
}
