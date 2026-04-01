public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
            Array.Sort(position,speed);
            Array.Reverse(position);
            Array.Reverse(speed);
            Stack<double> CarsTime = new Stack<double>();


            for (int i = 0; i < position.Length; i ++)
            {
                
                double total = (double)(target - position[i])/speed[i];

                if (CarsTime.Count==0 || total > CarsTime.Peek())
                {
                    CarsTime.Push(total);
                    
                    
                }
                
            }
            return CarsTime.Count;
    }
}
