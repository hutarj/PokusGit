using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vypocti_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);

            double soucet = a + b;
            MessageBox.Show("Součet je " + soucet.ToString());
            double rozdil = a - b;
            MessageBox.Show("Rozdíl je " + rozdil.ToString());
            double soucin = a * b;
            MessageBox.Show("Součin je " + soucin.ToString());
            if (b != 0)
            {
                double podil = a / b;
                MessageBox.Show("Podíl je je " + podil.ToString());
            }
            else MessageBox.Show("Nulou nelze dělit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jakub Hutař", "ITA2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox3.Text);
            long faktorial = 1;

            for (int i = cislo; i > 0; i--)
            {
                faktorial *= i;
            }
            MessageBox.Show(faktorial.ToString());
        }
    }
}
