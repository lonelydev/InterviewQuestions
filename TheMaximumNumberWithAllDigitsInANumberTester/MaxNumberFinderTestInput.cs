using System.Collections;
using NUnit.Framework;

namespace TheMaximumNumberWithAllDigitsInANumberTester
{
    [TestFixture]
    public class MaxNumberFinderTestInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(38293367).Returns(98763332);
                yield return new TestCaseData(1203465).Returns(6543210);
            }
        }
        
    }
}
