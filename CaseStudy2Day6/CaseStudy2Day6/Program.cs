using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2Day6
{

    // Joes Bakery (Case Study 2 Day 6)
    public class Item
    {
        private string itemName;
        private int Price, Quantity;
        public string itemname
        {
            get => itemName;
            set => itemName = value;
        }
        public int price
        {
            get => Price;
            set => Price = value;
        }
        public int quantity
        {
            get => Quantity;
            set => Quantity = value;
        }
        public Item(string itemName, int price)
        {
            this.itemName = itemName;
            this.price = price;
        }
        public void getItems()
        {
            Console.WriteLine("Name:" + itemname + " Price:" + price);

        }
        public void setQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
        public int getQuantity()
        {
            return this.Quantity;
        }
        
    }
    public class Menu
    {
        int count = 1;
        public void displayItems(Item[] it)
        {
            Console.WriteLine("----------- Welcome to Joe's Bakery ------------");
            Console.WriteLine("----------- Menu --------------------------------");
            foreach(Item single_item in it)
            {
                Console.Write(count++ + " ");
                single_item.getItems();
            }

            Console.WriteLine("-------------------------------------------------");
        }
    }
    class Order
    {
        Item[] orderedItems;
        int count = 0,totalAmount = 0;
        public Order(int size)
        {
            orderedItems = new Item[size];
        }
        public void getOrder(Item[] item_list)
        {
            for(int i = 0; i < orderedItems.Length; i++)
            {
                Console.WriteLine("Enter Order Details");
                Console.WriteLine("Enter Item Number to add Item");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Quantity ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                string  itemName = item_list[num - 1].itemname;
                int itemPrice = item_list[num - 1].price;
                Item orderedItem = new Item(itemName,itemPrice);
                orderedItem.setQuantity(quantity);
                addItemToOrder(orderedItem);
                Console.WriteLine("Item Added Successfully!");

            }
        }
        public void addItemToOrder(Item i)
        {
            orderedItems[count] = i;
            count++;
        }
        public void displayTotalAmount(Order o)
        {
            for(int counter = 0; counter < o.orderedItems.Length; counter++)
            {
                totalAmount += o.orderedItems[counter].price * o.orderedItems[counter].getQuantity();
            }
            Console.WriteLine("Total Amount: " + totalAmount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] itemsList = new Item[5];
            int flag= 1;
            itemsList[0] = new Item("Pizza",99);
            itemsList[1] = new Item("Burger", 67);
            itemsList[2] = new Item("Cold Coffee", 40);
            itemsList[3] = new Item("Coke", 40);
            itemsList[4] = new Item("Fries", 49);
            Menu menu = new Menu();
            menu.displayItems(itemsList);
            while (flag != 2)
            {
                Console.WriteLine("Enter total number of items you want to purchase");
                int total_item = Convert.ToInt32(Console.ReadLine());
                Order current_order = new Order(total_item);
                current_order.getOrder(itemsList);
                current_order.displayTotalAmount(current_order);
                Console.WriteLine("Do you want to confirm order Enter 1 for Yes Enter 2 for No");
                int confirmation = Convert.ToInt32(Console.ReadLine());
                if (confirmation == 1)
                {
                    Console.WriteLine("Order Confirmed Thanks!!!");
                }
                else
                {
                    Console.WriteLine("Order Rejected");
                }
                Console.WriteLine("Do you want to place one more order? Press 1 to place Press 2 to exit");
                flag = Convert.ToInt32(Console.ReadLine());

            }


        }
    }
}

// Check console inputs