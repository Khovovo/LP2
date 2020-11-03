using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE7
{
    public partial class frm_Ex1 : Form
    {
        public frm_Ex1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int x = 0;
            while (x < richTxt.Text.Length)
            {
                if (Char.IsWhiteSpace(richTxt.Text[x]))
                {
                    cont++;
                }
                x++;
            }
            MessageBox.Show("Aparecem " + cont + " espaços em branco nesta frase.");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char c in richTxt.Text)
            {
                if (c == 'R' || c == 'r')
                    cont++;
            }
            MessageBox.Show("Aparecem " + cont + " 'r' ou 'R' nesta frase.");
        }

        private void btnIguais_Click(object sender, EventArgs e)
        {
            int i, cont = 0;

            for (i = 1; i < richTxt.Text.Length; i++)
            {
                if (richTxt.Text[i - 1] == richTxt.Text[i])
                    cont++;
            }
            MessageBox.Show("existem " + cont + " letras que tem como antecessor ela mesma(espaços seguidos tambem contam).");
        }

        private void richTxt_TextChanged(object sender, EventArgs e)
        {
            int n;

            n = richTxt.Text.Length;
            txtContador.Text = n.ToString();
        }
    }
}
