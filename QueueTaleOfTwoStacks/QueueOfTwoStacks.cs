using System.Collections.Generic;

namespace QueueTaleOfTwoStacks
{
    /// <summary>
    /// This Implementation of a Queue using two stacks make the enqueue operation expensive
    /// by always emptying everything in newestOnTop onto oldestOnTop and then inserting the value 
    /// in newestOnTop and then again emptying oldestOnTop onto newestOnTop.
    /// </summary>
    public class QueueOfTwoStacks
    {
        Stack<int> newestOnTop = new Stack<int>();
        Stack<int> oldestOnTop = new Stack<int>();

        /// <summary>
        /// Method 1 (By making enQueue operation costly) 
        /// This method makes sure that oldest entered element is always at the top of stack 1, 
        /// so that deQueue operation just pops from stack1. To put the element at top of 
        /// stack1, stack2 is used.
        /// enQueue(q, x)
        /// 1) While stack1 is not empty, push everything from satck1 to stack2.
        /// 2) Push x to stack1(assuming size of stacks is unlimited).
        /// 3) Push everything back to stack1.        
        /// </summary>
        /// <param name="val"></param>
        public void Enqueue(int val)
        {
            while (newestOnTop.Count > 0)
            {
                oldestOnTop.Push(newestOnTop.Pop());
            }
            newestOnTop.Push(val);

            while(oldestOnTop.Count > 0)
            {
                newestOnTop.Push(oldestOnTop.Pop());
            }
        }

        /// <summary>
        /// /// dnQueue(q)
        /// 1) If stack1 is empty then error
        /// 2) Pop an item from stack1 and return it
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (newestOnTop.Count <= 0)
            {
                throw new System.Exception("What the hell? you can't pop an empty stack");
            }
            return newestOnTop.Pop();
        }        
    }
}
