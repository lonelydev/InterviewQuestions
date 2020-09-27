namespace SumTwoNumbers.Improved
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var headL1 = l1;
            var headL2 = l2;
            var headSum = new ListNode(0);
            var current = headSum;
            int carryOver = 0;
            while (headL1 != null || headL2 != null)
            {
                int val1 = headL1 != null ? headL1.val : 0;
                int val2 = headL2 != null ? headL2.val : 0;
                int sumVal = val1 + val2 + carryOver;
                carryOver = sumVal / 10;
                int newVal = sumVal % 10;
                current.val += newVal;

                if (headL1 != null)
                {
                    headL1 = headL1.next;
                }

                if (headL2 != null)
                {
                    headL2 = headL2.next;
                }
                if (headL1 != null || headL2 != null)
                {
                    var next = new ListNode(0);
                    current.next = next;
                    current = current.next;
                }
            }
            if (carryOver > 0)
            {
                current.next = new ListNode(carryOver);
            }
            return headSum;
        }
    }
}
