using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double p, a, m;
       

        private void tbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculoImc_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(tbPeso.Text);
            a = Convert.ToDouble(tbAltura.Text);

            m = p / (a * a);
      
            if (m>30)
            {
                MessageBox.Show("IMC muito elevado atenção" + m.ToString("F"));
                tbResultado.Text = ("O seu IMC é  " + m.ToString("F"));
            }
            else
            {
                tbResultado.Text = ("O seu IMC é  " + m.ToString("F"));
                MessageBox.Show("IMC recomendavel é abaixo de 25");
            }
            tbPeso.Text = "";
            tbAltura.Text = "";
            
        }
    }
}
