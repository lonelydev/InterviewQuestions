using System.Collections;
using NUnit.Framework;

namespace AnagramQuestionTester
{
    public class AnagramTesterInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("adult", "dulta")
                    .Returns(true)
                    .SetName("dulta is an anagram of adult");
                yield return new TestCaseData("anagram", "nagaram")
                    .Returns(true)
                    .SetName("nagaram is an anagram of anagram"); ;
                yield return new TestCaseData("anagram", "kilogram")
                    .Returns(false)
                    .SetName("anagram is not an anagram of kilogram");
            }
        }
    }
}
