using System.Collections.Generic;

namespace FirstRepeatedWordInASentence
{
    public class FirstRepeatWordFinder
    {
        public static string FirstRepeatedWord(string sentence)
        {
            var wordRepCounter = new HashSet<string>();
            var delimiters = new char[] { ' ', ',', ':', '-', '.', '\t' };
            string firstRepeatWord = null;
            foreach (var word in sentence.Split(delimiters))
            {
                if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
                    continue;
                if (wordRepCounter.Contains(word))
                {
                    firstRepeatWord = word;
                    break;
                }
                else
                {
                    wordRepCounter.Add(word);
                }
            }
            return firstRepeatWord;
        }
    }
}
