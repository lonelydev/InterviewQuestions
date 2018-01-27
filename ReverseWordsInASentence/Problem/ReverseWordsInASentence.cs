using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseWordsInASentenceQuestion.Problem
{
    public class ReverseWordsInASentence
    {
        public static void Main(string[] args)
        {
            var nOfTests = Console.ReadLine();
            var numberOfTests = 0;
            var listOfSentences = new List<string>();
            int.TryParse(nOfTests, out numberOfTests);
            while (numberOfTests > 0)
            {
                var inputSentence = Console.ReadLine();
                Console.WriteLine(ReverseWordsInTheSentence(inputSentence));
                numberOfTests--;
            }            
        }

        public static string ReverseWordsInTheSentence(string sentence)
        {
            var words = sentence.Split('.').Reverse().ToArray();
            return string.Join(".", words);
        }
    }
}
