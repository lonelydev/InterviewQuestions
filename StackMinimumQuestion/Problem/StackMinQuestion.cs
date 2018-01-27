using System.Collections.Generic;
using System.Linq;

namespace StackMinimumQuestion.Problem
{
    /*
     * Please note that it's Function problem i.e.
     * you need to write your solution in the form of Function(s) only.
     * Driver Code to call/invoke your function would be added by GfG's Online Judge.
     */

    public class StackMinQuestion
    {
        Stack<int> s = new Stack<int>();
        Stack<int> minElements = new Stack<int>();

        /// <summary>
        /// Returns min element from stack
        /// </summary>
        /// <returns></returns>
        public int GetMin()
        {
            if (!s.Any())
            {
                return -1;
            }
            return minElements.Peek();
        }

        /// <summary>
        /// Returns popped element from stack
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (!s.Any())
            {
                return -1;
            }
            minElements.Pop();
            return s.Pop();
        }

        /// <summary>
        /// push element x into the stack
        /// if x is greater than the top minelement then 
        /// push the top min element into the minelement stack again
        /// then insert x into stack
        /// If x is less or equal to top minelement then just push x into
        /// the minelements stack and so into the actual stack
        /// In short whether small or not you have to make sure you insert something into the 
        /// minElement stack so that your pop method is simple. 
        /// All the complexity of tracking minElement is in push. 
        /// </summary>
        /// <param name="x"></param>
        public void Push(int x)
        {
            if (minElements.Any())
            {
                if (minElements.Peek() < x)
                {
                    minElements.Push(minElements.Peek());
                    s.Push(x);
                }
                else
                {
                    minElements.Push(x);
                    s.Push(x);
                }
            }
            else
            {
                minElements.Push(x);
                s.Push(x);
            }
        }
    }
}
