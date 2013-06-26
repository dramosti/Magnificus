using HLP.Comum.Components;
namespace HLP.UI.Entries.Comercial
{
    partial class FormListaPreco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPreco));
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCodigoListaPreco = new HLP.Comum.Components.HLP_TextBox();
            this.txtxLista = new HLP.Comum.Components.HLP_TextBox();
            this.txtdListaPreco = new HLP.Comum.Components.HLP_TextBox();
            this.cbostAtualizacao = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidListaPrecoOrigem = new HLP.Comum.Components.HLP_Pesquisa();
            this.txtpPercentual = new HLP.Comum.Components.HLP_TextBox();
            this.btnGerar = new HLP.Comum.Components.HLP_Button();
            this.nudnDiasSemAtualicao = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cbostContrato = new HLP.Comum.Components.HLP_ComboBox();
            this.txtxNrContrato = new HLP.Comum.Components.HLP_TextBox();
            this.dtpdValidadeContrato = new HLP.Comum.Components.HLP_DateTimePicker();
            this.nudpDescontoMaximo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpAcressimoMaximo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.cboAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.bsListaPreco = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.btnAtribuicao = new HLP.Comum.Components.HLP_Button();
            this.btnAumentoPreco = new HLP.Comum.Components.HLP_Button();
            this.btnInserir = new HLP.Comum.Components.HLP_Button();
            this.dgvItens = new HLP.Comum.Components.HLP_DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idUnidadeMedida = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.sep_Geral = new HLP.Comum.Components.HLP_LabelSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaPreco)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.kryptonTabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1101, 561);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl2);
            this.panelPadrao.Controls.Add(this.splitter1);
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(1099, 537);
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
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(1093, 282);
            this.kryptonTabControl1.TabIndex = 1;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1085, 253);
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
            this.kryptonPanel1.Size = new System.Drawing.Size(1085, 253);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.sep_Geral);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxCodigoListaPreco);
            this.flowLayoutPanel1.Controls.Add(this.txtxLista);
            this.flowLayoutPanel1.Controls.Add(this.txtdListaPreco);
            this.flowLayoutPanel1.Controls.Add(this.cbostAtualizacao);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidListaPrecoOrigem);
            this.flowLayoutPanel1.Controls.Add(this.txtpPercentual);
            this.flowLayoutPanel1.Controls.Add(this.btnGerar);
            this.flowLayoutPanel1.Controls.Add(this.nudnDiasSemAtualicao);
            this.flowLayoutPanel1.Controls.Add(this.cbostContrato);
            this.flowLayoutPanel1.Controls.Add(this.txtxNrContrato);
            this.flowLayoutPanel1.Controls.Add(this.dtpdValidadeContrato);
            this.flowLayoutPanel1.Controls.Add(this.nudpDescontoMaximo);
            this.flowLayoutPanel1.Controls.Add(this.nudpAcressimoMaximo);
            this.flowLayoutPanel1.Controls.Add(this.cboAtivo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1085, 253);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idListaPrecoPai";
            this.txtCodigo._Help = "Chave principal do registro da lista de preço";
            this.txtCodigo._LabelGroup = this.sep_Geral;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Lista_Preco_Pai";
            this.txtCodigo._TamanhoComponente = 111;
            this.txtCodigo._TamanhoMaiorLabel = 200;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(158, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(158, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(156, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxCodigoListaPreco
            // 
            this.txtxCodigoListaPreco._Field = "xCodigoListaPreco";
            this.txtxCodigoListaPreco._Help = "Digite um código para a recém-criada lista de preço ";
            this.txtxCodigoListaPreco._LabelGroup = this.sep_Geral;
            this.txtxCodigoListaPreco._LabelText = "Código da lista de preço ";
            this.txtxCodigoListaPreco._Multiline = false;
            this.txtxCodigoListaPreco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCodigoListaPreco._Password = false;
            this.txtxCodigoListaPreco._Regex = null;
            this.txtxCodigoListaPreco._Table = "Lista_Preco_Pai";
            this.txtxCodigoListaPreco._TamanhoComponente = 111;
            this.txtxCodigoListaPreco._TamanhoMaiorLabel = 200;
            this.txtxCodigoListaPreco._Visible = false;
            this.txtxCodigoListaPreco.BackColor = System.Drawing.Color.Transparent;
            this.txtxCodigoListaPreco.Base = null;
            this.txtxCodigoListaPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCodigoListaPreco.Color = System.Drawing.Color.White;
            this.txtxCodigoListaPreco.Location = new System.Drawing.Point(67, 57);
            this.txtxCodigoListaPreco.Margin = new System.Windows.Forms.Padding(67, 3, 15, 3);
            this.txtxCodigoListaPreco.MaxLength = 32767;
            this.txtxCodigoListaPreco.Name = "txtxCodigoListaPreco";
            this.txtxCodigoListaPreco.ReadOnly = false;
            this.txtxCodigoListaPreco.Size = new System.Drawing.Size(247, 24);
            this.txtxCodigoListaPreco.TabIndex = 4;
            // 
            // txtxLista
            // 
            this.txtxLista._Field = "xLista";
            this.txtxLista._Help = "Descrição da lista de preço";
            this.txtxLista._LabelGroup = this.sep_Geral;
            this.txtxLista._LabelText = "Descrição ";
            this.txtxLista._Multiline = false;
            this.txtxLista._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxLista._Password = false;
            this.txtxLista._Regex = null;
            this.txtxLista._Table = "Lista_Preco_Pai";
            this.txtxLista._TamanhoComponente = 317;
            this.txtxLista._TamanhoMaiorLabel = 200;
            this.txtxLista._Visible = false;
            this.txtxLista.BackColor = System.Drawing.Color.Transparent;
            this.txtxLista.Base = null;
            this.txtxLista.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxLista.Color = System.Drawing.Color.White;
            this.txtxLista.Location = new System.Drawing.Point(144, 87);
            this.txtxLista.Margin = new System.Windows.Forms.Padding(144, 3, 15, 3);
            this.txtxLista.MaxLength = 32767;
            this.txtxLista.Name = "txtxLista";
            this.txtxLista.ReadOnly = false;
            this.txtxLista.Size = new System.Drawing.Size(376, 22);
            this.txtxLista.TabIndex = 5;
            // 
            // txtdListaPreco
            // 
            this.txtdListaPreco._Field = "dListaPreco";
            this.txtdListaPreco._Help = "Este campo mostra a data em que a lista de preços foi gerada (criada)";
            this.txtdListaPreco._LabelGroup = this.sep_Geral;
            this.txtdListaPreco._LabelText = "Data de criação da lista de preço";
            this.txtdListaPreco._Multiline = false;
            this.txtdListaPreco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtdListaPreco._Password = false;
            this.txtdListaPreco._Regex = null;
            this.txtdListaPreco._Table = "Lista_Preco_Pai";
            this.txtdListaPreco._TamanhoComponente = 111;
            this.txtdListaPreco._TamanhoMaiorLabel = 200;
            this.txtdListaPreco._Visible = false;
            this.txtdListaPreco.BackColor = System.Drawing.Color.Transparent;
            this.txtdListaPreco.Base = null;
            this.txtdListaPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdListaPreco.Color = System.Drawing.Color.White;
            this.txtdListaPreco.Location = new System.Drawing.Point(29, 115);
            this.txtdListaPreco.Margin = new System.Windows.Forms.Padding(29, 3, 15, 3);
            this.txtdListaPreco.MaxLength = 32767;
            this.txtdListaPreco.Name = "txtdListaPreco";
            this.txtdListaPreco.ReadOnly = true;
            this.txtdListaPreco.Size = new System.Drawing.Size(285, 21);
            this.txtdListaPreco.TabIndex = 6;
            // 
            // cbostAtualizacao
            // 
            this.cbostAtualizacao._Field = "stAtualizacao";
            this.cbostAtualizacao._Help = "Informar o tipo de atualização para o campo preço de venda para essa lista de pre" +
    "ço";
            this.cbostAtualizacao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostAtualizacao._Itens")));
            this.cbostAtualizacao._LabelGroup = this.sep_Geral;
            this.cbostAtualizacao._LabelText = "Tipo de atualização";
            this.cbostAtualizacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostAtualizacao._Regex = null;
            this.cbostAtualizacao._situacao = false;
            this.cbostAtualizacao._Table = "Lista_Preco_Pai";
            this.cbostAtualizacao._TamanhoComponente = 111;
            this.cbostAtualizacao._TamanhoMaiorLabel = 200;
            this.cbostAtualizacao._Visible = false;
            this.cbostAtualizacao.BackColor = System.Drawing.Color.Transparent;
            this.cbostAtualizacao.Base = null;
            this.cbostAtualizacao.Color = System.Drawing.Color.White;
            this.cbostAtualizacao.DataSource = null;
            this.cbostAtualizacao.DisplayMember = "DisplayMember";
            this.cbostAtualizacao.Enabled = false;
            this.cbostAtualizacao.Location = new System.Drawing.Point(97, 142);
            this.cbostAtualizacao.Margin = new System.Windows.Forms.Padding(97, 3, 15, 3);
            this.cbostAtualizacao.Name = "cbostAtualizacao";
            this.cbostAtualizacao.SelectedIndex = -1;
            this.cbostAtualizacao.SelectedValue = 0;
            this.cbostAtualizacao.Size = new System.Drawing.Size(217, 21);
            this.cbostAtualizacao.TabIndex = 7;
            this.cbostAtualizacao.ValueMember = "ValueMember";
            this.cbostAtualizacao._SelectedIndexChanged += new System.EventHandler(this.cbostAtualizacao__SelectedIndexChanged);
            // 
            // hlP_PesquisaidListaPrecoOrigem
            // 
            this.hlP_PesquisaidListaPrecoOrigem._Field = "idListaPrecoOrigem";
            this.hlP_PesquisaidListaPrecoOrigem._Help = "Informar qual é a lista de preço origem quando a lista for automática, o campo só" +
    " é disponibilizado quando a lista for automática";
            this.hlP_PesquisaidListaPrecoOrigem._LabelGroup = this.sep_Geral;
            this.hlP_PesquisaidListaPrecoOrigem._LabelText = "Lista de preço origem";
            this.hlP_PesquisaidListaPrecoOrigem._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidListaPrecoOrigem._ListaCamposDisplay")));
            this.hlP_PesquisaidListaPrecoOrigem._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidListaPrecoOrigem._ListaValoresDisplay")));
            this.hlP_PesquisaidListaPrecoOrigem._NomeCampoPK = "ID";
            this.hlP_PesquisaidListaPrecoOrigem._NomeFormCadastroOriginal = "FormListaPreco";
            this.hlP_PesquisaidListaPrecoOrigem._NomeView = "vwListaPrecoPai";
            this.hlP_PesquisaidListaPrecoOrigem._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidListaPrecoOrigem._Regex = null;
            this.hlP_PesquisaidListaPrecoOrigem._Table = "Lista_Preco_Pai";
            this.hlP_PesquisaidListaPrecoOrigem._TamanhoComponente = 227;
            this.hlP_PesquisaidListaPrecoOrigem._TamanhoMaiorLabel = 200;
            this.hlP_PesquisaidListaPrecoOrigem._Vinculado = false;
            this.hlP_PesquisaidListaPrecoOrigem._Visible = false;
            this.hlP_PesquisaidListaPrecoOrigem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidListaPrecoOrigem.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidListaPrecoOrigem.Base = null;
            this.hlP_PesquisaidListaPrecoOrigem.Location = new System.Drawing.Point(86, 169);
            this.hlP_PesquisaidListaPrecoOrigem.Margin = new System.Windows.Forms.Padding(86, 3, 15, 3);
            this.hlP_PesquisaidListaPrecoOrigem.Name = "hlP_PesquisaidListaPrecoOrigem";
            this.hlP_PesquisaidListaPrecoOrigem.ReadOnly = false;
            this.hlP_PesquisaidListaPrecoOrigem.Size = new System.Drawing.Size(434, 21);
            this.hlP_PesquisaidListaPrecoOrigem.TabIndex = 20;
            this.hlP_PesquisaidListaPrecoOrigem.Value = 0;
            // 
            // txtpPercentual
            // 
            this.txtpPercentual._Field = "pPercentual";
            this.txtpPercentual._Help = "Este campo serve para se definir o % de acréscimo (valor positivo) ou % de descon" +
    "to (valor negativo) para a lista que está sendo mostrada na tela e definida como" +
    " automática";
            this.txtpPercentual._LabelGroup = this.sep_Geral;
            this.txtpPercentual._LabelText = "Percentual";
            this.txtpPercentual._Multiline = false;
            this.txtpPercentual._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtpPercentual._Password = false;
            this.txtpPercentual._Regex = null;
            this.txtpPercentual._Table = "Lista_Preco_Pai";
            this.txtpPercentual._TamanhoComponente = 111;
            this.txtpPercentual._TamanhoMaiorLabel = 200;
            this.txtpPercentual._Visible = false;
            this.txtpPercentual.BackColor = System.Drawing.Color.Transparent;
            this.txtpPercentual.Base = null;
            this.txtpPercentual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpPercentual.Color = System.Drawing.Color.White;
            this.txtpPercentual.Location = new System.Drawing.Point(142, 196);
            this.txtpPercentual.Margin = new System.Windows.Forms.Padding(142, 3, 15, 3);
            this.txtpPercentual.MaxLength = 32767;
            this.txtpPercentual.Name = "txtpPercentual";
            this.txtpPercentual.ReadOnly = false;
            this.txtpPercentual.Size = new System.Drawing.Size(172, 22);
            this.txtpPercentual.TabIndex = 17;
            // 
            // btnGerar
            // 
            this.btnGerar._LabelGroup = this.sep_Geral;
            this.btnGerar._LabelText = "Gerar lista";
            this.btnGerar._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnGerar._Regex = null;
            this.btnGerar._TamanhoComponente = 80;
            this.btnGerar._TamanhoMaiorLabel = 200;
            this.btnGerar._Visible = false;
            this.btnGerar.Base = null;
            this.btnGerar.Location = new System.Drawing.Point(203, 224);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(203, 3, 15, 3);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(80, 24);
            this.btnGerar.TabIndex = 21;
            this.btnGerar._btnHlpClick += new System.EventHandler(this.btnGerar_Click);
            // 
            // nudnDiasSemAtualicao
            // 
            this.nudnDiasSemAtualicao._Field = "nDiasSemAtualicao";
            this.nudnDiasSemAtualicao._Help = "Muda a cor para vermelho no registro que não sofrem alteração no preço de custo a" +
    " mais do que o número de dias estabelecido no campo";
            this.nudnDiasSemAtualicao._LabelGroup = this.sep_Geral;
            this.nudnDiasSemAtualicao._LabelText = "Dias s/ atualização no valor de custo";
            this.nudnDiasSemAtualicao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudnDiasSemAtualicao._Regex = null;
            this.nudnDiasSemAtualicao._Table = "Lista_Preco_Pai";
            this.nudnDiasSemAtualicao._TamanhoComponente = 80;
            this.nudnDiasSemAtualicao._TamanhoMaiorLabel = 200;
            this.nudnDiasSemAtualicao._Visible = false;
            this.nudnDiasSemAtualicao.BackColor = System.Drawing.Color.Transparent;
            this.nudnDiasSemAtualicao.Base = null;
            this.nudnDiasSemAtualicao.Color = System.Drawing.Color.White;
            this.nudnDiasSemAtualicao.DecimalPlaces = 2;
            this.nudnDiasSemAtualicao.Location = new System.Drawing.Point(544, 3);
            this.nudnDiasSemAtualicao.Margin = new System.Windows.Forms.Padding(9, 3, 15, 3);
            this.nudnDiasSemAtualicao.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudnDiasSemAtualicao.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudnDiasSemAtualicao.Name = "nudnDiasSemAtualicao";
            this.nudnDiasSemAtualicao.ReadOnly = false;
            this.nudnDiasSemAtualicao.Size = new System.Drawing.Size(274, 22);
            this.nudnDiasSemAtualicao.TabIndex = 10;
            this.nudnDiasSemAtualicao.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudnDiasSemAtualicao.ValueInt = 0;
            // 
            // cbostContrato
            // 
            this.cbostContrato._Field = "stContrato";
            this.cbostContrato._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbostContrato._Itens")));
            this.cbostContrato._LabelGroup = this.sep_Geral;
            this.cbostContrato._LabelText = "É contrato?";
            this.cbostContrato._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbostContrato._Regex = null;
            this.cbostContrato._situacao = true;
            this.cbostContrato._Table = "Lista_Preco_Pai";
            this.cbostContrato._TamanhoComponente = 80;
            this.cbostContrato._TamanhoMaiorLabel = 200;
            this.cbostContrato._Visible = false;
            this.cbostContrato.BackColor = System.Drawing.Color.Transparent;
            this.cbostContrato.Base = null;
            this.cbostContrato.Color = System.Drawing.Color.White;
            this.cbostContrato.DataSource = null;
            this.cbostContrato.DisplayMember = "DisplayMember";
            this.cbostContrato.Location = new System.Drawing.Point(673, 31);
            this.cbostContrato.Margin = new System.Windows.Forms.Padding(138, 3, 15, 3);
            this.cbostContrato.Name = "cbostContrato";
            this.cbostContrato.SelectedIndex = -1;
            this.cbostContrato.SelectedValue = 0;
            this.cbostContrato.Size = new System.Drawing.Size(145, 21);
            this.cbostContrato.TabIndex = 12;
            this.cbostContrato.ValueMember = "ValueMember";
            // 
            // txtxNrContrato
            // 
            this.txtxNrContrato._Field = "xNrContrato";
            this.txtxNrContrato._LabelGroup = this.sep_Geral;
            this.txtxNrContrato._LabelText = "Nº contrato";
            this.txtxNrContrato._Multiline = false;
            this.txtxNrContrato._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNrContrato._Password = false;
            this.txtxNrContrato._Regex = null;
            this.txtxNrContrato._Table = "Lista_Preco_Pai";
            this.txtxNrContrato._TamanhoComponente = 146;
            this.txtxNrContrato._TamanhoMaiorLabel = 200;
            this.txtxNrContrato._Visible = false;
            this.txtxNrContrato.BackColor = System.Drawing.Color.Transparent;
            this.txtxNrContrato.Base = null;
            this.txtxNrContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNrContrato.Color = System.Drawing.Color.White;
            this.txtxNrContrato.Location = new System.Drawing.Point(671, 58);
            this.txtxNrContrato.Margin = new System.Windows.Forms.Padding(136, 3, 15, 3);
            this.txtxNrContrato.MaxLength = 32767;
            this.txtxNrContrato.Name = "txtxNrContrato";
            this.txtxNrContrato.ReadOnly = false;
            this.txtxNrContrato.Size = new System.Drawing.Size(213, 22);
            this.txtxNrContrato.TabIndex = 13;
            // 
            // dtpdValidadeContrato
            // 
            this.dtpdValidadeContrato._Field = "dValidadeContrato";
            this.dtpdValidadeContrato._LabelGroup = this.sep_Geral;
            this.dtpdValidadeContrato._LabelText = "Data de validade do contrato";
            this.dtpdValidadeContrato._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtpdValidadeContrato._Regex = null;
            this.dtpdValidadeContrato._Table = "Lista_Preco_Pai";
            this.dtpdValidadeContrato._TamanhoComponente = 80;
            this.dtpdValidadeContrato._TamanhoMaiorLabel = 200;
            this.dtpdValidadeContrato._Visible = false;
            this.dtpdValidadeContrato.BackColor = System.Drawing.Color.Transparent;
            this.dtpdValidadeContrato.Base = null;
            this.dtpdValidadeContrato.Color = System.Drawing.Color.Empty;
            this.dtpdValidadeContrato.CustomFormat = "";
            this.dtpdValidadeContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdValidadeContrato.Location = new System.Drawing.Point(581, 86);
            this.dtpdValidadeContrato.Margin = new System.Windows.Forms.Padding(46, 3, 15, 3);
            this.dtpdValidadeContrato.Name = "dtpdValidadeContrato";
            this.dtpdValidadeContrato.Size = new System.Drawing.Size(237, 21);
            this.dtpdValidadeContrato.TabIndex = 14;
            this.dtpdValidadeContrato.Value = new System.DateTime(2012, 8, 8, 8, 0, 1, 556);
            // 
            // nudpDescontoMaximo
            // 
            this.nudpDescontoMaximo._Field = "pDescontoMaximo";
            this.nudpDescontoMaximo._LabelGroup = this.sep_Geral;
            this.nudpDescontoMaximo._LabelText = "Desconto máximo";
            this.nudpDescontoMaximo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpDescontoMaximo._Regex = null;
            this.nudpDescontoMaximo._Table = "Lista_Preco_Pai";
            this.nudpDescontoMaximo._TamanhoComponente = 80;
            this.nudpDescontoMaximo._TamanhoMaiorLabel = 200;
            this.nudpDescontoMaximo._Visible = false;
            this.nudpDescontoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.nudpDescontoMaximo.Base = null;
            this.nudpDescontoMaximo.Color = System.Drawing.Color.White;
            this.nudpDescontoMaximo.DecimalPlaces = 2;
            this.nudpDescontoMaximo.Location = new System.Drawing.Point(640, 113);
            this.nudpDescontoMaximo.Margin = new System.Windows.Forms.Padding(105, 3, 15, 3);
            this.nudpDescontoMaximo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpDescontoMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpDescontoMaximo.Name = "nudpDescontoMaximo";
            this.nudpDescontoMaximo.ReadOnly = false;
            this.nudpDescontoMaximo.Size = new System.Drawing.Size(178, 22);
            this.nudpDescontoMaximo.TabIndex = 15;
            this.nudpDescontoMaximo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpDescontoMaximo.ValueInt = 0;
            // 
            // nudpAcressimoMaximo
            // 
            this.nudpAcressimoMaximo._Field = "pAcressimoMaximo";
            this.nudpAcressimoMaximo._LabelGroup = this.sep_Geral;
            this.nudpAcressimoMaximo._LabelText = "Acréscimo máximo";
            this.nudpAcressimoMaximo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpAcressimoMaximo._Regex = null;
            this.nudpAcressimoMaximo._Table = "Lista_Preco_Pai";
            this.nudpAcressimoMaximo._TamanhoComponente = 80;
            this.nudpAcressimoMaximo._TamanhoMaiorLabel = 200;
            this.nudpAcressimoMaximo._Visible = false;
            this.nudpAcressimoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.nudpAcressimoMaximo.Base = null;
            this.nudpAcressimoMaximo.Color = System.Drawing.Color.White;
            this.nudpAcressimoMaximo.DecimalPlaces = 2;
            this.nudpAcressimoMaximo.Location = new System.Drawing.Point(638, 141);
            this.nudpAcressimoMaximo.Margin = new System.Windows.Forms.Padding(103, 3, 15, 3);
            this.nudpAcressimoMaximo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpAcressimoMaximo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpAcressimoMaximo.Name = "nudpAcressimoMaximo";
            this.nudpAcressimoMaximo.ReadOnly = false;
            this.nudpAcressimoMaximo.Size = new System.Drawing.Size(180, 22);
            this.nudpAcressimoMaximo.TabIndex = 16;
            this.nudpAcressimoMaximo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpAcressimoMaximo.ValueInt = 0;
            // 
            // cboAtivo
            // 
            this.cboAtivo._Field = "Ativo";
            this.cboAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cboAtivo._Itens")));
            this.cboAtivo._LabelGroup = this.sep_Geral;
            this.cboAtivo._LabelText = "Ativo?";
            this.cboAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cboAtivo._Regex = null;
            this.cboAtivo._situacao = true;
            this.cboAtivo._Table = "Lista_Preco_Pai";
            this.cboAtivo._TamanhoComponente = 80;
            this.cboAtivo._TamanhoMaiorLabel = 200;
            this.cboAtivo._Visible = false;
            this.cboAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cboAtivo.Base = null;
            this.cboAtivo.Color = System.Drawing.Color.White;
            this.cboAtivo.DataSource = null;
            this.cboAtivo.DisplayMember = "DisplayMember";
            this.cboAtivo.Location = new System.Drawing.Point(700, 169);
            this.cboAtivo.Margin = new System.Windows.Forms.Padding(165, 3, 15, 3);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.SelectedIndex = -1;
            this.cboAtivo.SelectedValue = 0;
            this.cboAtivo.Size = new System.Drawing.Size(118, 21);
            this.cboAtivo.TabIndex = 11;
            this.cboAtivo.ValueMember = "ValueMember";
            // 
            // bsListaPreco
            // 
            this.bsListaPreco.DataSource = typeof(HLP.Models.Entries.Comercial.Lista_precoModel);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1085, 217);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Produtos";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.BorderWidth = 0;
            this.kryptonPanel3.Controls.Add(this.btnAtribuicao);
            this.kryptonPanel3.Controls.Add(this.btnAumentoPreco);
            this.kryptonPanel3.Controls.Add(this.btnInserir);
            this.kryptonPanel3.Controls.Add(this.dgvItens);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel3.GradientToogleColors = false;
            this.kryptonPanel3.GradientUseBlend = false;
            this.kryptonPanel3.GradientUseSolid = true;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PersistentColors = false;
            this.kryptonPanel3.Size = new System.Drawing.Size(1085, 217);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // btnAtribuicao
            // 
            this.btnAtribuicao._LabelGroup = null;
            this.btnAtribuicao._LabelText = "Atribuição coletiva";
            this.btnAtribuicao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnAtribuicao._Regex = null;
            this.btnAtribuicao._TamanhoComponente = 164;
            this.btnAtribuicao._TamanhoMaiorLabel = 0;
            this.btnAtribuicao._Visible = false;
            this.btnAtribuicao.Base = null;
            this.btnAtribuicao.Location = new System.Drawing.Point(445, 1);
            this.btnAtribuicao.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnAtribuicao.Name = "btnAtribuicao";
            this.btnAtribuicao.Size = new System.Drawing.Size(164, 24);
            this.btnAtribuicao.TabIndex = 25;
            this.btnAtribuicao._btnHlpClick += new System.EventHandler(this.btnAtribuicao_Click);
            // 
            // btnAumentoPreco
            // 
            this.btnAumentoPreco._LabelGroup = null;
            this.btnAumentoPreco._LabelText = "Alteração no preço de venda/custo do produto";
            this.btnAumentoPreco._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnAumentoPreco._Regex = null;
            this.btnAumentoPreco._TamanhoComponente = 267;
            this.btnAumentoPreco._TamanhoMaiorLabel = 0;
            this.btnAumentoPreco._Visible = false;
            this.btnAumentoPreco.Base = null;
            this.btnAumentoPreco.Location = new System.Drawing.Point(172, 1);
            this.btnAumentoPreco.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnAumentoPreco.Name = "btnAumentoPreco";
            this.btnAumentoPreco.Size = new System.Drawing.Size(267, 24);
            this.btnAumentoPreco.TabIndex = 24;
            this.btnAumentoPreco._btnHlpClick += new System.EventHandler(this.btnAumentoPreco_Click);
            // 
            // btnInserir
            // 
            this.btnInserir._LabelGroup = null;
            this.btnInserir._LabelText = "Carregar todos os produtos";
            this.btnInserir._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnInserir._Regex = null;
            this.btnInserir._TamanhoComponente = 164;
            this.btnInserir._TamanhoMaiorLabel = 0;
            this.btnInserir._Visible = false;
            this.btnInserir.Base = null;
            this.btnInserir.Location = new System.Drawing.Point(2, 1);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(164, 24);
            this.btnInserir.TabIndex = 23;
            this.btnInserir._btnHlpClick += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.Altera = false;
            this.dgvItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.cm = null;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.idUnidadeMedida,
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
            this.dgvItens.DragDropLinha = false;
            this.dgvItens.Exclui = false;
            this.dgvItens.Inclui = false;
            this.dgvItens.Location = new System.Drawing.Point(0, 26);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(1085, 191);
            this.dgvItens.TabIndex = 22;
            this.dgvItens.Tag = "Lista_preco";
            this.dgvItens.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellEndEdit);
            // 
            // idProduto
            // 
            this.idProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProduto.DataPropertyName = "idProduto";
            this.idProduto.HeaderText = "Produto";
            this.idProduto.Name = "idProduto";
            this.idProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProduto.ToolTipText = "Nome do Produto informado no cadastro de produtos";
            this.idProduto.Width = 79;
            // 
            // idUnidadeMedida
            // 
            this.idUnidadeMedida.DataPropertyName = "idUnidadeMedida";
            this.idUnidadeMedida.HeaderText = "Un. de Medida";
            this.idUnidadeMedida.Name = "idUnidadeMedida";
            this.idUnidadeMedida.ToolTipText = "Informação sobre a unidade padrão do produto";
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
            this.vCustoProduto.ToolTipText = "Campo informa o valor de custo do produto";
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
            this.pDesconto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pDesconto.ToolTipText = "Informar um valor de desconto a ser agregado no valor de vendas";
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
            this.pComissao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissao.ToolTipText = "Este campo serve para que o usuário defina o % de comissão que será aplicado ao p" +
    "reço de custo do produto, interferindo assim no cálculo do preço de venda";
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
            this.pOutros.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOutros.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOutros.ToolTipText = "Este campo serve para que o usuário defina a % de outros indicadores que será apl" +
    "icado ao preço de venda do produto, pode ser inserido vários indicadores no mesm" +
    "o campo";
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
            this.pLucro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pLucro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pLucro.ToolTipText = "Este campo serve para que o usuário defina o % de margem de lucro desejado que se" +
    "rá aplicado ao preço de custo do produto";
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
            this.vVenda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vVenda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vVenda.ToolTipText = "Valor final do preço de vendas";
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
            this.pDescontoMaximo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pDescontoMaximo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pDescontoMaximo.ToolTipText = "Informar o valor de Desconto Máximo, quando não preenchido o sistema deixará semp" +
    "re dar desconto de 100%";
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
            this.pAcrescimoMaximo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAcrescimoMaximo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAcrescimoMaximo.ToolTipText = "Informar o valor de acréscimo máximo que o usuário poderá dar no valor do produto" +
    ", caso não esteja preenchido o sistema não tratará o campo e o valor será libera" +
    "do para acréscimo";
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
            this.pComissaoAvista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAvista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAvista.ToolTipText = "Inserir a alíquota de comissão quando a condição de pagamento for A vista";
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
            this.pComissaoAprazo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAprazo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAprazo.ToolTipText = "Inserir a alíquota de comissão quando a condição de pagamento for A prazo";
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
            // kryptonTabControl2
            // 
            this.kryptonTabControl2.AllowCloseButton = false;
            this.kryptonTabControl2.AllowContextButton = false;
            this.kryptonTabControl2.AllowNavigatorButtons = false;
            this.kryptonTabControl2.AllowSelectedTabHigh = false;
            this.kryptonTabControl2.BorderWidth = 1;
            this.kryptonTabControl2.Controls.Add(this.tabPage3);
            this.kryptonTabControl2.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl2.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl2.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl2.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(3, 288);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(1093, 246);
            this.kryptonTabControl2.TabIndex = 2;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 285);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1093, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // sep_Geral
            // 
            this.sep_Geral._LabelText = "Geral";
            this.sep_Geral._TamanhoMaiorLabel = 0;
            this.sep_Geral.BackColor = System.Drawing.Color.Transparent;
            this.sep_Geral.Location = new System.Drawing.Point(3, 3);
            this.sep_Geral.Name = "sep_Geral";
            this.sep_Geral.Size = new System.Drawing.Size(517, 18);
            this.sep_Geral.TabIndex = 22;
            this.sep_Geral.TabStop = false;
            // 
            // FormListaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 588);
            this.Name = "FormListaPreco";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Lista de Preço";
            this.Load += new System.EventHandler(this.FormListaPreco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsListaPreco)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.kryptonTabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxCodigoListaPreco;
        private Comum.Components.HLP_TextBox txtxLista;
        private System.Windows.Forms.BindingSource bsListaPreco;
        private Comum.Components.HLP_TextBox txtdListaPreco;
        private Comum.Components.HLP_ComboBox cbostAtualizacao;
        private Comum.Components.HLP_NumericUpDown nudnDiasSemAtualicao;
        private Comum.Components.HLP_ComboBox cboAtivo;
        private Comum.Components.HLP_ComboBox cbostContrato;
        private Comum.Components.HLP_TextBox txtxNrContrato;
        private Comum.Components.HLP_DateTimePicker dtpdValidadeContrato;
        private Comum.Components.HLP_NumericUpDown nudpDescontoMaximo;
        private Comum.Components.HLP_NumericUpDown nudpAcressimoMaximo;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.Splitter splitter1;
        private Comum.Components.HLP_TextBox txtpPercentual;
        private HLP_DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUnidadeMedida;
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
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidListaPrecoOrigem;
        private HLP_Button btnGerar;
        private HLP_Button btnInserir;
        private HLP_Button btnAumentoPreco;
        private HLP_Button btnAtribuicao;
        private HLP_LabelSeparator sep_Geral;
    }
}