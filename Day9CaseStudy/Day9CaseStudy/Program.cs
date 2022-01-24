using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Day9CaseStudy
{
    class handleUser
    {
        public void addTable(SqlConnection conn)
        {
            string query = "create table userDetails(user_id int primary key,username varchar(20),email varchar(20),password varchar(20))";
            SqlCommand cmd = new SqlCommand(query, conn);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created");
        }
        public void addUser(SqlConnection conn)
        {
            string parameterized_query = "insert into userDetails values(@user_id,@username,@email,@password)";
            SqlCommand cmd = new SqlCommand(parameterized_query, conn);
            cmd.Parameters.Add("@user_id", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@username",System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            Console.WriteLine("Enter id: ");
            cmd.Parameters["@user_id"].Value = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            cmd.Parameters["@username"].Value = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            cmd.Parameters["@email"].Value = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            cmd.Parameters["@password"].Value = Console.ReadLine();
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Number of rows inserted {0}", i);
        }
        public void validateUser(SqlConnection conn)
        {
            Console.WriteLine("Enter Username: ");
            string parameterized_query = "select * from userDetails where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(parameterized_query, conn);
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@password", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            cmd.Parameters["@password"].Value = Console.ReadLine();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("Welcome Logged In Successfully");
            }
            else
            {
                Console.WriteLine("User Not found");
            }
          

            //DataTable dt = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    Console.WriteLine("Welcome Logged In Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("User Not Found");
            //}
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            handleUser hu = new handleUser();
            try
            {
                
                SqlConnection conn = new SqlConnection(@"Database Path");
                conn.Open();
                //hu.addTable(conn);

                Console.WriteLine("Connection Established");
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Enter 1 to Register or Enter 2 to Login (if already registered)");
                    int user_input = Convert.ToInt32(Console.ReadLine());
                    if (user_input == 1)
                    {
                        hu.addUser(conn);
                    }
                    else if(user_input == 2)
                    {
                        hu.validateUser(conn);
                        
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}
