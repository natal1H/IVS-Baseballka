/**
 * @file StandartDeviation.cs
 * 
 * @brief Trieda zameraná na výpočet smerodajnej odchýlky
 * @author Natália Holková (xholko02), Egor Shamardin (xshama00)
 * 
 * @note .NET Framework v4.0
 * 
 * @todo Poriadne doplniť komentáre
 */

using System;
using System.Collections.Generic;
using Calculator;

namespace StandartDeviation
{
    /**
     * @class Trieda na výpočet smerodajnej odchýlky
     */
    class StandartDeviation
    {
        private List<double> list; /** Zoznam všetkých čísiel v postupnosti */
        private int N; /** Počet prvkov */

        /**
         * @brief Konštruktor triedy StandartDeviation
         * @param number Zoznam prvok, z ktorých sa má vypočítať smerodajná odchýlka
         */
        public StandartDeviation(List<double> numbers)
        {
            list = numbers;
            N = list.Count;
        } 

        /**
         * @brief Výpočet aritmetického priemeru
         * 
         * @todo Možno bude zbytočná po prejdení na druhý vzorec
         */
        public double GetArithmeticMean()
        {
            double res = 0, sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = MatLib.add(sum, list[i]);
            }
            try
            {
                res = MatLib.divide(sum, N);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("{0}", e.Message);
                Console.WriteLine("Press any key to continue . . .");
                Console.Read();
                Environment.Exit(-1);
            }
            return res;
        }

        /**
         * @todo Počíta podĺa zlého vzorca, opraviť (nie je to podĺa toho v zadaní)
         */
        public double GetSum()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = MatLib.add(sum, MatLib.square(list[i]));
            }
            return sum;
        }

        /**
         * @brief Výpočet smerodajnej odchýlky
         * 
         * @return smerodajná odchýlka
         */
        public double GetStandartDeviation()
        {
            double tmp = GetSum();
            double tmp2 = MatLib.multiply(N, MatLib.square(GetArithmeticMean()));
            tmp = MatLib.subtract(tmp, tmp2);
            try
            {
                tmp = MatLib.divide(tmp, N - 1);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("{0}", e.Message);
                Console.WriteLine("Press any key to continue . . .");
                Console.Read();
                Environment.Exit(-1);
            }

            tmp = MatLib.sqrt(tmp);
            return tmp;
        }
    }
}
/*** Koniec súboru StandartDeviation.cs ***/