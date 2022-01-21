using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Struct
{
    class Program {
        struct Date
        {
            public int day;
            public int month;
            public int year;
            public void printDate()
            {
                Console.WriteLine(day);
                Console.WriteLine(month);
                Console.WriteLine(year);
            }
        }
        struct salary
        {
            public int basic, da, hra, pf, gross, net;
        public void PrintSalary(salary s1)
        {
            Console.WriteLine(s1.basic);
            Console.WriteLine(s1.da);
            Console.WriteLine(s1.gross);
            Console.WriteLine(s1.net);
            Console.WriteLine(s1.hra);
            Console.WriteLine(s1.pf);
            
        }
    }
    static void Main(String[] args)
        {
            Console.WriteLine("Hello from struct");
            Date d = new Date(); // New keyword assigns memory in heap and initialize to 0
            d.day = 1;
            d.month = 4;
            d.year = 2004;
            d.printDate();

            // Accesing salary struct 
            salary s1;
            s1.basic = 10;
            s1.gross = 100;
            s1.net = 120;
            s1.da = 20;
            s1.hra = 30;
            s1.pf = 50;
            



            s1.PrintSalary(s1);
            Console.ReadLine();
        }
    }
}

