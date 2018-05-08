using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodes
{
    class Node
    {
        private object _data;
        private Node _next;
        public Node Next { get => _next; set => _next = value; }

        public Node(object data, Node next = null)
        {
            _data = data;
            _next = next;
        }

        public void AddToEnd( object data)
        {
            if (_next == null) {
                _next = new Node(data);
            }
            else
            {
                _next.AddToEnd(data);
            }

        }

        public void Print() {
            Console.Write(" |" + _data + "->");
            if (_next != null)
                _next.Print();
        }

    }
}
