namespace HLP.UI.Sales.Comercial
{
    partial class formItensPorcAcimaLista
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
            this.pnPrincipal = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvItens = new HLP.Comum.Components.HLP_DataGridView();
            this.itemPorcAcimaListaModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ItemPorcAcimaListaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnBotoes = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.orcamentoItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemPorcAcimaListaModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porListaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPermitir = new HLP.Comum.Components.HLP_Button();
            this.btnCancelar = new HLP.Comum.Components.HLP_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPorcAcimaListaModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPorcAcimaListaModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).BeginInit();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPorcAcimaListaModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.dgvItens);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(963, 311);
            this.pnPrincipal.TabIndex = 0;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeColumns = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.Altera = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.cm = null;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numProdutoDataGridViewTextBoxColumn,
            this.idProdutoDataGridViewTextBoxColumn,
            this.xNomeProduto,
            this.porAtualDataGridViewTextBoxColumn,
            this.porListaDataGridViewTextBoxColumn});
            this.dgvItens.DataSource = this.itemPorcAcimaListaModelBindingSource2;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.DragDropLinha = false;
            this.dgvItens.Exclui = false;
            this.dgvItens.Inclui = false;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(963, 311);
            this.dgvItens.TabIndex = 0;
            // 
            // itemPorcAcimaListaModelBindingSource2
            // 
            this.itemPorcAcimaListaModelBindingSource2.DataSource = typeof(HLP.Models.Entries.Gerais.ItemPorcAcimaListaModel);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btnCancelar);
            this.pnBotoes.Controls.Add(this.btnPermitir);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotoes.Location = new System.Drawing.Point(0, 260);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(963, 51);
            this.pnBotoes.TabIndex = 1;
            // 
            // orcamentoItemModelBindingSource
            // 
            this.orcamentoItemModelBindingSource.DataSource = typeof(HLP.Models.Sales.Comercial.Orcamento_ItemModel);
            // 
            // numProdutoDataGridViewTextBoxColumn
            // 
            this.numProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numProdutoDataGridViewTextBoxColumn.DataPropertyName = "numProduto";
            this.numProdutoDataGridViewTextBoxColumn.HeaderText = "Nº Produto no Orçamento";
            this.numProdutoDataGridViewTextBoxColumn.Name = "numProdutoDataGridViewTextBoxColumn";
            this.numProdutoDataGridViewTextBoxColumn.Width = 161;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código de Produto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.Width = 126;
            // 
            // xNomeProduto
            // 
            this.xNomeProduto.DataPropertyName = "xNomeProduto";
            this.xNomeProduto.HeaderText = "Produto";
            this.xNomeProduto.Name = "xNomeProduto";
            this.xNomeProduto.Width = 250;
            // 
            // porAtualDataGridViewTextBoxColumn
            // 
            this.porAtualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.porAtualDataGridViewTextBoxColumn.DataPropertyName = "porAtual";
            this.porAtualDataGridViewTextBoxColumn.HeaderText = "Porcentagem Desc/Acresc";
            this.porAtualDataGridViewTextBoxColumn.Name = "porAtualDataGridViewTextBoxColumn";
            this.porAtualDataGridViewTextBoxColumn.Width = 160;
            // 
            // porListaDataGridViewTextBoxColumn
            // 
            this.porListaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.porListaDataGridViewTextBoxColumn.DataPropertyName = "porLista";
            this.porListaDataGridViewTextBoxColumn.HeaderText = "Porcentagem Desc/Acresc Permitido na lista";
            this.porListaDataGridViewTextBoxColumn.Name = "porListaDataGridViewTextBoxColumn";
            // 
            // btnPermitir
            // 
            this.btnPermitir._LabelGroup = null;
            this.btnPermitir._LabelText = "Permitir";
            this.btnPermitir._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnPermitir._Regex = null;
            this.btnPermitir._TamanhoComponente = 168;
            this.btnPermitir._TamanhoMaiorLabel = 0;
            this.btnPermitir.Base = null;
            this.btnPermitir.bConfiguracao = false;
            this.btnPermitir.Location = new System.Drawing.Point(588, 15);
            this.btnPermitir.Name = "btnPermitir";
            this.btnPermitir.objConfigComponenteModel = null;
            this.btnPermitir.Size = new System.Drawing.Size(168, 24);
            this.btnPermitir.TabIndex = 0;
            this.btnPermitir._btnHlpClick += new System.EventHandler(this.btnPermitir__btnHlpClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar._LabelGroup = null;
            this.btnCancelar._LabelText = "Cancelar";
            this.btnCancelar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnCancelar._Regex = null;
            this.btnCancelar._TamanhoComponente = 168;
            this.btnCancelar._TamanhoMaiorLabel = 0;
            this.btnCancelar.Base = null;
            this.btnCancelar.bConfiguracao = false;
            this.btnCancelar.Location = new System.Drawing.Point(783, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.objConfigComponenteModel = null;
            this.btnCancelar.Size = new System.Drawing.Size(168, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar._btnHlpClick += new System.EventHandler(this.btnCancelar__btnHlpClick);
            // 
            // formItensPorcAcimaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 311);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formItensPorcAcimaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens com Porcentagem acima de permitida na lista";
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPorcAcimaListaModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPorcAcimaListaModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orcamentoItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPorcAcimaListaModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnBotoes;
        private Comum.Components.HLP_DataGridView dgvItens;
        private System.Windows.Forms.BindingSource ItemPorcAcimaListaModelBindingSource;
        private System.Windows.Forms.BindingSource orcamentoItemModelBindingSource;
        private System.Windows.Forms.BindingSource ItemPorcAcimaListaModelBindingSource1;
        private System.Windows.Forms.BindingSource itemPorcAcimaListaModelBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn porAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porListaDataGridViewTextBoxColumn;
        private Comum.Components.HLP_Button btnCancelar;
        private Comum.Components.HLP_Button btnPermitir;
    }
}