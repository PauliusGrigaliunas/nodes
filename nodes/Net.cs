using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodes
{
    class Net
    {
        public Node headNode;
        
        public void AddToEnd(object data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);

            }
            else
            {
                headNode.AddToEnd(data);
            }

        }


        public void AddToBegin(object data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);

            }
            else
            {
                Node temp = new Node(data);
                temp.Next = headNode;
                headNode = temp;
            }

        }
        public void Print()
        {
            headNode.Print();
        }
    }
}
