using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE6
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text));

            MessageBox.Show("O Sorteio resultou em: " + numero);
        }
    }
}
