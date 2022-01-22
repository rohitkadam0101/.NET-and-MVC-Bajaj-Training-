using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Day8SerializableExample
{
    [Serializable]
    public class Employee
    {
        private string empName, dept;
        public string EmployeeName
        {
            get { return empName; }
            set { empName = value; }
        }
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public void WriteToFile(Employee e)
        {
            Stream saveFileStream = File.Create("E:/Bajaj/C#/" + e.EmployeeName + ".txt");
            BinaryFormatter serializable = new BinaryFormatter();
            serializable.Serialize(saveFileStream, e);
            saveFileStream.Close();
        }
        public  Employee ReadFromFile(string fileName)
        {
            string filelocation = "E:/Bajaj/C#/" + fileName+".txt";
            if (File.Exists(filelocation))
            {
                Console.WriteLine("Reading from saved file");
                Stream openFileStream = File.OpenRead(filelocation);
                BinaryFormatter deserializable = new BinaryFormatter();
                Employee emp = (Employee)deserializable.Deserialize(openFileStream);
               
                return emp;
            }
            else
            {
                return null;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.EmployeeName = "XYZ";
            e.Dept = "IT";
            //e.WriteToFile(e);
            Employee e1 = e.ReadFromFile("XYZ");
            Console.WriteLine(e1.EmployeeName);
            Console.WriteLine(e1.Dept);
            Console.ReadLine();


        }
    }
}
