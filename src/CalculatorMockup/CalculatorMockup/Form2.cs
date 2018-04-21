using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorMockup
{
    public partial class Form2 : Form
    {
        private bool shift_pressed;
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
            button33.Hide();
            button34.Hide();
            button35.Hide();
            button36.Hide();
            shift_pressed = false;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.FormClosing -= Form2_FormClosing;
            this.Close();
        }

        private void grafickýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.FormClosing -= Form2_FormClosing;
            this.Close();
        }

        private void štatistickýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form4()).Show();
            this.FormClosing -= Form2_FormClosing;
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (shift_pressed == true)
            {
                button27.Show();
                button28.Show();
                button29.Show();
                button30.Show();

                button33.Hide();
                button34.Hide();
                button35.Hide();
                button36.Hide();
            }
            else
            {
                button27.Hide();
                button28.Hide();
                button29.Hide();
                button30.Hide();

                button33.Show();
                button34.Show();
                button35.Show();
                button36.Show();
            }
            shift_pressed = !shift_pressed;
        }
    }
}
