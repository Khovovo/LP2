using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (double.TryParse(txtA.Text, out a) && 
                (double.TryParse(txtB.Text, out b)) && 
                (double.TryParse(txtC.Text, out c)) 
                && a > 0 && b > 0 && c > 0)
            {
                if (Math.Abs(b - c) < a && a < b + c &&
                    Math.Abs(a - c) < b && b < a + c &&
                   Math.Abs(a - b) < c && c < a + b)
                {
                    if (a == b && b == c)
                        MessageBox.Show("Equilatero");
                    else if (a == b || b == c || a==c)
                        MessageBox.Show("Isósceles");
                    else
                        MessageBox.Show("Escaleno");
                }
                else
                    MessageBox.Show("Valores não coincidem ao de um triangulo");
                }
            else
                MessageBox.Show("Insira um valor Válido e positivo");
        }
    }
}
