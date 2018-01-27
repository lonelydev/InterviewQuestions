using System.Collections;
using NUnit.Framework;

namespace ReverseWordsInASentenceTester.Tests
{
    class ReverseWordsInASentenceTestInput
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("this.is.a.freaking.long.sentence.that.has.to.be.reversed")
                    .Returns("reversed.be.to.has.that.sentence.long.freaking.a.is.this")
                    .SetName("The long sentence words should be reversed");
                yield return new TestCaseData("will.i.ever.get.a.job")
                    .Returns("job.a.get.ever.i.will")
                    .SetName("The job sentence words should be reversed");
                yield return new TestCaseData("m.a.l.a.y.a.l.a.m")
                    .Returns("m.a.l.a.y.a.l.a.m")
                    .SetName("The palindrome sentence words should be reversed");
            }
        }
    }
}
