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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Ex1>().Count() <= 0)
            {
                frm_Ex1 frm1 = new frm_Ex1();
                frm1.Show();
            }
        }

        private void brnEx2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Ex2>().Count() <= 0)
            {
                frm_Ex2 frm2 = new frm_Ex2();
                frm2.Show();
            }
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Ex3>().Count() <= 0)
            {
                frm_Ex3 frm3 = new frm_Ex3();
                frm3.Show();
            }
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Ex4>().Count() <= 0)
            {
                frm_Ex4 frm4 = new frm_Ex4();
                frm4.Show();
            }
        }
    }
}
