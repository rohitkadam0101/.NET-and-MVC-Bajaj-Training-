using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dll file 
namespace AccessSpecifierLab
{
    public class Details
    {
        public void enterInputs(int principal,int rate, int time)
        {
            int simpleIntrest = principal * rate * time / 100;
            Console.WriteLine("Simple Intrest = "+ simpleIntrest);
            printDate();
        }
        internal void printDate()
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}
