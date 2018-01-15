using CountPossibleDecodingsQuestion;
using NUnit.Framework;

namespace CountPossibleDecodingsTester
{
    [TestFixture]
    public class CountPossibleDecodingsTester
    {
        [Test, TestCaseSource(typeof(CountPossibleDecodingsTestInput), "TestCases1")]
        public int CountPossibleDecodingsTestRecursive(string inputString, int lengthOfInputString)
        {
            return CountPossibleDecodings.NumberOfDecodedStringsRecursive(inputString, lengthOfInputString);
        }

        [Test, TestCaseSource(typeof(CountPossibleDecodingsTestInput), "TestCases1")]
        public int CountPossibleDecodingsTestNonRecursive(string inputString, int lengthOfInputString)
        {
            return CountPossibleDecodings.NumberOfDecodedStringsNonRecursive(inputString, lengthOfInputString);
        }

        [Test, TestCaseSource(typeof(CountPossibleDecodingsTestInput), "TestCases2")]
        public int CountPossibleDecodingsTestRecursive(string inputString)
        {
            return CountPossibleDecodings.NumberOfDecodedStringsRecursive(inputString);
        }

        [Test, TestCaseSource(typeof(CountPossibleDecodingsTestInput), "TestCases2")]
        public int CountPossibleDecodingsTestNonRecursive(string inputString)
        {
            return CountPossibleDecodings.NumberOfDecodedStringsNonRecursive(inputString);
        }
        
    }
}
