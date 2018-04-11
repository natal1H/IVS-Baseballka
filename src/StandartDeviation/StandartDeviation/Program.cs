/**
 * @file Program.cs
 * 
 * @todo Odstrániť zbytočné riadky
 */

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
        static List<double> GetInput()
        {
            List<double> input = new List<double>();
            string line;
            while ((line = Console.ReadLine()) != null && line != "" )
            {
                try
                {
                    input.Add(double.Parse(line));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nepodarilo sa pridať {0} medzi prvky.", line);
                }
            }

            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pogram na výpočet smerodajnej odchýlky");

            List<double> list2 = GetInput();
            
            StandartDeviation s2 = new StandartDeviation(list2);

            double res = s2.GetStandartDeviation();

            Console.WriteLine("Smerodajná odchýlka: {0}", res);


            Console.WriteLine("Press any key to continue . . .");
            Console.Read();
        }
    }
}
/*** Koniec súboru Program.cs ***/