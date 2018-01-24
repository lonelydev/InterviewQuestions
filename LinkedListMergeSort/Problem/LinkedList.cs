using System;
using System.Text;

namespace LinkedListMergeSort.Problem
{
    /// <summary>
    /// A simple implementation of a linkedlist
    /// that stores integer values
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// a pointer to the first node also commonly called head of the list
        /// </summary>
        Node head;

        /// <summary>
        /// a pointer to the last element of the linked list
        /// </summary>
        Node current;

        public int Count { get; private set; }

        /// <summary>
        /// Creates a linkedlist with head and current pointing to the same node
        /// with an empty data property
        /// </summary>
        public LinkedList(int data)
        {
            // head is a node only to keep track of the first element
            // it does not really store a value
            head = new Node(data);
            current = head;
        }

        /// <summary>
        /// As the name suggests, inserts an element to the end of the list.
        /// </summary>
        /// <param name="data"></param>
        public void Append(int data)
        {
            var newNode = new Node
            {
                Data = data,
                Next = null
            };
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        /// <summary>
        /// Deletes the first occurrence of the element from the list
        /// </summary>
        public void Remove(int data)
        {
            var iterator = head;
            var previous = head;
            while (iterator.Next != null)
            {
                //data matches then previous.next points this.next
                if (iterator.Data == data)
                {
                    previous.Next = iterator.Next;
                }
                previous = iterator;
                iterator = iterator.Next;
            }
        }

        public override string ToString()
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

        /// <summary>
        /// A common interview question
        /// </summary>
        public void Reverse()
        {
            // iterate through elements
            // switch Next pointers to point to the previous
            var iterator = head;
            // initialize temporary variables to null
            Node previous = null;
            Node temporary = null;
            while(iterator != null)
            {
                temporary = iterator.Next;
                iterator.Next = previous;
                previous = iterator;
                iterator = temporary;
            }
            head = previous;
        }

        public void PrintAllNodes()
        {
            var iterator = head;
            while (iterator != null)
            {
                Console.WriteLine(iterator.ToString());
                iterator = iterator.Next;
            }
        }
    }
}
