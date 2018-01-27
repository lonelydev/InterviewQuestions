namespace SumTree.Problem
{
    public class SumTreeQuestion
    {
        private static int Sum(Node root)
        {
            if (root == null)
                return 0;
            return Sum(root.left) + root.data + Sum(root.right);
        }

        public static bool IsSumTree(Node node)
        {

            //if null node or leaf node then it is a sumtree.
            if ((node == null) || (node.left == null && node.right == null))
                return true;

            int leftTreeSum = Sum(node.left);
            int rightTreeSum = Sum(node.right);

            if (node.data == (leftTreeSum + rightTreeSum) && IsSumTree(node.left) && IsSumTree(node.right))
            {
                return true;
            }
            return false;
        }
    }
}
