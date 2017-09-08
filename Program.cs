using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the customer details:");
        
            Console.WriteLine("enter the customer first name :");
            string customerFname = Console.ReadLine();
            
            Console.WriteLine("enter the customer last name :");
            string customerLname = Console.ReadLine();

            Console.WriteLine("enter the customer Account id :");
             int accountid = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter the customer Id:");
             int customerid= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the customer Account balance:");
             int accountbalance = Convert.ToInt32(Console.ReadLine());
             customer obj = new customer(customerid,customerFname,customerLname,accountbalance,accountid);
        
            string Name=obj.customerFullname();
            Console.WriteLine("Customer Nmae :" + Name);
            int Balance = obj.balance();
            Console.WriteLine("Account Balance :" + Balance);
            Console.WriteLine("enter 1 to update or 0 to exit :");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("enter the customer id to update the name");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Customer first Nmae :");
                customerFname = Console.ReadLine();
                Console.WriteLine("Customer Last Nmae :");
                customerLname = Console.ReadLine();
                bool test = obj.updatename(id, customerFname, customerLname);
                if (test)
                {
                    Console.WriteLine("updated");

                    Console.WriteLine("thank u");

                }
                else
                {
                   
                    Console.WriteLine("Not updated");

                    Console.WriteLine("thank u");

                }

            }
            else
            {
                Console.WriteLine("thank u");
            }
            Console.ReadLine();

        }
    }
}
