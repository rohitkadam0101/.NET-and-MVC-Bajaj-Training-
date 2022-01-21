using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day6
{
    class Calculation
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void divide(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot Divide by Zero");
                
            }
            

        }
        public int mul(int a,int b)
        {
            return a * b;
        }
    }
    // Custom Exception
    class AgeException : SystemException
    {
        public AgeException(int age) : base("invalid age " + age)
        {

        }
    }

    class Candidate
    {
        public void checkAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException(15);
            }
            else
            {
                Console.WriteLine("you are eligible");
            }
        }
        internal class Program
        {
            public static void readFromFile(String fileName)
            {
                StreamReader reader = null;
                try
                {
                    reader = new StreamReader(fileName);
                    string data = reader.ReadToEnd();
                    reader.Close();
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("File Handling Done");
                }
            }
            static void Main(string[] args)
            {
                Calculation calc = new Calculation();
                calc.add(4, 2);
                calc.sub(6, 5);
                calc.divide(12, 0);
                Candidate obj = new Candidate();
                try
                {
                    obj.checkAge(4);
                }
                catch (AgeException e)
                {
                    Console.WriteLine(e);
                }
                readFromFile("sdadadadd");

                Console.ReadLine();
            }
        }
    }
}
