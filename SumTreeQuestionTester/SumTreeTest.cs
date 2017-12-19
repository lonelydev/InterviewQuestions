using SumTree;
using NUnit.Framework;

namespace SumTreeQuestionTester
{
    [TestFixture]
    public class SumTreeTest
    {
        [Test]
        public void IsSumTreeTest_1()
        {
            var root = new Node(26);
            root.left = new Node(10);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(6);
            root.right.right = new Node(3);

            Assert.AreEqual(true, SumTreeQuestion.IsSumTree(root));
        }

        [Test]
        public void IsSumTreeTest_2()
        {
            var root = new Node(3);
            root.left = new Node(1);
            root.right = new Node(2);
            
            Assert.AreEqual(true, SumTreeQuestion.IsSumTree(root));
        }

        [Test]
        public void IsSumTreeTest_3()
        {
            var root = new Node(10);
            root.left = new Node(20);
            root.right = new Node(30);
            root.left.left = new Node(40);
            root.left.right = new Node(60);

            Assert.AreEqual(false, SumTreeQuestion.IsSumTree(root));
        }
    }
}
