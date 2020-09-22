using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Do_Cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura, volume;
            try
            {
                raio = Convert.ToDouble(txtRaio.Text);
                altura = Convert.ToDouble(txtAltura.Text);
                volume = Math.PI * (raio * raio) * altura;
                txtVolume.Text = "" + volume.ToString("N5");
            }
            catch (Exception)
            {

                MessageBox.Show("Um dos valores não é número");
            }
            
            

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            txtAltura.Focus();
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnCalcular.Focus();
        }
    }
}
