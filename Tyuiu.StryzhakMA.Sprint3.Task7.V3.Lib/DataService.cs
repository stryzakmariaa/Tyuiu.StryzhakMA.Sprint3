using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StryzhakMA.Sprint3.Task7.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (Math.Sin(x) - 3 + x == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = (3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
