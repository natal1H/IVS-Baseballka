/**
 * @date 12.4.2018 
 * 
 * @note .NET Framework v4.0
 * @todo Pridať zachytenie výnimiek pri operáciach (delenie nulou apod)
 */

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
 *         3)Pod operande nie je mozne zadat dva a viac ciferne cislo
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
        bool equal_pressed = false;
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
            if ( ((result.Text == "0") || (operation_pressed) || (equal_pressed)) &&  ((!(result.Text == ",")) || (!(result.Text == "0,"))) ) {
                result.Clear(); //Zmaze cislo po zadani operacie
                operation_pressed = false; //Dalsie cislo nezmazat -> Nepotrebny udaj -> False
                equal_pressed = false;
            }

            Button Button_Name = (Button)sender;

            if (Button_Name.Text == ",")
            {
                if (!result.Text.Contains(","))
                {
                    if ((result.Text.Contains("0") && number_pressed == false )) // if ak je prva zadana desatinna ciarka -> pre cisla ako 0,1
                    {
                        result.Text = result.Text + Button_Name.Text; // Vystup vysledku na result.Text
                    }
                    else
                    {
                        if ( (number_pressed == false && result.Text.Contains("")) || (result.Text == "" && number_pressed == true) )
                        {
                            result.Text = "0"; //Zadanie nuly pred desatinnu ciarku
                        }
                        result.Text = result.Text + Button_Name.Text; // Vystup vysledku na result.Text
                    }
                }
            }
            else
            {
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
                    case "xʸ":
                        value = MatLib.power(value, int.Parse(result.Text)); //Pretypovanie Integer->String
                        result.Text = (value).ToString(); //Pretypovanie Double->String
                        break;
                    case "ʸ√x":
                        value = MatLib.genroot(value, int.Parse(result.Text)); //Pretypovanie Integer->String
                        result.Text = (value).ToString(); //Pretypovanie Double->String
                        break;
                }
            value = 0; //Nulovanie vysledku a zabranenie duplicite pri viacnasobnej rovnakej operacii
            //operation = "";
            }
            Button Button_Name = (Button)sender; 
            operation = Button_Name.Text; //Operacia podla nazvu tlacitka
            value = Double.Parse(result.Text); //Pretypovanie String->Double
            operation_pressed = true; //Operacia vykonana
            number_pressed = false; //Vykonany operator -> Cislo = False(Vyhybanie sa cyklicej operacii bez dalsieho cisla)
            
        }

        /**
         * @brief Vykona matematicku operatciu na zaklade nazvu tlačitka 
         * @note Program si nepamata posledne zvolene cislo, preto
         *       po vykonanej operacii je vysledok konecny -> Nie je mozne v operacii
         *       dalej pokracovat alebo pripadne na vysledok nadviazat bez zadania dalsej operacie!
         *       Priklad:
         *       Nebude fungovat: "5" "+" "6" "=" "5" "="
         *       Bude fungovat: "5" "+" "6" "=" "+" "5" "="   
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
                case "xʸ":
                    value = MatLib.power(value, int.Parse(result.Text)); //Pretypovanie Integer->String
                    result.Text = (value).ToString(); //Pretypovanie Double->String
                    break;
                case "ʸ√x":
                    value = MatLib.genroot(value, int.Parse(result.Text)); //Pretypovanie Integer->String
                    result.Text = (value).ToString(); //Pretypovanie Double->String
                    break;
            }
            value = 0; //Nulovanie vysledku a zabranenie duplicite pri viacnasobnej rovnakej operacii
            number_pressed = false; //Vykonany sucet -> Cislo = False(Vyhybanie sa cyklickemu scitavaniu bez dalsieho cisla)
            //operation = "";
            equal_pressed = true;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

 
        /**
         * @brief Podpora pred Numpad
         * @bug Nefunkcny Enter
         */ 
        private void CalculatorGUI_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar.ToString())
            {
                case "0":
                    button_number0.PerformClick();
                    break;
                case "1":
                    button_number1.PerformClick();
                    break;
                case "2":
                    button_number2.PerformClick();
                    break;
                case "3":
                    button_number3.PerformClick();
                    break;
                case "4":
                    button_number4.PerformClick();
                    break;
                case "5":
                    button_number5.PerformClick();
                    break;
                case "6":
                    button_number6.PerformClick();
                    break;
                case "7":
                    button_number7.PerformClick();
                    break;
                case "8":
                    button_number8.PerformClick();
                    break;
                case "9":
                    button_number9.PerformClick();
                    break;
                case "+":
                    button_plus.PerformClick();
                    break;
                case "-":
                    button_minus.PerformClick();
                    break;
                case "*":
                    button_multiply.PerformClick();
                    break;
                case "/":
                    button_divide.PerformClick();
                    break;
                case ".":
                    button_dot.PerformClick();
                    break;
                //case "ENTER":
                //    button_equals.PerformClick();
                //   break;
                default:
                    break;
            }
        }

        private void button_Square_Click(object sender, EventArgs e)
        {
            value = MatLib.square(Double.Parse(result.Text)); //Pretypovanie Double->String
            result.Text = (value).ToString(); //Pretypovanie Double->String
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            value = MatLib.sqrt(Double.Parse(result.Text)); //Pretypovanie Double->String
            result.Text = (value).ToString(); //Pretypovanie Double->String
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            value = MatLib.factorial(int.Parse(result.Text)); //Pretypovanie int->String
            result.Text = (value).ToString(); //Pretypovanie Double->String
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            value = MatLib.log10(Double.Parse(result.Text)); //Pretypovanie Double->String
            result.Text = (value).ToString(); //Pretypovanie Double->String
        }
    }
}
