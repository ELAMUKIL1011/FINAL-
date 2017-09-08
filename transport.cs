using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_interface
{
    class transport
    {
        public void getproduct(iproducttransport product)
        {
            string fromaddress = product.getfromaddress(); ;
            string toaddress = product.gettoaddress();
            Console.WriteLine("from address :"+fromaddress);
            Console.WriteLine(" to address" +toaddress);

        }
    }
}
