﻿using System;
using System.Collections;
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
    public partial class ex5 : Form
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            String stringona = "";
            array.Add("Ana");
            array.Add("André");
            array.Add("Débora");
            array.Add("Fátima");
            array.Add("João");
            array.Add("Janete");
            array.Add("Otávio");
            array.Add("Marcelo");
            array.Add("Pedro");
            array.Add("Thais");

            foreach (Object o in array)
            {
                stringona += o + "\n";
            }
            MessageBox.Show(stringona);

            array.Remove("Otávio");
            stringona = "";
            foreach (Object o in array)
            {
                stringona += o + "\n";
            }
            MessageBox.Show(stringona);
        }
    }
}
