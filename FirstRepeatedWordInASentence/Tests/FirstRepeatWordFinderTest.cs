using FirstRepeatedWordInASentence.Problem;
using NUnit.Framework;

namespace FirstRepeatedWordInASentenceTester.Tests
{
    [TestFixture]
    public class FirstRepeatWordFinderTest
    {
        [Test, TestCaseSource(typeof(FirstRepeatWordTestInput), "RepeatedWordSentences")]
        public string FirstRepeatedWordTest(string sentence)
        {
            return FirstRepeatWordFinder.FirstRepeatedWord(sentence);
        }
    }
}
