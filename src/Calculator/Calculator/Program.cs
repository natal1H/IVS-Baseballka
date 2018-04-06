using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator.CalculatorGUI());
            //Application.Run(new Form1());

            Console.WriteLine("Calculator started!");

            Console.WriteLine("Matlib test");

            double n1 = 2;
            double n2 = 40;
            double res = MatLib.add(n1, n2);
            Console.WriteLine("{0} + {1} = {2}", n1, n2, res);

            n1 = 9;
            n2 = 27;
            res = MatLib.subtract(n1, n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, res);

            n1 = 5;
            n2 = 7;
            res = MatLib.multiply(n1, n2);
            Console.WriteLine("{0} * {1} = {2}", n1, n2, res);

            n1 = 99;
            n2 = 3;
            res = MatLib.divide(n1, n2);
            Console.WriteLine("{0} / {1} = {2}", n1, n2, res);

            int num_int = 5;
            long res_fact = MatLib.factorial(num_int);
            Console.WriteLine("{0}! = {1}", num_int, res_fact);

            double num = 0.81;
            double res_sqrt = MatLib.sqrt(num);
            Console.WriteLine("sqrt({0}) = {1}", num, res_sqrt);

            double num_to_calc = 27;
            int root = 3;
            double res_genroot = MatLib.genroot(num_to_calc, root);
            Console.WriteLine("genroot({0}, {1}) = {2}", num_to_calc, root, res_genroot);

            double x = 100;
            double res_log10 = MatLib.log10(x);
            Console.WriteLine("log10({0}) = {1}", x, res_log10);
        }
    }
}
