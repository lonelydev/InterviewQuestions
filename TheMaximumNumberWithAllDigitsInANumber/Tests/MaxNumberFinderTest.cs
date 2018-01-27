using TheMaximumNumberWithAllDigitsInANumber.Problem;
using NUnit.Framework;

namespace TheMaximumNumberWithAllDigitsInANumberTester.Tests
{
    [TestFixture]
    public class MaxNumberFinderTest
    {
        [Test, TestCaseSource(typeof(MaxNumberFinderTestInput), "TestCases")]
        public long MaxNumberInAnotherNumberTest(long number)
        {
            return MaxNumberFinder.MaxNumberWithAllDigitsInANumber(number);
        }
        
    }
}
