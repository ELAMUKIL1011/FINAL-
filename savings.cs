using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_abstractclass
{
    class savings : account
    {       
        public savings(int accountid,
        int accountbalance,
       string customername) : base(accountid, accountbalance, customername)
        {

            Console.WriteLine("saving constructor");
        }

        public override bool whithdraw(int amount)
        {
            accountbalance = accountbalance - amount-50;
            return true;
        }

        public override bool deposit(int amoubt)
        {
            accountbalance = accountbalance + amoubt+ 50;
            return true;
        }

        public override bool stoppayment(string chequeno)
        {
            Console.WriteLine("cheque stopped"+ chequeno);
            return true;
        }
    }
}
