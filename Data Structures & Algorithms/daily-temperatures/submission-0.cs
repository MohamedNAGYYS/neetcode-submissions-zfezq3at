public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        List<int> indicies = new List<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            int day = 0;
            for (int j = i+1; j < temperatures.Length; j++)
            {
                if (temperatures[i] < temperatures[j])
                {
                    day = j-i;
                    break;
                }
            }
            indicies.Add(day);
        }
        return indicies.ToArray();









    }
}
