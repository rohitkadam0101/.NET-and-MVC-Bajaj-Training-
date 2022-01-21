using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day7CollectionsLab
{
    class Item
    {
        string itemName;
        float price;
        public string ItemName
        {
            get => itemName;
            set=> itemName = value;
        }
        public float Price
        {
            get => price;
            set => price = value;
        }
        public Item(string itemName,float price)
        {
            this.itemName = itemName;
            this.price = price;
        }
        public override string ToString()
        {
            return base.ToString() + "ItemName = " + ItemName + " Price = " + Price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList itemList = new ArrayList();
            itemList.Add(new Item("Fries", 49.0f));
            itemList.Add(new Item("Burger", 99.99f));
            itemList.Add(new Item("Pizza", 129.99f));

            Console.WriteLine("Printing Items from ArrayList");
            foreach (Item i in itemList)
            {
                Console.WriteLine(i.ToString());
            }
            Stack st = new Stack();
            st.Push(new Item("Fries", 49.0f));
            st.Push(new Item("Burger", 99.99f));
            st.Push(new Item("Pizza", 129.99f));
            Console.WriteLine("Printing Items from Stack");
            foreach (Item i in st)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
