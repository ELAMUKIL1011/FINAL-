using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Account 
    {
        public void getemployee(IAccountEMP ACC)
        {

            int employeesalary = ACC.GetEmployeeSalary();
            int employeeaccno = ACC.GetEmployeeAccno();
            int employeeid = ACC.GetEmployeeId();
            Console.WriteLine("employee account num " + employeeaccno + "  employeesalary " + employeesalary
                + "employee id  " + employeeid);
        }
    }
}
