using System.Text;

namespace CTCI_LinkedList
{
    /// <summary>
    /// Simplest implementation of LinkedList as given in CTCI
    /// </summary>
    public class SinglyLinkedList
    {
        public SinglyLinkedList Next = null;
        public int Data;

        public SinglyLinkedList(int d)
        {
            Data = d;
        }

        /// <summary>
        /// add d to the end of the linked list.
        /// </summary>
        /// <param name="d"></param>
        public void AppendToTail(int d)
        {
            var end = new SinglyLinkedList(d);
            var node = this;
            while(node.Next != null)
            {
                node = node.Next;
            }
            node.Next = end;
        }

        /// <summary>
        /// Delete val from the linked list that starts at head
        /// You are relying on the garbage collector to clear unreferenced elements
        /// not sure I like this way, I prefer my delete method in the LinkedList merge sort project
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public SinglyLinkedList Delete(SinglyLinkedList head, int val)
        {
            var n = head;
            // check existing element
            if (n.Data == val)
            {
                return head.Next;
            }

            //check the remaining elements
            while (n.Next != null)
            {
                if (n.Next.Data == val)
                {
                    n.Next = n.Next.Next;
                    return head;
                }
                n = n.Next;
            }
            return head;
        }

        public static string ToString(SinglyLinkedList head)
        {
            var iterator = head;
            var stringRep = new StringBuilder();
            while (iterator != null)
            {
                stringRep.Append(iterator.ToString());
                //forgot this at first. infinite loop
                iterator = iterator.Next;
            }
            return stringRep.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}->{1}", Data, (Next == null) ? "NULL" : "");
        }
    }
}
