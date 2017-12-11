using System.Collections.Generic;

namespace QueueTaleOfTwoStacks
{
    /// <summary>
    /// This Implementation of a Queue using two stacks make the dequeue operation expensive
    /// Method 2 (By making deQueue operation costly)In this method, in en-queue operation, 
    /// the new element is entered at the top of stack1. In de-queue operation, 
    /// if stack2 is empty then all the elements are moved to stack2 and 
    /// finally top of stack2 is returned.
    /// </summary>
    public class QueueOfTwoStacks1
    {
        Stack<int> newestOnTop = new Stack<int>();
        Stack<int> oldestOnTop = new Stack<int>();

        /// <summary>
        /// enQueue(q, x)
        /// 1) Push x to stack1(assuming size of stacks is unlimited).
        /// </summary>
        /// <param name="val"></param>
        public void Enqueue(int val)
        {
            newestOnTop.Push(val);
        }

        /// <summary>
        /// deQueue(q)
        /// 1) If both stacks are empty then error.
        /// 2) If stack2 is empty
        /// While stack1 is not empty, push everything from stack1 to stack2.
        /// 3) Pop the element from stack2 and return it.
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (newestOnTop.Count <= 0 && oldestOnTop.Count <= 0)
            {
                throw new System.Exception("Sorry Nothing in here to deque");
            }
            if (oldestOnTop.Count <= 0)
            {
                while (newestOnTop.Count > 0)
                {
                    oldestOnTop.Push(newestOnTop.Pop());
                }
                return oldestOnTop.Pop();
            }
            else
            {
                throw new System.Exception("Sorry Nothing in here to deque");
            }
        }    
    }
}
