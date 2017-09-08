using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_bank_system
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int x = Console.Read();
            Console.WriteLine(x); */

            int accountid;
            string customername;
            string customeraddress;
            DateTime customerdob;
            string accounttype;
            double accountbalance;
            Console.WriteLine("enter the Account id");
            accountid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            customername=Console.ReadLine();
            customername=customername.ToUpper();
            Console.WriteLine("Enter Address: ");
            
            customeraddress = Console.ReadLine();
            Console.WriteLine("Enter DOB(mm/dd/yyyy: ");
            
            customerdob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter type: ");
            
            accounttype = Console.ReadLine();
            Console.WriteLine("Enter AccountBalance: ");
            
            accountbalance = Convert.ToDouble(Console.ReadLine());
            int option;
            do
            {
                Console.WriteLine("enter an option: 1. deposit  2.withdrawal 3. check balance 4. customer detail 5. exit ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter the amount to be deposited");
                        int depamt = Convert.ToInt32(Console.ReadLine());
                        if (depamt < 500)
                        {
                            Console.WriteLine("Please deposit a amount greater than 500");
                        }
                        else
                        {
                            accountbalance = accountbalance + depamt;
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter the amount to be withdrawn");
                        int withdrawnamt = Convert.ToInt32(Console.ReadLine());
                        if (withdrawnamt > 5000 || accountbalance < withdrawnamt)
                        {
                            Console.WriteLine("Amount cannot be withdrawn");
                        }
                        else
                        {
                            accountbalance = accountbalance - withdrawnamt;
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("Account Balance : " + accountbalance);
                        break;
                    case 4:
                        Console.WriteLine("Customer Details :");
                        Console.WriteLine("Customer Name :" + customername);
                        Console.WriteLine("Customer Address :" + customeraddress);
                        TimeSpan t = DateTime.Now - customerdob;
                        int age = Convert.ToInt32(t.TotalDays / 365);
                        Console.WriteLine("Customer Age :" + age);
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                }


            } while (option != 5);
            Console.ReadLine();
        }
        
        }
    }

