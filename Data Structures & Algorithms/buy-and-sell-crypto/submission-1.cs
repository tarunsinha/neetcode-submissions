public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0, r= 1, max_profit = 0;
        while(r< prices.Length){
            if(prices[l] < prices[r]){
               max_profit = Math.Max(max_profit, (prices[r]-prices[l]));
            }
            else{
                l=r;
            }
            r++;
        }
        return max_profit;
    }
}


/* [10,1,5,6,7,1]


*/
