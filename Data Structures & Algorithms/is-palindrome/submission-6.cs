public class Solution {
    public bool IsPalindrome(string s) {
        string small = s.ToLower();
        int left = 0;
        int right = small.Length - 1;

        while (left < right) {
            // Skip non-alphanumeric on left
            if (!char.IsLetterOrDigit(small[left])) { left++; continue; }

            // Skip non-alphanumeric on right
            if (!char.IsLetterOrDigit(small[right])) { right--; continue; }

            // Compare
            if (small[left] != small[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}
