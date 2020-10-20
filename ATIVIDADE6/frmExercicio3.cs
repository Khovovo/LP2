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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            txtPalavra1.Text = txtPalavra1.Text.ToLower();
            txtPalavra2.Text = txtPalavra2.Text.ToLower();
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);
                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnReverso_Click(object sender, EventArgs e)
        {
            string texto = txtPalavra1.Text;
            char[] arr = texto.ToCharArray();
            Array.Reverse(arr);
            string resultado = "";

            foreach (char letra in arr)
                resultado = resultado + letra.ToString();
            MessageBox.Show(resultado);
        }
    }
}
