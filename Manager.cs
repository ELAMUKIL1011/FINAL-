using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Manager
    {
        public void getemployee(IManagerEmp Man)
        {
            int employeeid = Man.GetEmployeeId();
            int employeeexp = Man.GetEmployeeExperience();
            string projectdetails = Man.GetEmployeeProjDetails();
            Console.WriteLine("employee id " + employeeid+ "  employeeexperience " + employeeexp
                + "employee project details  " + projectdetails);
        }
    }
}
