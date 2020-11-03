namespace ATIVIDADE7
{
    partial class frm_Ex3
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
            this.txtBoxEhPalindromo = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtEx3Reverse = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtEx3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxEhPalindromo
            // 
            this.txtBoxEhPalindromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEhPalindromo.Location = new System.Drawing.Point(154, 160);
            this.txtBoxEhPalindromo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEhPalindromo.MaxLength = 50;
            this.txtBoxEhPalindromo.Name = "txtBoxEhPalindromo";
            this.txtBoxEhPalindromo.ReadOnly = true;
            this.txtBoxEhPalindromo.Size = new System.Drawing.Size(245, 34);
            this.txtBoxEhPalindromo.TabIndex = 9;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(13, 160);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(133, 32);
            this.btnReverse.TabIndex = 8;
            this.btnReverse.Text = "Inverter Frase";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // txtEx3Reverse
            // 
            this.txtEx3Reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEx3Reverse.Location = new System.Drawing.Point(13, 216);
            this.txtEx3Reverse.Margin = new System.Windows.Forms.Padding(4);
            this.txtEx3Reverse.MaxLength = 50;
            this.txtEx3Reverse.Name = "txtEx3Reverse";
            this.txtEx3Reverse.ReadOnly = true;
            this.txtEx3Reverse.Size = new System.Drawing.Size(386, 34);
            this.txtEx3Reverse.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(14, 24);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(546, 29);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Escreva a frase para verificar se ela é palíndromo:";
            // 
            // txtEx3
            // 
            this.txtEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEx3.Location = new System.Drawing.Point(13, 94);
            this.txtEx3.Margin = new System.Windows.Forms.Padding(4);
            this.txtEx3.MaxLength = 50;
            this.txtEx3.Name = "txtEx3";
            this.txtEx3.Size = new System.Drawing.Size(386, 34);
            this.txtEx3.TabIndex = 5;
            // 
            // frm_Ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.txtBoxEhPalindromo);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtEx3Reverse);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtEx3);
            this.Name = "frm_Ex3";
            this.Text = "frm_Ex3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEhPalindromo;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtEx3Reverse;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtEx3;
    }
}