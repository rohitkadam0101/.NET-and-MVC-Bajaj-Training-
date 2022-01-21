using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CaseStudy2
{
    abstract class Employee
    {
        public string EmployeeName;
        public string Department;
        public string Designation;
       public Salary s = new Salary();
    
        public abstract void setDetails(string EmployeeName,int basic ,int da,int hra,int pf,int gross,int net);

    }
    public class Salary
    {
        
        public int basic, da, hra, pf, gross, net;
    }
    //Manager ,Engineer and LineStaff
    class Manager : Employee
    {

        public override void setDetails(string empName,int basic ,int da, int hra, int pf, int gross, int net)
        {
            this.EmployeeName = empName;
            this.Department = "Buisness";
            this.Designation = "Manager";
            this.s.basic = basic;
            this.s.da = da;
            this.s.hra = hra;
            this.s.pf = pf;
            this.s.gross = gross;
            this.s.net = net;

        }
    }
    class Engineer : Employee
    {

        public override void setDetails(string empName, int basic, int da, int hra, int pf, int gross, int net)
        {
            this.EmployeeName = empName;
            this.Department = "IT";
            this.Designation = "Senior Software Engineer";
            this.s.basic = basic;
            this.s.da = da;
            this.s.hra = hra;
            this.s.pf = pf;
            this.s.gross = gross;
            this.s.net = net;
        }

    }
    class LineStaff : Employee
    {

        public override void setDetails(string empName, int basic, int da, int hra, int pf, int gross, int net)
        {
            this.EmployeeName = empName;
            this.Department = "LineStaff";
            this.Designation = "Employee1";
            this.s.basic = basic;
            this.s.da = da;
            this.s.hra = hra;
            this.s.pf = pf;
            this.s.gross = gross;
            this.s.net = net;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.setDetails("Peter", 15, 55, 20, 68, 44, 89);
            Console.WriteLine($"Employee Name -->  {m.EmployeeName}.\nDepartment --> {m.Department}.\nDesignation --> {m.Designation}.\nBasic --> {m.s.basic}.\n da --> {m.s.da}.\nHRA --> {m.s.hra}.\n PF --> {m.s.pf}.\n Gross --> {m.s.gross}.\n Net --> {m.s.net}\n");
            Engineer e = new Engineer();
            e.setDetails("Mark", 17, 59, 24, 80, 40, 81);
            Console.WriteLine($"Employee Name -->  {e.EmployeeName}.\nDepartment --> {e.Department}.\nDesignation --> {e.Designation}.\nBasic --> {e.s.basic}.\n da --> {e.s.da}.\nHRA --> {m.s.hra}.\n PF --> {m.s.pf}.\n Gross --> {m.s.gross}.\n Net --> {m.s.net}\n");
            LineStaff l = new LineStaff();
            l.setDetails("Elon", 15, 56, 25, 63, 45, 88);
            Console.WriteLine($"Employee Name -->  {l.EmployeeName}.\nDepartment --> {l.Department}.\nDesignation --> {l.Designation}.\nBasic --> {l.s.basic}.\n da --> {l.s.da}.\nHRA --> {l.s.hra}.\n PF --> {l.s.pf}.\n Gross --> {l.s.gross}.\n Net --> {l.s.net}\n");

            Console.ReadLine();
            
        }
    }
}
