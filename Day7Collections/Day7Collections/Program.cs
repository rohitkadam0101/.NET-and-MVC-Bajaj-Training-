using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack is Prebuilt class inside system.collections whose size can be increased dynamically
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Peek();
            int no_of_elements = stack.Count;
            Console.WriteLine(no_of_elements);
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("array list");

            ArrayList a = new ArrayList ();
            a.Add(90);
            a.Add(78);
            a.Add(44);
            a.Add(4);
            
            //Array a  = new Array(ArrayList.toArray())
            ArrayList n = new ArrayList ();
            n.Add(5);
            n.Add(66);
            a.AddRange(n);
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            a.Sort();
            Console.WriteLine("After Sorting");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(a.BinarySearch(66));
            //a.Insert(7, 3); // element,index
            a.Remove(78);
            a.Reverse();

            ArrayList b = new ArrayList ();
            for(int i = 0; i < 10; i++)
            {
                b.Insert(i, i);
            }

            // Bit Array holds bit values 1 and 0
            BitArray bitarr = new BitArray(5);
            bitarr[2] = true;
            bitarr[4] = true;
            for(int i = 0; i < bitarr.Length; i++)
            {
                Console.WriteLine(bitarr[i]);
            }
            BitArray bitarr2 = new BitArray(5);
            bitarr2[1] = true;
            bitarr2[4] = true;
            BitArray bitarr3 = bitarr.And(bitarr2);
            Console.WriteLine("Values in Bit Array 3");
            for (int i = 0; i < bitarr3.Length; i++)
            {
                Console.WriteLine(bitarr3[i]);
            }

            // Hash Table (Key,Value) pairs
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "apple");
            hashtable.Add(2, "Mango");
            hashtable.Add(3, "Orange");
            hashtable.Add(4, "Pappaya");
            var keys = hashtable.Keys;
            Console.WriteLine("'Hash Table");
            foreach(var x in keys)
            {
                Console.WriteLine(hashtable[x]);
            }
            // Queue
            Queue q = new Queue();
            q.Enqueue("Peter");
            q.Enqueue("Sam");
            q.Enqueue("Edgar");
            q.Enqueue("Mathew");
            int c = q.Count;
            Console.WriteLine("Printing Queue");
            for(int i = 0; i < c; i++){
                Console.WriteLine(q.Dequeue());
                
            }
            // Dictionary 
            Dictionary<Int32, String> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict.Add(2, "Mango");
            dict.Add(3, "Litchi");
            dict.Add(4, "Orange");
            Console.WriteLine("Dictionary Values");
            var keys_dict = dict.Keys;
            foreach(int k in keys_dict)
            {
                Console.WriteLine(dict[k]);
            }
            //Linked List
            LinkedList<string> linkedList = new LinkedList<string>();
            var node = linkedList.AddFirst("Apple");
            linkedList.AddLast("Banana");
            linkedList.AddLast("PineApple");
            linkedList.AddAfter(node, "Litchi");
            Console.WriteLine("Linked List Values");
            foreach(var it in linkedList)
            {
                Console.WriteLine(it);
            }
            Console.ReadKey();
        }
    }
}
