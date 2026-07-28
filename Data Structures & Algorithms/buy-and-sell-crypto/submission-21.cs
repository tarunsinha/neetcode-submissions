public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, maxProfit = 0;
        while (r < prices.Length) {
            if (prices[r] < prices[l]) {
                l = r;
            } else {
                maxProfit = Math.Max(prices[r] - prices[l], maxProfit);
            }
            r++;
        }
        return maxProfit;
    }
}
