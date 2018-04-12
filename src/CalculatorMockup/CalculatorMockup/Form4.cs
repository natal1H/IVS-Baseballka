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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormClosing += Form4_FormClosing;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.FormClosing -= Form4_FormClosing;
            this.Close();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.FormClosing -= Form4_FormClosing;
            this.Close();
        }

        private void grafickýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.FormClosing -= Form4_FormClosing;
            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
