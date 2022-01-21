using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5Association;
namespace Day5Lab1
{
    public class Intrest
    {
        float amount;
        float rate;
        public Intrest(float amount,float rate)
        {
            this.amount = amount;
            this.rate = rate;
            Console.WriteLine("Amount = " + amount);
            Console.WriteLine("Rate = " + rate);
        }
    }
    public class LoanRate : Intrest
    {
        public LoanRate(float amount,float rate) : base(amount, rate)
        {
            Console.WriteLine("From LoanRate class");

        }
        
    }

    // 2nd Question
    class Exam
    {
        string student_name;
        string semester;
        static public string exam_details;
        public Exam(string student_name,string semester)
        {  
            this.student_name = student_name;
            this.semester = semester;
            Console.WriteLine("Normal Constructor");
        }

        static Exam()
        {
            Console.WriteLine("Static Constructor");
            exam_details = "C# Exam";

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LoanRate l = new LoanRate(23.0f,1.0f);
            Exam e = new Exam("Jason", "Sem1");
            Exam e2 = new Exam("Jason2", "Sem2");
            Console.WriteLine(Exam.exam_details);
            // Association Example (Both classes are associated with each other but can also exists independtly)
            Manager m1 = new Manager("John", "cena", "cse");
            SwipeCard s = new SwipeCard("123");
            s.swipe(m1);
            Console.ReadLine();
        }
    }
}


//using System;
//namespace test2
//{
//    public class Employee
//    {
//        string Name;
//        int ID;
//        int Salary;



//        public void GetDetails()
//        {
//            Console.WriteLine("Enter Name:");
//            this.Name = Console.ReadLine();



//            Console.WriteLine("Enter ID:");
//            this.ID = Convert.ToInt32(Console.ReadLine());



//            Console.WriteLine("Enter Salary:");
//            this.Salary = Convert.ToInt32(Console.ReadLine());
//        }
//        public void ShowDetails()
//        {
//            Console.WriteLine("Name:" + this.Name);
//            Console.WriteLine("ID:" + this.ID);
//            Console.WriteLine("Salary:" + this.Salary);
//        }
//    }
//    internal class Activity
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            emp.GetDetails();
//            emp.ShowDetails();
//        }
//    }
//}
