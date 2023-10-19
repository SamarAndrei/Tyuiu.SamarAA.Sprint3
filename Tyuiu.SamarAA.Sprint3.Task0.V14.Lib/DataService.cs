using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamarAA.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries * Math.Pow(1 / Math.Pow(i, value), -1);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
