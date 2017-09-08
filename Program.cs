using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_gc
{
    class Program
    {
        static void Main(string[] args)
        {
            employee obj 





            using (employee obj = new employee())
            {

                IDisposable d = obj; //using internally do the folowing two line 
                d.Dispose();
            }
         /*   int i = 0;
            while (i < 5)
            {
                test obj = new test();
                if (i == 3)
                {
                    GC.SuppressFinalize(obj); 
                }
                obj = null;
                i++;

            
            }
            GC.Collect(); // destructor called */
            Console.ReadLine();
        }
    }
}
