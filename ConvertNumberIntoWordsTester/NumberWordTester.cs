using System.Collections;
using ConvertNumberIntoWords;
using NUnit.Framework;

namespace ConvertNumberIntoWordsTester
{
    [TestFixture]
    public class NumberWordTester
    {
        [Test, TestCaseSource(typeof(NumberWordTestInput), "NumberAndWordsTestData")]
        public string NumberInEnglishTest(int number)
        {
            return NumberToEnglishConverter.ToEnglish(number);
        }
    }
    public class NumberWordTestInput
    {
        public static IEnumerable NumberAndWordsTestData
        {
            get
            {
                yield return new TestCaseData(1000).Returns("one thousand").SetName("One Thousand");
                yield return new TestCaseData(1001).Returns("one thousand one").SetName("One Thousand and one");
                yield return new TestCaseData(1101).Returns("one thousand one hundred one").SetName("One Thousand one hundred and one");
                yield return new TestCaseData(1110).Returns("one thousand one hundred ten").SetName("One Thousand one hundred and ten");
                yield return new TestCaseData(1111).Returns("one thousand one hundred eleven").SetName("one thousand one hundred eleven");
                yield return new TestCaseData(1120).Returns("one thousand one hundred twenty").SetName("one thousand one hundred twenty");
                yield return new TestCaseData(21).Returns("twenty one").SetName("twenty one");
                yield return new TestCaseData(19).Returns("nineteen").SetName("nineteen");
                yield return new TestCaseData(10).Returns("ten").SetName("ten");
                yield return new TestCaseData(5).Returns("five").SetName("five");
            }
        }
    }
}
