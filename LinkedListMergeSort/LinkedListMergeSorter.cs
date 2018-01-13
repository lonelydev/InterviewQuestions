using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMergeSort
{
    public class LinkedListMergeSorter
    {
        /// <summary>
        /// very basic straightforward implementation of merge sort
        /// idea is: 
        ///   - if node is null or it has no next, then return node
        ///   - else go find the middle node of the linked list
        ///     then recursively call the same merge sort method on head to middle to sort left list
        ///     another recursive call to sort right list
        ///     then final call to merge both left and right - which again is recursive
        ///     I'm a bit concerned with the amount of recursive methods in here. 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node MergeSort(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            // find the middle of the linkedlist
            var middleNode = GetMiddleNodeOfList(head);
            var nextOfMiddle = middleNode.Next;

            middleNode.Next = null;
            //sort list upto middleNode 
            var left = MergeSort(head);
            //sort list from middleNode
            var right = MergeSort(nextOfMiddle);
            return MergeSortedLists(left, right);
        }

        private static Node GetMiddleNodeOfList(Node head)
        {
            Node singleElementIterator, doubleElementIterator;
            singleElementIterator = doubleElementIterator = head;
            while(doubleElementIterator.Next != null)
            {
                singleElementIterator = singleElementIterator.Next;
                doubleElementIterator = doubleElementIterator.Next.Next;
            }
            return singleElementIterator;
        }

        /// <summary>
        /// a recursive way to merge two sorted linked list. 
        /// this did not strike me until after reading a solution online. 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static Node MergeSortedLists(Node left, Node right)
        {
            if (left == null) return right;
            if (right == null) return left;

            //left and right are sorted lists so we just have to merge them together into a bigger sorted list
            Node mergedListNode = null;
            while (left.Next!=null && right.Next != null)
            {
                if (left.Data < right.Data)
                {
                    mergedListNode = left;
                    mergedListNode.Next = MergeSortedLists(left.Next, right);
                }
                else
                {
                    mergedListNode = right;
                    mergedListNode.Next = MergeSortedLists(left, right.Next);
                }
            }
            return mergedListNode;
        }
    }
}
