using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter customer details");
            Console.WriteLine("ennter id");
            int customerid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ennter NAME");
            String customername = Console.ReadLine();
            Console.WriteLine("enter contact number");
            string contactnumber=Console.ReadLine();
            Console.WriteLine("enter contact mail");
            string customeremail = Console.ReadLine();
            Console.WriteLine("are you normal or special");
            string type = Console.ReadLine();
            if (type == "special")
            {
                Console.WriteLine("enter payment type");
                string paymenttype = Console.ReadLine();
                Console.WriteLine("enter the deliveryaddress");
                string deliveryaddress = Console.ReadLine();
                customerspecial obj1 = new customerspecial(customerid, customername, contactnumber, customeremail, paymenttype, deliveryaddress);
                string namespecial = obj1.getdetail();
                Console.WriteLine(namespecial);
                string customerspecial = obj1.getpaymentaandaddress();
                Console.WriteLine(customerspecial);
            }
            else
            {
                customer obj = new customer(customerid, customername, contactnumber, customeremail);
                string name = obj.getdetail();
                Console.WriteLine(name);
            }
            Console.ReadLine();



         
        }
    }
}
