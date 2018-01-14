using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRepeatedWordInASentence
{
    public class FirstRepeatWordFinder
    {
        static string FirstRepeatedWord(string sentence)
        {
            var wordRepCounter = new Dictionary<string, int>();
            var delimiters = new char[] { ' ', ',', ':', '-', '.', '\t' };
            string firstRepeatWord = null;
            foreach (var word in sentence.Split(delimiters))
            {
                if (string.IsNullOrEmpty(word) || string.IsNullOrWhiteSpace(word))
                    continue;
                if (wordRepCounter.ContainsKey(word))
                {
                    firstRepeatWord = word;
                    break;
                }
                else
                {
                    wordRepCounter.Add(word, 1);
                }
            }
            return firstRepeatWord;
        }
    }
}
