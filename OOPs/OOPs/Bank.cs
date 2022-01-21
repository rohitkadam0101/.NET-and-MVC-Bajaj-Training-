using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Bank
    {
        int amount = 0; // should be private(encapsulation) as we cannot give direct access to ammount vairable
        public void depositAmount(int value)
        {
            if (value <= 0)
            {
                Console.WriteLine("Cannot add negative amount or zero");
            }
            else
            {
                amount += value;

            }
            
        }
        public void withdrawAmount(int v)
        {
            if (v > amount)
            {
                Console.WriteLine("Account Balance not sufficient");
            }
            else
            {
                amount -= v;
            }
            
        }
        public void displayAmount()
        {
            Console.WriteLine("Balance = {0}", amount);
        }
    }
}
