using System.Collections.Generic;

namespace CTCI_LinkedList.Problems
{
    /// <summary>
    /// Solutions for removing duplicates from an unsorted singly linked LinkedList. 
    /// </summary>
    public class LinkedList_1
    {
        /// <summary>
        /// The most straightforward way is to have a map to keep track of elements and occurrence
        /// and delete accordingly.
        /// This solution being the simplest, may not be accepted by the interviewer.
        /// This solution takes O(n)  time where n is obviously the number of elements in the linked list.
        /// </summary>
        /// <param name="head"></param>
        public static void RemoveDuplicates(SinglyLinkedList head)
        {
            var valuesMap = new HashSet<int>();
            var n = head;
            SinglyLinkedList previous = null;
            while (n != null)
            {
                if (valuesMap.Contains(n.Data))
                {
                    previous.Next = n.Next;
                }
                else
                {
                    valuesMap.Add(n.Data);
                    previous = n;
                }
                n = n.Next;
            }
        }

        /// <summary>
        /// Now if you are not allowed to use a secondary storage space or buffer to track your duplicates
        /// how would you remove duplicates? Sounds crazy right?
        /// One of the most common techniques to solve linked list problems is to use two pointers to traverse the list. 
        /// Now you might just say "hey but that's a buffer right there". I think so too. But CTCI thinks otherwise.
        /// The idea is to keep:
        ///   * one pointer at the node in context, the one you are checking if it has duplicates
        ///   * the other pointer goes through the remaining elements to check if there is a duplicate
        /// That does sound easy enough. 
        /// This way the time complexity is O(n^2)
        /// space complexity is O(1)
        /// </summary>
        /// <param name="head"></param>
        public static void RemoveDuplicatesWithoutBuffer(SinglyLinkedList head)
        {
            if (head == null)
            {
                return;
            }

            var current = head;
            while (current != null)
            {
                SinglyLinkedList runner = current;
                while (runner.Next != null)
                {
                    // do we have a duplicate?
                    if (runner.Next.Data == current.Data)
                    {
                        // reset the pointer - basically what delete would do
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }
    }
}
