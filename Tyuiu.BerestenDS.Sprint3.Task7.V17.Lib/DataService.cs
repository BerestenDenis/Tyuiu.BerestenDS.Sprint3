﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BerestenDS.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x =startValue; x <=stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) / (x + 1.7) - Math.Cos(x) * (4 * x) - 6),2);
                valueArray[count] = y;
                count++;
                
            }
            return valueArray;
        }

    }
}
