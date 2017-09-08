using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_inheritance
{
    class customerspecial : customer
    {
        protected string paymenttype;
        protected string deliveryadd;
        public customerspecial(int customerid, string customername, string contactnumber,
            string customeremail, string paymenttype, string deliveryadd) : base(customerid,customername,contactnumber,customeremail)

        {
            this.paymenttype = paymenttype;
            this.deliveryadd = deliveryadd;
            Console.WriteLine("derived object creared");
        }
        public string getpaymentaandaddress()
        {
            return paymenttype + " " + deliveryadd;

        }
    }
}
