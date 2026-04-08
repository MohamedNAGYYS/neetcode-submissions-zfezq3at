public class Solution {
    public int MaxProfit(int[] prices) {
            int minPrice = prices[0];
            int MaxProfit = 0;

            foreach(int i in prices)
                {
                    if (i < minPrice)
                    {
                        minPrice = i;
                    }
                    else
                    {
                        if (MaxProfit < (i - minPrice)){MaxProfit = (i-minPrice);}
                    }
                }
            return MaxProfit;

    }
}
