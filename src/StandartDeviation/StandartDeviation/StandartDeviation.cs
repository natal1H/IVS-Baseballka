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

        public double GetArithmeticMeanOfFirstX(int X)
        {
            double sum = 0;
            for (int i = 0; i < X; i++)
            {
                sum = MatLib.add(sum, list[i]);
            }
            return MatLib.divide(sum, X);
        }

        /**
         * @todo Počíta podĺa zlého vzorca, opraviť (nie je to podĺa toho v zadaní)
         */
        public double GetSpecialSum()
        {
            double sum = 0;
            double arit_mean = GetArithmeticMean(); // tmp = N * arit_mean(x)^2
            for (int i = 0; i < N; i++)
            {
                double tmp = MatLib.square( MatLib.subtract(list[i], arit_mean) ); // tmp2 = X[i]^2
                sum = MatLib.add(sum, tmp);
            }
            return sum;
        }

        public double GetStandartDeviation()
        {
            double tmp = GetSpecialSum();
            tmp = MatLib.divide(tmp, N - 1);
            tmp = MatLib.sqrt(tmp);
            return tmp;
        }
    }
}
