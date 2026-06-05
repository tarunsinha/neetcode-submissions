public class Solution {
    public int MaxArea(int[] ht) {
        int l=0; int r= ht.Length-1; int max_area =0;

        while(l<=r){
            int h = Math.Min(ht[l], ht[r]);
            int d = r-l;
            int curr_area = h*d;
            max_area = Math.Max(curr_area, max_area);

            if(ht[r] > ht[l]) l++;
            else r--;

        }
        return max_area;
    }
}
