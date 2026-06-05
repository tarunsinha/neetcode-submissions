public class Solution {
    public int MaxArea(int[] heights) {
        int l=0, r= heights.Length-1;
        int max_area =0;

        while(l<r){
            int area = Math.Min(heights[l], heights[r]) * (r-l);
            
            max_area = Math.Max(area, max_area);
            if(heights[r] >= heights[l]) l++;
            else if(heights[r] < heights[l]) r--;
        }
        return max_area;
    }
}
