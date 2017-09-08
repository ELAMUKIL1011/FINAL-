using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_abstractclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the customer details");
            Console.WriteLine("enter the account id");
            int accountid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the account balance");
            int accountbalance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter customer name");
            String customername = Console.ReadLine();
            Console.WriteLine("enter account type");
            string Accounttype = Console.ReadLine();
           account obj=null;
           switch (Accounttype)
           {
               case "savings":
                   obj = new savings(accountid, accountbalance, customername);
                   break;
               case "current":
                   obj = new current(accountid, accountbalance, customername);
                   break;
               case "salary":
                   obj = new salary(accountid, accountbalance, customername);
                   break;
               default:
                   Console.WriteLine("enter correctt type");
                   break;
           }
           if (obj != null)
           {    
               int balance = obj.getbalance();
               Console.WriteLine("account balance" + balance);
               Console.WriteLine("enter the amt to withdrawn");
               int amount = Convert.ToInt32(Console.ReadLine());
               obj.whithdraw(amount);
               balance = obj.getbalance();
               Console.WriteLine("account balance" + balance);
               Console.WriteLine("enter the amt to deposit");
               int amoubt = Convert.ToInt32(Console.ReadLine());
               obj.deposit(amoubt);
               balance = obj.getbalance();
               Console.WriteLine("Account balance: " + balance);
               Console.WriteLine("enter the chequeno to stop transcation");
               string chequeno = Console.ReadLine();
               obj.stoppayment(chequeno);
           }
           Console.ReadLine();    




        }
    }
}
