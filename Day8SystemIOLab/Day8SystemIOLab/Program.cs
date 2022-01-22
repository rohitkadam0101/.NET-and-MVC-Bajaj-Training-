using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day8SystemIOLab
{
    class Employee
    {
        string name, email;
        int id;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public void addDetails()
        {
            StreamWriter sw = new StreamWriter("E:/Bajaj/C#/EmployeeDetails.txt");
            sw.WriteLine("EmployeeName: " + this.name + "\nMail:  " + this.email + "\nEmp id:  " + this.id);
            sw.Flush();
            sw.Close();
        }
        public void showDetails()
        {
            StreamReader sr = new StreamReader("E:/Bajaj/C#/EmployeeDetails.txt");
            string data = sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Employee emp = new Employee();
            emp.Name = name;
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            emp.Email = email;
            Console.WriteLine("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            emp.Id = id;
            emp.addDetails();
            emp.showDetails();

            Console.ReadKey();
        }
    }
}
