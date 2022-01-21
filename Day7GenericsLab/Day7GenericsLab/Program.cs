using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7GenericsLab
{
    class Data<T>
    {
        T user_data;
        public T userData // Generic type class
        {
            get => user_data;
            set => user_data = value;
        }
    }
    class Calculator
    {
        public void calculate<T>(T t1,T t2)
        {
            Console.WriteLine("Processsing {0}, {1}",t1,t2);

        }
    }
    //Genric List
    public class GenericList<T>
    {
        private T[] arr;
        public GenericList(int size)
        {
            arr = new T[size]; 
        }
        private int c = 0;
        public void add(T t)
        {
            arr[c++] = t;

        }
        public T get(int c)
        {
            return arr[c];
        }
        public T[] getAll()
        {
            return arr;
        }
    }
    // Passing Employee instance generics
    class Employee
    {
        string empName;
        string department;
        public string empname
        {
            get => empName;
            set => empName = value;
        }
        public string Dept
        {
            get => department;
            set => department = value;
        }
        public string details()
        {
            return "EmployeeName  = " + empName + "Department= " + department;
        }
    }
    class InfoData<T, E>
    {
        T t; // integer
        E e; // Employee class instance1
        public InfoData(T t, E e)
        {
            this.t = t;
            this.e = e;
        }
    
        public void printInfo()
        {
            Console.WriteLine("{0} {1}", t, e);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Data <string> data = new Data<string>();
            Data <float> data2 = new Data<float>();
            Data <int> data3 = new Data<int>();

            data.userData = "Hello";
            data2.userData = 1.7f;
            data3.userData = 44;
            Console.WriteLine(data.userData);
            Console.WriteLine(data2.userData);
            Console.WriteLine(data3.userData);

            // Generic Functions
            Calculator c= new Calculator();
            c.calculate("Hello", "world");
            c.calculate(12, 23);

            // Generic Array
            GenericList<int> g = new GenericList<int>(5);
            g.add(1);
            g.add(2);
            g.add(3);
            g.add(4);
            g.add(5);
            foreach(int x in g.getAll())
            {
                Console.WriteLine(x);
            }

            // Class for generics
            Employee emp = new Employee();
            emp.empname = "Peter";
            emp.Dept = "MCU";
            InfoData<int,Employee> info = new InfoData<int, Employee>(1,emp);
            info.printInfo();
            Console.ReadKey();
        }
    }
}
