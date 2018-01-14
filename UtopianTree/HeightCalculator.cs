namespace UtopianTree
{
    public class HeightCalculator
    {
        public static int HeightFinder(int growthCycles)
        {
            int height = 1;
            for(int cycle = 1; cycle <= growthCycles; cycle++)
            {
                if (cycle % 2 != 0)
                {
                    height = 2 * height;
                }
                else
                {
                    height = height + 1;
                }
            }
            return height;
        }
    }
}
