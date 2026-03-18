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

        public static double CalculateAverage(int[] values)
        {
            if (values.Length == 0) return 0;
            double sum = 0;
            foreach (var v in values) sum += v;
            return sum / values.Length;
        }
        public static int CalculateMax(int[] values)
        {
            if (values.Length == 0) throw new ArgumentException("Brak danych");
            int max = values[0];
            foreach (var v in values)
            if (v > max) max = v;
            return max;
        }
        public static int CalculateMin(int[] values)
        {
            if (values.Length == 0) throw new ArgumentException("Brak danych");
            int min = values[0];
            foreach (var v in values)
            if (v < min) min = v;
            return min;
        }
    }

}ź
