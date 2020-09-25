namespace SwapNodes
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

        public override string ToString()
        {
            if (next == null)
            {
                return $"|Data:{data}|next:null|";
            }
            return $"|Data:{data}|next:->|";
        }
    }
}
