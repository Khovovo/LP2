using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE8
{
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }

        private void btnNomes_Click(object sender, EventArgs e)
        {
            lstNomes.Items.Clear();
            String nome, caracter;
            int finalRa = 1;

            for (int i = 0; i < finalRa; i++)
            {
                nome = Interaction.InputBox("Digite o nome " + (i + 1), "Lista de Nomes");
                caracter = nome.Replace(" ", "");
                lstNomes.Items.Add("Nome " + (i + 1) + ": " + nome + " " + caracter.Length + " Caracteres");
            }
        }
    }
}
