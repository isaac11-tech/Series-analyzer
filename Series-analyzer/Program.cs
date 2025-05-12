using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_analyzer
{
    internal class Program
    {

        //function that print numbers in order
        //static int [] printInOrder(int[] series)
        //{
         //   for (int i = 0; i < series.Length; i++)
         //   {
        //        Console.WriteLine($"{i + 1}. {series[i]} ");
         //   }  
         //   return series;
       // }



        //function that move numbers in revers order
        static int [] printInRevers(int[] series)
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

        //function that sort the series with Bubbles sort
        static int[] sortArr(int[] series)
        {
            int len = series.Length;
            for(int i = 0; i < len -1; i++)
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
        
        // function that return the max number in series
        static int getMax(int[] series)
        {
            int indexMax = 0;
            for (int i = 1;i < series.Length; i++)
            {
                if (series[i] > series[indexMax])
                {
                    indexMax = i;
                }       
            }
            return series[indexMax];
        }

        // function that return the min number in series
        static int getMin(int[] series)
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


        // function that return the sum of series
        static int  getSum(int[] series)
        {
            int sum = 0;
            foreach (int i in series)
            {
                sum += i;
            }
            return sum;             
        }
        // function that return the length of series
        static int getLength(int[] series)
        {
           return series.Length;
        }


        // function that return the avg of the series
        static double getAvg(int [] series)
        {     
            return (double)getSum(series) /getLength(series);
        }


        // function that display the series
        static void printSeries(int[] series)
        {
            for(int i = 1; i <= series.Length; ++i)
            {
                Console.WriteLine($"{i}. {series[i]}");
            }
        }



        static void Main(string[] args)
        {
           



        }
    }
}
