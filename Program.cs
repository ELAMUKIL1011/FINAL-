using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            manager m1 = manager.getobject();
            manager m2 = manager.getobject();
            if (m1 == m2)
            {
                Console.WriteLine("singleton");
            }
            Console.ReadLine();

        }
    }
}
