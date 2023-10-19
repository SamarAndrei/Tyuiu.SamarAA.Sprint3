using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SamarAA.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res += (Math.Pow(value, startValue) + 0.25) * Math.Sin(startValue);
                startValue++;
            } while (startValue <= 13);
            return Math.Round(res, 3);
        }
    }
}
