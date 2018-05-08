using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Net list = new Net();
            list.AddToEnd(5);
            list.AddToEnd(4);
            list.AddToEnd(9);
            list.Print();


        }
    }
}
