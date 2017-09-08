using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop_gc
{
    class employee  :IDisposable
    {

        public void Dispose()
        {
            Console.WriteLine("dispose");
            //database.close()
            //file.close()
        }
    }
}
