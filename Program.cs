using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment_day5
{
    class Program
    {
        static void Main(string[] args)
        {
            company com = new company("ÏNAUTIX ","ASCENDAS");
            int option;
            do{
               

            Console.WriteLine("enter your option 1.add employee 2.search employee 3.remove employee 4.show employee 5. to apply leave 6.to show my leave details 7.to show all leave details 8.exit ");
            option= Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                
                    case 1:
                        Console.WriteLine("enter employee name");
                          string employeename= Console.ReadLine();
                        Console.WriteLine("enter employee city");
                        string employeecity =Console.ReadLine();
                        employee emp= new employee(employeename,employeecity);
                        if( com.addemployee(emp))
                        {
                        Console.WriteLine("employee added sucessfully");
                            Console.WriteLine("employee id  :"+ emp.pemployeeid);
                        
                        }
                        else
                        {
                        Console.WriteLine("employee not added ");
                        
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter employee id ");
                        int employeeid= Convert.ToInt32(Console.ReadLine());
                        employee empfound =com.searchemployee(employeeid);
                        if (empfound!=null)
                        {
                            Console.WriteLine("employee found");
                       Console.WriteLine( empfound.getdetails());

                        
                        }
                        else
                        {
                        Console.WriteLine("employee not found");
                        
                        }
                        break;
                    case 3:
                        Console.WriteLine("enter employee id to be removed ");
                        int employeeidremove=Convert.ToInt32(Console.ReadLine());
                        bool emprem = com.removeemployee(employeeidremove);
                        if (emprem)
                        {
                        Console.WriteLine("employee removed");
                        }
                        else{
                        Console.WriteLine("employee not removed ");
                        }
                             break;  
                    case 4:
                        com.showemployee();
                        break;

                    case 5:
                        Console.WriteLine("enter the employee id");
                        int employeeidleave = Convert.ToInt32(Console.ReadLine());
                          employee obj_employee = com.searchemployee(employeeidleave);
                          if (obj_employee != null)
                          {

                              Console.WriteLine("enter the reason");
                              string reason = Console.ReadLine();
                              obj_employee.takeleave(reason);
                          }
                          else
                          {
                              Console.WriteLine("employee not found");
                          }

                        break;
                    case 6:
                        Console.WriteLine("enter your employee id");
                        int showempid = Convert.ToInt32(Console.ReadLine());
                        employee obj_employeemy = com.searchemployee(showempid);
                        if (obj_employeemy != null)
                        {
                            com.showmyleave(showempid);
                        }
                        else
                        {
                            Console.WriteLine("ïd not found");
                        
                        }
                        break;
                    case 7:
                        Console.WriteLine("employee leave details");
                        com.approval();
                        com.showallleave();
                        break;
                        
                      
                    

                    default:
                        Console.WriteLine     ("thankyou");
                        break;
                
                }
            }while(option!=8);

        }
    }
}
