using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Main File
using AccessSpecifierLab;
namespace AccessSpecifierLabMainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.enterInputs(200, 2, 2);
            Console.ReadLine();
        }
    }
}
