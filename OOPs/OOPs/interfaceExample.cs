using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface Shape
    {
        void drawShape();
    }
    interface Color
    {
        void addColor();
    }
    class Square : Shape, Color
    {
        public void drawShape()
        {
            Console.WriteLine("Drawing Shape");
        }
        public void addColor()
        {
            Console.WriteLine("Adding Color");
        }
    }
    class printSquare
    {
        public void showShape(Shape s)
        {
            s.drawShape();
        }
        public void ShowColor(Color c)
        {
            c.addColor();
        }
    }
    //class InterfaceExample
    //{
    //    static void Main(string[] args)
    //    {
    //        Square obj = new Square();
    //        printSquare prnt = new printSquare();
    //        prnt.showShape(obj);
    //        prnt.ShowColor(obj);
    //        Console.ReadLine();
    //    }

    //}


}
