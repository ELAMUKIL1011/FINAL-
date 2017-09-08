using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop3
{
    class employee
    {
        public int Employee_id;
        public static int count;
        public project empproject;
        static employee()
        {
            count = 5;
        }
        public void setproject(project p)
        {
            empproject = p;
        }


        public void update()
        {
            employee.count++;

        }
        public static int getdata()  // in this function we cannot use employee id directly
        {
            return 100;
        }
     
    }
}
