using System.Windows.Forms;
namespace HLP.UI.Entries.Geral
{
    partial class FormDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeposito));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_PesquisaidSite = new HLP.Comum.Components.HLP_Pesquisa();
            this.txtxDeposito = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostTipo = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostGrupoIdentificacao = new HLP.Comum.Components.HLP_ComboBox();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.tabHierarquia = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.treeSite = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.async_work = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.tabHierarquia.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(623, 284);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(621, 260);
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1_Geral);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.hlP_PesquisaidSite);
            this.Principal.Controls.Add(this.txtxDeposito);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.cbostTipo);
            this.Principal.Controls.Add(this.cbostGrupoIdentificacao);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1_Geral
            // 
            this.hlP_LabelSeparator1_Geral._LabelText = "Geral";
            this.hlP_LabelSeparator1_Geral._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1_Geral.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1_Geral.Location = new System.Drawing.Point(0, 3);
            this.hlP_LabelSeparator1_Geral.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.hlP_LabelSeparator1_Geral.Name = "hlP_LabelSeparator1_Geral";
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(543, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idDeposito";
            this.txtCodigo._Help = "Chave principal do registro do depósito";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Deposito";
            this.txtCodigo._TamanhoComponente = 132;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(108, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // hlP_PesquisaidSite
            // 
            this.hlP_PesquisaidSite._Field = "idSite";
            this.hlP_PesquisaidSite._Help = "Informar qual site o depósito se origina";
            this.hlP_PesquisaidSite._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisaidSite._LabelText = "Site";
            this.hlP_PesquisaidSite._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidSite._ListaCamposDisplay")));
            this.hlP_PesquisaidSite._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidSite._ListaValoresDisplay")));
            this.hlP_PesquisaidSite._NomeCampoPK = "ID";
            this.hlP_PesquisaidSite._NomeFormCadastroOriginal = "FormSite";
            this.hlP_PesquisaidSite._NomeView = "vwSite";
            this.hlP_PesquisaidSite._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidSite._Regex = null;
            this.hlP_PesquisaidSite._Table = "Deposito";
            this.hlP_PesquisaidSite._TamanhoComponente = 300;
            this.hlP_PesquisaidSite._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidSite._Vinculado = false;
            this.hlP_PesquisaidSite._Visible = false;
            this.hlP_PesquisaidSite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidSite.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidSite.Base = null;
            this.hlP_PesquisaidSite.Location = new System.Drawing.Point(127, 54);
            this.hlP_PesquisaidSite.Margin = new System.Windows.Forms.Padding(127, 3, 15, 3);
            this.hlP_PesquisaidSite.Name = "hlP_PesquisaidSite";
            this.hlP_PesquisaidSite.ReadOnly = false;
            this.hlP_PesquisaidSite.Size = new System.Drawing.Size(416, 21);
            this.hlP_PesquisaidSite.TabIndex = 4;
            this.hlP_PesquisaidSite.Value = 0;
            // 
            // txtxDeposito
            // 
            this.txtxDeposito._Field = "xDeposito";
            this.txtxDeposito._Help = "Insira uma identidade para o depósito ";
            this.txtxDeposito._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDeposito._LabelText = "Depósito";
            this.txtxDeposito._Multiline = false;
            this.txtxDeposito._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDeposito._Password = false;
            this.txtxDeposito._Regex = null;
            this.txtxDeposito._Table = "Deposito";
            this.txtxDeposito._TamanhoComponente = 253;
            this.txtxDeposito._TamanhoMaiorLabel = 150;
            this.txtxDeposito._Visible = false;
            this.txtxDeposito.BackColor = System.Drawing.Color.Transparent;
            this.txtxDeposito.Base = null;
            this.txtxDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDeposito.Color = System.Drawing.Color.White;
            this.txtxDeposito.Location = new System.Drawing.Point(99, 81);
            this.txtxDeposito.Margin = new System.Windows.Forms.Padding(99, 3, 15, 3);
            this.txtxDeposito.MaxLength = 32767;
            this.txtxDeposito.Name = "txtxDeposito";
            this.txtxDeposito.ReadOnly = false;
            this.txtxDeposito.Size = new System.Drawing.Size(307, 21);
            this.txtxDeposito.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Identificando nome ou descrição do depósito";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Nome";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Deposito";
            this.txtxDescricao._TamanhoComponente = 324;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = false;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(116, 108);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(361, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // cbostTipo
            // 
            this.cbostTipo._Field = "stTipo";
            this.cbostTipo._Help = "Selecione o tipo de depósito";
            this.cbostTipo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostTipo._Itens")));
            this.cbostTipo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostTipo._LabelText = "Tipo de depósito";
            this.cbostTipo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostTipo._Regex = null;
            this.cbostTipo._situacao = false;
            this.cbostTipo._Table = "Deposito";
            this.cbostTipo._TamanhoComponente = 128;
            this.cbostTipo._TamanhoMaiorLabel = 150;
            this.cbostTipo._Visible = false;
            this.cbostTipo.BackColor = System.Drawing.Color.Transparent;
            this.cbostTipo.Base = null;
            this.cbostTipo.Color = System.Drawing.Color.White;
            this.cbostTipo.DataSource = null;
            this.cbostTipo.DisplayMember = "DisplayMember";
            this.cbostTipo.Location = new System.Drawing.Point(59, 135);
            this.cbostTipo.Margin = new System.Windows.Forms.Padding(59, 3, 15, 3);
            this.cbostTipo.Name = "cbostTipo";
            this.cbostTipo.SelectedIndex = -1;
            this.cbostTipo.SelectedValue = 0;
            this.cbostTipo.Size = new System.Drawing.Size(222, 21);
            this.cbostTipo.TabIndex = 5;
            this.cbostTipo.ValueMember = "ValueMember";
            // 
            // cbostGrupoIdentificacao
            // 
            this.cbostGrupoIdentificacao._Field = "stGrupoIdentificacao";
            this.cbostGrupoIdentificacao._Help = "Selecione o grupo de identificação do depósito";
            this.cbostGrupoIdentificacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostGrupoIdentificacao._Itens")));
            this.cbostGrupoIdentificacao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostGrupoIdentificacao._LabelText = "Grupo de identificação";
            this.cbostGrupoIdentificacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostGrupoIdentificacao._Regex = null;
            this.cbostGrupoIdentificacao._situacao = false;
            this.cbostGrupoIdentificacao._Table = "Deposito";
            this.cbostGrupoIdentificacao._TamanhoComponente = 370;
            this.cbostGrupoIdentificacao._TamanhoMaiorLabel = 150;
            this.cbostGrupoIdentificacao._Visible = false;
            this.cbostGrupoIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostGrupoIdentificacao.Base = null;
            this.cbostGrupoIdentificacao.Color = System.Drawing.Color.White;
            this.cbostGrupoIdentificacao.DataSource = null;
            this.cbostGrupoIdentificacao.DisplayMember = "DisplayMember";
            this.cbostGrupoIdentificacao.Location = new System.Drawing.Point(28, 162);
            this.cbostGrupoIdentificacao.Margin = new System.Windows.Forms.Padding(28, 3, 15, 3);
            this.cbostGrupoIdentificacao.Name = "cbostGrupoIdentificacao";
            this.cbostGrupoIdentificacao.SelectedIndex = -1;
            this.cbostGrupoIdentificacao.SelectedValue = 0;
            this.cbostGrupoIdentificacao.Size = new System.Drawing.Size(495, 21);
            this.cbostGrupoIdentificacao.TabIndex = 6;
            this.cbostGrupoIdentificacao.ValueMember = "ValueMember";
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(615, 254);
            this.kryptonTabControl1.TabIndex = 2;
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
            this.tabPage1.Size = new System.Drawing.Size(607, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.Principal);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(607, 225);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tabHierarquia
            // 
            this.tabHierarquia.BackColor = System.Drawing.SystemColors.Window;
            this.tabHierarquia.Controls.Add(this.kryptonPanel3);
            this.tabHierarquia.Location = new System.Drawing.Point(4, 25);
            this.tabHierarquia.Margin = new System.Windows.Forms.Padding(0);
            this.tabHierarquia.Name = "tabHierarquia";
            this.tabHierarquia.Size = new System.Drawing.Size(804, 225);
            this.tabHierarquia.TabIndex = 2;
            this.tabHierarquia.Tag = false;
            this.tabHierarquia.Text = "Hierarquia";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.treeSite);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(804, 225);
            this.kryptonPanel3.TabIndex = 2;
            // 
            // treeSite
            // 
            this.treeSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSite.ImageIndex = 0;
            this.treeSite.ImageList = this.imageList1;
            this.treeSite.ItemHeight = 21;
            this.treeSite.Location = new System.Drawing.Point(0, 0);
            this.treeSite.Name = "treeSite";
            this.treeSite.SelectedImageIndex = 0;
            this.treeSite.Size = new System.Drawing.Size(804, 225);
            this.treeSite.TabIndex = 0;
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
            // FormDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeposito";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Depósitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeposito_FormClosing);
            this.Load += new System.EventHandler(this.FormDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.tabHierarquia.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxDeposito;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidSite;
        private Comum.Components.HLP_ComboBox cbostTipo;
        private Comum.Components.HLP_ComboBox cbostGrupoIdentificacao;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.TabPage tabHierarquia;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private TreeView treeSite;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker async_work;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}