namespace ATIVIDADE8
{
    partial class ex1
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
            this.btnInverso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInverso
            // 
            this.btnInverso.Location = new System.Drawing.Point(204, 115);
            this.btnInverso.Name = "btnInverso";
            this.btnInverso.Size = new System.Drawing.Size(231, 129);
            this.btnInverso.TabIndex = 0;
            this.btnInverso.Text = "Mostrar Números em ordem Inversa";
            this.btnInverso.UseVisualStyleBackColor = true;
            this.btnInverso.Click += new System.EventHandler(this.btnInverso_Click);
            // 
            // ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 380);
            this.Controls.Add(this.btnInverso);
            this.Name = "ex1";
            this.Text = "ex1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverso;
    }
}