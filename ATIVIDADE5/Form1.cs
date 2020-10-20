using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioLiquido, salarioBruto, salarioFamilia, descontoINSS, descontoIRPF;
            salarioFamilia = 0;
            string nome = txtNome.Text;
            descontoINSS = 0;
            descontoIRPF = 0;
            salarioBruto = 0;
            int numFilhos;
            try
            {
                salarioBruto = Convert.ToDouble(mtbSalario.Text) / 100;
                try
                {
                    numFilhos = Convert.ToInt32(mtbFilhos.Text);
                    if (salarioBruto <= 800.47)
                    {
                        txtAliquotaInss.Text = "6.65%";
                        descontoINSS = salarioBruto * 0.0765;
                        txtDescontoINSS.Text = "" + descontoINSS;
                    }
                    else if (salarioBruto > 800.47 && salarioBruto <= 1050)
                    {
                        txtAliquotaInss.Text = "8.65%";
                        descontoINSS = salarioBruto * 0.0865;
                        txtDescontoINSS.Text = "" + descontoINSS;
                    }
                    else if (salarioBruto > 1050 && salarioBruto <= 1400.77)
                    {
                        txtAliquotaInss.Text = "9%";
                        descontoINSS = salarioBruto * 0.09;
                        txtDescontoINSS.Text = "" + descontoINSS;
                    }
                    else if (salarioBruto > 1400.77 && salarioBruto <= 2801.56)
                    {
                        txtAliquotaInss.Text = "11%";
                        descontoINSS = salarioBruto * 0.11;
                        txtDescontoINSS.Text = "" + descontoINSS;
                    }
                    else if (salarioBruto > 2801.56)
                    {
                        txtAliquotaInss.Text = "0%";
                        descontoINSS = 308.17;
                        txtDescontoINSS.Text = "" + descontoINSS;
                    }

                    if (salarioBruto <= 1257.12)
                    {
                        txtAliquotaIRPF.Text = "0%";
                        descontoIRPF = salarioBruto * 0;
                        txtDescontoIRPF.Text = "" + descontoIRPF;

                    }
                    else if (salarioBruto > 1257.12 && salarioBruto <= 2512.08)
                    {
                        txtAliquotaIRPF.Text = "15%";
                        descontoIRPF = salarioBruto * 0.15;
                        txtDescontoIRPF.Text = "" + descontoIRPF;
                    }
                    else if (salarioBruto > 2512.08)
                    {
                        txtAliquotaIRPF.Text = "27,5%";
                        descontoIRPF = salarioBruto * 0.275;
                        txtDescontoIRPF.Text = "" + descontoIRPF;
                    }

                    if (salarioBruto <= 435.52)
                        salarioFamilia = 22.33 * numFilhos;
                    else if (salarioBruto > 435.52 && salarioBruto <= 654.61)
                        salarioFamilia = 15.74 * numFilhos;
                    else if (salarioBruto > 654.61)
                    {
                        salarioFamilia = 0;
                    }

                    salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;
                    txtSalarioFamilia.Text = "" + salarioFamilia;
                    txtSalarioLiquido.Text = "" + salarioLiquido;
                    string civil;
                    if (ckbCasado.Checked)
                        civil = " Casado(a) ";
                    else
                        civil = " Solteiro(a) ";
                    if (rdbF.Checked == true)
                        lblDados.Text = "Os descontos do salário da Senhora " + nome + "\nque é" + civil + "\ne que tem " + numFilhos + "Filho(s) são:";
                    else
                        lblDados.Text = "Os descontos do salário do Senhor " + nome + "\nque é" + civil + "\ne que tem " + numFilhos + "Filho(s) são:";
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira o Número de filhos");
                    mtbFilhos.Focus();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Insira o valor do salário");
                mtbSalario.Focus();
            }
            
            
            
            
            
        }
    }
}
