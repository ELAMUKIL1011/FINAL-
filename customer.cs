using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop1
{
    class customer
    {
        private int customerid;
        private string customerFname;
        private string customerLname;
        private int accountid;
       private int accountbalance;
       public customer(int customerid,string customerFname,
           string customerLname,int accountbalance,int accountid):this(customerid)
       {
           Console.WriteLine("constructor called");
        this.   customerid = customerid;
         this.  customerFname = customerFname;
          this. customerLname = customerLname;
          this. accountbalance = accountbalance;
           this .accountid = accountid;
       }
       public customer(int customerid)
       {
        
           this.customerid = customerid;
           Console.WriteLine("existing ");

       }
        public string customerFullname()
        {
            return customerFname + " " + customerLname;
        }
        public int balance()
        {
            return accountbalance;
        }
        public bool updatename(int customerid, string customerFname, string customerLname)
        {

            if (this.customerid == customerid)
            {
                this.customerFname = customerFname;
                this.customerLname = customerLname;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
