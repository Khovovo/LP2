namespace ATIVIDADE6
{
    partial class frmExercicio2
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
            this.btnIguais = new System.Windows.Forms.Button();
            this.btn1no2 = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIguais
            // 
            this.btnIguais.Location = new System.Drawing.Point(107, 114);
            this.btnIguais.Name = "btnIguais";
            this.btnIguais.Size = new System.Drawing.Size(75, 35);
            this.btnIguais.TabIndex = 0;
            this.btnIguais.Text = "Iguais?";
            this.btnIguais.UseVisualStyleBackColor = true;
            this.btnIguais.Click += new System.EventHandler(this.btnIguais_Click);
            // 
            // btn1no2
            // 
            this.btn1no2.Location = new System.Drawing.Point(107, 155);
            this.btn1no2.Name = "btn1no2";
            this.btn1no2.Size = new System.Drawing.Size(75, 35);
            this.btn1no2.TabIndex = 1;
            this.btn1no2.Text = "1° no 2°";
            this.btn1no2.UseVisualStyleBackColor = true;
            this.btn1no2.Click += new System.EventHandler(this.btn1no2_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(107, 194);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(75, 35);
            this.btnAsterisco.TabIndex = 2;
            this.btnAsterisco.Text = "*  *";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(94, 58);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 22);
            this.txtPalavra1.TabIndex = 3;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(94, 86);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 22);
            this.txtPalavra2.TabIndex = 4;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 278);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.btnAsterisco);
            this.Controls.Add(this.btn1no2);
            this.Controls.Add(this.btnIguais);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIguais;
        private System.Windows.Forms.Button btn1no2;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}