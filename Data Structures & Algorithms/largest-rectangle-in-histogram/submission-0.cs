public class Solution {
    public int LargestRectangleArea(int[] heights) {
            List<int> Areas = new List<int>();

            for (int i = 0; i < heights.Length; i ++)
            {
                int left = i;
                int right = i;
                while (left > 0 && heights[left-1] >= heights[i]){left--;}
                while (right < heights.Length-1 && heights[right+1] >= heights[i]){right++;}

                int width = right - left +1;
                int area = width * heights[i];

                Areas.Add(area);
            }

            int max = 0;
            foreach (int i in Areas)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
    }
}
