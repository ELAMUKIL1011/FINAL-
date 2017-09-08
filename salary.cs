using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_abstractclass
{
    class salary :account
    {
        public salary(int accountid, int accountbalance, string customername)
            : base(accountid, accountbalance, customername)
        {
            Console.WriteLine("salary constructor called");
        }


        public override bool whithdraw(int amount)
        {
            accountbalance = accountbalance - amount - 100;
            return true;
        }

        public override bool deposit(int amoubt)
        {
            accountbalance = accountbalance + amoubt+8;
            return true;
        }

        public override bool stoppayment(string chequeno)
        {
            Console.WriteLine("cheque transcation stopped:" + chequeno);
            return true;

        }
    }
}
