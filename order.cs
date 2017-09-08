using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_windows_day5
{
    class order
    {
         int orderid;
        static int count;
        int ordervalue;
        private int itemquantity;
        private int itemprice;
        private string itemname;
        private string customername;
        private string paymentoption;
        private string ordercity;
        private string address;

       

        public order(int itemquantity, int itemprice,string customername,string ordercity,string address,string paymentoption,string itemname)
        {
            this.itemprice = itemprice;
            this.itemquantity = itemquantity;
            count++;
            this.orderid = count;
            this.itemname=itemname;
            this.ordercity=ordercity;
            this.customername=customername;
            this.paymentoption=paymentoption;
            this.address = address;
           
         
        
        }
        public int porderid
        {
            get
            {

                return this.orderid;
            
            }
        
        }




        public int pitemquantity
        {

            get {

                return itemquantity;
            }
        
        }
        public int pitemprice
        {

            get
            {

                return itemprice;
            }

        }
        public string pcustomername
        {
            get {
                return customername;

            
            }
        
        }

        public string pitemname
        {

            get {

                return itemname;
            }
        
        }
        public string pordercity
        {
            get {

                return ordercity;
            }
        
        }
        public string paddress
        {
            get
            {

                return address;
            }

        }

        public string ppaymentoption
        {

            get {

                return paymentoption;
            }
        }

        public int getordervalue()
        {
            ordervalue = itemquantity * itemprice;
            return ordervalue;
        }
        



    }
}
