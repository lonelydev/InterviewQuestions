using CountPossibleDecodingsQuestion.Problem;
using NUnit.Framework;

namespace CountPossibleDecodingsTester.Tests
{
    [TestFixture]
    public class CountPossibleDecodingsTester
    {
        [Test, TestCaseSource(typeof(CountPossibleDecodingsTestInput), "TestCases")]
        public int CountPossibleDecodingsTestRecursive(string inputString)
        {
            return CountPossibleDecodings.NumberOfDecodedStringsRecursive(inputString);
        }

        [Test, TestCaseSource(typeof(CountPossibleDecodingsTestInput), "TestCases")]
        public int CountPossibleDecodingsTestNonRecursive(string inputString)
        {
            return CountPossibleDecodings.NumberOfDecodedStringsNonRecursive(inputString);
        }
        
    }
}
