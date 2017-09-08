using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consoleoverrid
{
    class employee
    {
        protected int employeeid;
        protected string employeename;
        protected int employeeperdaysalary;
        protected int noofdays;
        public employee(int employeeid, string employeename, int employeeperdaysalary, int noofdays)
        {
            this.employeeid = employeeid;
            this.employeename = employeename;
            this.employeeperdaysalary = employeeperdaysalary;
            this.noofdays = noofdays;
        }
        public string getdetails()
        {
            return this.employeeid + " " + this.employeename;
        }
        public void getwork()
        {
            Console.WriteLine("work called");
        }

        public virtual int getsalary() //giving permission to override so virtual key word
        {
            int bonus = 5000;
            int pf = 2000;
            return (noofdays * employeeperdaysalary) + bonus - pf;
        }

    }
}
