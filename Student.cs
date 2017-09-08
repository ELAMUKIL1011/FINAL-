using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop2
{
    class Student
    {
        private int studentid;
        private string studentname;
        private int studentmarks;
        private bool studentstatus;
        public int Pstudentid
        {
            get
            {
                return studentid;
            }
        }
        public string Pstudentname
        {
            get
            {
                return studentname;
            }
            set
            {
                studentname = value;
            }
                    
        }
        public int Pstudentmarks
        {
            get
            {
                return studentmarks;
            }
            set
            {
                if (value > 100 || value < 0)
                {
                    studentmarks = 0;
                }
                else
                {
                    studentmarks = value;
                }
                if (studentmarks >= 50)
                {
                    studentstatus = true;

                }
                else
                {
                    studentstatus = false;
                }
            }
        }
        public bool Pstudentstatus
        {
            get
            {
                return studentstatus;
            }
        }
        public Student(int studentid, string studentname, int studentmarks)
        {
            this.studentid = studentid;
            this.studentname = studentname;
            this.studentmarks = studentmarks;
            if (this.studentmarks >= 50)
            {
                this.studentstatus = true;
            }
        }
    }

}
