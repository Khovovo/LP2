namespace ATIVIDADE7
{
    partial class frm_Ex4
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtBoxSalario = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBoxSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblGrat = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxGrat = new System.Windows.Forms.TextBox();
            this.txtBoxProd = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxCargo = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(180, 165);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(105, 25);
            this.lblSalario.TabIndex = 44;
            this.lblSalario.Text = "SALARIO:";
            // 
            // txtBoxSalario
            // 
            this.txtBoxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalario.Location = new System.Drawing.Point(293, 165);
            this.txtBoxSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSalario.Name = "txtBoxSalario";
            this.txtBoxSalario.Size = new System.Drawing.Size(299, 30);
            this.txtBoxSalario.TabIndex = 43;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(248, 320);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(175, 32);
            this.btnCalc.TabIndex = 42;
            this.btnCalc.Text = "Calcular Salario Bruto";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBoxSalarioBruto
            // 
            this.txtBoxSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalarioBruto.Location = new System.Drawing.Point(185, 432);
            this.txtBoxSalarioBruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSalarioBruto.Name = "txtBoxSalarioBruto";
            this.txtBoxSalarioBruto.Size = new System.Drawing.Size(299, 30);
            this.txtBoxSalarioBruto.TabIndex = 41;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(243, 375);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(179, 25);
            this.lblSalarioBruto.TabIndex = 40;
            this.lblSalarioBruto.Text = "SALARIO BRUTO:";
            // 
            // lblGrat
            // 
            this.lblGrat.AutoSize = true;
            this.lblGrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrat.Location = new System.Drawing.Point(116, 272);
            this.lblGrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrat.Name = "lblGrat";
            this.lblGrat.Size = new System.Drawing.Size(169, 25);
            this.lblGrat.TabIndex = 39;
            this.lblGrat.Text = "GRATIFICAÇÃO:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(152, 218);
            this.lblProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(133, 25);
            this.lblProd.TabIndex = 38;
            this.lblProd.Text = "PRODUÇÃO:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(32, 115);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(253, 25);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "NUMERO DE INSCRIÇÃO:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(194, 61);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(91, 25);
            this.lblCargo.TabIndex = 36;
            this.lblCargo.Text = "CARGO:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(207, 13);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(78, 25);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "NOME:";
            // 
            // txtBoxGrat
            // 
            this.txtBoxGrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGrat.Location = new System.Drawing.Point(293, 272);
            this.txtBoxGrat.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGrat.Name = "txtBoxGrat";
            this.txtBoxGrat.Size = new System.Drawing.Size(299, 30);
            this.txtBoxGrat.TabIndex = 34;
            // 
            // txtBoxProd
            // 
            this.txtBoxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProd.Location = new System.Drawing.Point(293, 218);
            this.txtBoxProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProd.Name = "txtBoxProd";
            this.txtBoxProd.Size = new System.Drawing.Size(299, 30);
            this.txtBoxProd.TabIndex = 33;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(293, 112);
            this.txtBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(299, 30);
            this.txtBoxID.TabIndex = 32;
            // 
            // txtBoxCargo
            // 
            this.txtBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCargo.Location = new System.Drawing.Point(293, 61);
            this.txtBoxCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCargo.Name = "txtBoxCargo";
            this.txtBoxCargo.Size = new System.Drawing.Size(299, 30);
            this.txtBoxCargo.TabIndex = 31;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(293, 13);
            this.txtBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(299, 30);
            this.txtBoxNome.TabIndex = 30;
            // 
            // frm_Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 522);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtBoxSalario);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblGrat);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtBoxGrat);
            this.Controls.Add(this.txtBoxProd);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxCargo);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "frm_Ex4";
            this.Text = "frm_Ex4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtBoxSalario;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtBoxSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblGrat;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxGrat;
        private System.Windows.Forms.TextBox txtBoxProd;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxCargo;
        private System.Windows.Forms.TextBox txtBoxNome;
    }
}