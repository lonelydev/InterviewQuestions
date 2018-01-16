using System;

namespace CTCI_LinkedList.Problems
{
    /// <summary>
    /// Implement an algorithm to find the k'th to the last element of a singly linked list.
    /// In a singly linked list you can only traverse in one direction. 
    /// So when asked to print the penultimate elment, you have to travel from the first to the penultimate element
    /// And you also need a way to identify that it is the penultimate or in this case, a more general, k'th element 
    /// from the end.
    /// 
    /// Also keep in mind that the size of the linked list is not always known. This would have made the algorithm easy to implement
    /// </summary>
    public class LinkedList_2
    {

        /// <summary>
        /// A recursive solution to print the kth to the last element in a linked list
        /// Here we do not return the node, however we just print the value. 
        /// Why recurse?
        /// When a recursive function executes, it keeps calling itself till it hits the base case 
        /// and then returns backwards, helping us seemingly traverse the linked list backwards 
        /// It returns the number of the node in the linked list from the last
        /// </summary>
        /// <param name="node"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int PrintKthElementRecursive(SinglyLinkedList node, int k, ref int kthElementValue)
        {
            if (node == null)
                return 0;

            int i = PrintKthElementRecursive(node.Next, k, ref kthElementValue) + 1;
            //print this node's data if i is the kth element 
            if (i == k)
            {
                kthElementValue = node.Data;
                Console.WriteLine(node.Data);
            }
            return i;
        }
    }
}
