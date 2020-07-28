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
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46) // цифры, запятая, backspace
            {
                e.Handled = true;
            }
        }
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(metroTextBox1.Text);
            metroTextBox3.Text = Convert.ToString(a * 0.8697);
        }
        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(metroTextBox3.Text);
            b = Convert.ToDouble(metroTextBox2.Text);
            metroTextBox4.Text = Convert.ToString(a - b);
        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(metroTextBox6.Text);
            metroTextBox5.Text = Convert.ToString(a * 0.72);
        }

        private void metroTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46) // цифры, запятая, backspace
            {
                e.Handled = true;
            }
        }

        private void metroTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46) // цифры, запятая, backspace
            {
                e.Handled = true;
            }
        }

        private void metroTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46) // цифры, запятая, backspace
            {
                e.Handled = true;
            }
        }

        private void metroTextBox7_TextChanged(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(metroTextBox7.Text);
            b = Convert.ToDouble(metroTextBox9.Text);
            c = Convert.ToDouble(metroTextBox5.Text);
            metroTextBox8.Text = Convert.ToString(c - (a * b));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }
    }
}
