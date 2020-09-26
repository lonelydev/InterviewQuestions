using System;
using System.Text;

namespace SumTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public override string ToString()
        {
            if (next == null)
            {
                return $"|Data:{val}|next:null|";
            }
            return $"|Data:{val}|next:->|";
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ListNode ln = (ListNode)obj;
                return this.val == ln.val;
            }
        }

        public override int GetHashCode()
        {
            return val;
        }
    }
}
