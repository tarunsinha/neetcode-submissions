public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        foreach(var c in s){
            if(c == '(' || c == '{' || c == '[')
                st.Push(c);
            else if(c == ')' || c == '}' || c == ']'){
                if(st.Count == 0) return false;
                var stTop = st.Pop();
                if((stTop == '(' && c == ')') ||
                    (stTop == '{' && c == '}') ||
                    (stTop == '[' && c == ']')) continue;
                else return false;
            }
        }
        if(st.Count == 0)
            return true;
        else return false;
    }
}
