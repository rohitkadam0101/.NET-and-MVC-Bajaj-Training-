using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5OperatorOverloading
{

    public class CofeeMachine
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("Coffee is getting Ready");
        }
    }
    public class HotCoffee : CofeeMachine
    {
        public new void PrintMessage() // if we use new then overriden will stop and will show only base class output
        {
            Console.WriteLine("Hot Cofee is gettng ready");
        }
    }
    public class ColdCofee : CofeeMachine
    {
        public override void PrintMessage()
        {
            Console.WriteLine("Cold Cofee is getting ready");
        }

    }
    public class CofeeDispenser
    {
        public void Dispense(CofeeMachine c)
        {
            c.PrintMessage();
        }
    }
    class Date
    {
        int day,month,year;
        string noofdays;
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void print()
        {
            Console.WriteLine(noofdays);
        }
        public static Date operator -(Date d1, Date d2)
        {
            Date d3 = new Date(0, 0, 0);
            DateTime dt1 = new DateTime(d1.year, d1.month, d1.day);
            DateTime dt2 = new DateTime(d2.year, d2.month, d2.day);
            String diff = (dt1-dt2).TotalDays.ToString();
            d3.noofdays = diff;
            return d3;
        }

    }
    class Number
    {
        string msg;
        public void printMsg()
        {
            Console.WriteLine("This is message");
        }
        public static Number operator +(Number i)
        {
            Number n = new Number();
            n.msg = "Hello";
            return n;
        }
    }
    class Student
    {
        string student_name;
        float weight;
        public Student(string student_name,float weight)
        {
            this.student_name = student_name;
            this.weight = weight;
        }
        public static bool operator< (Student s1,Student s2)
        {
            float f1 = s1.weight;
            float f2 = s2.weight;
            return f1<f2?true:false;
        }
        public static bool operator >(Student s1, Student s2)
        {
            float f1 = s1.weight;
            float f2 = s2.weight;
            return f1 > f2 ?true:false;
        }
    }

    class Ticket
    {
        string source;
        string destination;
        public void setDetails(string source,string destination)
        {
            this.source = source;
            this.destination = destination;
            printDetails(this);
        }
        public void printDetails(Ticket t)
        {
            Console.WriteLine(t.source);
            Console.WriteLine(t.destination);
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Number obj = new Number();
                obj = +obj;
                obj.printMsg();
                
                // Binary Operator Overloading
                Date obj1 = new Date(12, 11, 2019);
                Date obj2 = new Date(12, 12, 2020);
                Date d3 = obj2 - obj1;
                d3.print();

                // Method Overriding (Dynamic Polymorphism)
                CofeeMachine cofee;
                cofee = new HotCoffee(); // instance of hot cofee
                CofeeDispenser dispenser = new CofeeDispenser();
                dispenser.Dispense(cofee);
                cofee = new ColdCofee(); // Instance of cold cofee
                dispenser.Dispense(cofee);

            // < > overloading

            Student s1 = new Student("Student 1", 51);
            Student s2 = new Student("Student 2", 55);
            Console.WriteLine("Is s1 weight greater than s2? {0}", s1 > s2);
            Console.WriteLine("Is s2 weight greater than s1? {0}", s2 > s1);

            // Printing current instance of object (this keyword)
            Ticket t1 = new Ticket();
            t1.setDetails("Vita", "Pune");
            Console.ReadLine();


            }
            
            

        }
}
