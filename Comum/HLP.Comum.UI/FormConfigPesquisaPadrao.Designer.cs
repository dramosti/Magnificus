using HLP.Comum.Components;
namespace HLP.Comum.UI
{
    partial class FormConfigPesquisaPadrao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigPesquisaPadrao));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvCampos = new HLP.Comum.Components.HLP_DataGridView();
            this.Campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utiliza = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cboGrid = new HLP.Comum.Components.HLP_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.dgvCampos);
            this.kryptonPanel.Controls.Add(this.btnSalvar);
            this.kryptonPanel.Controls.Add(this.cboGrid);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(454, 385);
            this.kryptonPanel.TabIndex = 0;
            // 
            // dgvCampos
            // 
            this.dgvCampos.AllowDrop = true;
            this.dgvCampos.AllowUserToAddRows = false;
            this.dgvCampos.AllowUserToDeleteRows = false;
            this.dgvCampos.Altera = false;
            this.dgvCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCampos.cm = null;
            this.dgvCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campo,
            this.Field,
            this.Utiliza});
            this.dgvCampos.DragDropLinha = false;
            this.dgvCampos.Exclui = false;
            this.dgvCampos.Inclui = false;
            this.dgvCampos.Location = new System.Drawing.Point(12, 39);
            this.dgvCampos.MultiSelect = false;
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.RowHeadersWidth = 15;
            this.dgvCampos.Size = new System.Drawing.Size(430, 303);
            this.dgvCampos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvCampos.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.TabIndex = 3;
            this.dgvCampos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampos_CellContentClick);
            this.dgvCampos.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvCampos_DragDrop);
            this.dgvCampos.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvCampos_DragOver);
            this.dgvCampos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCampos_MouseDown);
            this.dgvCampos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCampos_MouseMove);
            // 
            // Campo
            // 
            this.Campo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Campo.HeaderText = "Campo";
            this.Campo.Name = "Campo";
            this.Campo.ReadOnly = true;
            // 
            // Field
            // 
            this.Field.HeaderText = "Field";
            this.Field.Name = "Field";
            this.Field.ReadOnly = true;
            this.Field.Visible = false;
            // 
            // Utiliza
            // 
            this.Utiliza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.Utiliza.DefaultCellStyle = dataGridViewCellStyle1;
            this.Utiliza.FalseValue = null;
            this.Utiliza.HeaderText = "Utilizar";
            this.Utiliza.IndeterminateValue = null;
            this.Utiliza.Name = "Utiliza";
            this.Utiliza.TrueValue = null;
            this.Utiliza.Width = 53;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(352, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 25);
            this.btnSalvar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Values.Text = "&Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboGrid
            // 
            this.cboGrid._Help = "Selecione o que deseja configurar na grid";
            this.cboGrid._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboGrid._Itens")));
            this.cboGrid._LabelGroup = null;
            this.cboGrid._LabelText = "Configurar";
            this.cboGrid._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboGrid._Regex = null;
            this.cboGrid._situacao = false;
            this.cboGrid._TamanhoComponente = 155;
            this.cboGrid._TamanhoMaiorLabel = 0;
            this.cboGrid.BackColor = System.Drawing.Color.Transparent;
            this.cboGrid.Base = null;
            this.cboGrid.Color = System.Drawing.Color.White;
            this.cboGrid.DataSource = null;
            this.cboGrid.DisplayMember = "DisplayMember";
            this.cboGrid.Location = new System.Drawing.Point(12, 12);
            this.cboGrid.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.cboGrid.Name = "cboGrid";
            this.cboGrid.SelectedIndex = -1;
            this.cboGrid.SelectedValue = 0;
            this.cboGrid.Size = new System.Drawing.Size(218, 21);
            this.cboGrid.TabIndex = 1;
            this.cboGrid.ValueMember = "ValueMember";
            this.cboGrid._SelectedIndexChanged += new System.EventHandler(this.cboGrid__SelectedIndexChanged);
            // 
            // FormConfigPesquisaPadrao
            // 
            this.AllowFormChrome = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 385);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigPesquisaPadrao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConfigPesquisaPadrao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private Components.HLP_ComboBox cboGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        private HLP_DataGridView dgvCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Utiliza;
    }
}

