using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CaseStudy
{
    class Customer
    {
        public string CustomerName;
        public string Address;
        public string ContactNumber;
        private Product[] product;
        public int productNumber;
        int counter = 0;
        public Customer(string name,string adress,string contactNo,int productsnumber)
        {
           CustomerName = name;
           Address = adress;
            ContactNumber = contactNo;
            productNumber = productsnumber;
            product = new Product[productNumber];
        }
        public void AddProduct(Product p)
        {
            this.product[counter++] = p;

        }
        public Product[] getProducts()
        {
            return this.product;
            
        }
        public void customerDetails()
        {
            Console.WriteLine("Customer Name --> " + CustomerName + " Adress -->" + Address + "Contact Number --> " + ContactNumber);
        }
        
    }
    class Product
    {
        public string ProductName;
        public int Price;
        public int Quantity;
    }
    class Sales
    {
        static void Main(String[] args)
        {
            
                Console.WriteLine("Enter Your Name");
                string CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Your Address");
                string Address = Console.ReadLine(); 
                Console.WriteLine("Enter Your ContactNumber");
                string ContactNumber = Console.ReadLine();
                Console.WriteLine("Enter Number of Products");
                int number_products = Convert.ToInt32(Console.ReadLine());
            Customer c = new Customer(CustomerName,Address,ContactNumber,number_products);
            Product[] p = new Product[number_products];
                Console.WriteLine("Enter Product Details:  ");
                for (int j = 0; j < number_products; j++)
                {
                    p[j] = new Product();
                    Console.WriteLine("Enter Product Name");
                    p[j].ProductName = Console.ReadLine();
                    Console.WriteLine("Enter Product Price");
                    p[j].Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Quantity(Int)");
                    p[j].Quantity = Convert.ToInt32(Console.ReadLine());
                    c.AddProduct(p[j]);
                }

            Product[] products = c.getProducts();
            c.customerDetails();
            Console.WriteLine("Product Details");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Product Number -- "+i);

                Console.WriteLine("Product = "+products[i].ProductName+ "\n+Product Price = "+products[i].Price+"\nProduct Quantity =  " + products[i].Quantity + "\n");
            }




            Console.ReadLine();
        }
    }
    
}
