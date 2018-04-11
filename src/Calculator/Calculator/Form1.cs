/**
 * @date 12.4.2018 
 * 
 * @note .NET Framework v4.0
 * 
 * @bug Mocniny, odmocnina, log neimplementovane   
 * @todo Pridať zachytenie výnimiek pri operáciach (delenie nulou apod)
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
        bool number_pressed = false;
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
            if ((result.Text == "0") || (operation_pressed )) {
                result.Clear(); //Zmaze cislo po zadani operacie
                operation_pressed = false; //Dalsie cislo nezmazat -> Nepotrebny udaj -> False
            }

            Button Button_Name = (Button)sender;

            if (Button_Name.Text == ",")
            {
                if (!result.Text.Contains(","))
                {
                    if (result.Text == "0") // if ak je prva zadana desatinna ciarka -> pre cisla ako 0,1
                    {
                        result.Text = result.Text + Button_Name.Text; // Vystup vysledku na result.Text
                    }
                    else
                    {
                        result.Text = "0"; //Zadanie nuly pred desatinnu ciarku
                        result.Text = result.Text + Button_Name.Text; // Vystup vysledku na result.Text
                    }
                }
            }
            else {
                result.Text = result.Text + Button_Name.Text;
            }
            number_pressed = true;
        }

        /**
         * @brief Vlozi len 0 do result.Text po stlaceni CE
         */ 
        private void Button_CE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            number_pressed = false;
            operation_pressed = false;
        }

        /**
         * @brief Vykona operaciu
         */ 
        private void Operator_click(object sender, EventArgs e)
        {
            if (number_pressed == true) {

                // TODO Zlucenie s Button_equals_Click?
                
                switch (operation)
                {
                    case "+":
                        //value = (value + Double.Parse(result.Text)); //Pretypovanie Double->String
                        value = MatLib.add(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                        result.Text = (value).ToString(); //Pretypovanie Double->String
                        break;
                    case "-":
                        //value = (value - Double.Parse(result.Text)); //Pretypovanie Double->String
                        value = MatLib.subtract(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                        result.Text = (value).ToString(); //Pretypovanie Double->String
                        break;
                    case "*":
                        //value = (value * Double.Parse(result.Text)); //Pretypovanie Double->String
                        value = MatLib.multiply(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                        result.Text = (value).ToString(); //Pretypovanie Double->String
                        break;
                    case "/":
                        //value = (value / Double.Parse(result.Text)); //Pretypovanie Double->String
                        value = MatLib.divide(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                        result.Text = (value).ToString(); //Pretypovanie Double->String
                        break;
                }
            value = 0; //Nulovanie vysledku a zabranenie duplicite pri viacnasobnej rovnakej operacii
            }
            Button Button_Name = (Button)sender; 
            operation = Button_Name.Text; //Operacia podla nazvu tlacitka
            value = Double.Parse(result.Text); //Pretypovanie String->Double
            operation_pressed = true; //Operacia vykonana
            number_pressed = false; //Vykonany operator -> Cislo = False(Vyhybanie sa cyklicej operacii bez dalsieho cisla)
            
        }

        /**
         * @brief Vykona matematicku operatciu na zaklade nazvu tlačitka 
         */
        private void Button_equals_Click(object sender, EventArgs e)
        {
             if ( operation_pressed == true) { //Osetrenie duplicity vysledku po kombinacii "5" + "6" "+" "="
                value = 0;
             }
            switch (operation)
            {
                case "+":
                    //value = (value + Double.Parse(result.Text)); //Pretypovanie Double->String
                    value = MatLib.add(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                    result.Text = (value).ToString(); //Pretypovanie Double->String
                    break;
                case "-":
                    //value = (value - Double.Parse(result.Text)); //Pretypovanie Double->String
                    value = MatLib.subtract(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                    result.Text = (value).ToString(); //Pretypovanie Double->String
                    break;
                case "*":
                    //value = (value * Double.Parse(result.Text)); //Pretypovanie Double->String
                    value = MatLib.multiply(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                    result.Text = (value).ToString(); //Pretypovanie Double->String
                    break;
                case "/":
                    //value = (value / Double.Parse(result.Text)); //Pretypovanie Double->String
                    value = MatLib.divide(value, Double.Parse(result.Text)); //Pretypovanie Double->String
                    result.Text = (value).ToString(); //Pretypovanie Double->String
                    break;
            }
            value = 0; //Nulovanie vysledku a zabranenie duplicite pri viacnasobnej rovnakej operacii
            number_pressed = false; //Vykonany sucet -> Cislo = False(Vyhybanie sa cyklickemu scitavaniu bez dalsieho cisla)
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
