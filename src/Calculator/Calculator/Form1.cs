/**
 * @date 30.3.2018 
 * 
 * @note .NET Framework v4.0
 * 
 * @bug Maximalne jedna matematicka operacia
 *      Mocniny, odmocnina, log neimplementovane
 *      Neimplementovana desatinna ciarka:
 *         1)Je mozne vlozit nekonecne mnozsvo desatinnych ciarok(Prve zadanie cisla)
 *         2)result.Clear pri zadani ciarky
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class CalculatorGUI : Form
    {
        Double value = 0; 
        String operation = ""; //Ziadny operator
        bool operation_pressed = false; //Ziadna operacia
        public CalculatorGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            /*
             * (result.Text == "0") -> Zmaze 0 pri prvom zadani cisla => Priklad: "'03'->'3'"
             * 
             * (operation_pressed) -> Zmaze cislo pri zadavani dalsieho s mat. operaciou
             * Priklad: "'356' '+' '356211'" -> "'356' '+' '211'"
             */
            if ((result.Text == "0") || (operation_pressed)) {
                result.Clear();
            }

            Button Button_Name = (Button)sender;
            result.Text = result.Text + Button_Name.Text; // Vystup vysledku na result.Text
        }

        /**
         * @brief Vlozi len 0 do result.Text po stlaceni CE
         */ 
        private void Button_CE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        /**
         * @brief Vykona operaciu
         */ 
        private void Operator_click(object sender, EventArgs e)
        {
            Button Button_Name = (Button)sender; 
            operation = Button_Name.Text; //Operacia podla nazvu tlacitka
            value = Double.Parse(result.Text); //Pretypovanie String->Double
            operation_pressed = true; //Operacia vykonana
        }

        /**
         * @brief Vykona matematicku operatciu na zaklade nazvu tlačitka 
         */
        private void Button_equals_Click(object sender, EventArgs e)
        {
           
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString(); //Pretypovanie Double->String
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString(); //Pretypovanie Double->String
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString(); //Pretypovanie Double->String
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString(); //Pretypovanie Double->String
                    break;
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
