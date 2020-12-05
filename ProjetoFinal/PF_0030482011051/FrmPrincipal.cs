using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_0030482011051
{
    public partial class FrmPrincipal : Form
    {
        public static SqlConnection conexao;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCidade_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmCidade>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmCidade>().First().Focus();
            }
            else
            {
                FrmCidade FrmCidade = new FrmCidade();
                FrmCidade.Show(); 
                }
            }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmSobre>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmSobre>().First().Focus();
            }
            else
            {
                FrmSobre FrmSobre = new FrmSobre();
                FrmSobre.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-71PL3AG\\KVZSERVER;Initial Catalog=LP2;User ID=khovovo;Password=root");
                conexao.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }
    }
}
