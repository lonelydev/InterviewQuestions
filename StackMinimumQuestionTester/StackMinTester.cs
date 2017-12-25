using NUnit.Framework;
using StackMinimumQuestion;

namespace StackMinimumQuestionTester
{
    [TestFixture]
    public class StackMinTester
    {
        [Test]
        public void StackMinTest1()
        {
            var gfg = new StackMinQuestion();
            gfg.Push(10);
            gfg.Push(5);
            gfg.Push(7);
            gfg.Push(9);
            gfg.Push(4);
            Assert.AreEqual(4, gfg.GetMin());

            gfg.Pop();
            Assert.AreEqual(5, gfg.GetMin());
        }

        [Test]
        public void StackMinTest2()
        {
            var gfg = new StackMinQuestion();
            gfg.Push(10);
            gfg.Push(9);
            gfg.Push(8);
            gfg.Push(7);
            gfg.Push(6);
            Assert.AreEqual(6, gfg.GetMin());

            gfg.Pop();
            Assert.AreEqual(7, gfg.GetMin());


            gfg.Pop();
            Assert.AreEqual(8, gfg.GetMin());


            gfg.Pop();
            Assert.AreEqual(9, gfg.GetMin());
        }

        [Test]
        public void StackMinTest3()
        {
            var gfg = new StackMinQuestion();
            gfg.Push(10);
            Assert.AreEqual(10, gfg.GetMin());            
        }

        [Test]
        public void StackMinTest4()
        {
            var gfg = new StackMinQuestion();            
            Assert.AreEqual(-1, gfg.GetMin());
        }

        [Test]
        public void StackMinTest5()
        {
            var gfg = new StackMinQuestion();
            gfg.Push(10);
            Assert.AreEqual(10, gfg.GetMin());
            gfg.Pop();
            Assert.AreEqual(-1, gfg.GetMin());
        }
    }
}
