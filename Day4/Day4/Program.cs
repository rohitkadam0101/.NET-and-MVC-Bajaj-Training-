using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Calculator
    {
        int first;
        int second;
        public Calculator() // Non Parameterized Constructor
        {
            first = 0;
            second = 1;
        }
        public Calculator(int x,int y) // Parameterized Constructor
        {
            first = x;
            second = y;
        }

        public void printValues()
        {
            Console.WriteLine("First = " + first);
            Console.WriteLine("Second = " + second);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Calculator c = new Calculator(5,7);
                c.printValues();
            Console.ReadLine(); 
        }
    }
}
