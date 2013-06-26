namespace HLP.UI.Entries.Comercial
{
    partial class FormListaPrecoAtribuicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPrecoAtribuicao));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboTipo = new HLP.Comum.Components.HLP_ComboBox();
            this.nudPorcentagem = new HLP.Comum.Components.HLP_NumericUpDown();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnFiltro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAplicar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(395, 97);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cboTipo);
            this.flowLayoutPanel1.Controls.Add(this.nudPorcentagem);
            this.flowLayoutPanel1.Controls.Add(this.kryptonPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 97);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cboTipo
            // 
            this.cboTipo._Field = null;
            this.cboTipo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboTipo._Itens")));
            this.cboTipo._LabelGroup = null;
            this.cboTipo._LabelText = "Trocar conteúdo do campo";
            this.cboTipo._Obrigatorio = HLP.Comum.Components.HLP_ComboBox.CampoObrigatorio.NÃO;
            this.cboTipo._situacao = false;
            this.cboTipo._Table = null;
            this.cboTipo._TamanhoComponente = 215;
            this.cboTipo._TamanhoMaiorLabel = 146;
            this.cboTipo._Visible = true;
            this.cboTipo.BackColor = System.Drawing.Color.Transparent;
            this.cboTipo.Color = System.Drawing.Color.White;
            this.cboTipo.DataSource = null;
            this.cboTipo.DisplayMember = "DisplayMember";
            this.cboTipo.Location = new System.Drawing.Point(3, 3);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.SelectedIndex = -1;
            this.cboTipo.SelectedValue = 0;
            this.cboTipo.Size = new System.Drawing.Size(361, 21);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.ValueMember = "ValueMember";
            // 
            // nudPorcentagem
            // 
            this.nudPorcentagem._Field = null;
            this.nudPorcentagem._LabelGroup = null;
            this.nudPorcentagem._LabelText = "Por";
            this.nudPorcentagem._Obrigatorio = HLP.Comum.Components.HLP_NumericUpDown.CampoObrigatorio.NÃO;
            this.nudPorcentagem._Table = null;
            this.nudPorcentagem._TamanhoMaiorLabel = 146;
            this.nudPorcentagem._TamanhoComponente = 122;
            this.nudPorcentagem._Visible = true;
            this.nudPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.nudPorcentagem.Color = System.Drawing.Color.White;
            this.nudPorcentagem.DecimalPlaces = 2;
            this.nudPorcentagem.Location = new System.Drawing.Point(122, 30);
            this.nudPorcentagem.Margin = new System.Windows.Forms.Padding(122, 3, 15, 3);
            this.nudPorcentagem.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudPorcentagem.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudPorcentagem.Name = "nudPorcentagem";
            this.nudPorcentagem.ReadOnly = false;
            this.nudPorcentagem.Size = new System.Drawing.Size(149, 22);
            this.nudPorcentagem.TabIndex = 1;
            this.nudPorcentagem.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudPorcentagem.ValueInt = 0;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btnFiltro);
            this.kryptonPanel2.Controls.Add(this.btnAplicar);
            this.kryptonPanel2.Controls.Add(this.btnCancelar);
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 58);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(373, 37);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(76, 3);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(90, 25);
            this.btnFiltro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnFiltro.TabIndex = 25;
            this.btnFiltro.Values.Text = "Filtrar";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(172, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(90, 25);
            this.btnAplicar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAplicar.TabIndex = 21;
            this.btnAplicar.Values.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(220, 3, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormListaPrecoAtribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 97);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaPrecoAtribuicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atribuição Coletiva";
            this.Load += new System.EventHandler(this.FormListaPrecoAtribuicao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListaPrecoAtribuicao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_ComboBox cboTipo;
        private Comum.Components.HLP_NumericUpDown nudPorcentagem;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAplicar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltro;
    }
}