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

            /*Node nodes = new Node(4);
            nodes.First = new Node(3);
            nodes.First.Second = new Node(7);
            nodes.First.Second.First = new Node(8);
            nodes.Print();*/

            Net list = new Net();
            list.headNode = new Node(4);
            list.headNode.First = new Node(4);
            /*list.AddToEnd(5);
            list.AddToEnd(4);
            list.AddToEnd(9);
            list.AddToSecondEnd(44);
            list.AddToEnd(9);
            list.AddToThirdEnd(12);
            list.AddToFourthEnd(30);
            list.AddToEnd(9);*/
            list.Print();


        }
    }
}
