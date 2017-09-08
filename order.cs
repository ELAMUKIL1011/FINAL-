using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_3._1
{
    class order
    {
        private  int orderid;
        private static int customercount;
        public static int pcustomercount
        {
            get
            {
                return customercount;
            }
        }

        private int itemid;
        private int itemqty;
        private int itemprice;
        private static int count;
        private string customername;
        private static string customernamecheck="";
        public int porderid
        {
            get
            {
                return orderid;
            }
        }
        public int pordervalue
        {
            get
            {
                return itemprice * itemqty;
            }
        }
        public order(int itemid, int itemqty, int itemprice, string customername)
        {
            count++;
            
            this.orderid = count;
            this.itemid = itemid;
            this.itemqty = itemqty;
            this.itemprice = itemprice;
            this.customername = customername;
            if (customernamecheck != customername)
            {
                customernamecheck = customername;
                customercount = 1;
            }
            else
            {
                customercount++;
            }


         //   Console.WriteLine("caled constructor");
        }
        public static  int GetTotalOrderCount()
        {
            //Console.WriteLine("before" + orderid);
           
            // Console.WriteLine("before" + orderid);
             return count;
        }

    }
}
