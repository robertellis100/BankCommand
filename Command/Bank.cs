using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Bank //me walking up to the teller window or ATM
    {
        private Account account;
        private TransactionManager transactions;

        public Bank()
        {
            account = new Account();
            transactions = new TransactionManager();
        }

        public void Deposit(decimal amount)
        {
            var deposit = new Deposit(account, amount);
            transactions.AddTransactions(deposit);
        }

        public void Withdraw(decimal amount)
        {
            var withdrawal = new Withdrawal(account, amount);
            transactions.AddTransactions(withdrawal);
        }

        public void CancelLastTransaction()
        {
            transactions.RemoveTransaction();
        }

        public void RedoLastTransaction()
        {
            transactions.Redo();
        }

        public decimal BalanceInquiry()
        {
            Console.WriteLine("Balance: "+account.Balance);
            return account.Balance;
        }

    }
}
