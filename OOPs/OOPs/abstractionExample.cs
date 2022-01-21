using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract class Item
    {
        public abstract void setDetails();
    }
    class giftItem : Item
    {
        public override void setDetails()
        {
            Console.WriteLine("Helloooooo");
        }
    }
}
