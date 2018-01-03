using FirstNonRepeatingCharacterInStringQuestion;
using NUnit.Framework;

namespace FirstNonRepeatingCharactersInStringTester
{
    [TestFixture]
    public class FirstNonRepeatingCharInStringTester
    {
        [Test]
        public void FirstNonRepeaterTest1()
        {
            var stringLength = new StringsLengths(5, "aabbc");
            Assert.AreEqual("c", FirstNonRepeatingCharacterInString.NonRepeatingCharacter(stringLength));
        }

        [Test]
        public void FirstNonRepeaterTest2()
        {
            var stringLength = new StringsLengths(6, "paalla");
            Assert.AreEqual("p", FirstNonRepeatingCharacterInString.NonRepeatingCharacter(stringLength));
        }
    }
}
