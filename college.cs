using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_generic_student
{
    class college
    {
        public void leavenotify(int studentid, string reason) // delegate subscriber side
        {
            Console.WriteLine("--------college-------------- ");
            Console.WriteLine("student request for leavenotify ");
            Console.WriteLine("studentid"+ studentid);
            Console.WriteLine("reason "+reason);
        }









        private string collegename;
        private string collegeaddress;
        private List<student> list_students = new List<student>();




        public college(string collegename, string collegeaddress)
        {

            this.collegeaddress = collegeaddress;
            this.collegename = collegename;
        
        }
        public string getcollegedetails()
        {

            return this.collegename + " " + this.collegeaddress;
        }
        public bool addstudent(student stdobj)
        {
            if (stdobj != null)
            {
                student.del_leave delobj = new student.del_leave(this.leavenotify);

                stdobj.evt_leave += delobj;



      
      list_students.Add(stdobj);
                return true;
            }
            else

            {

                return false;
            }
        }

        public bool removestudent(int studentid)
        {
            foreach (student st in list_students)
            {
                if (st.pstudentid == studentid)
                {
                    list_students.Remove(st);  
                    return true;
                }
               
            }
            return false;
        
        }
        public student findstudent(int studentid)
        {

            foreach (student st in list_students)
            {
                if (st.pstudentid == studentid)
                {
                    return st;
                }

            }
            return null;
        
        
        }

        public void showstudents()
        {
        
        foreach (student st in list_students)
        {
        Console.WriteLine(st.getdetails()); 
       
        }
        
        }


        public int gettotalstuden()
        {
            return list_students.Count;
        
        }




    }
}
