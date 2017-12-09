using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using LongestContinuousStringOfRepeatingCharsQuestion;

namespace LongestContinuousStringOfRepeatingCharsTester
{
    [TestFixture]
    public class LongestContinuousStringOfRepeatingCharsTest
    {
        [Test, TestCaseSource(typeof(SubstringOfStringTesterInputs), "TestCases")]
        public List<string> SubstringOfStringRepTest1(string input)
        {
            return LongestContinuousStringOfRepeatingChars.GetRepititiveCharSubstringsAndLengths(input);
        }
    }

    public class SubstringOfStringTesterInputs
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("abbbbbaaafccccccccdd").Returns(new List<string> { "a", "bbbbb", "aaa", "f", "cccccccc", "dd" });
                yield return new TestCaseData("geeksforgeeks").Returns(new List<string> { "g", "ee", "k", "s", "f", "o", "r", "g", "ee", "k", "s" });
            }
        }
    }
}
