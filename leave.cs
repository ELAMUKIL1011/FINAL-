using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_day5
{
    class leave
    {
        private int employeeid;
      private int leaveid;
        private static int count;
       private string reason;
        private DateTime date;
        private bool status = false;

        

        
        public  leave(int employeeid, string reason)
        {
            count++;
            this.employeeid = employeeid;
            this.reason = reason;
          
            this.leaveid = count;


        }
        public int pemployeeid
        {

            get {

                return this.employeeid;
            
            }

        
        }
        public string pemployeereason
        {

            get
            {

                return this.reason;

            }


        }
        public int pleaveid
        {

            get
            {

                return this.leaveid;

            }


        }
        public bool pstatus
        {

            get
            {

                return this.status;

            }
            set {
                status = value;
            
            }


        }

        public void getdetails()
        {

            Console.WriteLine(this.employeeid + " " + this.leaveid + " " + this.reason+" "+this.status);
        
        }
      
    }
}
