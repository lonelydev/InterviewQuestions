using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_ArraysAndStrings.Problems
{
    public class ArrayString_1
    {
        /// <summary>
        /// 
        /// The simplest way to find if all chars in a word are unique is to keep track of the chars
        /// that you have encountered in a quick lookup data structure and return false when it exists 
        /// there already.
        /// When asked this question, do confirm with the interviewer if the word is an ASCII char string.
        /// The datastructure required to track the total number of ascii chars is going to be significantly 
        /// smaller than its unicode counterpart. 
        /// We are going to solve this problem assuming it is an ASCII string.
        /// Time Complexity - O(n)
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool AreAllCharsUnique(string word)
        {
            // ASCII char set will have only 128 characters!!
            if (word.Length > 128)
                return false;

            var charMap = new char[128];
            var wordChars = word.ToCharArray();
            foreach(var character in wordChars)
            {
                if (charMap[character] == character)
                {
                    return false;
                }
                else
                {
                    charMap[character] = character;
                }
            }
            return true;
        }

        public static bool AreAllCharsUniqueBoolBuffer(string word)
        {
            // ASCII char set will have only 128 characters!!
            if (word.Length > 128)
                return false;

            var charMap = new bool[128];
            var wordChars = word.ToCharArray();
            foreach (var character in wordChars)
            {
                if (charMap[character])
                {
                    return false;
                }
                else
                {
                    charMap[character] = true;
                }
            }
            return true;
        }

        /// <summary>
        /// An almost immediate followup to the question is to find out how the same check could be done without a buffer
        /// 
        /// This one uses bit operations. I am not very familiar with them myself.
        /// The suggested method only works for a word that contains a-z
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool AreAllCharsUniqueWithoutBufferBitOp(string word)
        {
            int checker = 0;
            var wordChars = word.ToCharArray();
            foreach(var character in wordChars)
            {
                var val = character - '\0';
                if ((checker & (1 << val)) > 0)
                    return false;
                checker |= (1 << val);
            }
            return true;
        }
    }
}
