using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3._2
{
    class manager
    {
        private int managerid;
        private string managername;
        public int pmanagerid
        {
            get
            {
                return managerid;
            }
        }
        public string pmanagername
        {
            get
            {
                return managername;
            }
        }

        private manager()
        {
        }
        static manager m1;
        public static manager getobject()
        {
            if (m1 == null)
            {
                m1 = new manager();
                m1.managerid = 1;
                m1.managername = "Aishwarya";
                return manager.m1;
            }




            return manager.m1;



        }
    }
}
