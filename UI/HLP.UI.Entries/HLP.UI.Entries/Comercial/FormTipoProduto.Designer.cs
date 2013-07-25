using HLP.Comum.Components;
namespace HLP.UI.Entries.Comercial
{
    partial class FormTipoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoProduto));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Principal = new System.Windows.Forms.FlowLayoutPanel();
            this.hlP_LabelSeparator1 = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxTipo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxDescricao = new HLP.Comum.Components.HLP_TextBox();
            this.cbostTerceiros = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostServicos = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostPatrimonio = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostProducao = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostEstoque = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostCompras = new HLP.Comum.Components.HLP_ComboBox();
            this.cbostComercial = new HLP.Comum.Components.HLP_ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new HLP.Comum.Components.HLP_DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlternativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xInglesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProduto = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel2 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.btnVisualizar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.Principal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(887, 390);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(885, 366);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = false;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.Controls.Add(this.tabPage2);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(879, 360);
            this.kryptonTabControl1.TabIndex = 3;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(871, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Principal";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.Principal);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(871, 331);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // Principal
            // 
            this.Principal.AutoScroll = true;
            this.Principal.BackColor = System.Drawing.Color.Transparent;
            this.Principal.Controls.Add(this.hlP_LabelSeparator1);
            this.Principal.Controls.Add(this.txtCodigo);
            this.Principal.Controls.Add(this.txtxTipo);
            this.Principal.Controls.Add(this.txtxDescricao);
            this.Principal.Controls.Add(this.cbostTerceiros);
            this.Principal.Controls.Add(this.cbostServicos);
            this.Principal.Controls.Add(this.cbostPatrimonio);
            this.Principal.Controls.Add(this.cbostProducao);
            this.Principal.Controls.Add(this.cbostEstoque);
            this.Principal.Controls.Add(this.cbostCompras);
            this.Principal.Controls.Add(this.cbostComercial);
            this.Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Principal.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(871, 331);
            this.Principal.TabIndex = 1;
            this.Principal.Tag = "Principal";
            // 
            // hlP_LabelSeparator1
            // 
            this.hlP_LabelSeparator1._LabelText = "Geral";
            this.hlP_LabelSeparator1._TamanhoMaiorLabel = 0;
            this.hlP_LabelSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.hlP_LabelSeparator1.Location = new System.Drawing.Point(3, 3);
            this.hlP_LabelSeparator1.Name = "hlP_LabelSeparator1";
            this.hlP_LabelSeparator1.Size = new System.Drawing.Size(618, 18);
            this.hlP_LabelSeparator1.TabIndex = 11;
            this.hlP_LabelSeparator1.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idTipoProduto";
            this.txtCodigo._Help = "Chave principal do registro do tipo de produto";
            this.txtCodigo._LabelGroup = this.hlP_LabelSeparator1;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Tipo_produto";
            this.txtCodigo._TamanhoComponente = 107;
            this.txtCodigo._TamanhoMaiorLabel = 350;
            this.txtCodigo._Visible = true;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(308, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(308, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(152, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtxTipo
            // 
            this.txtxTipo._Field = "xTipo";
            this.txtxTipo._Help = "Informe o tipo de produto resumidamente";
            this.txtxTipo._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxTipo._LabelText = "Tipo de produto";
            this.txtxTipo._Multiline = false;
            this.txtxTipo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTipo._Password = false;
            this.txtxTipo._Regex = null;
            this.txtxTipo._Table = "Tipo_produto";
            this.txtxTipo._TamanhoComponente = 219;
            this.txtxTipo._TamanhoMaiorLabel = 350;
            this.txtxTipo._Visible = true;
            this.txtxTipo.BackColor = System.Drawing.Color.Transparent;
            this.txtxTipo.Base = null;
            this.txtxTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTipo.Color = System.Drawing.Color.White;
            this.txtxTipo.Location = new System.Drawing.Point(262, 54);
            this.txtxTipo.Margin = new System.Windows.Forms.Padding(262, 3, 15, 3);
            this.txtxTipo.MaxLength = 32767;
            this.txtxTipo.Name = "txtxTipo";
            this.txtxTipo.ReadOnly = false;
            this.txtxTipo.Size = new System.Drawing.Size(310, 21);
            this.txtxTipo.TabIndex = 3;
            // 
            // txtxDescricao
            // 
            this.txtxDescricao._Field = "xDescricao";
            this.txtxDescricao._Help = "Descrição do tipo de produto";
            this.txtxDescricao._LabelGroup = this.hlP_LabelSeparator1;
            this.txtxDescricao._LabelText = "Descrição ";
            this.txtxDescricao._Multiline = false;
            this.txtxDescricao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxDescricao._Password = false;
            this.txtxDescricao._Regex = null;
            this.txtxDescricao._Table = "Tipo_produto";
            this.txtxDescricao._TamanhoComponente = 268;
            this.txtxDescricao._TamanhoMaiorLabel = 350;
            this.txtxDescricao._Visible = true;
            this.txtxDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtxDescricao.Base = null;
            this.txtxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxDescricao.Color = System.Drawing.Color.White;
            this.txtxDescricao.Location = new System.Drawing.Point(294, 81);
            this.txtxDescricao.Margin = new System.Windows.Forms.Padding(294, 3, 15, 3);
            this.txtxDescricao.MaxLength = 10;
            this.txtxDescricao.Name = "txtxDescricao";
            this.txtxDescricao.ReadOnly = false;
            this.txtxDescricao.Size = new System.Drawing.Size(327, 21);
            this.txtxDescricao.TabIndex = 2;
            // 
            // cbostTerceiros
            // 
            this.cbostTerceiros._Field = "stTerceiros";
            this.cbostTerceiros._Help = "Marque se tipo de produto é de terceiros, seja ele de clientes ou fornecedores";
            this.cbostTerceiros._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostTerceiros._Itens")));
            this.cbostTerceiros._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostTerceiros._LabelText = "Material de terceiros";
            this.cbostTerceiros._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostTerceiros._Regex = null;
            this.cbostTerceiros._situacao = true;
            this.cbostTerceiros._Table = "Tipo_produto";
            this.cbostTerceiros._TamanhoComponente = 80;
            this.cbostTerceiros._TamanhoMaiorLabel = 350;
            this.cbostTerceiros._Visible = true;
            this.cbostTerceiros.BackColor = System.Drawing.Color.Transparent;
            this.cbostTerceiros.Base = null;
            this.cbostTerceiros.Color = System.Drawing.Color.White;
            this.cbostTerceiros.DataSource = null;
            this.cbostTerceiros.DisplayMember = "DisplayMember";
            this.cbostTerceiros.Location = new System.Drawing.Point(241, 108);
            this.cbostTerceiros.Margin = new System.Windows.Forms.Padding(241, 3, 15, 3);
            this.cbostTerceiros.Name = "cbostTerceiros";
            this.cbostTerceiros.SelectedIndex = -1;
            this.cbostTerceiros.SelectedValue = 0;
            this.cbostTerceiros.Size = new System.Drawing.Size(192, 21);
            this.cbostTerceiros.TabIndex = 4;
            this.cbostTerceiros.ValueMember = "ValueMember";
            // 
            // cbostServicos
            // 
            this.cbostServicos._Field = "stServicos";
            this.cbostServicos._Help = "Marque se o tipo de produto é para serviços";
            this.cbostServicos._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostServicos._Itens")));
            this.cbostServicos._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostServicos._LabelText = "Serviços";
            this.cbostServicos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostServicos._Regex = null;
            this.cbostServicos._situacao = true;
            this.cbostServicos._Table = "Tipo_produto";
            this.cbostServicos._TamanhoComponente = 80;
            this.cbostServicos._TamanhoMaiorLabel = 350;
            this.cbostServicos._Visible = true;
            this.cbostServicos.BackColor = System.Drawing.Color.Transparent;
            this.cbostServicos.Base = null;
            this.cbostServicos.Color = System.Drawing.Color.White;
            this.cbostServicos.DataSource = null;
            this.cbostServicos.DisplayMember = "DisplayMember";
            this.cbostServicos.Location = new System.Drawing.Point(305, 135);
            this.cbostServicos.Margin = new System.Windows.Forms.Padding(305, 3, 15, 3);
            this.cbostServicos.Name = "cbostServicos";
            this.cbostServicos.SelectedIndex = -1;
            this.cbostServicos.SelectedValue = 0;
            this.cbostServicos.Size = new System.Drawing.Size(128, 21);
            this.cbostServicos.TabIndex = 5;
            this.cbostServicos.ValueMember = "ValueMember";
            // 
            // cbostPatrimonio
            // 
            this.cbostPatrimonio._Field = "stPatrimonio";
            this.cbostPatrimonio._Help = "Marque se o produto é referente a patrimônio";
            this.cbostPatrimonio._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostPatrimonio._Itens")));
            this.cbostPatrimonio._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostPatrimonio._LabelText = "Produto de patrimônio";
            this.cbostPatrimonio._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostPatrimonio._Regex = null;
            this.cbostPatrimonio._situacao = true;
            this.cbostPatrimonio._Table = "Tipo_produto";
            this.cbostPatrimonio._TamanhoComponente = 80;
            this.cbostPatrimonio._TamanhoMaiorLabel = 350;
            this.cbostPatrimonio._Visible = true;
            this.cbostPatrimonio.BackColor = System.Drawing.Color.Transparent;
            this.cbostPatrimonio.Base = null;
            this.cbostPatrimonio.Color = System.Drawing.Color.White;
            this.cbostPatrimonio.DataSource = null;
            this.cbostPatrimonio.DisplayMember = "DisplayMember";
            this.cbostPatrimonio.Location = new System.Drawing.Point(228, 162);
            this.cbostPatrimonio.Margin = new System.Windows.Forms.Padding(228, 3, 15, 3);
            this.cbostPatrimonio.Name = "cbostPatrimonio";
            this.cbostPatrimonio.SelectedIndex = -1;
            this.cbostPatrimonio.SelectedValue = 0;
            this.cbostPatrimonio.Size = new System.Drawing.Size(205, 21);
            this.cbostPatrimonio.TabIndex = 6;
            this.cbostPatrimonio.ValueMember = "ValueMember";
            // 
            // cbostProducao
            // 
            this.cbostProducao._Field = "stProducao";
            this.cbostProducao._Help = "Marque se deseja que todos os produtos com esse tipo deverá mostrar em todas as t" +
    "elas do módulo produção";
            this.cbostProducao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostProducao._Itens")));
            this.cbostProducao._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostProducao._LabelText = "Visualizar o tipo de produto no módulo de produção";
            this.cbostProducao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostProducao._Regex = null;
            this.cbostProducao._situacao = true;
            this.cbostProducao._Table = "Tipo_produto";
            this.cbostProducao._TamanhoComponente = 80;
            this.cbostProducao._TamanhoMaiorLabel = 350;
            this.cbostProducao._Visible = true;
            this.cbostProducao.BackColor = System.Drawing.Color.Transparent;
            this.cbostProducao.Base = null;
            this.cbostProducao.Color = System.Drawing.Color.White;
            this.cbostProducao.DataSource = null;
            this.cbostProducao.DisplayMember = "DisplayMember";
            this.cbostProducao.Location = new System.Drawing.Point(72, 189);
            this.cbostProducao.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.cbostProducao.Name = "cbostProducao";
            this.cbostProducao.SelectedIndex = -1;
            this.cbostProducao.SelectedValue = 0;
            this.cbostProducao.Size = new System.Drawing.Size(361, 21);
            this.cbostProducao.TabIndex = 7;
            this.cbostProducao.ValueMember = "ValueMember";
            // 
            // cbostEstoque
            // 
            this.cbostEstoque._Field = "stEstoque";
            this.cbostEstoque._Help = "Marque se deseja que todos os produtos com esse tipo deverá mostrar em todas as t" +
    "elas do módulo estoque";
            this.cbostEstoque._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostEstoque._Itens")));
            this.cbostEstoque._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostEstoque._LabelText = "Visualizar o tipo de produto no módulo de estoque";
            this.cbostEstoque._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostEstoque._Regex = null;
            this.cbostEstoque._situacao = true;
            this.cbostEstoque._Table = "Tipo_produto";
            this.cbostEstoque._TamanhoComponente = 80;
            this.cbostEstoque._TamanhoMaiorLabel = 350;
            this.cbostEstoque._Visible = true;
            this.cbostEstoque.BackColor = System.Drawing.Color.Transparent;
            this.cbostEstoque.Base = null;
            this.cbostEstoque.Color = System.Drawing.Color.White;
            this.cbostEstoque.DataSource = null;
            this.cbostEstoque.DisplayMember = "DisplayMember";
            this.cbostEstoque.Location = new System.Drawing.Point(80, 216);
            this.cbostEstoque.Margin = new System.Windows.Forms.Padding(80, 3, 15, 3);
            this.cbostEstoque.Name = "cbostEstoque";
            this.cbostEstoque.SelectedIndex = -1;
            this.cbostEstoque.SelectedValue = 0;
            this.cbostEstoque.Size = new System.Drawing.Size(353, 21);
            this.cbostEstoque.TabIndex = 8;
            this.cbostEstoque.ValueMember = "ValueMember";
            // 
            // cbostCompras
            // 
            this.cbostCompras._Field = "stCompras";
            this.cbostCompras._Help = "Marque se deseja que todos os produtos com esse tipo deverá mostrar em todas as t" +
    "elas do módulo compras";
            this.cbostCompras._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostCompras._Itens")));
            this.cbostCompras._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostCompras._LabelText = "Visualizar o tipo de produto no módulo de compras";
            this.cbostCompras._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostCompras._Regex = null;
            this.cbostCompras._situacao = true;
            this.cbostCompras._Table = "Tipo_produto";
            this.cbostCompras._TamanhoComponente = 80;
            this.cbostCompras._TamanhoMaiorLabel = 350;
            this.cbostCompras._Visible = true;
            this.cbostCompras.BackColor = System.Drawing.Color.Transparent;
            this.cbostCompras.Base = null;
            this.cbostCompras.Color = System.Drawing.Color.White;
            this.cbostCompras.DataSource = null;
            this.cbostCompras.DisplayMember = "DisplayMember";
            this.cbostCompras.Location = new System.Drawing.Point(79, 243);
            this.cbostCompras.Margin = new System.Windows.Forms.Padding(79, 3, 15, 3);
            this.cbostCompras.Name = "cbostCompras";
            this.cbostCompras.SelectedIndex = -1;
            this.cbostCompras.SelectedValue = 0;
            this.cbostCompras.Size = new System.Drawing.Size(354, 21);
            this.cbostCompras.TabIndex = 9;
            this.cbostCompras.ValueMember = "ValueMember";
            // 
            // cbostComercial
            // 
            this.cbostComercial._Field = "stComercial";
            this.cbostComercial._Help = "Marque se deseja que todos os produtos com esse tipo deverá mostrar em todas as t" +
    "elas do módulo comercial/faturamento";
            this.cbostComercial._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostComercial._Itens")));
            this.cbostComercial._LabelGroup = this.hlP_LabelSeparator1;
            this.cbostComercial._LabelText = "Visualizar o tipo de produto no módulo de comercial/faturamento";
            this.cbostComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostComercial._Regex = null;
            this.cbostComercial._situacao = true;
            this.cbostComercial._Table = "Tipo_produto";
            this.cbostComercial._TamanhoComponente = 80;
            this.cbostComercial._TamanhoMaiorLabel = 350;
            this.cbostComercial._Visible = true;
            this.cbostComercial.BackColor = System.Drawing.Color.Transparent;
            this.cbostComercial.Base = null;
            this.cbostComercial.Color = System.Drawing.Color.White;
            this.cbostComercial.DataSource = null;
            this.cbostComercial.DisplayMember = "DisplayMember";
            this.cbostComercial.Location = new System.Drawing.Point(6, 270);
            this.cbostComercial.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.cbostComercial.Name = "cbostComercial";
            this.cbostComercial.SelectedIndex = -1;
            this.cbostComercial.SelectedValue = 0;
            this.cbostComercial.Size = new System.Drawing.Size(427, 21);
            this.cbostComercial.TabIndex = 10;
            this.cbostComercial.ValueMember = "ValueMember";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProdutos);
            this.tabPage2.Controls.Add(this.kryptonPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(871, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Produtos Relacionados";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Altera = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.cm = null;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.cAlternativoDataGridViewTextBoxColumn,
            this.xComercialDataGridViewTextBoxColumn,
            this.xFiscalDataGridViewTextBoxColumn,
            this.xInglesDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.bsProduto;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.DragDropLinha = false;
            this.dgvProdutos.Exclui = false;
            this.dgvProdutos.Inclui = false;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 31);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(871, 300);
            this.dgvProdutos.TabIndex = 23;
            this.dgvProdutos.Tag = "Produto";
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "idProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cAlternativoDataGridViewTextBoxColumn
            // 
            this.cAlternativoDataGridViewTextBoxColumn.DataPropertyName = "cAlternativo";
            this.cAlternativoDataGridViewTextBoxColumn.HeaderText = "Código Alternativo";
            this.cAlternativoDataGridViewTextBoxColumn.Name = "cAlternativoDataGridViewTextBoxColumn";
            this.cAlternativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xComercialDataGridViewTextBoxColumn
            // 
            this.xComercialDataGridViewTextBoxColumn.DataPropertyName = "xComercial";
            this.xComercialDataGridViewTextBoxColumn.HeaderText = "Descrição Comercial";
            this.xComercialDataGridViewTextBoxColumn.Name = "xComercialDataGridViewTextBoxColumn";
            this.xComercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xFiscalDataGridViewTextBoxColumn
            // 
            this.xFiscalDataGridViewTextBoxColumn.DataPropertyName = "xFiscal";
            this.xFiscalDataGridViewTextBoxColumn.HeaderText = "Descrição Fiscal";
            this.xFiscalDataGridViewTextBoxColumn.Name = "xFiscalDataGridViewTextBoxColumn";
            this.xFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xInglesDataGridViewTextBoxColumn
            // 
            this.xInglesDataGridViewTextBoxColumn.DataPropertyName = "xIngles";
            this.xInglesDataGridViewTextBoxColumn.HeaderText = "Descrição em Inglês";
            this.xInglesDataGridViewTextBoxColumn.Name = "xInglesDataGridViewTextBoxColumn";
            this.xInglesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsProduto
            // 
            this.bsProduto.DataSource = typeof(HLP.Models.Entries.Comercial.ProdutoModel);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.BorderWidth = 0;
            this.kryptonPanel2.Controls.Add(this.btnVisualizar);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel2.GradientToogleColors = false;
            this.kryptonPanel2.GradientUseBlend = false;
            this.kryptonPanel2.GradientUseSolid = true;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PersistentColors = false;
            this.kryptonPanel2.Size = new System.Drawing.Size(871, 31);
            this.kryptonPanel2.TabIndex = 22;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(3, 3);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(194, 25);
            this.btnVisualizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnVisualizar.TabIndex = 20;
            this.btnVisualizar.Values.Text = "Visualizar Produtos Relacionados";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // FormTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 417);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTipoProduto";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Tipos de Produto";
            this.Load += new System.EventHandler(this.FormTipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel Principal;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxTipo;
        private Comum.Components.HLP_TextBox txtxDescricao;
        private Comum.Components.HLP_ComboBox cbostTerceiros;
        private Comum.Components.HLP_ComboBox cbostServicos;
        private Comum.Components.HLP_ComboBox cbostPatrimonio;
        private Comum.Components.HLP_ComboBox cbostProducao;
        private Comum.Components.HLP_ComboBox cbostEstoque;
        private Comum.Components.HLP_ComboBox cbostCompras;
        private Comum.Components.HLP_ComboBox cbostComercial;
        private System.Windows.Forms.TabPage tabPage2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVisualizar;
        private HLP_DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlternativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xInglesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsProduto;
        private HLP_LabelSeparator hlP_LabelSeparator1;
    }
}