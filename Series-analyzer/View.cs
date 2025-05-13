using System;
using System.Collections.Generic;
using System.Linq;

namespace Series_analyzer
{
    internal class View
    {
        public void printMenu()
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

        public void printSeries(int[] series)
        {
            for (int i = 0; i < series.Length; ++i)
            {
                Console.WriteLine($"{i + 1}. {series[i]}");
            }
        }

        public int[] GetSeriesFromUser()
        {
            List<int> listSeries = new List<int>();

            Console.WriteLine("enter number at least 3 positive numbers !!!");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            foreach (string part in parts)
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

            return listSeries.ToArray();
        }
    }
}