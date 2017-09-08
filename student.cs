using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_generic_student
{
    class student
    {
        public delegate void del_leave(int studentid, string reason);
        public event del_leave evt_leave;
        public void take_leave(string reason)
        
        {
            if (evt_leave != null)
            {
                evt_leave(this.studentid, reason);
                Console.WriteLine("event fired");
            
            
            }
        
        
        
        }




        private static int count;
        private int studentid;
        private string studentname;
        private string studentcity;
        private string studentgender;
        public student(string studentname, string studentcity, string studentgender)
        {
            this.studentcity = studentcity;
            this.studentgender = studentgender;
            this.studentname = studentname;

            count++;

            this.studentid = count;


        }
        public string getdetails()
        {


            return this.studentid + " " + this.studentname + " " + this.studentcity + " " + this.studentgender;

        
        }

        public int pstudentid
    {
        get {
            return this.studentid;
        
        }
    }
        public string pstudentname
        {
            get
            {
                return this.studentname;

            }
        }
        public string pstudentcity
        {
            get
            {
                return this.studentcity;

            }
        }
        public string pstudentgender
        {
            get
            {
                return this.studentgender;

            }
        }




    }
}
