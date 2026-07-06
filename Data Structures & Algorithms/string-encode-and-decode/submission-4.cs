public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach (var s in strs) sb.Append(s.Length).Append('#').Append(s);

        return sb.ToString();
    }
    // 5#hello5#World
    public List<string> Decode(string s) {
        var res = new List<string>();

        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') j++;

            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;
            j = i + length;
            res.Add(s.Substring(i, length));
            i = j;
        }
        return res;
    }
}
