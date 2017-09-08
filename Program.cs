using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
         
        Console.WriteLine("Enter the customer details:");
            
        Console.WriteLine("Enter the customer id:");
            int account_id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the customer Name:");
            string customer_name = Console.ReadLine();

            Console.WriteLine("Enter the customer dob (mm/dd/yyyy):");
            DateTime customer_dob =Convert.ToDateTime(Console.ReadLine());
           
                Account obj = new Account(account_id,customer_name,customer_dob);

       
            int option;
            do
            {

                Console.WriteLine("Enter the option 1.getbalance 2.withdraw 3.deposit 4.customer details: 5.exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        double balance = obj.getbalance();
                        Console.WriteLine(" Available Balance:" + balance);
                        break;
                    case 2:

                        Console.WriteLine("Enter the amount to be withdrawn");
                        int amountw = Convert.ToInt32(Console.ReadLine());
                        bool resultw = obj.withdraw(amountw);
                        if (resultw)
                        {

                            Console.WriteLine(" Amount have been successfully withdrawn");
                        }
                        else
                        {

                            Console.WriteLine("Enter the correct amount to be withdrawn:");
                        }
                        break;

                    case 3:

                        Console.WriteLine("Enter the amount to be deposited");
                        int amountd = Convert.ToInt32(Console.ReadLine());
                        bool resultd = obj.deposit(amountd);
                        if (resultd)
                        {

                            Console.WriteLine(" Amount have been successfully deposited");
                        }
                        else
                        {

                            Console.WriteLine("Enter the correct amount to be deposit:");
                        }
                        break;
                    case 4:
                        Console.WriteLine(" Customer details:");
                        Console.WriteLine("Account id:" + obj.paccount_id);

                        Console.WriteLine("Customer name:" + obj.pcustomer_name);

                        Console.WriteLine("Customer DOB:" + obj.pcustomer_dob);
                        

                        Console.WriteLine("Account Balance:" + obj.paccount_balance);
                        break;
                    case 5:
                        Console.WriteLine("THANK YOU");
                        break;
                }
            } while (option != 5);
            Console.ReadLine();
         }
    }
}
