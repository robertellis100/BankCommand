using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Withdrawal : ITransaction
    {
        private Account account;
        private decimal amount;
        public bool Completed { get; set; }
        public Withdrawal(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public void Execute()
        {
            account.Balance -= amount;
            Console.WriteLine("Current Balance: " + account.Balance);
            Completed = true;
        }

        public void Undo()
        {
            if (Completed)
            {
                account.Balance += amount;
                Console.WriteLine("Current Balance: " + account.Balance);
            }
        }
    }
}
