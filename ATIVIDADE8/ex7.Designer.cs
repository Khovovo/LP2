namespace ATIVIDADE8
{
    partial class ex7
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
            this.btnNomes = new System.Windows.Forms.Button();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNomes
            // 
            this.btnNomes.Location = new System.Drawing.Point(138, 61);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(231, 129);
            this.btnNomes.TabIndex = 1;
            this.btnNomes.Text = "Inserir Nomes";
            this.btnNomes.UseVisualStyleBackColor = true;
            this.btnNomes.Click += new System.EventHandler(this.btnNomes_Click);
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.ItemHeight = 16;
            this.lstNomes.Location = new System.Drawing.Point(415, 61);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(320, 340);
            this.lstNomes.TabIndex = 3;
            // 
            // ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNomes);
            this.Controls.Add(this.btnNomes);
            this.Name = "ex7";
            this.Text = "ex7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.ListBox lstNomes;
    }
}