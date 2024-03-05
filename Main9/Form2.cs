using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dollar_Click(object sender, EventArgs e)
        {
            Current.Text = "dollar";
        }

        private void Euro_Click(object sender, EventArgs e)
        {
            Current.Text = "euro";
        }

        private void Tenge_Click(object sender, EventArgs e)
        {
            Current.Text = "tenge";
        }

        private void Uani_Click(object sender, EventArgs e)
        {
            Current.Text = "uani";
        }

        private void En_Click(object sender, EventArgs e)
        {
            Current.Text = "en";
        }

        private void res_Click(object sender, EventArgs e)
        {
            string name = Current.Text;
            double rubles = double.Parse(num.Text);
            switch (name) {
                case "dollar":
                    value.Text = Convert.ToString(rubles / 91.16);
                    break;
                case "euro":
                    value.Text = Convert.ToString(rubles / 98.94);
                    break;
                case "tenge":
                    value.Text = Convert.ToString(rubles * 5);
                    break;
                case "uani":
                    value.Text = Convert.ToString(rubles * 12.62);
                    break;
                case "en":
                    value.Text = Convert.ToString(rubles * 1.65);
                    break;
            }
        }
    }
}
