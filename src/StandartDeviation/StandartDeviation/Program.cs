using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using StandartDeviation;

namespace StandartDeviation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STANDART DEVIATION");

            List<double> list = new List<double> { 1.0, 2.0, 3.0 };
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.WriteLine();

            StandartDeviation s = new StandartDeviation(list);

            Console.WriteLine("Press any key to continue . . .");
            Console.Read();
        }
    }
}
