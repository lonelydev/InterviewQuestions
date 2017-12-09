using ReverseWordsInASentenceQuestion;
using NUnit.Framework;

namespace ReverseWordsInASentenceTester
{
    [TestFixture]
    public class ReverseWordsInASentenceTest
    {
        [Test, TestCaseSource(typeof(ReverseWordsInASentenceTestInput), "TestCases")]
        public string ReverseWordsInTheSentenceTest(string input)
        {
            return ReverseWordsInASentence.ReverseWordsInTheSentence(input);
        }
    }
}
