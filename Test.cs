using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_oop2
{
   class Test
    {
        private string customername;
        private int customerid;
        public Test(int customerid, string customername)
        {
            this.customerid = customerid;
            this.customername = customername;

        
        
        }
        public Customernameupdatestatus update(int customerid, string customernewname)
        {
            if (this.customerid == customerid)
            {
                if (customernewname != "")
                {
                    this.customername = customernewname;
                    return Customernameupdatestatus.Updated;
                }
                else
                {
                    return Customernameupdatestatus.invalidname;
                }

            }
            else
            {
                return Customernameupdatestatus.Invalidcustomerid;
            }
        }
        public int getsalary(int perdayssalary, int no = 30)
        {
            int total = perdayssalary * no;
            return total;
        }
    }

    }

