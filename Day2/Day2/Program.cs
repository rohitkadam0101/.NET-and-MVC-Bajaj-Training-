using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void printSquare(int a)
        {
            Console.WriteLine(a*a);
        }
        static void printNumbers(int b)
        {
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            // 1D Arrays
            int[] a = new int[3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            Console.WriteLine(a[2]);

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(arr[5]);

            // 2D Arrays
            int[,] arr1 = new int[2, 2];
            arr1[0, 0] = 2;
            arr1[0, 1] = 3;
            arr1[1, 0] = 5;
            arr1[1, 1] = 6;
            Console.WriteLine(arr1[1, 1]);

            // string name = Console.ReadLine();
            // Console.WriteLine(name);

            // Jagged Array 
            // This is array of array with variable sizes of arrays defined inside it
            string[][] fruits = new string[2][]
            {  new string[] { "apple","banana"},
               new string[] { "mango","pear","litchi"}

            };
            // 3 furniture with height,width,area
            int[,] jason = new int[3, 3];
            jason[0, 0] = 1;
            jason[0, 1] = 2;
            jason[0, 2] = 3;
            jason[1, 0] = 4;
            jason[1, 1] = 5;
            jason[1, 2] = 6;
            jason[2, 0] = 7;
            jason[2, 1] = 8;
            jason[2, 2] = 9;

            Console.WriteLine(jason[2, 1]);

            // 4 students but no.of attempts is different
            string[][] peter = new string[4][]
            {
                new string[] { "Daito","1"},
                new string[] { "Rohit","2"},
                new string[]{ "Kaztro","3"},
                new string[]{"spidey","4"}
            };
            Console.WriteLine(peter);

            // Using Array class
            Array b = Array.CreateInstance(typeof(Int32), 3);
            b.SetValue(12, 0);
            b.SetValue(10, 1);
            b.SetValue(11, 2);
            Console.WriteLine(b.GetValue(2));
            Array.Sort(b); // Sorting Array

            int[] b1 = new int[4];
            Array.Copy(b, b1, 3); // Copy(what array,where,upto which index)
            Console.WriteLine(b1[2]);
            Console.WriteLine(b.GetValue(2));

            // For Each in array
            int[] num = { 1, 2, 3, 4 };
            Action<int> action = new Action <int>(printSquare);
            Array.ForEach(num, action);

            Array temp = Array.CreateInstance(typeof(Int32), 2, 4);
            temp.SetValue(12, 0,0);
            temp.SetValue(13, 0, 1);
            temp.SetValue(14, 0, 2);
            temp.SetValue(15, 0, 3);
            temp.SetValue(16, 1, 0);
            temp.SetValue(17, 1, 1);
            temp.SetValue(18, 1, 2);
            temp.SetValue(19, 1,3);
            Console.WriteLine(temp.GetValue(0, 2));

            int[] l1 = { 12, 23, 11, 19, 33, 55, 22 };
            int[] l2 = new int[8];
            Array.Copy(l1, 3, l2, 4, 4);
            Action<int> action1 = new Action<int>(printNumbers);
            Console.WriteLine("Printing Array 1");
            Array.ForEach(l1, action1);
            Console.WriteLine("Printing Array 2");
            Array.ForEach(l2, action1);

            // Conditional Constructs and Loops

            // Conditional if -> else if -> else
            if (2 > 3)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

            // Switch Case Syntax in C#

            string grade = Console.ReadLine().ToUpper();
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Very good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Average");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            // Loops
            // for while and do while is same as other languages
            // Break and Continue is same as other languages
            Console.WriteLine("Printing t2 ");
            int[] t2 = { 1, 2, 3, 4 };
            foreach(int i in t2)
            {
                Console.WriteLine(i);
            }

            string myName = "Rohit";
            string name = myName;
            Console.WriteLine(name == myName);
            Console.WriteLine(myName.Equals(name));

            // Sum of elements of array using loops
            int[] s = { 22,45,67,22,3,4,77,99,42,43};
            int sum_arr = 0;
            for(int i = 0; i < s.Length; i++)
            {
                sum_arr += s[i];
            }
            Console.WriteLine("Sum of array = " + sum_arr);
            int n = s.Length;
            // Sort using for loop
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if (s[j] > s[j + 1])
                    {
                        int temp1 = s[j];
                        s[j] = s[j + 1];
                        s[j+1] = temp1;
                    }
                }
            }
            Console.WriteLine("After sorting array");
            for(int i=0;i<s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            // Even numbers using forEach
            Console.WriteLine("Printing Even Numbers");
            foreach(int i in s){
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // Switch Case
            Console.Write("Enter Color: ");
            string color = Console.ReadLine().ToUpper();
            switch (color)
            {
                case "RED":
                    Console.WriteLine("You entered Red");
                    break;
                case "GREEN":
                    Console.WriteLine("You entered Green");
                    break;
                case "BLUE":
                    Console.WriteLine("You entered Blue");
                    break;
                default:
                    Console.WriteLine("You entered some other color");
                    break;
            }
            
            // Printing 2D array using loops

            Console.WriteLine("Printing 2D array ");
            int[,] height_weight_speed = new int[2, 3];
            height_weight_speed[0, 0] = 5;
            height_weight_speed[0, 1] = 45;
            height_weight_speed[0, 2] = 3;
            height_weight_speed[1, 0] = 4;
            height_weight_speed[1, 1] = 50;
            height_weight_speed[1, 2] = 6;

            for(int i = 0; i < height_weight_speed.GetLength(0); i++)
            {
                for(int j = 0; j < height_weight_speed.GetLength(1); j++)
                {
                    Console.Write(height_weight_speed[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
