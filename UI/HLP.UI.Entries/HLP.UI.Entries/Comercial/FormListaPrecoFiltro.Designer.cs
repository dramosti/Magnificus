using HLP.Comum.Components;
namespace HLP.UI.Entries.Comercial
{
    partial class FormListaPrecoFiltro
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bsListaPreco = new System.Windows.Forms.BindingSource(this.components);
            this.dgvItens = new HLP_DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vCustoProduto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pDesconto = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pComissao = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pOutros = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pLucro = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.vVenda = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pDescontoMaximo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pAcrescimoMaximo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pComissaoAvista = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pComissaoAprazo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.dAlteracaoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnConfirmar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTodos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.dgvItens);
            this.kryptonPanel1.Controls.Add(this.menuStrip1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonPanel1.Size = new System.Drawing.Size(860, 376);
            this.kryptonPanel1.TabIndex = 105;
            // 
            // bsListaPreco
            // 
            this.bsListaPreco.DataSource = typeof(HLP.Models.Entries.Comercial.Lista_precoModel);
            this.bsListaPreco.Filter = "";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.vCustoProduto,
            this.pDesconto,
            this.pComissao,
            this.pOutros,
            this.pLucro,
            this.vVenda,
            this.pDescontoMaximo,
            this.pAcrescimoMaximo,
            this.pComissaoAvista,
            this.pComissaoAprazo,
            this.dAlteracaoCusto});
            this.dgvItens.DataSource = this.bsListaPreco;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(3, 30);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(854, 343);
            this.dgvItens.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvItens.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens.TabIndex = 104;
            this.dgvItens.Tag = "Lista_preco";
            this.dgvItens.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_ColumnHeaderMouseClick);
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "idProduto";
            this.idProduto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idProduto.HeaderText = "Produto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProduto.Width = 300;
            // 
            // vCustoProduto
            // 
            this.vCustoProduto.DataPropertyName = "vCustoProduto";
            this.vCustoProduto.HeaderText = "Custo do Produto";
            this.vCustoProduto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vCustoProduto.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vCustoProduto.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vCustoProduto.Name = "vCustoProduto";
            this.vCustoProduto.ReadOnly = true;
            this.vCustoProduto.Width = 180;
            // 
            // pDesconto
            // 
            this.pDesconto.DataPropertyName = "pDesconto";
            this.pDesconto.HeaderText = "Porcentagem de Desconto";
            this.pDesconto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pDesconto.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pDesconto.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pDesconto.Name = "pDesconto";
            this.pDesconto.ReadOnly = true;
            this.pDesconto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pDesconto.Width = 220;
            // 
            // pComissao
            // 
            this.pComissao.DataPropertyName = "pComissao";
            this.pComissao.HeaderText = "Custo de Comissão";
            this.pComissao.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissao.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissao.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissao.Name = "pComissao";
            this.pComissao.ReadOnly = true;
            this.pComissao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissao.Width = 150;
            // 
            // pOutros
            // 
            this.pOutros.DataPropertyName = "pOutros";
            this.pOutros.HeaderText = "Outros";
            this.pOutros.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pOutros.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pOutros.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pOutros.Name = "pOutros";
            this.pOutros.ReadOnly = true;
            this.pOutros.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOutros.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOutros.Width = 100;
            // 
            // pLucro
            // 
            this.pLucro.DataPropertyName = "pLucro";
            this.pLucro.HeaderText = "Margem de Lucro";
            this.pLucro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pLucro.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pLucro.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pLucro.Name = "pLucro";
            this.pLucro.ReadOnly = true;
            this.pLucro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pLucro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pLucro.Width = 150;
            // 
            // vVenda
            // 
            this.vVenda.DataPropertyName = "vVenda";
            this.vVenda.HeaderText = "Preço de Venda";
            this.vVenda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.vVenda.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.vVenda.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.vVenda.Name = "vVenda";
            this.vVenda.ReadOnly = true;
            this.vVenda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vVenda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vVenda.Width = 150;
            // 
            // pDescontoMaximo
            // 
            this.pDescontoMaximo.DataPropertyName = "pDescontoMaximo";
            this.pDescontoMaximo.HeaderText = "Desconto Máximo";
            this.pDescontoMaximo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pDescontoMaximo.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pDescontoMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pDescontoMaximo.Name = "pDescontoMaximo";
            this.pDescontoMaximo.ReadOnly = true;
            this.pDescontoMaximo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pDescontoMaximo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pDescontoMaximo.Width = 150;
            // 
            // pAcrescimoMaximo
            // 
            this.pAcrescimoMaximo.DataPropertyName = "pAcrescimoMaximo";
            this.pAcrescimoMaximo.HeaderText = "Acréscimo Máximo";
            this.pAcrescimoMaximo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pAcrescimoMaximo.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pAcrescimoMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pAcrescimoMaximo.Name = "pAcrescimoMaximo";
            this.pAcrescimoMaximo.ReadOnly = true;
            this.pAcrescimoMaximo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAcrescimoMaximo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAcrescimoMaximo.Width = 150;
            // 
            // pComissaoAvista
            // 
            this.pComissaoAvista.DataPropertyName = "pComissaoAvista";
            this.pComissaoAvista.HeaderText = "Comissão a Vista";
            this.pComissaoAvista.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissaoAvista.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissaoAvista.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissaoAvista.Name = "pComissaoAvista";
            this.pComissaoAvista.ReadOnly = true;
            this.pComissaoAvista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAvista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAvista.Width = 150;
            // 
            // pComissaoAprazo
            // 
            this.pComissaoAprazo.DataPropertyName = "pComissaoAprazo";
            this.pComissaoAprazo.HeaderText = "Comissão a Prazo";
            this.pComissaoAprazo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissaoAprazo.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissaoAprazo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissaoAprazo.Name = "pComissaoAprazo";
            this.pComissaoAprazo.ReadOnly = true;
            this.pComissaoAprazo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAprazo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAprazo.Width = 150;
            // 
            // dAlteracaoCusto
            // 
            this.dAlteracaoCusto.DataPropertyName = "dAlteracaoCusto";
            this.dAlteracaoCusto.HeaderText = "Última Alteração no Custo";
            this.dAlteracaoCusto.Name = "dAlteracaoCusto";
            this.dAlteracaoCusto.ReadOnly = true;
            this.dAlteracaoCusto.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirmar,
            this.toolStripSeparator4,
            this.btnTodos});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 27);
            this.menuStrip1.TabIndex = 103;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmar.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(63, 20);
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnTodos
            // 
            this.btnTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTodos.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(87, 20);
            this.btnTodos.Text = "Mostrar Todos";
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // FormListaPrecoFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 376);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormListaPrecoFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar";
            this.Load += new System.EventHandler(this.FormListaPrecoFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.BindingSource bsListaPreco;
        private HLP_DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn vCustoProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pDesconto;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissao;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pOutros;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pLucro;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn vVenda;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pDescontoMaximo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pAcrescimoMaximo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissaoAvista;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissaoAprazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAlteracaoCusto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton btnConfirmar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnTodos;

    }
}