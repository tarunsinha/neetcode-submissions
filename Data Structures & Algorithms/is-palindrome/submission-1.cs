public class Solution {
    public bool IsPalindrome(string s) {
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        int l = 0;
        int r = s.Length - 1;

        while (l < r) {
            while (l < r && !IsAlphaNum(s[l])) l++;
            while (l < r && !IsAlphaNum(s[r])) r--;
            if (char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
            l++;
            r--;
        }
        return true;
    }

    public bool IsAlphaNum(char c) {
        return (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z' || c >= '0' && c <= '9');
    }
}
