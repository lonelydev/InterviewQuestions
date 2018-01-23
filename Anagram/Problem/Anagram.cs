using System.Collections.Generic;

namespace AnagramQuestion.Problem
{
    public class Anagram
    {
        /// <summary>
        /// A word is an anagram of another word if one can be 
        /// created from the other by simply re-arranging the letters in it
        /// dictionary cannot work for words where a letter is repeated multiple times
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public static bool isAnagram(string string1, string string2)
        {
            var str1 = string1.ToLower();
            var str2 = string2.ToLower();
            if (str1.Length != str2.Length)
            {
                return false;
            }
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < str1.Length; i++) {
                dictionary.Add(str1[i], i + 1);
            }
            for (int i = 0; i < dictionary.Count; i++) {
                if (!dictionary.ContainsKey(str2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// my alternate solution is to convert lower
        /// length check
        /// and then sort both strings
        /// and compare them
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public static bool isAnagramNoDictionary(string string1, string string2)
        {
            if (string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2))
                return false;
                        
            if (string1.Length != string2.Length)
            {
                return false;
            }

            foreach (var c in string2)
            {
                var idx = string1.IndexOf(c);
                //char is present in string1
                if (idx >= 0)
                    string1 = string1.Remove(idx, 1);
                else
                    return false;
            }

            return string.IsNullOrEmpty(string1);
        }
    }
}
