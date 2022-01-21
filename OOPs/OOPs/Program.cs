using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;
using ClassLibrary1; // from references->add referenes (it is class collection)
namespace OOPs
{
    public class MyCalculator : Calculator
    {
        public void print()
        {
            PrintingResult();
        }
        
    }
   
    internal class Program
    {
        //// Method Overloading 
        //public void msg()
        //{
        //    Console.WriteLine("Hello");
        //}
        //public void msg(string firstName)
        //{
        //    Console.WriteLine("Hello " + firstName);
        //}
        //public void msg(string firstName, string lastName)
        //{
        //    Console.WriteLine("Hello " + firstName + lastName);
        //}
        static void Main(string[] args)
        {
            Person p = new Person();
            Calculator o = new Calculator();
            MyCalculator c = new MyCalculator();
            c.print();

            //Encapsulation example Bank class
            Bank b = new Bank();
            //b.amount = 5000000; Must be privately defined inside class
            b.depositAmount(10000);
            b.displayAmount();
            b.withdrawAmount(1000);
            b.displayAmount();

            // Inheritance Example


            //Polymorphism Method Overloading
            //msg();
            //msg("Daito");
            //msg("Daito", "Valorant");
            Console.ReadLine();



        }
    }
}
