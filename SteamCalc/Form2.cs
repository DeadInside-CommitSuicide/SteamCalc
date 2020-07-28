using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace SteamCalc
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46) // цифры, запятая, backspace
            {
                e.Handled = true;
            }
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(metroTextBox1.Text);
            b = Convert.ToDouble(metroTextBox4.Text);
            metroTextBox2.Text = Convert.ToString(a * b);

        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(metroTextBox2.Text);
            metroTextBox3.Text = Convert.ToString(a * 0.95);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Close();
        }
    }
}
