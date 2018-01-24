using System.Collections;
using NUnit.Framework;

namespace FirstRepeatedWordInASentenceTester.Tests
{
    class FirstRepeatWordTestInput
    {
        public static IEnumerable RepeatedWordSentences
        {
            get
            {
                yield return new TestCaseData("This, is:a    a sent-ence with-with a repeated word. Are you ready? for this!?")
                    .Returns("a").SetName("Sentence with tabs, space, comma, hyphen, question mark, exclamation and period");
                yield return new TestCaseData("This, this is a wonderful wonderful repeated word sentence.")
                    .Returns("wonderful").SetName("Test if it understands case sensitive repeats");
                yield return new TestCaseData("multi-multi word word in in a a sentence.")
                    .Returns("multi").SetName("Repeats separated by -");
                yield return new TestCaseData("multi:multi word word in in a a sentence.")
                    .Returns("multi").SetName("Repeats separated by :");
                yield return new TestCaseData("multimulti word, word in in a a sentence.")
                    .Returns("word").SetName("Repeats separated by ,");
                yield return new TestCaseData("multimulti word 	word in in a a sentence.")
                    .Returns("word").SetName("Repeats separated by tab");
            }
        }
    }
}
