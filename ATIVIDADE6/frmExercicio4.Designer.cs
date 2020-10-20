namespace ATIVIDADE6
{
    partial class frmExercicio4
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
            this.rtbUnica = new System.Windows.Forms.RichTextBox();
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbUnica
            // 
            this.rtbUnica.Location = new System.Drawing.Point(149, 21);
            this.rtbUnica.Name = "rtbUnica";
            this.rtbUnica.Size = new System.Drawing.Size(234, 139);
            this.rtbUnica.TabIndex = 0;
            this.rtbUnica.Text = "";
            // 
            // btnNumericos
            // 
            this.btnNumericos.Location = new System.Drawing.Point(149, 179);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(75, 23);
            this.btnNumericos.TabIndex = 1;
            this.btnNumericos.Text = "Numericos";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.btnNumericos_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(228, 179);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(75, 23);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetra
            // 
            this.btnLetra.Location = new System.Drawing.Point(307, 179);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(75, 23);
            this.btnLetra.TabIndex = 3;
            this.btnLetra.Text = "Letra";
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 281);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumericos);
            this.Controls.Add(this.rtbUnica);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUnica;
        private System.Windows.Forms.Button btnNumericos;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetra;
    }
}