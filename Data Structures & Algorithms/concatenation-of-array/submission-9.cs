public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> ans = new List<int>();

        foreach(int n in nums){ ans.Add(n); }
        foreach(int n in nums){ ans.Add(n); }

        return ans.ToArray();

    }
}