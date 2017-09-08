using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1

{
    class Employee :IHRemployee,IAccountEMP,IManagerEmp

    {
        protected int employeeid;
        protected string employeename;
        protected string employeecity;
        protected string employeeaddress;
        protected int employeesalary;
        protected string employeeprojectdetails;
        protected int employeeexp;
        protected int employeeaccountno;
        protected string employeebankaccname;
        protected int employeeage;
        public Employee(int employeeid, string employeename, string employeecity, string employeeaddress, int employeesalary,
            string employeeprojectdetails, int employeeexp, int employeeaccountno, string employeebankaccname, int employeeage)
        {
            this.employeeid = employeeid;
            this.employeename = employeename;
            this.employeecity = employeecity;
            this.employeeaddress = employeeaddress;
            this.employeesalary = employeesalary;
            this.employeeprojectdetails = employeeprojectdetails;
            this.employeeexp = employeeexp;
            this.employeeaccountno = employeeaccountno;
            this.employeebankaccname = employeebankaccname;
            this.employeeage = employeeage;
        }


        public string GetEmployeeAddress()
        {
         return this.employeeaddress;
        }

        public int GetEmployeeSalary()
        {
            return this.employeesalary;

        }

        public int GetEmployeeId()
        {
            return this.employeeid;
        }


        public int GetEmployeeAccno()
        {  
            return this.employeeaccountno;
        }
        
        public int GetEmployeeExperience()
        {

            return this.employeeexp;
        }

        public string GetEmployeeProjDetails()
        {
            return this.employeeprojectdetails;
        }
    }
}
