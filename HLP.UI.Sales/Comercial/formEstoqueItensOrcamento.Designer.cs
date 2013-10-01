namespace HLP.UI.Sales.Comercial
{
    partial class formEstoqueItensOrcamento
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
            this.pnBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnPrincipal = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvItens = new HLP.Comum.Components.HLP_DataGridView();
            this.bsItens = new System.Windows.Forms.BindingSource(this.components);
            this.clProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantPendenteDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.qEstoqueDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bSelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codItemOrcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrevEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantItensDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dConfirmacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMotPerdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBottom
            // 
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 286);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(693, 64);
            this.pnBottom.TabIndex = 0;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.dgvItens);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(693, 286);
            this.pnPrincipal.TabIndex = 1;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.Altera = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.cm = null;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clProduto,
            this.quantPendenteDataGridViewTextBoxColumn,
            this.qEstoqueDataGridViewTextBoxColumn,
            this.bSelDataGridViewCheckBoxColumn,
            this.codItemOrcamentoDataGridViewTextBoxColumn,
            this.dPrevEntregaDataGridViewTextBoxColumn,
            this.quantItensDataGridViewTextBoxColumn,
            this.dConfirmacaoDataGridViewTextBoxColumn,
            this.codMotPerdaDataGridViewTextBoxColumn,
            this.obsItemDataGridViewTextBoxColumn});
            this.dgvItens.DataSource = this.bsItens;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.DragDropLinha = false;
            this.dgvItens.Exclui = false;
            this.dgvItens.Inclui = false;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(693, 286);
            this.dgvItens.TabIndex = 0;
            // 
            // bsItens
            // 
            this.bsItens.DataSource = typeof(HLP.Models.Sales.Comercial.stItensModel);
            // 
            // clProduto
            // 
            this.clProduto.DataPropertyName = "codItem";
            this.clProduto.HeaderText = "Produto";
            this.clProduto.Name = "clProduto";
            this.clProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clProduto.Width = 180;
            // 
            // quantPendenteDataGridViewTextBoxColumn
            // 
            this.quantPendenteDataGridViewTextBoxColumn.DataPropertyName = "quantPendente";
            this.quantPendenteDataGridViewTextBoxColumn.HeaderText = "Qtd Pendente";
            this.quantPendenteDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantPendenteDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.quantPendenteDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantPendenteDataGridViewTextBoxColumn.Name = "quantPendenteDataGridViewTextBoxColumn";
            this.quantPendenteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantPendenteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.quantPendenteDataGridViewTextBoxColumn.Width = 100;
            // 
            // qEstoqueDataGridViewTextBoxColumn
            // 
            this.qEstoqueDataGridViewTextBoxColumn.DataPropertyName = "qEstoque";
            this.qEstoqueDataGridViewTextBoxColumn.HeaderText = "Qtd Estoque";
            this.qEstoqueDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qEstoqueDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.qEstoqueDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.qEstoqueDataGridViewTextBoxColumn.Name = "qEstoqueDataGridViewTextBoxColumn";
            this.qEstoqueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.qEstoqueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.qEstoqueDataGridViewTextBoxColumn.Width = 100;
            // 
            // bSelDataGridViewCheckBoxColumn
            // 
            this.bSelDataGridViewCheckBoxColumn.DataPropertyName = "bSel";
            this.bSelDataGridViewCheckBoxColumn.HeaderText = "bSel";
            this.bSelDataGridViewCheckBoxColumn.Name = "bSelDataGridViewCheckBoxColumn";
            this.bSelDataGridViewCheckBoxColumn.Visible = false;
            // 
            // codItemOrcamentoDataGridViewTextBoxColumn
            // 
            this.codItemOrcamentoDataGridViewTextBoxColumn.DataPropertyName = "codItemOrcamento";
            this.codItemOrcamentoDataGridViewTextBoxColumn.HeaderText = "codItemOrcamento";
            this.codItemOrcamentoDataGridViewTextBoxColumn.Name = "codItemOrcamentoDataGridViewTextBoxColumn";
            this.codItemOrcamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dPrevEntregaDataGridViewTextBoxColumn
            // 
            this.dPrevEntregaDataGridViewTextBoxColumn.DataPropertyName = "dPrevEntrega";
            this.dPrevEntregaDataGridViewTextBoxColumn.HeaderText = "dPrevEntrega";
            this.dPrevEntregaDataGridViewTextBoxColumn.Name = "dPrevEntregaDataGridViewTextBoxColumn";
            this.dPrevEntregaDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantItensDataGridViewTextBoxColumn
            // 
            this.quantItensDataGridViewTextBoxColumn.DataPropertyName = "quantItens";
            this.quantItensDataGridViewTextBoxColumn.HeaderText = "quantItens";
            this.quantItensDataGridViewTextBoxColumn.Name = "quantItensDataGridViewTextBoxColumn";
            this.quantItensDataGridViewTextBoxColumn.Visible = false;
            // 
            // dConfirmacaoDataGridViewTextBoxColumn
            // 
            this.dConfirmacaoDataGridViewTextBoxColumn.DataPropertyName = "dConfirmacao";
            this.dConfirmacaoDataGridViewTextBoxColumn.HeaderText = "dConfirmacao";
            this.dConfirmacaoDataGridViewTextBoxColumn.Name = "dConfirmacaoDataGridViewTextBoxColumn";
            this.dConfirmacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codMotPerdaDataGridViewTextBoxColumn
            // 
            this.codMotPerdaDataGridViewTextBoxColumn.DataPropertyName = "codMotPerda";
            this.codMotPerdaDataGridViewTextBoxColumn.HeaderText = "codMotPerda";
            this.codMotPerdaDataGridViewTextBoxColumn.Name = "codMotPerdaDataGridViewTextBoxColumn";
            this.codMotPerdaDataGridViewTextBoxColumn.Visible = false;
            // 
            // obsItemDataGridViewTextBoxColumn
            // 
            this.obsItemDataGridViewTextBoxColumn.DataPropertyName = "obsItem";
            this.obsItemDataGridViewTextBoxColumn.HeaderText = "obsItem";
            this.obsItemDataGridViewTextBoxColumn.Name = "obsItemDataGridViewTextBoxColumn";
            this.obsItemDataGridViewTextBoxColumn.Visible = false;
            // 
            // formEstoqueItensOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 350);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnBottom);
            this.MaximizeBox = false;
            this.Name = "formEstoqueItensOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque Itens do Orçamento";
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnBottom;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal;
        private Comum.Components.HLP_DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewComboBoxColumn clProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn quantPendenteDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn qEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bSelDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItemOrcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrevEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantItensDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dConfirmacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMotPerdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsItens;
    }
}