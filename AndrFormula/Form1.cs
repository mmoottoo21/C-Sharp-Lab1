using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrFormula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        static bool IsNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsNum(textBox1.Text))
            {
                MessageBox.Show("Переменая число!");
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength <= 0)
            {
                MessageBox.Show("Не корректное заполнение формы/нехватка данных!");
            }
            else
            {
                int a = Convert.ToInt32(textBox1.Text);
                double Result = Math.Pow(Math.Cos(((3 / 8 * (Math.PI))) * (a / 4)), 2) - Math.Pow(Math.Cos((11 / 8 * (Math.PI)) + a / 4), 2);
                textBox2.Text = Result.ToString();
            }
        }
    }
}
