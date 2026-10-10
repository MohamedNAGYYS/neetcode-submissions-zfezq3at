public class Solution {
    public bool IsValid(string s) {
         Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict['['] = ']';
            dict['{'] = '}';
            dict['('] = ')';


            foreach(char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {


                    if(stack.Count == 0){ return false; }
                    if(dict[stack.Pop()] != c){ return false; }

                }
            }
            return stack.Count == 0;
    }
}
