using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BerestenDS.Sprint3.Task2.V16.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sum = 1;
            do
            {
                sum = sum * Math.Pow(1/(Math.Pow(startValue,value)), -1);
                startValue++;

            }while (startValue <= stopValue);
            return Math.Round(sum,3);
        }
    }
}
