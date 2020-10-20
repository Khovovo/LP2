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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumericos_Click(object sender, EventArgs e)
        {
            int numericos = 0;
            for (var x = 0; x <= rtbUnica.Text.Length - 1; x++)
            {
                if (Char.IsNumber(rtbUnica.Text[x]))
                    numericos++;
            }
            MessageBox.Show(""+numericos + " são numéricos");
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x < rtbUnica.Text.Length)
            {
                if (Char.IsWhiteSpace(rtbUnica.Text[x]))
                {
                    MessageBox.Show("O primeiro branco aparece na posição " + (x + 1));
                    break;
                }
                x++;
            }
        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            int letras = 0;

            foreach (char c in rtbUnica.Text)
            {
                if (Char.IsLetter(c))
                    letras++;
            }

            MessageBox.Show("Número de letras : " + letras);
        }
    }
}
