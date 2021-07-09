using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vat_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kwotasieBedrag;
            kwotasieBedrag = float.Parse(textBox1.Text);
            float InterimVat = (float)(kwotasieBedrag / 1.15);

            decimal Vat = (decimal)(kwotasieBedrag - InterimVat);

            var FinalVAT = Math.Round(Vat, 2);

            string answer = (Convert.ToDecimal(FinalVAT).ToString());
            textBox2.Text = (answer).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
