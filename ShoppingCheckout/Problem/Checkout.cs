using System.Collections.Generic;
using System.Linq;

namespace ShoppingCheckout
{
  public class Checkout
  {
    private static Dictionary<char, int> itemPrices = new Dictionary<char, int>()
        {
            { 'A', 20},
            { 'B', 30},
            { 'C', 10},
            { 'D', 25},
            { 'E', 15}
        };

    private static Dictionary<char, KeyValuePair<int, int>> itemOffer = new Dictionary<char, KeyValuePair<int, int>>()
        {
            {'A', new KeyValuePair<int, int>(2, 30)}, { 'B', new KeyValuePair<int, int>(5, 125) }
        };

    public static int ScanAndCheckout(string items)
    {
      var runningTotal = 0;
      var itemCounts = items.GroupBy(i => i).Select(group => new { Item = group.Key, Count = group.Count() });
      foreach (var itemCount in itemCounts)
      {
        // if we have an offer then apply it
        if (itemOffer.ContainsKey(itemCount.Item) && ((itemCount.Count >= itemOffer[itemCount.Item].Key)))
        {
          var offer = itemOffer[itemCount.Item];
          var offerMultiplier = (itemCount.Count / offer.Key);
          // apply offer n number of times where n  = itemCount / offerOnNumber
          if (offerMultiplier > 0)
          {
            runningTotal += offerMultiplier * offer.Value;
            // then add remainder number of items at regular price
            var remainingNoOfferItemCount = itemCount.Count % offer.Key;
            runningTotal += remainingNoOfferItemCount * itemPrices[itemCount.Item];
          }
        }
        else
        {
          runningTotal += itemCount.Count * itemPrices[itemCount.Item];
        }
      }
      return runningTotal;
    }
  }
}
