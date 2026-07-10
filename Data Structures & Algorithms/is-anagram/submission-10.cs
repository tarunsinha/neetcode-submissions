public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sC = new int[26];
        var tC = new int[26];

        foreach (char c in s) sC[c - 'a']++;
        foreach (char c in t) tC[c - 'a']++;

        return string.Join('.', sC) == string.Join('.', tC);
    }
}
