public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1, maxPro = 0;

        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                maxPro = Math.Max(maxPro, prices[r] - prices[l]);
            } else
                l = r;
            r++;
        }
        return maxPro;
    }
}
