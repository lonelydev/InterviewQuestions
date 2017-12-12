using NUnit.Framework;
using System.Collections;

namespace CountPossibleDecodingsTester
{
    public class CountPossibleDecodingsTestInput
    {
        public static IEnumerable TestCases1
        {
            get
            {
                yield return new TestCaseData("1234", 4).Returns(3);
                yield return new TestCaseData("1202", 4).Returns(1);
                yield return new TestCaseData("675356291270936062618792", 24).Returns(0);
                yield return new TestCaseData("123", 3).Returns(3);
                yield return new TestCaseData("103", 3).Returns(1);
                yield return new TestCaseData("23759228973", 11).Returns(4);
                yield return new TestCaseData("05279196", 8).Returns(0);
            }
        }

        public static IEnumerable TestCases2
        {
            get
            {
                yield return new TestCaseData("1234").Returns(3);
                yield return new TestCaseData("1202").Returns(1);
                yield return new TestCaseData("675356291270936062618792").Returns(0);
                yield return new TestCaseData("123").Returns(3);
                yield return new TestCaseData("103").Returns(1);
                yield return new TestCaseData("23759228973").Returns(4);
            }
        }
    }
}
