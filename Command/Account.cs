using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Account
    {
        public decimal Balance { get; set; }

        public Account(): this(0) //this is called constructor chaining
        {
        }

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public void Inquiry()
        {
            Balance;
        }
    }
}
