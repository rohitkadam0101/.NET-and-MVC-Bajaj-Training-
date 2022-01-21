using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Train
    {
        public int trainno = 10011;
        public void  printTrain()
        {
            Console.WriteLine(trainno);
        }
    }
    class TrainInherited : Train
    {
        void print()
        {
            printTrain();
        }
    }
}