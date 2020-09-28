using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumeroDois.Text = "";
            txtNumeroUm.Text = "";
            txtResultado.Text = "";
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            double numUm, numDois, resultado;
            if(double.TryParse(txtNumeroUm.Text, out numUm) && (double.TryParse(txtNumeroDois.Text, out numDois)))
            {
                resultado = numUm - numDois;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double numUm, numDois, resultado;
            if (double.TryParse(txtNumeroUm.Text, out numUm) && (double.TryParse(txtNumeroDois.Text, out numDois)))
            {
                resultado = numUm + numDois;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double numUm, numDois, resultado;
            if (double.TryParse(txtNumeroUm.Text, out numUm) && (double.TryParse(txtNumeroDois.Text, out numDois)))
            {
                resultado = numUm * numDois;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void bttnDivisao_Click(object sender, EventArgs e)
        {
            double numUm, numDois, resultado;
            if (double.TryParse(txtNumeroUm.Text, out numUm) && (double.TryParse(txtNumeroDois.Text, out numDois)))
            {
                resultado = numUm / numDois;
                txtResultado.Text = resultado.ToString("N2");
            }
        }
    }
}
