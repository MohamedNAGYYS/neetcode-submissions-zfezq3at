public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int[] numbers = [..nums1, ..nums2];

            Array.Sort(numbers);
    
            int size =  numbers.Length / 2;
            if (numbers.Length % 2 == 0)
            {
                return (numbers[size] + numbers[size-1]) / 2.0;
            }
            else
            {
                return numbers[size];
            }
    }
}
