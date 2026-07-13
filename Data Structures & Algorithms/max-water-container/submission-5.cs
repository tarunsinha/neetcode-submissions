public class Solution {
    public int MaxArea(int[] h) {
        int l = 0;
        int r = h.Length - 1;
        int max_area = Int32.MinValue;
        while (l <= r) {
            int height = Math.Min(h[l], h[r]);
            int length = r - l;
            var area = height * length;
            Console.WriteLine(area);
            max_area = Math.Max(area, max_area);
            if (h[l] < h[r])
                l++;
            else
                r--;
        }
        return max_area;
    }
}
