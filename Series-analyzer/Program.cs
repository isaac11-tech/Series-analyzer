using System;

namespace Series_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control controller = new Control();
            controller.Start(args);
        }
    }
}