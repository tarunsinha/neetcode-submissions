public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach (var s in strs) sb.Append(s.Length).Append('#').Append(s);

        return sb.ToString();
    }
    // 5#hello5#World
    public List<string> Decode(string s) {
        /*
        - start from 0 -> till you find the separator ('#')
        - find the substring to get the length of the word in this case 5
        - move i -> j+1 to point at 'h'
        - move j to end -> j+length
        - add into a list substring from i -> length of word
        - move i -> j so that i now points at seconf 5
        */

        int i = 0;
        var res = new List<string>();

        while (i < s.Length) {
            var j = i;
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
