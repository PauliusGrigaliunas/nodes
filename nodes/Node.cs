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
        private Node _first;
        private Node _second;
        private Node _third;
        private Node _fourth;
        public Node First { get => _first; set => _first = value; }
        public Node Second { get => _second; set => _second = value; }
        public Node Third { get => _third; set => _third = value; }
        public Node Fourth { get => _fourth; set => _fourth = value; }

        public Node(object data, Node next = null)
        {
            _data = data;
            _first = next;
            _second = null;
            _third = null;
            _fourth = null;
        }

        public void AddToFirstEnd(object data)
        {
            if (_first == null) {
                _first = new Node(data);
            }
            else
            {
                _first.AddToFirstEnd(data);
            }

        }

        public void AddToSecondEnd(object data)
        {
            if (_second == null)
            {
                _second = new Node(data);
            }
            else
            {
                _second.AddToSecondEnd(data);
            }

        }
        public void AddToThirdEnd(object data)
        {
            if (_third == null)
            {
                _third = new Node(data);
            }
            else
            {
                _third.AddToThirdEnd(data);
            }

        }

        public void AddToFourthEnd(object data)
        {
            if (_fourth == null)
            {
                _fourth = new Node(data);
            }
            else
            {
                _fourth.AddToFourthEnd(data);
            }

        }


        public void Print() {
            Console.Write(" |" + _data + "->");
            if (_first != null)
                _first.Print();
        }

    }
}
