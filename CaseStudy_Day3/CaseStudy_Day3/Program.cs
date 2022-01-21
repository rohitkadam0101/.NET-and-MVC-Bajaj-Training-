using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Day3
{
    enum Size:int
    {
        SMALL,
        MEDIUM,
        BIG,
        LARGE
    }
    struct User
    {
        public string username;
        public string email;
        public string  mobile_no;
        public void printUserDetails()
        {
            Console.WriteLine("Username = " + username + "\nemail = " + email + "\nmobile no = " + mobile_no);

        }
    }
    struct orderDetails
    {
        public int orderno;
        public DateTime orderdate;
        public string itemname;
        public int price;
        public int quantity;
        public int orderSize;

        public void printOrderDetails()
        {
            Console.WriteLine("OrderNo = "+orderno + "\nOrderDate = " + orderdate + "\nItemName = " + itemname + "\nprice" + price + "\nQuantity= " +quantity + "\nOrderSize = " +orderSize);

        }
        public void viewSizeValue()
        {
            int size = orderSize;



            switch (size)
            {
                case (int) Size.SMALL:
                    Console.WriteLine("price is 50+");
                    break;
                case (int) Size.MEDIUM:
                    Console.WriteLine("price is 100+");
                    break;
                case (int) Size.LARGE:
                    Console.WriteLine("price is 250+");
                    break;



                case (int) Size.BIG:
                    Console.WriteLine("price is 200+");
                    break;



            }

        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine("Enter Your Name: ");
            user1.username = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            user1.email = Console.ReadLine();
            Console.WriteLine("Enter Your Mobile: ");
            user1.mobile_no = Console.ReadLine();

            user1.printUserDetails();


            orderDetails o = new orderDetails();
            Console.WriteLine("Enter orderno");
            o.orderno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter itemname");
            o.itemname = Console.ReadLine();
            Console.WriteLine("Enter Price");
            o.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity (Int) ");
            o.quantity = Convert.ToInt32(Console.ReadLine());
            o.orderdate = new DateTime(2022, 1, 17);
            Console.WriteLine("Enter Size: 0 for Small,1 for Medium,2 for  Big,3 for Large");
            o.orderSize = Convert.ToInt32(Console.ReadLine());
            o.printOrderDetails();
            o.viewSizeValue();
            Console.ReadLine();
        }
    }
}
