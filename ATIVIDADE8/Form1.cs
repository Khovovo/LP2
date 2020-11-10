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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtividade1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex1>().Count() <= 0)
            {
                ex1 frm1 = new ex1();
                frm1.Show();
            }
        }

        private void btnAtividade2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex2>().Count() <= 0)
            {
                ex2 frm2 = new ex2();
                frm2.Show();
            }
        }

        private void btnAtividade3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex3>().Count() <= 0)
            {
                ex3 frm3 = new ex3();
                frm3.Show();
            }
        }

        private void btnAtividade4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex4>().Count() <= 0)
            {
                ex4 frm4 = new ex4();
                frm4.Show();
            }
        }

        private void btnAtividade5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex5>().Count() <= 0)
            {
                ex5 frm5 = new ex5();
                frm5.Show();
            }
        }

        private void btnAtividade6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex6>().Count() <= 0)
            {
                ex6 frm6 = new ex6();
                frm6.Show();
            }
        }

        private void btnAtividade7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ex7>().Count() <= 0)
            {
                ex7 frm7 = new ex7();
                frm7.Show();
            }
        }
    }
}
