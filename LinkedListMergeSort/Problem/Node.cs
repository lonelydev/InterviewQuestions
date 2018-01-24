namespace LinkedListMergeSort.Problem
{
    public class Node
    {
        public int? Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public Node()
        {
            Data = null;
            Next = null;
        }

        public override string ToString()
        {
            return string.Format("{0}->{1}", Data, (Next == null) ? "NULL" : "");
        }
    }
}
