using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_interface
{
    class Program
    {
        static void Main(string[] args)
        {
        

            producta obja = new producta(1001, "asd", "chennai");
            productb objb = new productb(1001, 111, "dsa", "mad");
            transport tran = new transport();
            iproducttransport p1= obja;
             iproducttransport p2 = objb;
           
            tran.getproduct(p1); // iproducttransport p1= obja;
            tran.getproduct(p2); // iproducttransport p1 = obja;
            Console.ReadLine();
        }
    }
}
