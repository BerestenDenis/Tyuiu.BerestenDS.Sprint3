using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BerestenDS.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multi = 1;
            while (startValue <= stopValue)
            {
                multi = multi * (startValue / Math.Pow(Math.Cos(5)+1,2));
                startValue++;
            }
            return Math.Round(multi,3);
        }
    }
}
