using NUnit.Framework;
using System.Collections;

namespace CountPossibleDecodingsTester
{
    public class CountPossibleDecodingsTestInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("1234").Returns(3);
                yield return new TestCaseData("1202").Returns(1);
                yield return new TestCaseData("675356291270936062618792").Returns(0);
                yield return new TestCaseData("123").Returns(3);
                yield return new TestCaseData("103").Returns(1);
                yield return new TestCaseData("23759228973").Returns(4);
                yield return new TestCaseData("05279196").Returns(0);
            }
        }
    }
}
