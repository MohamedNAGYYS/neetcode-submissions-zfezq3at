public class Solution {
    public bool hasDuplicate(int[] nums) {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (numbers.Keys.Contains(i))
                {
                    return true;
                }
                numbers.Add(i,1); 
            }
            return false;
        
    }
}