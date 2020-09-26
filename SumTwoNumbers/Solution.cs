using System;

namespace SumTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // read number from l1
            // in the right order
            // read number from l2 right order
            // add numbers and create final list. 

            // read number1
            long number1 = GetNumber(l1);

            // read number 2
            var numListNode2 = l2;
            long number2 = GetNumber(l2);

            long sum = number2 + number1;
            return CreateListNode(sum);
        }

        private static long GetNumber(ListNode l1)
        {
            var numListNode1 = l1;
            long number1 = 0;
            long iterationCounter = 0;
            while (numListNode1 != null)
            {
                number1 += numListNode1.val * (long) Math.Pow(10, iterationCounter);
                numListNode1 = numListNode1.next;
                iterationCounter++;
            }
            return number1;
        }

        public static ListNode CreateListNode(long numValue)
        {
            ListNode resultNode = null;
            ListNode previousNode = null;
            long iterationCounter = 1;
            if (numValue == 0)
            {
                return new ListNode(0);
            }
            while (numValue > 0)
            {
                int num = (int)(numValue % 10);
                var newNode = new ListNode(num);
                if (iterationCounter == 1)
                {
                    resultNode = newNode;
                }
                if (previousNode != null)
                {
                    previousNode.next = newNode;
                    previousNode = newNode;
                }
                else
                {
                    previousNode = newNode;
                }
                iterationCounter++;
                numValue /= 10;
            }
            return resultNode;
        }
    }
}
