using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Association
{
    class Manager
    {
        public string first_name;
        public string last_name;
        public string department;
        public Manager(string first_name,string last_name,string department)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.department = department;
        }
    }
    class SwipeCard
    {
        string card_no;
        public SwipeCard(string card_no)
        {
            this.card_no = card_no;
        }
        public void swipe(Manager m)
        {
            Console.WriteLine("Card Swipped by {0} {1}", m.first_name, m.last_name);
        }
    }
    internal class Association
    {

    }
}
