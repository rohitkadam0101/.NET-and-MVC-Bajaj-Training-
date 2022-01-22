using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day8FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("E:/Bajaj/C#/fileHandling.txt");
            int i = sr.Peek(); // Reads only single char
            Console.WriteLine((char)i);
            int i = sr.Read();
            while (i != 'F')
            {
                Console.WriteLine((char)i);
                i = sr.Read();

            }

            Reading Line by Line
            while (sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
            }

            ReadToEnd without loops




            string data = sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();

            StreamWriter sw = new StreamWriter("E:/Bajaj/C#/fileHandling.txt");
            sw.Write("Adding data to file"); // will delete previous data
            sw.Flush();

            Binary Files

            FileStream fs = new FileStream("E:/Bajaj/C#/BinaryDataFile.txt",FileMode.OpenOrCreate,FileAccess.Write);
           BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(10);
            bw.Write('A');
            bw.Write(true);
            bw.Flush();
            bw.Close();

            FileStream fs1 = new FileStream("E:/Bajaj/C#/BinaryDataFile.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            int i = br.ReadInt32();
            char a = br.ReadChar();
            bool b = br.ReadBoolean();
            Console.WriteLine(i);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
