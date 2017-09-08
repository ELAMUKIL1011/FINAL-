using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_interface
{
    class producta : iproducttransport
    {
        private int productid;
        private string customername;
        private string customeraddress;
        public producta(int productid, string customername, string customeraddress)
        {
            this.productid = productid;
            this.customername = customername;
            this.customeraddress = customeraddress;
        }
        public void start()
        {
            Console.WriteLine("start");
        }

        public void stop()
        {
            Console.WriteLine("stop");
        }

        public string getfromaddress()
        {
           return "company name ";
        }

        public string gettoaddress()
        {
         return this.customeraddress;
        }
    }

}
