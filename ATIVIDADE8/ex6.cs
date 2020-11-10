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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] nota1 = new double[20];
            double[] nota2 = new double[20];
            double[] nota3 = new double[20];
            bool aux;
            String medias = "";
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite a nota 1 do Aluno " + (i + 1), "Prova 1"), out nota1[i]);
                } while (aux == false);

                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite a nota 2 do Aluno " + (i + 1), "Prova 2"), out nota2[i]);
                } while (aux == false);

                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite a nota 3 do Aluno " + (i + 1), "Prova 3"), out nota3[i]);
                } while (aux == false);

                medias += "Aluno " + (i + 1) + ": média: " + ((nota1[i] + nota2[i] + nota3[i]) / 3).ToString("N2") + "\n";
            }

            MessageBox.Show(medias);
        }
    }
}
