using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7GenericsLabExercise
{
    
    class ProductInfo<T,E>
    {
        T[] product;
        E[] productType;
        int size;
        public ProductInfo(int size)
        {
            this.size = size;
            product = new T[size];
            productType = new E[size];
        }
        public void PrintDetails()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(product[i] + "," + productType[i]);
            }

        }
        public void addProduct(T productName, int position)
        {
            product[position] = productName;
        }
        public void addProductType(E producttype, int position)
        {
            productType[position] = producttype;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductInfo <string,string> pi = new ProductInfo<string,string>(3);
            pi.addProduct("Lays",0);
            pi.addProductType("Chips", 0);
            pi.addProduct("Pepsi", 1);
            pi.addProductType("Cold Drink", 1);
            pi.addProduct("Coffee", 2);
            pi.addProductType("Drink", 2);
            pi.PrintDetails();
            Console.ReadKey();
        }
    }
}
