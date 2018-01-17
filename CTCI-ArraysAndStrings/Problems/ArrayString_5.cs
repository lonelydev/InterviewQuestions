using System.Text;

namespace CTCI_ArraysAndStrings.Problems
{
    /// <summary>
    /// Compress a string sequence
    /// given a string aabcccdddde
    /// return a2b1c3d4e1
    /// provided that is shorter than the actual input
    /// </summary>
    public class ArrayString_5
    {
        /// <summary>
        /// This one is the simplest method that popped into my head, just as I thought of of a solution.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string CompressIfNecessary(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;
            var compressed = new StringBuilder();
            char prev = word[0];
            int charCounter = 1;
            for (int i = 1; i <= word.Length; i++)
            {
                if (i == word.Length)
                {
                    compressed.Append(prev);
                    compressed.Append(charCounter);
                    break;
                }
                if (word[i] == prev)
                {
                    charCounter++;
                }
                else
                {
                    compressed.Append(prev);
                    compressed.Append(charCounter);
                    prev = word[i];
                    charCounter = 1;
                }
            }
            if (compressed.Length < word.Length)
                return compressed.ToString();
            else
                return word;
        }

        /// <summary>
        /// Previously we went and did compression anyway and checked what to return only after doing
        /// the operation. 
        /// Another way to do this is to check beforehand if the compression has to happen
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string CompressIfNecessaryCheckFirst(string word)
        {
            var sizeOfCompressedString = CompressedStringSize(word);
            if (sizeOfCompressedString >= word.Length)
            {
                return word;
            }
            int charCounter = 1;
            char prev = word[0];
            var compressed = new StringBuilder();
            for (int i = 1; i <= word.Length; i++)
            {
                if (i == word.Length)
                {
                    compressed.Append(prev);
                    compressed.Append(charCounter);
                    break;
                }
                if (word[i] == prev)
                {
                    charCounter++;
                }
                else
                {
                    compressed.Append(prev);
                    compressed.Append(charCounter);
                    prev = word[i];
                    charCounter = 1;
                }
            }
            return compressed.ToString();
        }

        private static int CompressedStringSize(string word)
        {
            int size = 0;
            int counter = 1;
            var prev = word[0];
            for(int i=1; i <= word.Length; i++)
            {
                if (i == word.Length)
                {
                    size += 1 + counter.ToString().Length;
                    break;
                }
                if (word[i] == prev)
                {
                    counter++;
                }
                else
                {
                    size += 1 + counter.ToString().Length;
                    prev = word[i];
                    counter = 1;
                }
            }
            return size;
        }
    }
}
