using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day8FileHandlingCustomerExample
{
    public class Customer
    {
        string customerName;
        string emailID;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string EmailID
        {
            get { return emailID; }
            set { emailID = value; }
        }

    }
    public class CustomerDetails
    {
        private static string CUSTOMER_FILE_NAME = "E:/Bajaj/C#/CustomerDataFile.txt";
        public void SaveToFile(Customer customer)
        {
            StreamWriter sw = new StreamWriter(CUSTOMER_FILE_NAME);
            sw.WriteLine("Customer Name {0}, Email Id {1}", customer.CustomerName, customer.EmailID);
            sw.Flush();
            sw.Close();
        }
        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader(CUSTOMER_FILE_NAME);
            string data = sr.ReadToEnd();
            Console.Write(data);
            sr.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            customer.CustomerName = name;
            Console.WriteLine("Enter Mail");
            string email = Console.ReadLine();
            customer.EmailID = email;
            CustomerDetails c = new CustomerDetails();
            c.SaveToFile(customer);
            c.ReadFromFile();
            Console.ReadKey();
        }
    }
}
