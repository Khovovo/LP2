namespace ATIVIDADE5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbCasado = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAliquotaInss = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbSalario = new System.Windows.Forms.MaskedTextBox();
            this.mtbFilhos = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Filhos";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(12, 194);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(49, 17);
            this.lblDados.TabIndex = 3;
            this.lblDados.Text = "Dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alíquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alíquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salário Família";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salário Líquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Desconto IRPF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbM);
            this.groupBox1.Controls.Add(this.rdbF);
            this.groupBox1.Location = new System.Drawing.Point(471, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Checked = true;
            this.rdbF.Location = new System.Drawing.Point(19, 21);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(37, 21);
            this.rdbF.TabIndex = 0;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(19, 48);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(40, 21);
            this.rdbM.TabIndex = 1;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbCasado);
            this.panel1.Location = new System.Drawing.Point(471, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            // 
            // ckbCasado
            // 
            this.ckbCasado.AutoSize = true;
            this.ckbCasado.Location = new System.Drawing.Point(19, 3);
            this.ckbCasado.Name = "ckbCasado";
            this.ckbCasado.Size = new System.Drawing.Size(78, 21);
            this.ckbCasado.TabIndex = 0;
            this.ckbCasado.Text = "Casado";
            this.ckbCasado.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(139, 22);
            this.txtNome.TabIndex = 12;
            // 
            // txtAliquotaInss
            // 
            this.txtAliquotaInss.Enabled = false;
            this.txtAliquotaInss.Location = new System.Drawing.Point(177, 267);
            this.txtAliquotaInss.Name = "txtAliquotaInss";
            this.txtAliquotaInss.Size = new System.Drawing.Size(100, 22);
            this.txtAliquotaInss.TabIndex = 15;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(177, 301);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(100, 22);
            this.txtAliquotaIRPF.TabIndex = 16;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(177, 335);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioFamilia.TabIndex = 17;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(177, 369);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioLiquido.TabIndex = 18;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(423, 264);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(100, 22);
            this.txtDescontoINSS.TabIndex = 19;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(423, 299);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(100, 22);
            this.txtDescontoIRPF.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Verifica Desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtbSalario
            // 
            this.mtbSalario.Location = new System.Drawing.Point(167, 72);
            this.mtbSalario.Mask = "######,##";
            this.mtbSalario.Name = "mtbSalario";
            this.mtbSalario.Size = new System.Drawing.Size(139, 22);
            this.mtbSalario.TabIndex = 22;
            // 
            // mtbFilhos
            // 
            this.mtbFilhos.Location = new System.Drawing.Point(167, 100);
            this.mtbFilhos.Mask = "##";
            this.mtbFilhos.Name = "mtbFilhos";
            this.mtbFilhos.Size = new System.Drawing.Size(139, 22);
            this.mtbFilhos.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 481);
            this.Controls.Add(this.mtbFilhos);
            this.Controls.Add(this.mtbSalario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaInss);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbCasado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAliquotaInss;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbSalario;
        private System.Windows.Forms.MaskedTextBox mtbFilhos;
    }
}

