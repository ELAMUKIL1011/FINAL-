using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HR hr = new HR();
            Account ac = new Account();
            Manager ma = new Manager();
            Employee e = new Employee(123,"aish","pune","kk nagar ",20000,".net ",2,123654789,"hdfc",21);
            hr.getemployee(e);
            ac.getemployee(e);
            ma.getemployee(e);

            Console.ReadLine();
        }
    }
}
