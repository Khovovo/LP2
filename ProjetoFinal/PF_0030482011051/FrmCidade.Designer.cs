namespace PF_0030482011051
{
    partial class FrmCidade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidade));
            this.bdnCidade = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCidade = new System.Windows.Forms.TabControl();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.dgvCidades = new System.Windows.Forms.DataGridView();
            this.tbDetalhes = new System.Windows.Forms.TabPage();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lP2DataSet = new PF_0030482011051.LP2DataSet();
            this.tBCIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBCIDADETableAdapter = new PF_0030482011051.LP2DataSetTableAdapters.TBCIDADETableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tsbInserir = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdnCidade)).BeginInit();
            this.bdnCidade.SuspendLayout();
            this.tbCidade.SuspendLayout();
            this.tbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).BeginInit();
            this.tbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCIDADEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdnCidade
            // 
            this.bdnCidade.AddNewItem = null;
            this.bdnCidade.CountItem = this.bindingNavigatorCountItem;
            this.bdnCidade.DeleteItem = null;
            this.bdnCidade.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdnCidade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbInserir,
            this.tsbEditar,
            this.tsbExcluir,
            this.tsbSalvar,
            this.tsbCancelar,
            this.tsbSair});
            this.bdnCidade.Location = new System.Drawing.Point(0, 0);
            this.bdnCidade.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdnCidade.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdnCidade.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdnCidade.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdnCidade.Name = "bdnCidade";
            this.bdnCidade.PositionItem = this.bindingNavigatorPositionItem;
            this.bdnCidade.Size = new System.Drawing.Size(800, 27);
            this.bdnCidade.TabIndex = 0;
            this.bdnCidade.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbCidade
            // 
            this.tbCidade.Controls.Add(this.tbDados);
            this.tbCidade.Controls.Add(this.tbDetalhes);
            this.tbCidade.Location = new System.Drawing.Point(0, 30);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.SelectedIndex = 0;
            this.tbCidade.Size = new System.Drawing.Size(800, 422);
            this.tbCidade.TabIndex = 1;
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.dgvCidades);
            this.tbDados.Location = new System.Drawing.Point(4, 25);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(792, 393);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // dgvCidades
            // 
            this.dgvCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCidades.Location = new System.Drawing.Point(8, 3);
            this.dgvCidades.Name = "dgvCidades";
            this.dgvCidades.RowHeadersVisible = false;
            this.dgvCidades.RowHeadersWidth = 51;
            this.dgvCidades.RowTemplate.Height = 24;
            this.dgvCidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCidades.Size = new System.Drawing.Size(778, 384);
            this.dgvCidades.TabIndex = 0;
            // 
            // tbDetalhes
            // 
            this.tbDetalhes.Controls.Add(this.cmbEstado);
            this.tbDetalhes.Controls.Add(this.txtCidade);
            this.tbDetalhes.Controls.Add(this.txtID);
            this.tbDetalhes.Controls.Add(this.label3);
            this.tbDetalhes.Controls.Add(this.label2);
            this.tbDetalhes.Controls.Add(this.label1);
            this.tbDetalhes.Location = new System.Drawing.Point(4, 25);
            this.tbDetalhes.Name = "tbDetalhes";
            this.tbDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tbDetalhes.Size = new System.Drawing.Size(792, 393);
            this.tbDetalhes.TabIndex = 1;
            this.tbDetalhes.Text = "Detalhes";
            this.tbDetalhes.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(216, 125);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(127, 24);
            this.cmbEstado.TabIndex = 5;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(216, 83);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(127, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(216, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(127, 22);
            this.txtID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCIDADEBindingSource
            // 
            this.tBCIDADEBindingSource.DataMember = "TBCIDADE";
            this.tBCIDADEBindingSource.DataSource = this.lP2DataSet;
            // 
            // tBCIDADETableAdapter
            // 
            this.tBCIDADETableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tsbInserir
            // 
            this.tsbInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInserir.Image = global::PF_0030482011051.Properties.Resources.plus;
            this.tsbInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInserir.Name = "tsbInserir";
            this.tsbInserir.Size = new System.Drawing.Size(29, 24);
            this.tsbInserir.Text = "Inserir";
            this.tsbInserir.Click += new System.EventHandler(this.tsbInserir_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::PF_0030482011051.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(29, 24);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = global::PF_0030482011051.Properties.Resources.X;
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(29, 24);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Enabled = false;
            this.tsbSalvar.Image = global::PF_0030482011051.Properties.Resources.Save;
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(29, 24);
            this.tsbSalvar.Text = "Gravar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::PF_0030482011051.Properties.Resources.Cancel;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(29, 24);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::PF_0030482011051.Properties.Resources.exit;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(29, 24);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.bdnCidade);
            this.Name = "FrmCidade";
            this.Text = "FrmCadCidade";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdnCidade)).EndInit();
            this.bdnCidade.ResumeLayout(false);
            this.bdnCidade.PerformLayout();
            this.tbCidade.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCidades)).EndInit();
            this.tbDetalhes.ResumeLayout(false);
            this.tbDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCIDADEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdnCidade;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbCidade;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.DataGridView dgvCidades;
        private System.Windows.Forms.TabPage tbDetalhes;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbInserir;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource tBCIDADEBindingSource;
        private LP2DataSetTableAdapters.TBCIDADETableAdapter tBCIDADETableAdapter;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbSair;
    }
}