namespace ATIVIDADE7
{
    partial class frm_Ex1
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
            this.richTxt = new System.Windows.Forms.RichTextBox();
            this.lblExpl = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnIguais = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxt
            // 
            this.richTxt.Location = new System.Drawing.Point(14, 64);
            this.richTxt.Margin = new System.Windows.Forms.Padding(4);
            this.richTxt.MaxLength = 100;
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(322, 131);
            this.richTxt.TabIndex = 14;
            this.richTxt.Text = "";
            this.richTxt.TextChanged += new System.EventHandler(this.richTxt_TextChanged);
            // 
            // lblExpl
            // 
            this.lblExpl.AutoSize = true;
            this.lblExpl.Location = new System.Drawing.Point(9, 25);
            this.lblExpl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpl.Name = "lblExpl";
            this.lblExpl.Size = new System.Drawing.Size(327, 17);
            this.lblExpl.TabIndex = 13;
            this.lblExpl.Text = "Digite uma frase para analise(Max 100 caracteres)";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(350, 203);
            this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(163, 17);
            this.lblContador.TabIndex = 12;
            this.lblContador.Text = "Contador de Caracteres:";
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(353, 222);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(157, 22);
            this.txtContador.TabIndex = 11;
            // 
            // btnIguais
            // 
            this.btnIguais.Location = new System.Drawing.Point(216, 203);
            this.btnIguais.Margin = new System.Windows.Forms.Padding(4);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(120, 61);
            this.btnIguais.TabIndex = 10;
            this.btnIguais.Text = "Contador de Letras Iguais Seguidas";
            this.btnIguais.UseVisualStyleBackColor = true;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(120, 203);
            this.btnR.Margin = new System.Windows.Forms.Padding(4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(88, 61);
            this.btnR.TabIndex = 9;
            this.btnR.Text = "Contador de letras R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(12, 203);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(100, 61);
            this.btnBranco.TabIndex = 8;
            this.btnBranco.Text = "Contador Espaços Brancos";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // frm_Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 303);
            this.Controls.Add(this.richTxt);
            this.Controls.Add(this.lblExpl);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.btnIguais);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBranco);
            this.Name = "frm_Ex1";
            this.Text = "frm_Ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxt;
        private System.Windows.Forms.Label lblExpl;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnBranco;
    }
}