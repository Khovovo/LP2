namespace ATIVIDADE7
{
    partial class frm_Ex2
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBoxH = new System.Windows.Forms.TextBox();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(86, 187);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(124, 27);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calcular H";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBoxH
            // 
            this.txtBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxH.Location = new System.Drawing.Point(147, 83);
            this.txtBoxH.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxH.Name = "txtBoxH";
            this.txtBoxH.ReadOnly = true;
            this.txtBoxH.Size = new System.Drawing.Size(79, 41);
            this.txtBoxH.TabIndex = 8;
            // 
            // txtBoxN
            // 
            this.txtBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxN.Location = new System.Drawing.Point(147, 128);
            this.txtBoxN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(79, 41);
            this.txtBoxN.TabIndex = 7;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(80, 128);
            this.lblN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(70, 36);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N = ";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(80, 92);
            this.lblH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(61, 36);
            this.lblH.TabIndex = 5;
            this.lblH.Text = "H =";
            // 
            // frm_Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 339);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxH);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblH);
            this.Name = "frm_Ex2";
            this.Text = "frm_Ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtBoxH;
        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblH;
    }
}