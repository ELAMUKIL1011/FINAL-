using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_event_delegationmodel
{
    class Program
    {
        static void Main(string[] args)
        {

            test t = new test();
            t.bind();
            t.fire();
            Console.ReadLine();


        }
    }
}
