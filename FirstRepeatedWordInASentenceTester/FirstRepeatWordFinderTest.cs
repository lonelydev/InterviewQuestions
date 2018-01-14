using FirstRepeatedWordInASentence;
using NUnit.Framework;

namespace FirstRepeatedWordInASentenceTester
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
