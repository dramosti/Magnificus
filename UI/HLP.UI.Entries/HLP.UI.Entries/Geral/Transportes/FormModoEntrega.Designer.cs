namespace HLP.UI.Entries.Geral.Transportes
{
    partial class FormModoEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModoEntrega));
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxModosEntrega = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostServico = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidTransportador = new HLP.Comum.Components.HLP_Pesquisa();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.Principal.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
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
            this.Principal.Controls.Add(this.txtxModosEntrega);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.cbostServico);
            this.Principal.Controls.Add(this.hlP_PesquisaidTransportador);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(607, 225);
            this.Principal.TabIndex = 2;
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
            this.hlP_LabelSeparator1_Geral.Size = new System.Drawing.Size(300, 18);
            this.hlP_LabelSeparator1_Geral.TabIndex = 30;
            this.hlP_LabelSeparator1_Geral.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idModosEntrega";
            this.txtCodigo._Help = "Código do modos de entrega";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Modos_entrega";
            this.txtCodigo._TamanhoComponente = 132;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo._Visible = true;
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
            // txtxModosEntrega
            // 
            this.txtxModosEntrega._Field = "xModosEntrega";
            this.txtxModosEntrega._Help = "Digite um código alfanumérico para o modo de entrega ";
            this.txtxModosEntrega._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxModosEntrega._LabelText = "Modo de entrega ";
            this.txtxModosEntrega._Multiline = false;
            this.txtxModosEntrega._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxModosEntrega._Password = false;
            this.txtxModosEntrega._Regex = null;
            this.txtxModosEntrega._Table = "Modos_entrega";
            this.txtxModosEntrega._TamanhoComponente = 251;
            this.txtxModosEntrega._TamanhoMaiorLabel = 150;
            this.txtxModosEntrega._Visible = true;
            this.txtxModosEntrega.BackColor = System.Drawing.Color.Transparent;
            this.txtxModosEntrega.Base = null;
            this.txtxModosEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxModosEntrega.Color = System.Drawing.Color.White;
            this.txtxModosEntrega.Location = new System.Drawing.Point(53, 54);
            this.txtxModosEntrega.Margin = new System.Windows.Forms.Padding(53, 3, 15, 3);
            this.txtxModosEntrega.MaxLength = 32767;
            this.txtxModosEntrega.Name = "txtxModosEntrega";
            this.txtxModosEntrega.ReadOnly = false;
            this.txtxModosEntrega.Size = new System.Drawing.Size(351, 21);
            this.txtxModosEntrega.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Digite uma breve descrição do modo de entrega";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.txtxDescricao._LabelText = "Descrição";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Modos_entrega";
            this.txtxDescricao._TamanhoComponente = 251;
            this.txtxDescricao._TamanhoMaiorLabel = 150;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(97, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(307, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // cbostServico
            // 
            this.cbostServico._Field = "stServico";
            this.cbostServico._Help = "Selecione o tipo de serviço de remessa usado para o modo de entrega ";
            this.cbostServico._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostServico._Itens")));
            this.cbostServico._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.cbostServico._LabelText = "Tipo de serviço";
            this.cbostServico._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostServico._Regex = null;
            this.cbostServico._situacao = false;
            this.cbostServico._Table = "Modos_entrega";
            this.cbostServico._TamanhoComponente = 118;
            this.cbostServico._TamanhoMaiorLabel = 150;
            this.cbostServico._Visible = true;
            this.cbostServico.BackColor = System.Drawing.Color.Transparent;
            this.cbostServico.Base = null;
            this.cbostServico.Color = System.Drawing.Color.White;
            this.cbostServico.DataSource = null;
            this.cbostServico.DisplayMember = "DisplayMember";
            this.cbostServico.Location = new System.Drawing.Point(70, 108);
            this.cbostServico.Margin = new System.Windows.Forms.Padding(70, 3, 15, 3);
            this.cbostServico.Name = "cbostServico";
            this.cbostServico.SelectedIndex = -1;
            this.cbostServico.SelectedValue = 0;
            this.cbostServico.Size = new System.Drawing.Size(201, 21);
            this.cbostServico.TabIndex = 5;
            this.cbostServico.ValueMember = "ValueMember";
            this.cbostServico._SelectedIndexChanged += new System.EventHandler(this.cbostServico__SelectedIndexChanged);
            // 
            // hlP_PesquisaidTransportador
            // 
            this.hlP_PesquisaidTransportador._Field = "idTransportador";
            this.hlP_PesquisaidTransportador._Help = "Indentificar o transportador para esse modo de entrega quando o tipo de serviço e" +
    "stiver preenchido com diversos, terrestre ou via aérea";
            this.hlP_PesquisaidTransportador._LabelGroup = this.hlP_LabelSeparator1_Geral;
            this.hlP_PesquisaidTransportador._LabelText = "Empresa transportadora";
            this.hlP_PesquisaidTransportador._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidTransportador._ListaCamposDisplay")));
            this.hlP_PesquisaidTransportador._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidTransportador._ListaValoresDisplay")));
            this.hlP_PesquisaidTransportador._NomeCampoPK = "ID";
            this.hlP_PesquisaidTransportador._NomeFormCadastroOriginal = "FormTransportadora";
            this.hlP_PesquisaidTransportador._NomeView = "vwTransportador";
            this.hlP_PesquisaidTransportador._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidTransportador._Regex = null;
            this.hlP_PesquisaidTransportador._Table = "Modos_entrega";
            this.hlP_PesquisaidTransportador._TamanhoComponente = 300;
            this.hlP_PesquisaidTransportador._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidTransportador._Vinculado = false;
            this.hlP_PesquisaidTransportador._Visible = true;
            this.hlP_PesquisaidTransportador.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidTransportador.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidTransportador.Base = null;
            this.hlP_PesquisaidTransportador.Location = new System.Drawing.Point(22, 135);
            this.hlP_PesquisaidTransportador.Margin = new System.Windows.Forms.Padding(22, 3, 15, 3);
            this.hlP_PesquisaidTransportador.Name = "hlP_PesquisaidTransportador";
            this.hlP_PesquisaidTransportador.ReadOnly = false;
            this.hlP_PesquisaidTransportador.Size = new System.Drawing.Size(521, 21);
            this.hlP_PesquisaidTransportador.TabIndex = 4;
            this.hlP_PesquisaidTransportador.Value = 0;
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
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
            this.kryptonTabControl1.TabIndex = 4;
            this.kryptonTabControl1.UseExtendedLayout = false;
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
            // FormModoEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 311);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModoEntrega";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Text = "Modos de Entrega";
            this.Load += new System.EventHandler(this.FormModoEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidTransportador;
        private Comum.Components.HLP_TextBox txtxModosEntrega;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_ComboBox cbostServico;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_LabelSeparator hlP_LabelSeparator1_Geral;
    }
}