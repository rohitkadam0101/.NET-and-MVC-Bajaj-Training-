using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5CaseStudy
{
    public interface Person
    {
        void setDetails();
        Person getDetails();
    }
    public class Employee : Person
    {
        private string firstName;
        private string lastName;
        private string department;
        public void setDetails()
        {
            Console.WriteLine("Enter firstName: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter lastName: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            string dept = Console.ReadLine();
            Employee emp = new Employee();
            emp.firstName = fName;
            emp.lastName = lName;
            emp.department = dept;


        }
        public Person getDetails()
        {
            return this;
        }

    }
    public class Engineer : Person
    {
        private string firstName;
        private string lastName;
        private string department;
        public void setDetails()
        {
            Console.WriteLine("Enter firstName: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter lastName: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            string dept = Console.ReadLine();
            Engineer eng = new Engineer();
            eng.firstName = fName;
            eng.lastName = lName;
            eng.department = dept;


        }
        public Person getDetails()
        {
            return this;
        }

    }
    public class Worker : Person
    {
        private string firstName;
        private string lastName;
        private string department;
        public void setDetails()
        {
            Console.WriteLine("Enter firstName: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter lastName: ");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            string dept = Console.ReadLine();
            Worker worker = new Worker();
            worker.firstName = fName;
            worker.lastName = lName;
            worker.department = dept;

        }
        public Person getDetails()
        {
            return this;
        }

    }
    public class Salary{
        public void CalculateSalary(Person p)
        {
            if(p is Employee)
            {
                Console.WriteLine("Employee Salary = 10000");
            }
            if(p is Engineer)
            {
                Console.WriteLine("Engineer Salary = 2000");
            }
            if(p is Worker)
            {
                Console.WriteLine("Worker Salary = 500");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Person e = new Employee();
            e.setDetails();
            Person e1 = new Worker();
            e.setDetails();
            Person e2 = new Engineer();
            e.setDetails();
            Salary salary = new Salary();
            salary.CalculateSalary(e.getDetails());
            salary.CalculateSalary(e1.getDetails());
            salary.CalculateSalary(e2.getDetails());

            Console.ReadLine();
            


        }
    }
}
