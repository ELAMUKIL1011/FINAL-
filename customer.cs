using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_inheritance
{
    class customer
    {
       protected int customerid;
      protected string customername; // deeriving so protected 
        protected string contactnumber;
        protected string customeremail;
      
        public customer(int customerid,string customername,string contactnumber, string customeremail)
        {
            this.customerid = customerid;
            this.customername = customername;
            this.contactnumber = contactnumber;
            this.customeremail = customeremail;
           Console.WriteLine("customer object creared");
        }
        public string getdetail()
        {
            return this.customerid + " " + this.customername + " " + this.customeremail + " " + this.contactnumber;

        }
    }
}