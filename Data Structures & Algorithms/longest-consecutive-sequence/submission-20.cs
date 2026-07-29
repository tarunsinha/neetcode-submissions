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
            if (!hsSet.Contains(n - 1)) {
                int streak = 0;
                var x = n;
                while (hsSet.Contains(x++)) streak++;
                maxStreak = Math.Max(streak, maxStreak);
            }
        }
        return maxStreak;
    }
}
