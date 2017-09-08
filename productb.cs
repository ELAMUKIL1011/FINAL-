using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_interface
{
    class productb: iproducttransport
    {
        private int productid;
        private int productprice;
        private string customername;
        private string deliveryaddress;
        public productb(int productid, int productprice, string customername, string deliveryaddress)
        {


            this.productid = productid;
            this.productprice = productprice;
            this.customername = customername;
            this.deliveryaddress = deliveryaddress;

        }
        public string getdetails()
        {
            return this.productid + " " + this.productprice;

        }

        public string getfromaddress()
        {
          return "company name";
        }

        public string gettoaddress()
        {
            return this.deliveryaddress;
        }
    }
}
