public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();


            foreach(int n in nums)
            {
                if(dict.ContainsKey(n)){ return true; }
                
                dict[n] = 1;
            }
            return false;
    }
}