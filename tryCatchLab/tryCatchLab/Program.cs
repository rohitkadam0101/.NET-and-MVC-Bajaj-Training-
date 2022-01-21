using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace tryCatchLab
{
    class LengthException : SystemException
    {
        public LengthException(string text):base(text + "check length of " + text){
        
        }
    }
        
     

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[2];
                for(int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Enter Element");
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Array Exception Done");

            }
            try
            {
                Console.WriteLine("Enter Username ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                if (username.Length < 10 && password.Length < 6)
                {
                    throw new LengthException("Password and Username");
                }
                else if (password.Length < 6)
                {
                    throw new LengthException("password");
                }
                else if (username.Length < 10)
                {
                    throw new LengthException("username");
                }
                else
                {
                    Console.WriteLine("Every thing is fine");
                }
            }
            catch(LengthException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Password Exception Done");
            }
            Console.ReadLine();

        }
        

    }
}
