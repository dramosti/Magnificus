using System.Windows.Forms;
namespace HLP.UI.Entries.Comercial
{
    partial class FormSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSite));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtnSite = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.dgvEnderecos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.stTipoEndereco = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCEP = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.stLogradouro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCaixaPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFusoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.tabHierarquia = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.treeHierarquia = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.async_work = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).BeginInit();
            this.tabHierarquia.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(816, 318);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(814, 294);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
            this.kryptonTabControl1.Controls.Add(this.tabHierarquia);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(808, 288);
            this.kryptonTabControl1.TabIndex = 0;
            this.kryptonTabControl1.UseExtendedLayout = false;
            this.kryptonTabControl1.SelectedIndexChanged += new System.EventHandler(this.kryptonTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(800, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 259);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtnSite);
            this.flowLayoutPanel1.Controls.Add(this.txtxDescricao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 259);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idSite";
            this.txtCodigo._Help = "Chave principal do registro do site";
            this.txtCodigo._LabelGroup = null;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Site";
            this.txtCodigo._TamanhoMaiorLabel = 0;
            this.txtCodigo._TamanhoTextBox = 132;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtnSite
            // 
            this.txtnSite._Field = "nSite";
            this.txtnSite._Help = "Informe de forma resumida o nome do site";
            this.txtnSite._LabelGroup = null;
            this.txtnSite._LabelText = "Site";
            this.txtnSite._Multiline = false;
            this.txtnSite._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtnSite._Password = false;
            this.txtnSite._Regex = null;
            this.txtnSite._Table = "Site";
            this.txtnSite._TamanhoMaiorLabel = 0;
            this.txtnSite._TamanhoTextBox = 159;
            this.txtnSite._Visible = true;
            this.txtnSite.BackColor = System.Drawing.Color.Transparent;
            this.txtnSite.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnSite.Color = System.Drawing.Color.White;
            this.txtnSite.Location = new System.Drawing.Point(3, 33);
            this.txtnSite.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.txtnSite.MaxLength = 32767;
            this.txtnSite.Name = "txtnSite";
            this.txtnSite.ReadOnly = false;
            this.txtnSite.Size = new System.Drawing.Size(185, 24);
            this.txtnSite.TabIndex = 4;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Descrição detalhada do site";
            this.txtxDescricao._LabelGroup = null;
            this.txtxDescricao._LabelText = "Descrição do site";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.HLP_TextBox.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Site";
            this.txtxDescricao._TamanhoMaiorLabel = 0;
            this.txtxDescricao._TamanhoTextBox = 199;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(3, 63);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtxDescricao.MaxLength = 32767;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(293, 22);
            this.txtxDescricao.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(800, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Endereços";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.BorderWidth = 0;
            this.kryptonPanel2.Controls.Add(this.dgvEnderecos);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel2.GradientToogleColors = false;
            this.kryptonPanel2.GradientUseBlend = false;
            this.kryptonPanel2.GradientUseSolid = true;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PersistentColors = false;
            this.kryptonPanel2.Size = new System.Drawing.Size(800, 259);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.AutoGenerateColumns = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stTipoEndereco,
            this.xCEP,
            this.stLogradouro,
            this.xEndereco,
            this.nNumero,
            this.xComplemento,
            this.xBairro,
            this.xCaixaPostal,
            this.idCidade,
            this.xLatitude,
            this.xLongitude,
            this.xFusoHorario});
            this.dgvEnderecos.DataSource = this.bsEndereco;
            this.dgvEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecos.Location = new System.Drawing.Point(0, 0);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.Size = new System.Drawing.Size(800, 259);
            this.dgvEnderecos.TabIndex = 0;
            this.dgvEnderecos.Tag = "Site_Endereco";
            // 
            // stTipoEndereco
            // 
            this.stTipoEndereco.DataPropertyName = "stTipoEndereco";
            this.stTipoEndereco.HeaderText = "Tipo de endereço";
            this.stTipoEndereco.Items.AddRange(new object[] {
            "0 - COMERCIAL ",
            "1 - ENDEREÇO DE REMESSA DE TERCEIROS ",
            "2 - ENTREGA ",
            "3 - ENTREGA ALT.",
            "4 - NOTA FISCAL ",
            "5 - OUTRO ",
            "6 - REMETER-PARA ",
            "7 - RESIDÊNCIA ",
            "8 - SWIFT  "});
            this.stTipoEndereco.Name = "stTipoEndereco";
            this.stTipoEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEndereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stTipoEndereco.ToolTipText = "Especifique como usar o endereço selecionado";
            this.stTipoEndereco.Width = 150;
            // 
            // xCEP
            // 
            this.xCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.xCEP.DataPropertyName = "xCEP";
            this.xCEP.HeaderText = "CEP";
            this.xCEP.Mask = "00000-000";
            this.xCEP.Name = "xCEP";
            this.xCEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xCEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xCEP.ToolTipText = "Informar o Código de Endereçamento Postal do Site";
            this.xCEP.Width = 100;
            // 
            // stLogradouro
            // 
            this.stLogradouro.DataPropertyName = "stLogradouro";
            this.stLogradouro.HeaderText = "Tipo de logradouro";
            this.stLogradouro.Items.AddRange(new object[] {
            "0 - AER - AEROPORTO",
            "1 - AL - ALAMEDA ",
            "2 - AP - APARTAMENTO ",
            "3 - AV - AVENIDA ",
            "4 - BC - BECO ",
            "5 - BL - BLOCO ",
            "6 - CAM - CAMINHO ",
            "7 - ESCD - ESCADINHA ",
            "8 - EST  - ESTAÇÃO ",
            "9 - ETR - ESTRADA ",
            "10 - FAZ - FAZENDA ",
            "11 - FORT  - FORTALEZA ",
            "12 - GL - GALERIA ",
            "13 - LD - LADEIRA ",
            "14 - LGO  - LARGO ",
            "15 - PÇA - PRAÇA ",
            "16 - PR  - PRAIA ",
            "17 - PRQ - PARQUE ",
            "18 - QD  - QUADRA ",
            "19 - KM - QUILÔMETRO ",
            "20 - QTA  - QUINTA ",
            "21 - ROD  - RODOVIA ",
            "22 - R - RUA ",
            "23 - SQD - SUPER QUADRA ",
            "24 - TRV - TRAVESSA ",
            "25 - VD - VIADUTO ",
            "26 - VL - VILA "});
            this.stLogradouro.Name = "stLogradouro";
            this.stLogradouro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stLogradouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stLogradouro.ToolTipText = "Informar o Tipo de Logradouro para o endereço correspondente";
            this.stLogradouro.Width = 150;
            // 
            // xEndereco
            // 
            this.xEndereco.DataPropertyName = "xEndereco";
            this.xEndereco.HeaderText = "Endereço";
            this.xEndereco.Name = "xEndereco";
            this.xEndereco.ToolTipText = "Informar o nome da Rua do Site";
            this.xEndereco.Width = 200;
            // 
            // nNumero
            // 
            this.nNumero.DataPropertyName = "nNumero";
            this.nNumero.HeaderText = "Número";
            this.nNumero.Name = "nNumero";
            // 
            // xComplemento
            // 
            this.xComplemento.DataPropertyName = "xComplemento";
            this.xComplemento.HeaderText = "Complemento";
            this.xComplemento.Name = "xComplemento";
            // 
            // xBairro
            // 
            this.xBairro.DataPropertyName = "xBairro";
            this.xBairro.HeaderText = "Bairro";
            this.xBairro.Name = "xBairro";
            // 
            // xCaixaPostal
            // 
            this.xCaixaPostal.DataPropertyName = "xCaixaPostal";
            this.xCaixaPostal.HeaderText = "Caixa postal";
            this.xCaixaPostal.Name = "xCaixaPostal";
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "Cidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCidade.Width = 150;
            // 
            // xLatitude
            // 
            this.xLatitude.DataPropertyName = "xLatitude";
            this.xLatitude.HeaderText = "Latitude";
            this.xLatitude.Name = "xLatitude";
            // 
            // xLongitude
            // 
            this.xLongitude.DataPropertyName = "xLongitude";
            this.xLongitude.HeaderText = "Longitude";
            this.xLongitude.Name = "xLongitude";
            // 
            // xFusoHorario
            // 
            this.xFusoHorario.DataPropertyName = "xFusoHorario";
            this.xFusoHorario.HeaderText = "Fuso horário";
            this.xFusoHorario.Name = "xFusoHorario";
            // 
            // bsEndereco
            // 
            this.bsEndereco.DataSource = typeof(HLP.Models.Entries.Comercial.Site_enderecoModel);
            // 
            // tabHierarquia
            // 
            this.tabHierarquia.BackColor = System.Drawing.SystemColors.Window;
            this.tabHierarquia.Controls.Add(this.kryptonPanel3);
            this.tabHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tabHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabHierarquia.Name = "tabHierarquia";
            this.tabHierarquia.Size = new System.Drawing.Size(800, 259);
            this.tabHierarquia.TabIndex = 2;
            this.tabHierarquia.Tag = false;
            this.tabHierarquia.Text = "Hierarquia";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.treeHierarquia);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(800, 259);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // treeHierarquia
            // 
            this.treeHierarquia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHierarquia.ImageIndex = 0;
            this.treeHierarquia.ImageList = this.imageList1;
            this.treeHierarquia.ItemHeight = 21;
            this.treeHierarquia.Location = new System.Drawing.Point(0, 0);
            this.treeHierarquia.Name = "treeHierarquia";
            this.treeHierarquia.SelectedImageIndex = 0;
            this.treeHierarquia.Size = new System.Drawing.Size(800, 259);
            this.treeHierarquia.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1345830422_factory.ico");
            this.imageList1.Images.SetKeyName(1, "1345830899_nuclear.ico");
            this.imageList1.Images.SetKeyName(2, "1345831034_lorry.ico");
            this.imageList1.Images.SetKeyName(3, "1346243459_sitemap_color.ico");
            // 
            // async_work
            // 
            this.async_work.WorkerSupportsCancellation = true;
            this.async_work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.async_work_DoWork);
            // 
            // FormSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 345);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSite";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Sites";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSite_FormClosing);
            this.Load += new System.EventHandler(this.FormSite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).EndInit();
            this.tabHierarquia.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.TabPage tabHierarquia;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtnSite;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEnderecos;
        private System.Windows.Forms.BindingSource bsEndereco;
        private TreeView treeHierarquia;
        private System.Windows.Forms.DataGridViewComboBoxColumn stTipoEndereco;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn xCEP;
        private System.Windows.Forms.DataGridViewComboBoxColumn stLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCaixaPostal;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFusoHorario;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker async_work;
    }
}