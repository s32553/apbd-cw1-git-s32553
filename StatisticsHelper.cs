using System;

namespace APBD_CW1
{
    public static class StatisticsHelper
    {
        public static double CalculateAverage(int[] values)
        {
            if (values.Length == 0) return 0;
            double sum = 0;
            foreach (var v in values) sum += v;
            return sum / values.Length;
        }
    }
}ź
