public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0,r =1;
        int maxP =0;
        while(r<prices.Length){
            if(prices[l] < prices[r]) {
                maxP =  Math.Max(maxP, (prices[r]- prices[l]));
            }
            else {l=r;}
            r++;
        }
        return maxP;
    }
}
