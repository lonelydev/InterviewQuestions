using System.Collections;
using NUnit.Framework;
using CTCI_ArraysAndStrings.Problems;

namespace CTCI_ArraysAndStrings.Tests
{
    [TestFixture]
    public class ArrayString_5Tester
    {
        [Test, TestCaseSource(typeof(ArrayString_5TesterInputs), "WordsToCompress")]
        public string CompressTest(string word)
        {
            return ArrayString_5.CompressIfNecessary(word);
        }

        [Test, TestCaseSource(typeof(ArrayString_5TesterInputs), "WordsToCompress")]
        public string CompressTestWithChecksFirst(string word)
        {
            return ArrayString_5.CompressIfNecessaryCheckFirst(word);
        }
    }

    public class ArrayString_5TesterInputs
    {
        public static IEnumerable WordsToCompress
        {
            get
            {
                yield return new TestCaseData("aaaabcccccde").Returns("a4b1c5d1e1");
                yield return new TestCaseData("abra").Returns("abra");
                yield return new TestCaseData("jaaambulka").Returns("jaaambulka");
                yield return new TestCaseData("eeeeaakkkkaaaaannnn").Returns("e4a2k4a5n4");
            }
        }
    }
}
