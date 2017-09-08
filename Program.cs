using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; // for colelctions ARRAYLIST

namespace Console_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> markskeyvalues = new Dictionary<string, int>();
            markskeyvalues.Add("a1", 10);
            markskeyvalues.Add("a2", 20); // key must be unique
            markskeyvalues.Add("a3", 30);

            int marks1 = markskeyvalues["a2"]; //addressing through key


            Console.WriteLine(marks1);


            List<int> list_marks = new List<int>();

            int m1 = 10;
            int m2 = 10;
            list_marks.Add(m1);
            list_marks.Add(m2);
            int x1 = list_marks[0];
            Console.WriteLine(x1);
            for (int i = 0; i < list_marks.Count; i++)
            {

                int x2 = list_marks[i];
                Console.WriteLine(x2);
            }

            foreach (int m in list_marks)
            {
                Console.WriteLine(m);
            
            }




            List<string> list_names = new List<string>();










          /*  ArrayList list_marks = new ArrayList();
            int m1 = 52; // PLACED INSTACK
            int m2 = 22; // PLACED IN STCAK
            list_marks.Add ( m1); // index is 0
            list_marks.Add(m2); // index is 1
            list_marks.Add(44);// index is 2   // BOXING
            list_marks.Remove(m1); // reoves m1 and updates the array now 0 index is 22
            bool status1 = true;
            bool status2 = false;
            Console.WriteLine("count is " + list_marks.Count);
            list_marks.Add(status1);
            list_marks.Add(status2);
            list_marks.Add("hello");
            Console.WriteLine("count is " + list_marks.Count);

            int x1 =Convert.ToInt32( list_marks[0]); // this is not an array its a collection shoeing 0 as its index
             // UNBOXINH
            Console.WriteLine("colection" + x1); 











            test<int> obj = new test<int>(); 
            int tt =obj.getdata(100); // normal func
            int t = obj.Genericfun<int>(100);
            string s = obj.Genericfun<string>("abc");
            Console.WriteLine(t + " " + s + " "+tt); */
            Console.ReadLine();

        }
    }
}
