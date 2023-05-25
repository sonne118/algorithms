<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

class Solution
{
	public int maxProfit(int[] prices)
	{
		// if the given array is empty return 0
		if (prices.Length == 0) return 0;
		// initialize maxProfit to 0
		int maxProfit = 0;
		// we are storing the buying price & keep it smaller
		int buyAt = prices[0];
		for (int i = 1; i < prices.Length; i++)
		{
			maxProfit = Math.Max(maxProfit, prices[i] - buyAt);
			// if buy price greater than current price, then set buyAt = currentPrice
			if (buyAt > prices[i])
			{
				buyAt = prices[i];
			}
		}
		return maxProfit;
	}
}
//
//Input: prices = [7, 1, 5, 3, 6, 4]
//Output: 5
//Explanation: Buy on day 2(price = 1) and sell on day 5(price = 6), profit = 6 - 1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.