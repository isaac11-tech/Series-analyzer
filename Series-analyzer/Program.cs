using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_analyzer
{
    internal class Program
    {

        //function that move numbers in revers order
        static int [] ReversOrdring(int[] series)
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
            for(int i = 0; i < series.Length; ++i)
            {
                Console.WriteLine($"{i + 1}. {series[i]}");
            }                                      
        }

        // function that try to get agrs.
        // if it successful converts to arr series and returns true.
        // else return false and reset the series arr to null.
        static bool TryGetSeriesFromArgs(string[] args, out int[] series)
        {
            series = new int[args.Length];

            for (int i= 0; i < args.Length; ++i)
            {
                if( !int.TryParse(args[i], out series[i]) )
                {
                    series = null;
                    return false;
                }
            }
            if (!isVaildSeries(series)) // test if it illegal series
            {
                Console.WriteLine("the args that we get is illegal series enter with user");
                series = null;
                return false;
            }
            return true;
        }


        static int[] GetSeriesFromUser() {

            List<int> listSeries = new List<int>();
            
            Console.WriteLine("enter number at least 3 positive numbers !!!");
            string input = Console.ReadLine(); // get all numbers in one line !!!
            string [] parts = input.Split(' ');

            foreach(string part in parts)
            {
              if (int.TryParse(part.Trim(), out int number))
                {
                    listSeries.Add(number);
                }
                else
                {
                    Console.WriteLine($"the {part} is illegal input");
                }
            }
            if (!isVaildSeries(listSeries.ToArray()))// test if it illegal series
            {
                Console.WriteLine("is illegal series enter again");
                return GetSeriesFromUser();
            }

            return listSeries.ToArray();
        }

        //function that check if its valid series
        static bool isVaildSeries(int[] series)
        {
           return series == null ||   series.Length > 3 && series.All(n => n > 0);
        }

        // function that display the menu
        static void printMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Input a Series (Replace the current series)");
            Console.WriteLine("2. Display the series in the order it was entered");
            Console.WriteLine("3. Display the series in the reversed order");
            Console.WriteLine("4. Display the series in sorted order (low to high)");
            Console.WriteLine("5. Display the Max value");
            Console.WriteLine("6. Display the Min value");
            Console.WriteLine("7. Display the Average");
            Console.WriteLine("8. Display the Number of elements");
            Console.WriteLine("9. Display the Sum");
            Console.WriteLine("10. Exit");
            Console.Write("\nEnter your choice: ");
        }






        static void Main(string[] args)
        {

            int[] series;
            bool play = true;

            if (!TryGetSeriesFromArgs(args, out series))
            {
                series = GetSeriesFromUser();
            }

            while (play)
            {

                printMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        series = GetSeriesFromUser();
                        break;

                    case "2":
                        printSeries(series);
                        break;

                    case "3":
                        series = ReversOrdring(series);
                        printSeries(series);
                        break;

                    case "4":
                        series = sortArr(series);
                        printSeries(series);
                        break;

                    case "5":
                        Console.WriteLine(getMax(series)); 
                        break;

                    case "6":
                        Console.WriteLine(getMin(series));
                        break;

                    case "7":
                        Console.WriteLine(getAvg(series));
                        break;

                    case "8":
                        Console.WriteLine(getLength(series));
                        break;

                    case "9":
                        Console.WriteLine(getSum(series));
                        break;

                    case "10":
                        play = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;


                }

            }
        }
    }
}
