using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class HR 
        
    {
        public void getemployee(IHRemployee HR1)
        {
            string employeeaddress = HR1.GetEmployeeAddress();
            int employeesalary = HR1.GetEmployeeSalary();
            int employeeid = HR1.GetEmployeeId();

            Console.WriteLine("employee address " + employeeaddress + "  employeesalary " + employeesalary
                + "employee id  " + employeeid);
        }


      
    }
}
