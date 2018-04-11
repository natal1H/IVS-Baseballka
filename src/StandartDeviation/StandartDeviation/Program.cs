using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using StandartDeviation;
//using Calculator;

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
            Console.WriteLine("Počet prvkov: {0}", s.GetN());
            Console.WriteLine("Aritmetický priemer prvkov: {0}", s.GetArithmeticMean());
            Console.WriteLine("Special sum: {0}", s.GetSpecialSum());
            Console.WriteLine("Smerodajná odchýlka: {0}", s.GetStandartDeviation());

            Console.WriteLine("Press any key to continue . . .");
            Console.Read();
        }
    }
}
