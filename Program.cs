using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student(100, "vifhh", 60);
            Console.WriteLine(obj.Pstudentid);
            Console.WriteLine(obj.Pstudentname);
            Console.WriteLine(obj.Pstudentmarks);

            Console.WriteLine(obj.Pstudentstatus);
            obj.Pstudentname = Console.ReadLine()   ;
            obj.Pstudentmarks = 1000;
            Console.WriteLine(obj.Pstudentmarks);
            Console.WriteLine(obj.Pstudentstatus);
            Console.WriteLine(obj.Pstudentname);
            obj.Pstudentmarks = 75;
            Console.WriteLine(obj.Pstudentmarks);
            Console.WriteLine(obj.Pstudentstatus);






         /*   customer c = new customer();
            c.getdata();
            Test obj = new Test(1000,"abc");
            Customernameupdatestatus status = obj.update(100, "");
            if (status==Customernameupdatestatus.Updated)
            {
                Console.WriteLine("yes updated");
            }
           
else if(status==Customernameupdatestatus.invalidname)
            {
                Console.WriteLine("Customer name is invalid");

            }
            else if(status==Customernameupdatestatus.Invalidcustomerid)
            {
                Console.WriteLine(" customer id is invalid");
            }


            int salary = obj.getsalary(10000, 31); //normal way
            Console.WriteLine(salary);
            salary = obj.getsalary(10000); //oneoptional parameter 
            Console.WriteLine(salary);
            salary = obj.getsalary(no:31,perdayssalary: 10000); //named parameter 
            Console.WriteLine(salary);*/
            Console.ReadLine();


        }
    }
}
