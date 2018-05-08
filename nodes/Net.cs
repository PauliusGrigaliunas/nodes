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

        public void AddToEnd(object data, int num = 0)
        {
            if (headNode == null)
            {
                headNode = new Node(data);

            }
            else
            {
                switch (num)
                {
                    case 0:
                        headNode.AddToFirstEnd(data);
                        break;
                    case 1:
                        headNode.AddToSecondEnd(data);
                        break;
                    case 2:
                        headNode.AddToThirdEnd(data);
                        break;
                    case 3:
                        headNode.AddToFourthEnd(data);
                        break;

                }
            }

        }
        public void AddToSecondEnd(object data)
        {
            AddToEnd(data, 1);
        }

        public void AddToThirdEnd(object data)
        {
            AddToEnd(data, 1);
        }
        public void AddToFourthEnd(object data)
        {
            AddToEnd(data, 1);
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
                temp.First = headNode;
                headNode = temp;
            }

        }
        public void Print()
        {
            headNode.Print();
        }
    }
}
