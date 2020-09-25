namespace SwapNodes
{
    public class NodeSwapper
    {
        public LinkedList demoLinkedList { get; set; }
        public NodeSwapper(LinkedList linkedList)
        {
            demoLinkedList = linkedList;
        }
        public LinkedList SwapNodes(int x, int y)
        {
            demoLinkedList.SwapNodes(x, y);
            return demoLinkedList;
        }
    }
}
