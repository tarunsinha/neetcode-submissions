public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hsSet = new HashSet<int>();
        if (nums.Length == 0)
            return 0;

        foreach (var n in nums) {
            if (!hsSet.Contains(n))
                hsSet.Add(n);
        }

        int maxStreak = 1;

        foreach (var n in nums) {
            int curr = n;
            int streak = 1;
            if (!hsSet.Contains(curr - 1)) {  // marks the start of seq
                while (hsSet.Contains(curr + 1)) {
                    curr++;
                    streak++;
                }
                maxStreak = Math.Max(streak, maxStreak);
            }
        }
        return maxStreak;
    }
}
