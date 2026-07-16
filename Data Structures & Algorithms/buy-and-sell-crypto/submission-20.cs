public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, maxProfit = 0;
        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                var profit = prices[r] - prices[l];
                maxProfit = Math.Max(profit, maxProfit);

            } else
                l = r;
            r++;
        }
        return maxProfit;
    }
}
