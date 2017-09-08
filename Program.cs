using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[2];
            jaggedarray[1] = new int[3];
            jaggedarray[2] = new int[1];
            jaggedarray[0][0] = 25;
            jaggedarray[0][1] = 30;
            jaggedarray[1][0] = 12;

            jaggedarray[1][1] = 31;
            jaggedarray[1][2] = 55;
            jaggedarray[2][0] = 322;
            foreach (int[] array in jaggedarray)
            {
                foreach (int marks in array)
                {
                    Console.WriteLine(marks);
                }
            }
            Console.ReadLine();



        }
    }
}
