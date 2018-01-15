using CountPossibleDecodingsQuestion;
using NUnit.Framework;

namespace CountPossibleDecodingsTester
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
