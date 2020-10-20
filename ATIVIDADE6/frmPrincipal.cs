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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aTIVIDADE2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() <= 0)
            {
                frmExercicio2 frm2 = new frmExercicio2();
                frm2.Show();
            }
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() <= 0)
            {
                frmExercicio3 frm3 = new frmExercicio3();
                frm3.Show();
            }
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() <= 0)
            {
                frmExercicio4 frm4 = new frmExercicio4();
                frm4.Show();
            }
        }

        private void atividade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() <= 0)
            {
                frmExercicio5 frm5 = new frmExercicio5();
                frm5.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
