using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, pesoatual, pesoRecomendado;
            if(double.TryParse(txtAltura.Text, out altura) && (double.TryParse(txtPeso.Text, out pesoatual)))
            {
                if (rdbM.Checked == true)
                {
                    pesoRecomendado = (72.7 * (altura/100)-58);
                    if(pesoRecomendado == pesoatual)
                        MessageBox.Show("Você está com o Peso Ideal");
                    else if(pesoRecomendado > pesoatual)
                        MessageBox.Show("Coma bastante massas e doces");
                    else if (pesoRecomendado < pesoatual)
                        MessageBox.Show("Regime Obrigatório Já");
                }
                else
                {
                    pesoRecomendado = (62.1 * (altura/100)-44.7);
                    if (pesoRecomendado == pesoatual)
                        MessageBox.Show("Você está com o Peso Ideal");
                    else if (pesoRecomendado > pesoatual)
                        MessageBox.Show("Coma bastante massas e doces");
                    else if (pesoRecomendado < pesoatual)
                        MessageBox.Show("Regime Obrigatório Já");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
