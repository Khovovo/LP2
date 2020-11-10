using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ATIVIDADE8
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void btnInverso_Click(object sender, EventArgs e)
        {
            double[] num = new double[20];
            String numeroReverso = "";
            bool aux;

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite o Número " + (i + 1), "Digite os números"), out num[i]);
                } while (aux == false);
            }
            for (int i = 19; i >= 0; i--)
            {
                numeroReverso += num[i] + " ";
            }
            MessageBox.Show(numeroReverso);
        }
    }
}
