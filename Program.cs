using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_generic_student
{
    class Program
    {
        static void Main(string[] args)
        {
            college collegeobj = new college("inautix", "chenai");
            Console.WriteLine(collegeobj.getcollegedetails());
            Console.WriteLine("1. add student  2.find student 3.remove student 4.showstudent 5.showcount  6.exit 7.request a leave");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("enter option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        Console.WriteLine("enter student name");
                        string studentname = Console.ReadLine();
                        Console.WriteLine("enter student gender");
                        string studentgender = Console.ReadLine();

                        Console.WriteLine("enter student city");
                        string studentcity = Console.ReadLine();
                        student stuobj = new student(studentname, studentcity, studentgender);
                        if (collegeobj.addstudent(stuobj))
                        {
                            Console.WriteLine("student sucessfully added");
                            Console.WriteLine("student id " + stuobj.pstudentid);

                        }
                        else
                        {
                            Console.WriteLine("student not addded");
                        }
                        break;
                    case 2:

                        Console.WriteLine("enter student id");
                        int studentid = Convert.ToInt32(Console.ReadLine());
                        student foundobj = collegeobj.findstudent(studentid);
                        if (foundobj != null)
                        {
                            Console.WriteLine("found details " + foundobj.getdetails());

                        }
                        else
                        {
                            Console.WriteLine("student not found");

                        }
                        break;
                    case 3:
                        Console.WriteLine("enter student id to remove");
                        int remstuid = Convert.ToInt32(Console.ReadLine());
                        bool remobj = collegeobj.removestudent(remstuid);
                        if (remobj == true)
                        {
                            Console.WriteLine("student removed ");

                        }
                        else
                        {
                            Console.WriteLine("student not found");

                        }
                        break;
                    case 4:
                        collegeobj.showstudents();
                        break;

                    case 5:
                        int count = collegeobj.gettotalstuden();
                        Console.WriteLine("total count " + count);
                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("thank you");

                        break;


                    case 7:
                        Console.WriteLine("enter student id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        student obj_student = collegeobj.findstudent(id);
                        if (obj_student != null)
                        {

                            Console.WriteLine("enter the reason");
                            string reason = Console.ReadLine();
                            obj_student.take_leave(reason);
                        }
                        else
                        {
                            Console.WriteLine("student id incorrect");
                        
                        }
                        break;
                    default:
                        Console.WriteLine("enter the correct option");
                        break;
                }




            }


            Console.ReadLine();

        }

    }
}
