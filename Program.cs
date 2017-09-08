using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop3
{        
    class Program
    {
        static employee empobj = new employee(); //static is empobj variable (an instance) size foe emp obj os used to store pointer is 2 bytes //high frequrncy heap 
        static void Main(string[] args)
        {
            project p = new project();
            employee.count = 10;
            Console.WriteLine(employee.count);
            employee obj = new employee();
            obj.Employee_id = 1001;
            obj.update();
            obj.update();
            Console.WriteLine(employee.count);

            employee.count = 100;
            Console.WriteLine(employee.count);
           int i= employee.getdata();
           Console.WriteLine(i);
           obj.update();
           obj.update();
           obj.setproject(p);
           employee obj2 = new employee();
           p = null; // its not a memory leakage
           obj = null; //memory leakage 
           obj2 = null;//memory leakage 
           
            Console.ReadLine();
        }
    }
}
