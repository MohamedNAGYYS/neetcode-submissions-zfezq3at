public class Solution {
    public bool IsPalindrome(string s) {
            string clean = "";

            foreach (char c in s)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    clean += Char.ToLower(c);
                }
            }

            int left = 0;
            int right = clean.Length - 1;

            while (left < right)
            {
                if (clean[left] != clean[right])
                {
                    return false;
                }
                left ++;
                right --;

            }
            return true;





    }
}
