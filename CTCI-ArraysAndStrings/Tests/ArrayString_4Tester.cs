using System.Collections;
using NUnit.Framework;
using CTCI_ArraysAndStrings.Problems;

namespace CTCI_ArraysAndStrings.Tests
{
    [TestFixture]
    public class ArrayString_4Tester
    {
        [Test, TestCaseSource(typeof(ArrayString_4TestInput), "EncodeStringInput")]
        public void EncodeStringTester(char[] word, int trueLength, char[] expectedResult)
        {
            ArrayString_4.HtmlEncodeSpaces(word, trueLength);
            Assert.AreEqual(expectedResult, word);
        }
    }

    public class ArrayString_4TestInput
    {
        public static IEnumerable EncodeStringInput
        {
            get
            {
                yield return new TestCaseData(new char[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', '\0', ' ', ' ', ' ', ' ' },
                    13, new char[] { 'M', 'r', '%', '2', '0', 'J', 'o', 'h', 'n', '%', '2', '0', 'S', 'm', 'i', 't', 'h', '\0' });

                yield return new TestCaseData(new char[] { 'A', 'r', 'e', ' ', 'y', 'o', 'u', ' ', 'E', 'a', 'k', 'a', '\0', ' ', ' ', ' ', ' ' },
                    12, new char[] { 'A', 'r', 'e', '%', '2', '0', 'y', 'o', 'u', '%', '2', '0', 'E', 'a', 'k', 'a', '\0' });

                yield return new TestCaseData(
                    new char[] { 'A', ' ', 'e', ' ', 'i', ' ', 'o', ' ', 'u', '\0', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                    9, 
                    new char[] { 'A', '%', '2', '0', 'e', '%', '2', '0', 'i', '%', '2', '0', 'o', '%', '2', '0', 'u', '\0' });
            }
        }
    }
}
