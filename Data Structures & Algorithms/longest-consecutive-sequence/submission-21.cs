public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hsSet = new HashSet<int>();
        if (!nums.Any())
            return 0;

        foreach (var n in nums) {
            if (!hsSet.Contains(n))
                hsSet.Add(n);
        }

        // find start of the sequence
        var maxStreak = 1;

        foreach (var n in nums) {
            int streak = 1;
            var x = n;
            if (!hsSet.Contains(n - 1)) {
                while (hsSet.Contains(x+1)) {
                    x++;
                    streak++;
                }
                maxStreak = Math.Max(streak, maxStreak);
            }
        }
        return maxStreak;
    }
}
