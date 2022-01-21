using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_application
{
    internal class Calculator
    {
        int first_number;
        int second_number;
        void PrintNumbers()
        {
            //Non static functions do not need to create instance
            first_number = 15;
            second_number = 15;
            Console.WriteLine(first_number);
            Console.WriteLine(second_number);
        }
        static void Main(string[] args)
        {
            // static function needs to create instance of object to access variables inside class
            Calculator obj = new Calculator();
            obj.PrintNumbers();
            float radius = 2.7f;
            double area_circle = 3.14 * (radius * radius);
            Console.WriteLine("Area of Circle = " + area_circle);

            int discount = 10;
            int price = 7000;
            double discounted_price = (discount * price)/100;
            Console.WriteLine("Discounted Price = "+ discounted_price);

            int principal = 12000;
            int rate = 3;
            int time = 4;
            double simpleIntrest = (principal * rate* time)/100;
            Console.WriteLine("Simple Intrest = " + simpleIntrest);

            int x = 4;
            bool result = x is int;
            Console.WriteLine(result);


            int t = 10;
            int t1 = 20;
            int t3 = t > t1 ? t : t1;
            Console.WriteLine(t3);

            int age = 24;
            string a = age > 18 ? "Eligible to vote" : "Not eligible to vote";
            Console.WriteLine(a);

            int marks = 52;
            int exp = 5;
            string isEligible = age > 23 && marks > 50 && exp > 3 ? "Eligible" : "Not eligible";
            Console.WriteLine(isEligible);

            int base_triangle = 3;
            int height_triangle = 4;
            float triangle_area = 0.5f * base_triangle * height_triangle;
            Console.WriteLine("Area of Triangle = " + triangle_area);

            int square_side = 5;
            int area_square = square_side * square_side;
            Console.WriteLine("Area of Square = " + area_square);

            int base_salary = 50;
            int da = 10;
            int hra = 5;
            int pf = 5;
            int total_salary = base_salary + da + hra - pf;
            Console.WriteLine("Total Salary = " + total_salary);

            int Eric_marks = 55;

            char res = Eric_marks >= 90 ? 'A' : Eric_marks >= 75 ? 'B' : Eric_marks >= 60 ? 'C' : Eric_marks >= 50 ? 'D' : 'F';
            Console.WriteLine("Erric's result = " + res);

            int deci = 23;
            Console .WriteLine(Convert.ToString(deci,2)); // Decimal to Binary

            Console.WriteLine(12 & 23);
            Console.WriteLine(11 & 19);

            int x2 = 15;
            int y2 = 33;
            int z2 = x2 ^ y2;
            Console.WriteLine(z2);
            int x1 = 10;
            x1 = x1 << 2;
            x1 = x1 << 2;
            x1 = x1 << 2;
            Console.WriteLine("x1 = " + x1);

            Console.ReadKey();
        }
    }
}
