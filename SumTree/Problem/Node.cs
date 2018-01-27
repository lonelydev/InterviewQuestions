namespace SumTree.Problem
{
    public class Node
    {
        public int data;
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(int value)
        {
            data = value;
            left = right = null;
        }
    }
}
