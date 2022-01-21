using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        void printMessage()
        {
            Console.WriteLine("Hello World");
        }
        int add(int x,int y)
        {
            return x+ y;
        }
        void changeValue(ref int x)
        {
            x = 100;
        }
        void swapValues(ref int b,ref int c)
        {
            int temp;
            temp = b;
            b = c;
            c = temp;
        }
        int arrSum(int[] temp)
        {
            int s = 0;
            foreach(int i in temp)
            {
                s += i;
            }
            return s;
        }
        public static string GetNextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        enum Seasons:int // We can set float,long etc
        {
            // Constant Values
            Summer = 2, //0 if assigned 2 then it will start from 2
            Winter = 7, //1 we can assign custom values
            Autumn, //2
            Spring //3
        }
        enum Calculations:int
        {
           Addition = 10,
           Multiplication = 20,
           Division = 40,
           Substraction = 80
        }
        static void Main(string[] args)
        {
              Program a = new Program();
              a.printMessage();
            int answer = a.add(1, 2);
            Console.WriteLine(answer);
            int num = 10;
            a.changeValue(ref num); // Passsing as a ref so changes in function will be reflected
            // Out parameter => if we want to return multiple values , it is not necessary to initialize value
            Console.WriteLine("Num = "+num);
            // Swap two values using ref 
            int t1 = 55;
            int t2 = 60;
            a.swapValues(ref t1, ref t2);
            Console.WriteLine("t1 = " + t1 + " t2 = " + t2);

            // Sum of values of an Array
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum_arr = a.arrSum(arr);
            Console.WriteLine("Sum of array = "+sum_arr);

            // Out keyword in C#
            int k = 0;
            Console.WriteLine("Previous value of integer i:" + k.ToString());
            string test = GetNextNameByOut(out k);
            Console.WriteLine("Current value of integer i:" + k.ToString());

            // Printing enum values
            // Numeric value allocation starts from zero
            // Enum are used to assign integer to constant values
            Console.WriteLine((int)Seasons.Summer);
            Console.WriteLine((int)Seasons.Winter);
            String[] names = Enum.GetNames(typeof(Seasons));
            int[] enumValus = (int[]) Enum.GetValues(typeof(Seasons));
            foreach(int i in enumValus)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(names);

            // Accessing Calculations enum
            Console.WriteLine("Accesing values in Calculations Enum");
            int[] calculations_values = (int[]) Enum.GetValues(typeof(Calculations));
            foreach(int i in calculations_values)
            {
                Console.Write(i+"\n");
            }
            
            Console.ReadKey();

        }
    }
}
