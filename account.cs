using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_abstractclass
{
   abstract class account
    {
       protected int accountid;
       protected int accountbalance;
       protected string customername;
       public account ( int accountid,
     int accountbalance,
        string customername)
   {
       this.accountid = accountid;
       this.accountbalance = accountbalance;
       this.customername = customername;
       Console.WriteLine("account class constructor called");
   
   }
       public int getbalance()
       {
           return this.accountbalance;
       }
       public void getstatements()
       {
           Console.WriteLine("accouunt status");
       }
       public void blockaccount()
       {
           Console.WriteLine("accouunt  blocked");
       }
       public abstract bool whithdraw(int amount); // abstract functionp
       public abstract bool deposit(int amoubt); //abstarct func
       public abstract bool stoppayment(string chequeno); //abstract func


    }
}
