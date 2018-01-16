using System;
using System.Collections;
using System.Collections.Generic;
using CTCI_ArraysAndStrings.Problems;
using NUnit.Framework;

namespace CTCI_ArraysAndStrings.Tests
{
    [TestFixture]
    class ArrayString_1Tester
    {
        [Test, TestCaseSource(typeof(ArrayString_1TesterInput), "UniqueCharWordsInput")]
        public bool ArrayString_1Test(string word)
        {
            return ArrayString_1.AreAllCharsUnique(word);
        }

        [Test, TestCaseSource(typeof(ArrayString_1TesterInput), "UniqueCharWordsInput")]
        public bool ArrayString_1TestBoolBuffer(string word)
        {
            return ArrayString_1.AreAllCharsUniqueBoolBuffer(word);
        }

        [Test, TestCaseSource(typeof(ArrayString_1TesterInput), "UniqueCharWordsInput1")]
        public bool ArrayString_1TestNoBufferBitOp(string word)
        {
            return ArrayString_1.AreAllCharsUniqueWithoutBufferBitOp(word);
        }
    }

    public class ArrayString_1TesterInput
    {
        public static IEnumerable UniqueCharWordsInput
        {
            get
            {
                yield return new TestCaseData("eakan").Returns(false);
                yield return new TestCaseData("e").Returns(true);
                yield return new TestCaseData("durga").Returns(true);
                yield return new TestCaseData("bloom").Returns(false);
                yield return new TestCaseData("eg13dk12").Returns(false);
                yield return new TestCaseData("factset").Returns(false);
                yield return new TestCaseData("google").Returns(false);
                yield return new TestCaseData("amazon").Returns(false);
                yield return new TestCaseData("goldman").Returns(true);
                yield return new TestCaseData(AllAsciiChars).Returns(true);
            }
        }

        public static IEnumerable UniqueCharWordsInput1
        {
            get
            {
                yield return new TestCaseData("eakan").Returns(false);
                yield return new TestCaseData("e").Returns(true);
                yield return new TestCaseData("durga").Returns(true);
                yield return new TestCaseData("bloom").Returns(false);
                yield return new TestCaseData("eg13dk12").Returns(false);
                yield return new TestCaseData("factset").Returns(false);
                yield return new TestCaseData("google").Returns(false);
                yield return new TestCaseData("amazon").Returns(false);
                yield return new TestCaseData("goldman").Returns(true);                
            }
        }

        //Bad idea shouldn't be tested. it actually prints way more than 128!
        //public static string AllAsciiChars
        //{
        //    get
        //    {
        //        var allChars = new List<char>();
        //        for (int i = char.MinValue; i <= char.MaxValue; i++)
        //        {
        //            char c = Convert.ToChar(i);
        //            allChars.Add(c);
        //        }
        //        return string.Join("", allChars.ToArray());
        //    }
        //}

        public static string AllAsciiChars
        {
            get
            {
                var printableChars = new List<char>();
                for (int i = 0; i <= 127; i++)
                {

                    char c = Convert.ToChar(i);
                    if (!char.IsControl(c))
                    {
                        printableChars.Add(c);
                    }
                }
                return string.Join("", printableChars.ToArray());
            }
        }
    }
}
