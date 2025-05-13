using System;
using System.Collections.Generic;
using System.Linq;

namespace Series_analyzer
{
    internal class Model
    {
        private int[] series;

        public Model(int[] initialSeries = null)
        {
            series = initialSeries;
        }

        public int[] GetSeries()
        {
            return series;
        }

        public void SetSeries(int[] newSeries)
        {
            series = newSeries;
        }

        public int[] ReversOrdring(int[] series)
        {
            int len = series.Length;
            for (int i = 0; i < len / 2; i++)
            {
                int temp = series[i];
                series[i] = series[len - 1 - i];
                series[len - 1 - i] = temp;
            }
            return series;
        }

        public int[] sortArr(int[] series)
        {
            int len = series.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (series[j] > series[j + 1])
                    {
                        int temp = series[j];
                        series[j] = series[j + 1];
                        series[j + 1] = temp;
                    }
                }
            }
            return series;
        }

        public int getMax(int[] series)
        {
            int indexMax = 0;
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] > series[indexMax])
                {
                    indexMax = i;
                }
            }
            return series[indexMax];
        }

        public int getMin(int[] series)
        {
            int indexMin = 0;
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] < series[indexMin])
                {
                    indexMin = i;
                }
            }
            return series[indexMin];
        }

        public int getSum(int[] series)
        {
            int sum = 0;
            foreach (int i in series)
            {
                sum += i;
            }
            return sum;
        }

        public int getLength(int[] series)
        {
            return series.Length;
        }

        public double getAvg(int[] series)
        {
            return (double)getSum(series) / getLength(series);
        }

        public bool isVaildSeries(int[] series)
        {
            return series != null && series.Length >= 3 && series.All(n => n > 0);
        }
    }
}
