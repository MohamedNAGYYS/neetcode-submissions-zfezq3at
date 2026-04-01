public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            Dictionary<int,int> dictionray = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionray.Keys.Contains(nums[i]))
                {
                    dictionray[nums[i]] += 1;
                }
                else
                {
                    dictionray[nums[i]] = 1;
                }
            }

            var frequent = dictionray.OrderByDescending(KeyValuePair => KeyValuePair.Value);
            int[] result = frequent.Take(k).Select(pair => pair.Key).ToArray();
            return result;
    }
}
