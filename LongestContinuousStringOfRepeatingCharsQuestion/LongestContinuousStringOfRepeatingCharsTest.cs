using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using LongestContinuousStringOfRepeatingChars.Solution;

namespace LongestContinuousStringOfRepeatingChars.Test
{
    [TestFixture]
    public class LongestUniformStringTest
    {
        [Test, TestCaseSource(typeof(LongestUniformStringTestInput), "TestCases")]
        public List<string> SubstringOfStringRepTest1(string input)
        {
            return LongestUniformString.GetRepititiveCharSubstringsAndLengths(input);
        }

        [Test, TestCaseSource(typeof(LongestUniformStringTestInput), "LongestUniformSubstringTuple")]
        public Tuple<int, string> LongestUniformSubstringTester(string input)
        {
            return LongestUniformString.GetLongestUniformubstringsAndStartIndex(input);
        }
    }

    public class LongestUniformStringTestInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("abbbbbaaafccccccccdd").Returns(new List<string> { "a", "bbbbb", "aaa", "f", "cccccccc", "dd" });
                yield return new TestCaseData("geeksforgeeks").Returns(new List<string> { "g", "ee", "k", "s", "f", "o", "r", "g", "ee", "k", "s" });
            }
        }

        public static IEnumerable LongestUniformSubstringTuple
        {
            get
            {
                yield return new TestCaseData("abbbbbaaafccccccccdd").Returns(new Tuple<int, string>(10, "cccccccc"));
                yield return new TestCaseData("geeksforgeeks").Returns(new Tuple<int, string>(1, "ee"));
            }
        }
    }
}
