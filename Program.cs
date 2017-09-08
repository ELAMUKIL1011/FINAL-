using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console_csharp_builtinfun
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char ch = 'A';
            int num = Convert.ToInt32(ch);
            Console.WriteLine(num);
            num+=32;
            Console.WriteLine(Convert.ToChar(num)); */

            string Str1 = "abcd";
           Console.WriteLine(Str1.ToUpper());

           /* string str = "Hello world";
            int Cu=0;
            int Cl=0;
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    Cu++;
                }
                else if (char.IsLower(c))
                {
                    Cl++;
                }
                Console.WriteLine(c);

            }
            Console.WriteLine(Cu );
            Console.WriteLine(Cl); */

         /*   string str = "89 61 62 90 64";
            string[] str_array =str.Split(' ');
            int[] marks =Array.ConvertAll(str_array,int.Parse);
            Array.Sort(marks);
            Array.Reverse(marks);
            foreach (int m in marks)
            {
                Console.WriteLine(m);
            } */
            Console.ReadLine();
        }
    }
}
