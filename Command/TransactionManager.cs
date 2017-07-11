using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TransactionManager
    {
        private Stack<ITransaction> transactions;

        public TransactionManager()
        {
            transactions = new Stack<ITransaction>();
        }

        public void AddTransactions(ITransaction transaction)
        {
            transactions.Push(transaction);
            transaction.Execute();
        }

        public void RemoveTransaction()
        {
            var lastTransaction = transactions.Pop();
            lastTransaction.Undo();
        }

        public void Redo()
        {
            var lastTransaction = transactions.Peek();
            this.AddTransactions(lastTransaction);
        }

        


    }
}
