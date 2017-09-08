using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_delegate
{
    class test
    {
        public delegate void del(string str);
        public delegate void del1(int i);
        public delegate void delgeneric<t>(t str); // delegate generics 

        public void getdata(string msg)
        {

            Console.WriteLine("getdata" + msg);
        
        }

        public void setdata(string str)
    {
    Console.WriteLine("set data "+str);
    }


        public void run()
        {
            int x = 100;
            del obj = new del(this.getdata);
            obj += new del(this.setdata);// adding address
            //obj -= new del(this.setdata); // removing address
            obj += delegate(string str)
            {

                Console.WriteLine("anonymous func  " + str  + "  "+ x);

            };
            obj += new del((s) => Console.WriteLine("lambda expression " + s));
            obj += new del((s) =>
            {
                Console.WriteLine("lambda expression ");
                Console.WriteLine("with multiple line " + s);
            });
                
                
                
            obj("hello"); // calls getdata  // single cast (one address only)


        
        }
    }
}
