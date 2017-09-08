using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_day5
{
    class employee
    {
        public delegate void del_leave(leave leave);
        public event del_leave evt_leave;
        public void takeleave(string reason)
        {


            if (evt_leave != null)
            {

                leave l = new leave(this.employeeid, reason);
                evt_leave(l);
                Console.WriteLine(l.pleaveid);
               
            
            
            }
        
        
        }

          string employeename;
        int employeeid;
        string employeecity;
      private static  int count;
        public employee(string employeename, string employeecity)
        {
            this.employeename = employeename;
            count++;
            this.employeeid = count;
            this.employeecity = employeecity;
        
        }



        public string pemployeename
        {
            get {
                return employeename;
            }
            
        }
                public int pemployeeid
        {
            get {
                return employeeid;
            
            }
                }

                    public string pemployeecity
        {
            get {
                return employeecity;
            
            }

                    }


                    public string getdetails()
                    {

                        return this.employeename + " " + this.employeecity;
                    
                    }


                  

        }
    }

