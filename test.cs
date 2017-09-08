using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_gc
{
    class test
    {
        public test()
        {
            Console.WriteLine("object creatd");
        }
        ~test() //destructor no parameter // finalize
        {
            Console.WriteLine("object destroyed");
        }
    }
}
