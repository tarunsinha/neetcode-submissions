
public class Solution
{
    public int[] TwoSum(int[] n, int target)
    {
        int l = 0, r = n.Length-1;
        while (l < r)
        {
            int sum = n[l] + n[r];
            if (sum < target) l++;
            else if (sum > target) r--;
            else { return new int[]{l + 1, r + 1}; }
        }
        return new int[0];
    }
}