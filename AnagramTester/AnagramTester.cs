using NUnit.Framework;
using AnagramQuestion;

namespace AnagramQuestionTester
{
    [TestFixture]
    public class AnagramTester
    {
        //[Test, TestCaseSource(typeof(AnagramTesterInput), "TestCases")]
        //public bool AnagramTest(string input1, string input2)
        //{
        //    return Anagram.Anagram.isAnagram(input1, input2);
        //}

        [Test, TestCaseSource(typeof(AnagramTesterInput), "TestCases")]
        public bool AnagramTestNoDictionary(string input1, string input2)
        {
            return Anagram.isAnagramNoDictionary(input1, input2);
        }
    }
}
