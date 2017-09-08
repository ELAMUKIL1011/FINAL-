using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consoleoverrid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enteremployee details:");
            Console.WriteLine("enteremployee id:");
            
            int employeeid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enteremployee name:");
            string employeename = Console.ReadLine();
            Console.WriteLine("enteremployee salaryperday:");

            int employeesalaryperday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enteremployee no of work days:");

            int noofdays= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the employee type noraml / contract");
            string option = Console.ReadLine();
            employee obj=null;
            if (option == "normal")
            {
                 obj = new employee(employeeid, employeename, employeesalaryperday, noofdays);
            }
     
            else if (option == "contract")
            {
                 obj = new employee_contract(employeeid, employeename, employeesalaryperday, noofdays);
            }
            else {

                Console.WriteLine("not valid");
            }
            if (obj != null)
            {
                string details = obj.getdetails();
                Console.WriteLine(details);
                obj.getwork();
                int salary = obj.getsalary();
                Console.WriteLine(salary);
            }
            Console.ReadLine();
        
        
}
    }
}
