using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemDay6
{
    public class Employee
    {
        private int EmployeeId;
        private string EmployeeName, Department;
        private string Designation;
        private Salary salary_details;
        Attendance attendance_details;
       public int employeeId
        {
            get => EmployeeId;
            set => EmployeeId = value;
        }
        public string employeeName
        {
            get => EmployeeName;
            set => EmployeeName = value;
        }
        public string department
        {
            get => Department;
            set => Department = value;
        }
        public Employee(int EmployeeId,string EmployeeName, string Department,string designation,Salary salary_details)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.Department = Department;
            this.Designation = designation;
            this.salary_details = salary_details;
        }

        public void getEmployeeDetails(Employee e)
        {

            Console.WriteLine("EmployeeID = "+ e.EmployeeId);
            Console.WriteLine("EmployeeName = "+e.EmployeeName);
            Console.WriteLine("Department = "+e.Department);
            Console.WriteLine("Designation = "+e.Designation);
            Console.WriteLine("Attendance Details = "+ e.attendance_details.attendanceType);
            Console.WriteLine("Total Salary = "+ e.salary_details.totalSalary);
        }
        public void addAttendance(int c)
        {
            this.attendance_details = new Attendance(c);
        }

    }
    class Manager : Employee
    {
        
        int count =  0;
        public Employee[] employees = new Employee[10];
        public Manager(int EmployeeId, string EmployeeName, string Department, string Designation, Salary s) : base(EmployeeId, EmployeeName, Department, Designation, s)
        {

        }
        public void addEmployee()
        {
            //for(int i = 0; i < 2; i++)
            //{
            Console.WriteLine("Enter Details of Employee");
                Console.WriteLine("Enter id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Department");
                string department = Console.ReadLine();
                Console.WriteLine("Enter Designation");
                string des = Console.ReadLine();
                Console.WriteLine("Enter basic");
                int basic = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter HRA");
                int hra =   Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DA");
                int da  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gross");
                int gross = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter net");
                int net = Convert.ToInt32(Console.ReadLine());
                Salary s1 = new Salary(basic,hra,da,gross,net);
                Employee e = new Employee(id, name, department, des, s1);
                Console.WriteLine("Enter 1 Present 2 Absent 3 Leave");
                int attdetails = Convert.ToInt32(Console.ReadLine());
                e.addAttendance(attdetails);
                employees[count++] = e;
            //}
        }   
        
        public Employee[] getEmployees()
        {
            return employees;
        }
        
    }
    class Department
    {
        string departmentName; 
        Manager m;
        public Department(string departmentName,Manager m)
        {
            this.departmentName = departmentName;
            this.m = m;
        }
        // Get Manager Details
        public void getManagerDetails()
        {
            Console.WriteLine("Details of Manager in Department"+ this.departmentName);
            m.getEmployeeDetails(this.m);
            
        }
        public void getDepartmentDetails()
        {
            Console.WriteLine("Department Name = "+ this.departmentName);
            Console.WriteLine("Manager of Department = " + this.m.employeeName);


        }
        

    }
    public class Attendance
    {
        public string attendanceType;
        enum attendancetype
        {
            absent, present, leave
        }
        public Attendance(int c)
        {
            if((int) attendancetype.absent == c)
            {
                this.attendanceType = "Absent";
            }
            else if ((int)attendancetype.present == c)
            {
                this.attendanceType = "Present";
            }
            else
            {
                this.attendanceType = "Leave";
            }
        }
        
    }
    public class Salary
    {
        private int basic, hra, da, gross, net;
        public int totalSalary;
        public Salary(int basic,int hra,int da,int gross,int net)
        {
            this.basic = basic;
            this.hra = hra;
            this.da = da;
            this.gross = gross;
            this.net = net;
            this.totalSalary = basic * hra * da * gross * net;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int EmployeeId, string EmployeeName, string Department, string Designation, Salary s
            Manager m1 = new Manager(1, "Manager1", "IT", "Manager", new Salary(1000, 2, 2, 2, 2));
            m1.addAttendance(1);
            Manager m2 = new Manager(2, "Manager2", "Sales", "Manager", new Salary(2000, 2, 2, 2, 2));
            m2.addAttendance(1);
            Manager m3 = new Manager(3, "Manager3", "Collection", "Manager", new Salary(3000, 2, 2, 2, 2));
            m3.addAttendance(1);

            Department d1 = new Department("IT",m1);
            Department d2 = new Department("Sales", m2);
            Department d3 = new Department("Collections", m3);
       
            int input_user = 1;
            while (input_user != 5)
            {
                Console.WriteLine("--------------------  Welcome to System  --------------------------");
                Console.WriteLine("Press 1 to add Employee Press 2 to see Manager Details ");
                Console.WriteLine("Press 3 to see department details Press 4 to see particular Employee Details Press 5 to exit system");
                input_user = Convert.ToInt32(Console.ReadLine());
                if(input_user == 1)
                {
                    Console.WriteLine("Under which manager you want to add Employee?");
                    Console.WriteLine("Enter 1 for Manager1  Enter2  for Manager 2 or Enter 3 for Manager3");
                    int manager_no = Convert.ToInt32((Console.ReadLine()));
                    if(manager_no == 1)
                    {
                        m1.addEmployee();
                    }
                    else if(manager_no == 2)
                    {
                        m2.addEmployee();
                    }
                    else if(manager_no==3)
                    {
                        m3.addEmployee();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (input_user == 2)
                {
                    Console.WriteLine("Which Manger Details do you want to see?");
                    Console.WriteLine("Enter 1 for Manager1  Enter2  for Manager2 or Enter3 for Manager3 ");
                    int manager_input = Convert.ToInt32(Console.ReadLine());
                    if(manager_input == 1)
                    {
                        Console.WriteLine("Manager1 Details");
                        d1.getManagerDetails();
                        Console.WriteLine("Employees Under Manager1");
                        Employee[] e_temp = m1.getEmployees();
                        foreach (Employee e in e_temp)
                        {
                            if(e is null)
                            {
                                break;
                            }
                            e.getEmployeeDetails(e);
                        }

                    }
                    else if (manager_input == 2)
                    {
                        Console.WriteLine("Manager2 Details");
                        d2.getManagerDetails();
                        Console.WriteLine("Employees Under Manager1");
                        Employee[] e_temp = m2.getEmployees();
                        foreach (Employee e in e_temp)
                        {
                            if(e is null)
                            {
                                break;
                            }
                            e.getEmployeeDetails(e);
                        }

                    }
                    else if (manager_input == 3)
                    {
                        Console.WriteLine("Manager1 Details");
                        d3.getManagerDetails();
                        Console.WriteLine("Employees Under Manager1");
                        Employee [] e_temp = m3.getEmployees();
                        foreach(Employee e in e_temp)
                        {
                            if(e is null)
                            {
                                break;
                            }
                            e.getEmployeeDetails(e);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
                else if(input_user == 3)
                {
                    Console.WriteLine("Which DepartmentDetails do you want to see?");
                    Console.WriteLine("Enter 1 for Department1  Enter 2  for Department2 or Enter3 for Department3 ");
                    int department_input = Convert.ToInt32(Console.ReadLine());
                    if (department_input == 1)
                    {
                        Console.WriteLine("Department1 Details");
                        d1.getDepartmentDetails();

                    }
                    else if (department_input == 2)
                    {
                        Console.WriteLine("Department2 Details");
                        d2.getDepartmentDetails();

                    }
                    else if (department_input == 3)
                    {
                        Console.WriteLine("Department3 Details");
                        d3.getDepartmentDetails();

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (input_user == 4)
                {
                    Console.WriteLine("Enter Manager Number(1,2,3) of Employee: ");
                    int manager_emp_id  = Convert.ToInt32(Console.ReadLine());
                    if(manager_emp_id == 1)
                    {
                        Employee [] e = m1.getEmployees();
                        Console.WriteLine("Enter ID of Employee: ");
                        int emp_id = Convert.ToInt32(Console.ReadLine());
                        foreach (Employee emp in e)
                        {
                            if (emp != null)
                            {
                                if (emp.employeeId == emp_id)
                                {
                                    emp.getEmployeeDetails(emp);
                                }
                            }
                            else
                            {
                                break;
                            }
                            
                        }
                    }



                }
                else if(input_user == 5)
                {
                    Console.WriteLine("Thanks!!!! ");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }

            }
            Console.ReadLine();

        }
    }
}
