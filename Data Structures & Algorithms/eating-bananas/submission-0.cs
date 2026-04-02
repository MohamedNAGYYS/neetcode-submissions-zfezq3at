public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
            int left = 0;
            int right = piles.Max();

            int result = right;

            while (left <= right)
            {
                int mid = (left+right)/2;
                int hours=0;

                for (int i = 0; i < piles.Length; i++)
                {
                    hours += (int)Math.Ceiling((double)piles[i]/mid);
                    if (hours > h)
                    {
                        break;
                    }    
                }    

                if (hours <= h)
                {
                    result = mid;
                    right = mid - 1;                    
                }
                else{left = mid + 1;}


            }
            return result;   
    }
}
