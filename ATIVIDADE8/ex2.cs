﻿using System;
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
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            double[] num = new double[20];
            String numeroReverse = "";
            bool aux;

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aux = double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o Número " + (i + 1), "Digite os números"), out num[i]);
                } while (aux == false);
            }
            for (int i = 19; i >= 0; i--)
            {
                numeroReverse += num[i] + " ";
            }
            string array = new string(numeroReverse.Reverse().ToArray());
            MessageBox.Show(array);
        }
    }
}
