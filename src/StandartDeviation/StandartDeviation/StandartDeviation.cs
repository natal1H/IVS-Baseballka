/**
 * @file StandartDeviation.cs
 * 
 * @brief Trieda zameraná na výpočet smerodajnej odchýlky
 * @author Natália Holková (xholko02), Egor Shamardin (xshama00)
 * 
 * @note .NET Framework v4.0
 */

using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
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
         * @todo Odstrániť túto funkciu, zbytočná, iba na testovanie
         */
        public double GetN()
        {
            return N;
        }

        public double GetArithmeticMean()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum = MatLib.add(sum, list[i]);
            }
            return MatLib.divide(sum, N);
        }
    }
}
