using ReverseWordsInASentenceQuestion.Problem;
using NUnit.Framework;

namespace ReverseWordsInASentenceTester.Tests
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
