﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.Deposit(50);
            bank.Deposit(50);
            bank.Withdraw(75);
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
            Console.ReadLine();
        }
    }
}
