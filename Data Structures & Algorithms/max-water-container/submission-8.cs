public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        int maxArea = 0;
        while (l < r) {
            int h = Math.Min(heights[l], heights[r]);
            int ln = r - l;
            var area = h * ln;
            maxArea = Math.Max(area, maxArea);
            if (heights[l] < heights[r])
                l++;
            else
                r--;
        }
        return maxArea;
    }
}
