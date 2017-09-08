using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_abstractclass
{
    class current :account
    {
        public current(int accountid, int accountbalance, string customername)
            : base(accountid, accountbalance, customername)
        {
            Console.WriteLine("current account abject created");
        }


        public override bool whithdraw(int amount)
        {
            accountbalance = accountbalance - amount;
            return true;
        }

        public override bool deposit(int amoubt)
        {
            accountbalance = accountbalance + amoubt;
            return true;
            
        }

        public override bool stoppayment(string chequeno)
        {
            Console.WriteLine("Cheque is stopped" + chequeno);
            return true;
        }
    }
}
