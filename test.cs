using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_event_delegationmodel
{
    class test
    {

        public delegate void del(string str); // publisher // delegate func
        public event del evt;// event func
        public void fire()//firing event
        {
            if (evt != null)
            {
                evt("hello from the event");

            
            }
        }
    
        public void event_handler(string str) //subscriber end 
        {

            Console.WriteLine("event handler " + str);
        }
        public void bind() //binding code
        {

            del obj = new del(this.event_handler);
            this.evt += obj;
        
        }

    }
}
