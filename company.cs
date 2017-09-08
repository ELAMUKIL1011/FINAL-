using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_day5
{
    class company
    {
        List<leave> list_leave = new List<leave>();
        public void leavenotify(leave leave)
        {

            Console.WriteLine("---------------employee details -------------");
            Console.WriteLine("employee id " +leave. pemployeeid);
            Console.WriteLine("reason" + leave.pemployeereason);
            Console.WriteLine(" leave id" + leave.pleaveid);
            list_leave.Add(leave);
        
        }

        public void showallleave()
        {
            foreach (leave l in list_leave)
            {
                l.getdetails();
            
            }
        
        
        }
        public void showmyleave(int employeeid)
        {
            foreach (leave l in list_leave)
            {
                if (l.pemployeeid == employeeid)
                {


                    l.getdetails();
                }

            }


        }


        public void approval()
        {
            foreach (leave l in list_leave)
            {
                l.pstatus = true;
            }
        
        
        }


        int leaveid;
        private static int leavecount;

        private string companyname;
        private string companyaddress;
        List<employee> list_employee = new List<employee>();
      
        public company(string companyname, string companyaddress)
        {
            this.companyaddress = companyaddress;
            this.companyname = companyname;
        
        }

        public string getcompanydetails()
        {
            return this.companyname + "  " + this.companyaddress;
        
        }

        public bool addemployee(employee emp)
        {

            if (emp != null)


            {
                employee.del_leave delobj = new employee.del_leave(this.leavenotify);

                emp.evt_leave += delobj;




                list_employee.Add(emp);
                
                return true;
            }
            else {

               
                   
            return false;
            }
        
        
        }


        public employee searchemployee( int employeeid)
        {
            foreach (employee emp in list_employee)
            {
                if (emp.pemployeeid == employeeid)
                {
                    return emp;

                }
            
            
            }
            return null;
        
        }

        public bool removeemployee(int employeeid)
        {

            foreach (employee emp in list_employee)
            {
                if (emp.pemployeeid == employeeid)
                {

                    list_employee.Remove(emp);

                    Console.WriteLine(" employee removed sucessfully");
                    return true;
                }
            
            }
            return false;
        
        }

        public void showemployee()
        {

            foreach (employee emp in list_employee)
            {
                
               Console.WriteLine(emp.getdetails());
                 }

        
        }


        

    }
}
