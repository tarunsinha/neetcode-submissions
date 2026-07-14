public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int maxArea = 0;
        while (left < right) {
            int currentHeight = Math.Min(heights[left], heights[right]);
            int width = right - left;
            var area = currentHeight * width;
            maxArea = Math.Max(area, maxArea);
            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}
