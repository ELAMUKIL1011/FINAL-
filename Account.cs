using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_2
{
    class Account
    {
        private int account_id;
        private string customer_name;
        private DateTime customer_dob;
        private double account_balance;

        public Account(int account_id,string customer_name,DateTime customer_dob)
        {
            this.account_id=account_id;
            this.customer_name=customer_name;
            this.customer_dob=customer_dob;
        }
        public int paccount_id
        {
            get
            {
                return account_id;
            }
        }
        public string pcustomer_name
        {
            get
            {
                return customer_name;
            }
        }
        public DateTime pcustomer_dob
        {
            get
            {
                return customer_dob;
            }
        }
        public double paccount_balance
        {
            get
            {
                return account_balance;
            }
           
        }
        public double getbalance()
        {
            return account_balance;
        }

        public bool withdraw(int amountw)
        {
            if (amountw > account_balance)
            {
                return false;
            }
            else
            {
                account_balance = account_balance - amountw;
                return true;
            }
        }
        public bool deposit(int amountd)
        {
            if (amountd > 0)
            {
                account_balance = account_balance + amountd;
                return true;
            }
            else
            {
                return false;
            }
        }


     }
}
