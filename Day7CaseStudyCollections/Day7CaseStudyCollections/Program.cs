using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Day7CaseStudyCollections
{
    class Products
    {
        private string productName;
        private float price;
        private int quantity;

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }
        public float Price
        {
            get => price;
            set => price = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        public Products(string productName, float price ,int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }
    }
    public class Customer
    {
        string customerName,email,shippingAdress,billingAdress;
        
        public string CustomerName
        {
            get => customerName;
            set => customerName = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string ShippingAdress
        {
            get => shippingAdress;
            set => shippingAdress = value;
        }
        public string BillingAdress
        {
            get => billingAdress;
            private set => billingAdress = value;
        }
        public Customer(string customerName,string email,string shippingAdress,string billingAdress)
        {
            this.customerName = customerName;
            this.email = email;
            this.billingAdress = billingAdress;
            this.shippingAdress = shippingAdress;
        }

    }
    public class Cart
    {
        Customer customer;
        private int id;
        List<Products> ProductList = new List <Products>();
        float total_amount;
        bool orderStatus = false;

        public Cart(int id,Customer customer)
        {
            this.id = id;
            this.customer = customer;

        }
        public void addProducts()
        {
            int userInput2 = 1;
            while (userInput2 != 4)
            {
                Console.WriteLine("Enter 1 for Lays Enter 2 for Burger or Enter 3 for Pizza Enter 4 to Exit");
                userInput2 = Convert.ToInt32(Console.ReadLine());
                if (userInput2 == 1)
                {
                    Console.WriteLine("Enter Quantity");
                    int user_quantity = Convert.ToInt32(Console.ReadLine());
                    Products p = new Products("Lays", 50, user_quantity);
                    total_amount += 50 * user_quantity;
                    ProductList.Add(p);
                }
                else if (userInput2 == 2)
                {
                    Console.WriteLine("Enter Quantity");
                    int user_quantity = Convert.ToInt32(Console.ReadLine());
                    Products p = new Products("Burger", 99, user_quantity);
                    total_amount += 99 * user_quantity;
                    ProductList.Add(p);
                }
                else if (userInput2 == 3)
                {
                    Console.WriteLine("Enter Quantity");
                    int user_quantity = Convert.ToInt32(Console.ReadLine());
                    Products p = new Products("Pizza", 129, user_quantity);
                    total_amount += 129 * user_quantity;
                    ProductList.Add(p);
                }
                else if(userInput2 == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void showOrder()
        {
            Console.WriteLine("-------Order Details--------");
            Console.WriteLine("Customer Name = " + this.customer.CustomerName);
            Console.WriteLine("Email = " + this.customer.Email);
            Console.WriteLine("Shipping Adress = " + this.customer.ShippingAdress);
            Console.WriteLine("Billing Adress = " + this.customer.BillingAdress);

            foreach(var p in ProductList)
            {
                Console.WriteLine("Product Name = "+p.ProductName +"  Quantity = " +  p.Quantity);
            }
            Console.WriteLine("Total Amount = " + this.total_amount);

        }
    }
    public class Order
    {
        List<Cart> CartList = new List<Cart>();
        public int id;
        public Order(int id)
        {
            this.id = id;
        }
        public void ConfirmOrder(Cart c)
        {
            CartList.Add(c);
        }
        public void showOrder()
        {
            foreach(Cart c in CartList)
            {
                c.showOrder();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int order_id = 1;
            int user_input = 0;
            List<Order> ordersList = new List<Order>();

            while (user_input != 3)
            {
                Console.WriteLine("--------------- Welcome to Shopping Mart -------------------");
                
                List<Products> Available_Products = new List<Products>();
                Products p1 = new Products("Lays", 50, 1);
                Products p2 = new Products("Burger", 99, 1);
                Products p3 = new Products("Pizza", 129, 1);
                Available_Products.Add(p1);
                Available_Products.Add(p2);
                Available_Products.Add(p3);
           
                Console.WriteLine("Enter 1 to Place and Order Enter 2 to see List of Orders Enter 3 to exit");
                user_input = Convert.ToInt32(Console.ReadLine());
                if (user_input == 1)
                {
                    Console.WriteLine("--------------- Products Available ---------------------------");
                    foreach (var product in Available_Products)
                    {
                        Console.WriteLine("ProductName = " + product.ProductName);
                        Console.WriteLine("Price = " + product.Price);
                    }
                    //customerName,email,shippingAdress,billingAdress
                    Console.WriteLine("Enter Name ");
                    string customerName = Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    string customerEmail = Console.ReadLine();
                    Console.WriteLine("Enter Shipping Adress");
                    string shippingAdress = Console.ReadLine();
                    string billingAdress = "XYZ Store Mumbai";
                    Customer c = new Customer(customerName, customerEmail, shippingAdress, billingAdress);
                    Console.WriteLine("Enter Cart id");
                    int cart_id = Convert.ToInt32(Console.ReadLine());
                    Cart cart = new Cart(cart_id, c);
                    cart.addProducts();
                   
                    Console.WriteLine("Press 1 to confirm order");
                    int orderStatus = Convert.ToInt32(Console.ReadLine());
                    if(orderStatus == 1)
                    {
                        Console.WriteLine("Your OrderId is " + order_id);
                        Order order = new Order(order_id);
                        ordersList.Add(order);
                        order_id++;
                        order.ConfirmOrder(cart);

                    }

                }
                else if (user_input == 2)
                {
                    Console.Write("Enter order id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    foreach(var ord in ordersList)
                    {
                        if(ord.id == id)
                        {
                            ord.showOrder();
                        }
                    }

                }
                else if (user_input == 3)
                {
                    Console.WriteLine("Thanks for Shopping have a nice day!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            
        }
    }
}


