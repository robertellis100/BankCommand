using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal resultAmount =0;
            decimal expectedAmount =30;
            var bank = new Bank();
            bank.Deposit(50);
            bank.Deposit(10);
            bank.Withdraw(25);
            bank.Deposit(25);
            bank.Withdraw(20);
            bank.CancelLastTransaction();
            bank.Deposit(100);
            bank.RedoLastTransaction();
            bank.CancelLastTransaction();
            bank.CancelLastTransaction();
            bank.CancelLastTransaction();
            bank.CancelLastTransaction();
            bank.CancelLastTransaction();
            bank.CancelLastTransaction();
            resultAmount = bank.BalanceInquiry();
            if (bank.BalanceInquiry() == expectedAmount)
            {
                
            }
        }
    }
}
