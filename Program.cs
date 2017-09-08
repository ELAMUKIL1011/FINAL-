using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  string employeename;
            int employeesalary=0;
            string employeecity;
            DateTime employeedoj;
            int employeeexp = 0;
            Console.WriteLine("enter employee name");
            employeename = Console.ReadLine();
            Console.WriteLine("enter salary");
            employeesalary = Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine("enter employee city");
            employeecity = Console.ReadLine();
            Console.WriteLine("enter doj"); //mm/dd/yyy
            employeedoj=Convert.ToDateTime(Console.ReadLine());

            
            TimeSpan t = DateTime.Now - employeedoj;
            employeeexp = Convert.ToInt32(t.TotalDays / 365);
            Console.WriteLine("name :" + employeename);
            Console.WriteLine("salary:" + employeesalary);
            Console.WriteLine("city :" + employeecity);
            Console.WriteLine(DateTime.Now );
            Console.WriteLine("t :" + t);
            Console.WriteLine("doj :" + employeedoj.ToShortDateString());
            Console.WriteLine("exp:" + employeeexp); */
            int count = 50;
            if (count > 100)
            {
                Console.WriteLine(">100");
            }
            else
            {
                Console.WriteLine(false);
            }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine(c);
            }
            int option=1;
            switch (option)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 2:
                    Console.WriteLine("case 2");
                    break;

                default:
                    Console.WriteLine("default case");
                    break;
            }

            int[] marks = new int[5];
            marks[0] = 23;
            marks[1] = 45;
            marks[2] = 29;
            marks[3] = 90;
            marks[4] = 100;
          
            int[] salaries = { 1, 2, 3 };
            for (int j = 0; j < marks.Length; j++)
            {
                Console.WriteLine(marks[j]);
            }






            Console.ReadLine(); 

        }
    }
}
