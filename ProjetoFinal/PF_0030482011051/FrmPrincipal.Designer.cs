﻿namespace PF_0030482011051
{
    partial class FrmPrincipal
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
            this.btnCidade = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCidade
            // 
            this.btnCidade.Location = new System.Drawing.Point(61, 64);
            this.btnCidade.Name = "btnCidade";
            this.btnCidade.Size = new System.Drawing.Size(158, 38);
            this.btnCidade.TabIndex = 0;
            this.btnCidade.Text = "Cadastro Cidades";
            this.btnCidade.UseVisualStyleBackColor = true;
            this.btnCidade.Click += new System.EventHandler(this.btnCidade_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(225, 64);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(105, 38);
            this.btnSobre.TabIndex = 1;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(336, 64);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(158, 38);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 170);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnCidade);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCidade;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSair;
    }
}

