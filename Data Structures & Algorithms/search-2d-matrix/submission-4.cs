public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
            int top = 0;
            int bottom = matrix.Length - 1;
            while (top <= bottom)
            {
                int midRows = (top + bottom) / 2;
                if (matrix[midRows][0] <= target && target <= matrix[midRows][matrix[midRows].Length - 1])
                {
                    int left = 0;
                    int right = matrix[midRows].Length - 1;

                    while (left <= right)
                    {
                        int mid = (left + right) / 2;
                        if (matrix[midRows][mid] == target)
                        {
                            return true;
                        }
                        else if (matrix[midRows][mid] > target){right=mid-1;}
                        else {left = mid + 1;}
                    }
                    return false;
                }
                else if (matrix[midRows][0] > target){bottom=midRows-1;}
                else {top= midRows+1;}
            }
            return false;
    }
}