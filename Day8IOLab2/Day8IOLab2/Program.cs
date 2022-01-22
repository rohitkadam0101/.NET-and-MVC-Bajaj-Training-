using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day8IOLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 to see file exists or not Enter 2 to copy Enter 3 to rename");
            int user_input = Convert.ToInt32(Console.ReadLine());
            if (user_input == 1)
            {
                Console.WriteLine("Enter File Path");
                string file_path = Console.ReadLine();
                if (File.Exists(file_path)){
                    Console.WriteLine("File Exists");
                }
                else
                {
                    Console.WriteLine("Sorry File Not Found");
                }
            }
            else if(user_input == 2)
            {
                Console.WriteLine("Enter Source File Path");
                string source_path = Console.ReadLine();
                Console.WriteLine("Enter Destination File Path");
                string destination_path  = Console.ReadLine();
                File.Copy(source_path, destination_path, true);
            }
            else if(user_input == 3)
            {
                Console.WriteLine("Enter Source File Path");
                string source_path = Console.ReadLine();
                if (File.Exists(source_path))
                {
                    Console.WriteLine("Enter Destination");
                    string destination_path = Console.ReadLine();
                    File.Move(source_path, destination_path);
                    Console.WriteLine("File Renamed");
                }

            }
            Console.ReadKey();
        }

    }
}
