public class Solution {
    public bool CheckInclusion(string s1, string s2) {
            int length_s1 = s1.Length;
            if (length_s1 > s2.Length){return false;}

            string sortedS1 = string.Concat(s1.OrderBy(c=>c));


            for (int i = 0; i<=s2.Length-length_s1; i++)
            {
                string sub = s2.Substring(i, length_s1);
                string sortedSub = string.Concat(sub.OrderBy(s=>s));

                if (sortedSub == sortedS1){return true;}
            }

            return false;
    }
}
