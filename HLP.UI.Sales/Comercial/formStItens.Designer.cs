namespace HLP.UI.Sales.Comercial
{
    partial class formStItens
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
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new HLP.Comum.Components.HLP_DataGridView();
            this.pnTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bsItens = new System.Windows.Forms.BindingSource(this.components);
            this.codItemOrcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantPendenteDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.dPrevEntregaDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.quantItensDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.dConfirmacaoDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.clMotPerda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new HLP.Comum.Components.HLP_Button();
            this.btnCancelar = new HLP.Comum.Components.HLP_Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).BeginInit();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.kryptonTabControl1);
            this.pnPrincipal.Controls.Add(this.pnTop);
            this.pnPrincipal.Controls.Add(this.pnBottom);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(935, 311);
            this.pnPrincipal.TabIndex = 0;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tpItens);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(0, 42);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(935, 226);
            this.kryptonTabControl1.TabIndex = 5;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.dgvItens);
            this.tpItens.Location = new System.Drawing.Point(4, 25);
            this.tpItens.Margin = new System.Windows.Forms.Padding(0);
            this.tpItens.Name = "tpItens";
            this.tpItens.Size = new System.Drawing.Size(927, 197);
            this.tpItens.TabIndex = 0;
            this.tpItens.Tag = false;
            this.tpItens.Text = "Itens";
            this.tpItens.UseVisualStyleBackColor = true;
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
            this.codItemOrcamento,
            this.clSel,
            this.clProduto,
            this.quantPendenteDataGridViewTextBoxColumn,
            this.dPrevEntregaDataGridViewTextBoxColumn,
            this.quantItensDataGridViewTextBoxColumn,
            this.dConfirmacaoDataGridViewTextBoxColumn,
            this.clMotPerda,
            this.clObs});
            this.dgvItens.DataSource = this.bsItens;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.DragDropLinha = false;
            this.dgvItens.Exclui = false;
            this.dgvItens.Inclui = false;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(927, 197);
            this.dgvItens.TabIndex = 5;
            this.dgvItens.Tag = "Orcamento_Item";
            this.dgvItens.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvItens_CellValidating);
            this.dgvItens.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_ColumnHeaderMouseClick);
            // 
            // pnTop
            // 
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(935, 42);
            this.pnTop.TabIndex = 3;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.btnCancelar);
            this.pnBottom.Controls.Add(this.btnConfirmar);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 268);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(935, 43);
            this.pnBottom.TabIndex = 2;
            // 
            // bsItens
            // 
            this.bsItens.DataSource = typeof(HLP.Models.Sales.Comercial.stItensModel);
            // 
            // codItemOrcamento
            // 
            this.codItemOrcamento.DataPropertyName = "codItemOrcamento";
            this.codItemOrcamento.HeaderText = "codItemOrcamento";
            this.codItemOrcamento.Name = "codItemOrcamento";
            this.codItemOrcamento.Visible = false;
            // 
            // clSel
            // 
            this.clSel.DataPropertyName = "bSel";
            this.clSel.FillWeight = 60F;
            this.clSel.HeaderText = "Sel/Des";
            this.clSel.Name = "clSel";
            this.clSel.Width = 50;
            // 
            // clProduto
            // 
            this.clProduto.DataPropertyName = "codItem";
            this.clProduto.FillWeight = 150F;
            this.clProduto.HeaderText = "Produto";
            this.clProduto.Name = "clProduto";
            this.clProduto.ReadOnly = true;
            this.clProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clProduto.Width = 150;
            // 
            // quantPendenteDataGridViewTextBoxColumn
            // 
            this.quantPendenteDataGridViewTextBoxColumn.DataPropertyName = "quantPendente";
            this.quantPendenteDataGridViewTextBoxColumn.DecimalPlaces = 4;
            this.quantPendenteDataGridViewTextBoxColumn.HeaderText = "Qtd Orç.";
            this.quantPendenteDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantPendenteDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quantPendenteDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantPendenteDataGridViewTextBoxColumn.Name = "quantPendenteDataGridViewTextBoxColumn";
            this.quantPendenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantPendenteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantPendenteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.quantPendenteDataGridViewTextBoxColumn.Width = 60;
            // 
            // dPrevEntregaDataGridViewTextBoxColumn
            // 
            this.dPrevEntregaDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2013, 9, 26, 0, 0, 0, 0);
            this.dPrevEntregaDataGridViewTextBoxColumn.Checked = false;
            this.dPrevEntregaDataGridViewTextBoxColumn.DataPropertyName = "dPrevEntrega";
            this.dPrevEntregaDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dPrevEntregaDataGridViewTextBoxColumn.HeaderText = "Previsão Entrega";
            this.dPrevEntregaDataGridViewTextBoxColumn.Name = "dPrevEntregaDataGridViewTextBoxColumn";
            this.dPrevEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPrevEntregaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dPrevEntregaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dPrevEntregaDataGridViewTextBoxColumn.Width = 100;
            // 
            // quantItensDataGridViewTextBoxColumn
            // 
            this.quantItensDataGridViewTextBoxColumn.DataPropertyName = "quantItens";
            this.quantItensDataGridViewTextBoxColumn.DecimalPlaces = 4;
            this.quantItensDataGridViewTextBoxColumn.HeaderText = "Qtd.";
            this.quantItensDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantItensDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quantItensDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.quantItensDataGridViewTextBoxColumn.Name = "quantItensDataGridViewTextBoxColumn";
            this.quantItensDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantItensDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.quantItensDataGridViewTextBoxColumn.Visible = false;
            this.quantItensDataGridViewTextBoxColumn.Width = 60;
            // 
            // dConfirmacaoDataGridViewTextBoxColumn
            // 
            this.dConfirmacaoDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2013, 9, 26, 0, 0, 0, 0);
            this.dConfirmacaoDataGridViewTextBoxColumn.Checked = false;
            this.dConfirmacaoDataGridViewTextBoxColumn.DataPropertyName = "dConfirmacao";
            this.dConfirmacaoDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dConfirmacaoDataGridViewTextBoxColumn.HeaderText = "Data Confirmação";
            this.dConfirmacaoDataGridViewTextBoxColumn.Name = "dConfirmacaoDataGridViewTextBoxColumn";
            this.dConfirmacaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dConfirmacaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dConfirmacaoDataGridViewTextBoxColumn.Visible = false;
            this.dConfirmacaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // clMotPerda
            // 
            this.clMotPerda.DataPropertyName = "codMotPerda";
            this.clMotPerda.HeaderText = "Motivo Perda/Canc";
            this.clMotPerda.Name = "clMotPerda";
            this.clMotPerda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMotPerda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clMotPerda.Visible = false;
            this.clMotPerda.Width = 150;
            // 
            // clObs
            // 
            this.clObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clObs.DataPropertyName = "obsItem";
            this.clObs.HeaderText = "Obs Item";
            this.clObs.Name = "clObs";
            this.clObs.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar._LabelGroup = null;
            this.btnConfirmar._LabelSuperior = false;
            this.btnConfirmar._LabelText = "Enviar";
            this.btnConfirmar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnConfirmar._Regex = null;
            this.btnConfirmar._TamanhoComponente = 168;
            this.btnConfirmar._TamanhoMaiorLabel = 0;
            this.btnConfirmar.Base = null;
            this.btnConfirmar.bConfiguracao = false;
            this.btnConfirmar.Location = new System.Drawing.Point(575, 7);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.objConfigComponenteModel = null;
            this.btnConfirmar.Size = new System.Drawing.Size(168, 24);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar._LabelGroup = null;
            this.btnCancelar._LabelSuperior = false;
            this.btnCancelar._LabelText = "Cancelar";
            this.btnCancelar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnCancelar._Regex = null;
            this.btnCancelar._TamanhoComponente = 168;
            this.btnCancelar._TamanhoMaiorLabel = 0;
            this.btnCancelar.Base = null;
            this.btnCancelar.bConfiguracao = false;
            this.btnCancelar.Location = new System.Drawing.Point(759, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.objConfigComponenteModel = null;
            this.btnCancelar.Size = new System.Drawing.Size(168, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // formStItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 311);
            this.Controls.Add(this.pnPrincipal);
            this.MaximizeBox = false;
            this.Name = "formStItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formStItens";
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnBottom)).EndInit();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsItens;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tpItens;
        private Comum.Components.HLP_DataGridView dgvItens;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnTop;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn codItemOrcamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSel;
        private System.Windows.Forms.DataGridViewComboBoxColumn clProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn quantPendenteDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dPrevEntregaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn quantItensDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dConfirmacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clMotPerda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clObs;
        private Comum.Components.HLP_Button btnConfirmar;
        private Comum.Components.HLP_Button btnCancelar;
    }
}