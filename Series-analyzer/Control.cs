using System;
using System.Collections.Generic;
using System.Linq;

namespace Series_analyzer
{
    internal class Control
    {
        private Model model;
        private View view;

        public Control()
        {
            model = new Model();
            view = new View();
        }

        public void Start(string[] args)
        {
            int[] series;
            bool play = true;

            if (!TryGetSeriesFromArgs(args, out series))
            {
                series = GetValidSeriesFromUser();
            }

            model.SetSeries(series);

            while (play)
            {
                view.printMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        series = GetValidSeriesFromUser();
                        model.SetSeries(series);
                        break;

                    case "2":
                        view.printSeries(model.GetSeries());
                        break;

                    case "3":
                        series = model.ReversOrdring(model.GetSeries());
                        view.printSeries(series);
                        break;

                    case "4":
                        series = model.sortArr(model.GetSeries());
                        view.printSeries(series);
                        break;

                    case "5":
                        Console.WriteLine(model.getMax(model.GetSeries()));
                        break;

                    case "6":
                        Console.WriteLine(model.getMin(model.GetSeries()));
                        break;

                    case "7":
                        Console.WriteLine(model.getAvg(model.GetSeries()));
                        break;

                    case "8":
                        Console.WriteLine(model.getLength(model.GetSeries()));
                        break;

                    case "9":
                        Console.WriteLine(model.getSum(model.GetSeries()));
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

        private bool TryGetSeriesFromArgs(string[] args, out int[] series)
        {
            series = new int[args.Length];

            for (int i = 0; i < args.Length; ++i)
            {
                if (!int.TryParse(args[i], out series[i]))
                {
                    series = null;
                    return false;
                }
            }
            if (!model.isVaildSeries(series))
            {
                Console.WriteLine("the args that we get is illegal series enter with user");
                series = null;
                return false;
            }
            return true;
        }

        private int[] GetValidSeriesFromUser()
        {
            int[] series = view.GetSeriesFromUser();

            while (!model.isVaildSeries(series))
            {
                Console.WriteLine("is illegal series enter again");
                series = view.GetSeriesFromUser();
            }

            return series;
        }
    }
}
