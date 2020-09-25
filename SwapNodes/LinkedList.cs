using System;
using System.Text;

namespace SwapNodes
{
    public class LinkedList
    {
        public Node head;

        public void Append(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = node;
            }
        }

        public void Append(int x)
        {
            var node = new Node(x);
            Append(node);
        }

        public LinkedList(int[] nodeValues)
        {

            foreach (var nodeValue in nodeValues)
            {
                Append(nodeValue);
            }
        }

        /* swap node that has value x 
         * with a node that as value y
        */
        public void SwapNodes(int x, int y)
        {
            // same node cannot be swapped
            if (x == y)
            {
                return;
            }

            var xPreviousAndNode = FindPreviousAndNode(x);            
            var yPreviousAndNode = FindPreviousAndNode(y);
            
            var xPrevious = xPreviousAndNode.Item1;
            var xNode = xPreviousAndNode.Item2;

            var yPrevious = yPreviousAndNode.Item1;
            var yNode = yPreviousAndNode.Item2;

            if(xNode == null || yNode == null)
            {
                return;
            }

            if (xPrevious == null)
            {
                head = yNode;
            }
            else
            {
                xPrevious.next = yNode;
            }

            if (yPrevious == null)
            {
                head = xNode;
            }
            else
            {
                yPrevious.next = xNode;
            }

            var xNextNode = xNode.next;
            xNode.next = yNode.next;
            yNode.next = xNextNode;
        }

        public Tuple<Node, Node> FindPreviousAndNode(int x)
        {
            if (head == null)
            {
                return null;
            }
            var currentNode = head;
            Node previousNode = null;
            while (currentNode != null && currentNode.data != x)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            return new Tuple<Node, Node>(previousNode, currentNode);
        }

        public override string ToString()
        {
            var asString = new StringBuilder("");
            if (head == null)
            {
                asString.Append("List is Empty!");
                return asString.ToString();
            }
            var p = head;
            while (p != null)
            {
                asString.Append($"{p}");
                p = p.next;
            }            
            return asString.ToString();
        }
    }
}
