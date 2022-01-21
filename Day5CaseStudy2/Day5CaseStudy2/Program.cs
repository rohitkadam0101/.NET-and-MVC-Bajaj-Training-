using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5CaseStudy2
{
    
    public class Item
    {
        // Item class for details of Items purchased by customer
        private string itemName;
        public float Price;
        public int quantity;
        public float price
        {
            get => Price;
            set => Price = value;
        }
        public string ItemName
        {
            get => itemName;
            set => itemName = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        public Item(string item_name,float item_price,int item_quantity)
        {
            this.itemName = item_name;
            this.price = item_price;
            this.quantity = item_quantity;
        }
    }

    public class Order
    {
        // Order class for OrderDetails of Customer
        public int orderNo;
        public string orderDate;
        public Order(int orderNo)
        {
            this.orderNo = orderNo;
        }
        // Storing List of Items in Order Class
        public Item[] itemList = new Item[2];
        public int count = 0;
        public void addItem(Item it)
        {
            itemList[count++] = it;
        }
        public Item[] getItems()
        {
            return itemList;
        }
        
    }
    public class Stock
    {
        public static Item[] itemsInStock = new Item[10];
        public Stock stockDetails()
        {
            return this;
        }
    }
    public class Purchases
    {
        public Order o;
        public float totalAmount;
        public Purchases(Order o)
        {
            this.o = o;
        }
        public void calculateTotalAmount()
        {
            for(int k = 0; k < o.count; k++)
            {
                // Price_of_item * quantity_of_item
                float total = (o.itemList[k].Price) * (o.itemList[k].quantity);
                this.totalAmount += total;
            }
        }
        public void correctStock(Stock s)
        {
            o.itemList.CopyTo(Stock.itemsInStock, 0);
        }
    }
    public class Sales
    {
        public Order o;
        public float totalAmount;
        public Sales(Order o)
        {
            this.o = o;
        }
        public void calculateTotalAmount()
        {
            for (int k = 0; k < o.count; k++)
            {
                // Price_of_item * quantity_of_item
                float total = (o.itemList[k].Price)* (o.itemList[k].quantity);
                this.totalAmount += total;
            }
        }
        public void correctStock(Stock s)
        {
            for (int j = 0; j < o.count; j++)
            {
                Stock.itemsInStock = Array.FindAll(Stock.itemsInStock, i => i != o.itemList[j]).ToArray();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Order order = new Order(55);
            // User Input for Items
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter ItemName: ");
                string item_name = Console.ReadLine();
                Console.WriteLine("Enter Price");
                float f = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Quantity");
                int q = Convert.ToInt32(Console.ReadLine());
                Item item1 = new Item(item_name, f, q);
                order.addItem(item1);
            }
            // Displaying Purchased Items
            Item[] items = order.getItems();
            for(int j=0;j<items.Length; j++)
            {
                Console.WriteLine("Name --> " + items[j].ItemName);
                Console.WriteLine("Price --> " + items[j].Price);
                Console.WriteLine("Quantity --> " + items[j].Quantity);
            }
            Purchases purchase1 = new Purchases(order);
            purchase1.calculateTotalAmount();
            Console.WriteLine("Total Purchase Amount --> " + purchase1.totalAmount);

            Sales sales1 = new Sales(order);
            sales1.calculateTotalAmount();
            Console.WriteLine("Total Sales Amount --> " + sales1.totalAmount);
            purchase1.correctStock(stock);
            sales1.correctStock(stock);

            Console.ReadLine();
        }
    }
}
