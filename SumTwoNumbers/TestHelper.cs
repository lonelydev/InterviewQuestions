namespace SumTwoNumbers
{
    public class TestHelper
    {
        // takes in a number in the right format and puts it into ListNode
        // "245" => 2-> 4-> 5-> null
        public static ListNode CreateListNode(string numValue)
        {
            ListNode head = null;
            ListNode previous = null;
            for (int i = 0; i < numValue.Length; i++)
            {
                var oneChar = numValue[i];
                var charInt = int.Parse(oneChar.ToString());
                var node = new ListNode(charInt);
                if (head == null)
                {
                    head = node;
                }
                if (previous != null)
                {
                    previous.next = node;
                }
                previous = node;
            }
            return head;
        }

        public static bool AreNodesEqual(ListNode ln1, ListNode ln2)
        {
            var list1 = ln1;
            var list2 = ln2;

            while (list1 != null && list2 != null)
            {
                if (!list1.Equals(list2))
                {
                    return false;
                }

                list1 = list1.next;
                list2 = list2.next;
            }
            return true;
        }
    }
}
