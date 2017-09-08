using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
          string option1;  
            int customerordercount=0;
               int ordercount = 0;
               int ordervalue=0;
            do
            {
                Console.WriteLine("Cuustomer is there yes? else no");
                option1 = Console.ReadLine();
                if (option1 == "yes")
                {
                    string option;
                 
                    int itemid;
                    int itemqty;
                    int itemprice = 0;
                    string customername;


                    Console.WriteLine("enter the customer name");
                    customername = Console.ReadLine();
                    
                    do
                    {

                        Console.WriteLine("enter yes to order / no to exit");
                        option = Console.ReadLine();
                        if (option == "yes")
                        {

                            Console.WriteLine("enter the item to be purchased");
                            Console.WriteLine("1.phone,2.laptop,3.tab");
                            itemid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the number of items to be purchased");
                            itemqty = Convert.ToInt32(Console.ReadLine());

                            switch (itemid)
                            {
                                case 1:
                                    itemprice = 100;
                                    break;
                                case 2:
                                    itemprice = 200;
                                    break;
                                case 3:
                                    itemprice = 300;
                                    break;

                            }
                            // Console.WriteLine("your order id for the purchased");
                            order obj = new order(itemid, itemqty, itemprice, customername);
                            ordercount = order.GetTotalOrderCount();
                            ordervalue = obj.pordervalue;
                        }
                        else
                        {
                            Console.WriteLine("thank you !!!!Visit again");
                        }

                    } while (option!= "no");
                    Console.WriteLine("total Number of order you made");
                    Console.WriteLine("order count" +ordercount);
                    Console.WriteLine(ordervalue);
                    Console.WriteLine(order.pcustomercount);
        
                }
                else
                {
                    Console.WriteLine(" over");
                }

            } while (option1 != "no");
            Console.WriteLine("total orders made by all customers");
            Console.WriteLine(order.GetTotalOrderCount());
            Console.ReadLine();
        }
    }
}
