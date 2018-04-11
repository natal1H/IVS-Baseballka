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

namespace StandartDeviation
{
    /**
     * @class Trieda na výpočet smerodajnej odchýlky
     */
    class StandartDeviation
    {
        private List<double> elements; /** Zoznam všetkých čísiel v postupnosti */
        private int N;

        public StandartDeviation(List<double> numbers)
        {
            elements = numbers;
            N = elements.Count;
        } 
 
    }
}
