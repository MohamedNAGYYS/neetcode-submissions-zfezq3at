public class Solution {
    public int[] TwoSum(int[] nums, int target) {
          Dictionary<int, int> numbers = new Dictionary<int, int>();


            for(int i = 0; i < nums.Length; i++)
            {
                int result = target - nums[i];

                if(numbers.ContainsKey(result)){ return [numbers[result], i]; }

                numbers[nums[i]] = i;
            }
            return[];
    }
}
