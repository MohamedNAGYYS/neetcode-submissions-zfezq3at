public class Solution {
    public int FindDuplicate(int[] nums) {
            // Create a pointer variable
        int pointer = nums[0];


        // Create a diction
        Dictionary<int, int> dict = new Dictionary<int, int>();
        // While true

        while (true)
        {
            // If that pointer in diction, return it
            if (dict.TryGetValue(pointer, out int var))
            {
                return pointer;
            }
            // Otherwise, add it to dict, and move to that position
            else
            {
                dict[pointer] = 1;
                pointer = nums[pointer];
            }
        }

    }
}
