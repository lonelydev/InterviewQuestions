using NUnit.Framework;
using LinkedListMergeSort.Problem;

namespace LinkedListMergeSortTester
{
    [TestFixture]
    public class LinkedListTester
    {
        [Test]
        public void LinkedListAddPrint()
        {
            var list = new LinkedList(13);
            list.Append(12);
            Assert.AreEqual("13->12->NULL", list.ToString());
        }

        [Test]
        public void ListListAddReversePrint()
        {
            var list = new LinkedList(1);
            list.Append(5);
            list.Append(10);
            list.Reverse();
            Assert.AreEqual("10->5->1->NULL", list.ToString());
        }
    }
}
