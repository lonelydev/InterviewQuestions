using NUnit.Framework;
using System.Collections;

namespace ShoppingCheckout
{
  [TestFixture]
  public class CheckoutTester
  {
    [Test, TestCaseSource(typeof(CheckoutTester), "TestItems")]
    public int ScanAndCheckOut(string items)
    {
      return Checkout.ScanAndCheckout(items);
    }

    public static IEnumerable TestItems
    {
      get
      {
        yield return new TestCaseData("ABCDE").Returns(100);
        yield return new TestCaseData("AABCDE").Returns(110);
        yield return new TestCaseData("AABBBBBCDE").Returns(205);
      }
    }
  }
}
