using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consoleoverrid
{
    class employee_contract :employee
    {
        public employee_contract(int employeeid,string employeename,int employeeperdaysalary,int noofdays):base(employeeid,employeename,employeeperdaysalary,noofdays)
        {
            Console.WriteLine(" called");
        }
        public override int getsalary() //being overided from ome othr class so given overruide 
        {
            return (employeeperdaysalary * noofdays);
        }
    }
}
