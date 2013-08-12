using HLP.Comum.Components;
namespace HLP.UI.Entries.RecursosHumanos
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Identificacao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtCodigo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCodigoAlternativo = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSaudacao = new HLP.Comum.Components.HLP_TextBox();
            this.txtxNome = new HLP.Comum.Components.HLP_TextBox();
            this.cbxAtivo = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidCargo = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_Pesquisa_idDepartamento = new HLP.Comum.Components.HLP_Pesquisa();
            this.sp_administracao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbxstPerfil = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidCalendário = new HLP.Comum.Components.HLP_Pesquisa();
            this.sp_reqCompras = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxInformacaoAtencao = new HLP.Comum.Components.HLP_TextBox();
            this.hlP_PesquisaidSite = new HLP.Comum.Components.HLP_Pesquisa();
            this.hlP_PesquisaidDeposito = new HLP.Comum.Components.HLP_Pesquisa();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEndereco = new HLP.Comum.Components.HLP_DataGridView();
            this.stPrincipal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stTipoEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xEnderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCepDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.xNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xComplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xBairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFusoHorarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xCaixaPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsFuncionarioEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_InfPessoal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.mskxCpf = new HLP.Comum.Components.HLP_MaskedTextBox();
            this.txtxRg = new HLP.Comum.Components.HLP_TextBox();
            this.txtxConjugue = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFilhos = new HLP.Comum.Components.HLP_TextBox();
            this.dtdAniversario = new HLP.Comum.Components.HLP_DateTimePicker();
            this.cbxstSexo = new HLP.Comum.Components.HLP_ComboBox();
            this.dtdFalecimento = new HLP.Comum.Components.HLP_DateTimePicker();
            this.hlP_PesquisaidContaBancaria = new HLP.Comum.Components.HLP_Pesquisa();
            this.spVisto = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxVisto = new HLP.Comum.Components.HLP_TextBox();
            this.txtxVistoTrabalho = new HLP.Comum.Components.HLP_TextBox();
            this.dtdFinalVisto = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdFinalVistoTrabalho = new HLP.Comum.Components.HLP_DateTimePicker();
            this.sp_deptoPessoal = new HLP.Comum.Components.HLP_LabelSeparator();
            this.nudvDiaria = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudvSalario = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudvSalarioHora = new HLP.Comum.Components.HLP_NumericUpDown();
            this.dtdAdmissao = new HLP.Comum.Components.HLP_DateTimePicker();
            this.cbxstSalario = new HLP.Comum.Components.HLP_ComboBox();
            this.hlP_PesquisaidResponsavel = new HLP.Comum.Components.HLP_Pesquisa();
            this.sp_qtdehorastrab = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtTotalHorasTab = new HLP.Comum.Components.HLP_TextBox();
            this.dtdQtdHorasSegunda = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdQtdHorasTerca = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdQtdHorasQuarta = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdQtdHorasQuinta = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdQtdHorasSexta = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdQtdHorasSabado = new HLP.Comum.Components.HLP_DateTimePicker();
            this.dtdQtdHorasDomingo = new HLP.Comum.Components.HLP_DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.sp_Comercial = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxTelefoneComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxRamalComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCelularComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxRadioFoneComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxPagerComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxFaxComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxEmailComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSkypeComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxMSNComercial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxhttpComercial = new HLP.Comum.Components.HLP_TextBox();
            this.sp_Residencial = new HLP.Comum.Components.HLP_LabelSeparator();
            this.txtxTelefoneResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxCelularResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxRadioFoneResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxEmailResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxSkypeResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtxMsnResidencial = new HLP.Comum.Components.HLP_TextBox();
            this.txtXhttpPessoal = new HLP.Comum.Components.HLP_TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.kryptonPanel6 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView1 = new HLP.Comum.Components.HLP_DataGridView();
            this.stCertificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.xCertificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMemorandoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dConclusaoDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.dValidadeDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.bsFuncionarioCertificacao = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.kryptonTabControl3 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.dgvFuncionario_Comissao_Produto = new HLP.Comum.Components.HLP_DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pComissaoAvistaDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pComissaoAprazoDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsFuncionarioComissaoProduto = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonPanel9 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnAplicarComissao = new HLP.Comum.Components.HLP_Button();
            this.btnCarregarProdutos = new HLP.Comum.Components.HLP_Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.kryptonTabControl2 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new AC.ExtendedRenderer.Toolkit.KryptonPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.spComissao = new HLP.Comum.Components.HLP_LabelSeparator();
            this.cbxstComissao = new HLP.Comum.Components.HLP_ComboBox();
            this.nudpComissaoAvista = new HLP.Comum.Components.HLP_NumericUpDown();
            this.nudpComissaoAprazo = new HLP.Comum.Components.HLP_NumericUpDown();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView2 = new HLP.Comum.Components.HLP_DataGridView();
            this.pDeMargemVendaDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pAteMargemVendaDataGridViewTextBoxColumn = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pComissaoAvistaDataGridViewTextBoxColumn1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.pComissaoAprazoDataGridViewTextBoxColumn1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.bsFuncionarioMargemLucroComissao = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgvArquivos = new HLP.Comum.Components.HLP_DataGridView();
            this.xArquivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFuncionarioArquivo = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.kryptonPanel8 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.treeHierarquia = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonDataGridViewDateTimePickerColumn1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonDataGridViewDateTimePickerColumn2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonDataGridViewDateTimePickerColumn3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.kryptonDataGridViewDateTimePickerColumn4 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).BeginInit();
            this.panelPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioEndereco)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioCertificacao)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.kryptonTabControl3.SuspendLayout();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario_Comissao_Produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioComissaoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).BeginInit();
            this.kryptonPanel9.SuspendLayout();
            this.kryptonTabControl2.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.kryptonPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioMargemLucroComissao)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioArquivo)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).BeginInit();
            this.kryptonPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1068, 534);
            // 
            // panelPadrao
            // 
            this.panelPadrao.Controls.Add(this.kryptonTabControl1);
            this.panelPadrao.Size = new System.Drawing.Size(1066, 510);
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 27);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(1068, 534);
            this.kryptonPanel.TabIndex = 0;
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
            this.kryptonTabControl1.Controls.Add(this.tabPage3);
            this.kryptonTabControl1.Controls.Add(this.tabPage4);
            this.kryptonTabControl1.Controls.Add(this.tabPage5);
            this.kryptonTabControl1.Controls.Add(this.tabPage6);
            this.kryptonTabControl1.Controls.Add(this.tabPage7);
            this.kryptonTabControl1.Controls.Add(this.tabPage8);
            this.kryptonTabControl1.Controls.Add(this.tabPage9);
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
            this.kryptonTabControl1.Size = new System.Drawing.Size(1060, 504);
            this.kryptonTabControl1.TabIndex = 2;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.kryptonPanel7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1052, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Geral";
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Controls.Add(this.flowLayoutPanel1);
            this.kryptonPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel7.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(1052, 475);
            this.kryptonPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.sp_Identificacao);
            this.flowLayoutPanel1.Controls.Add(this.txtCodigo);
            this.flowLayoutPanel1.Controls.Add(this.txtxCodigoAlternativo);
            this.flowLayoutPanel1.Controls.Add(this.txtxSaudacao);
            this.flowLayoutPanel1.Controls.Add(this.txtxNome);
            this.flowLayoutPanel1.Controls.Add(this.cbxAtivo);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidCargo);
            this.flowLayoutPanel1.Controls.Add(this.hlP_Pesquisa_idDepartamento);
            this.flowLayoutPanel1.Controls.Add(this.sp_administracao);
            this.flowLayoutPanel1.Controls.Add(this.cbxstPerfil);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidCalendário);
            this.flowLayoutPanel1.Controls.Add(this.sp_reqCompras);
            this.flowLayoutPanel1.Controls.Add(this.txtxInformacaoAtencao);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidSite);
            this.flowLayoutPanel1.Controls.Add(this.hlP_PesquisaidDeposito);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1052, 475);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Tag = "Principal";
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // sp_Identificacao
            // 
            this.sp_Identificacao._LabelText = "Identificação";
            this.sp_Identificacao._TamanhoMaiorLabel = 0;
            this.sp_Identificacao.BackColor = System.Drawing.Color.Transparent;
            this.sp_Identificacao.Location = new System.Drawing.Point(0, 3);
            this.sp_Identificacao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Identificacao.Name = "sp_Identificacao";
            this.sp_Identificacao.Size = new System.Drawing.Size(565, 19);
            this.sp_Identificacao.TabIndex = 24;
            this.sp_Identificacao.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo._Field = "idFuncionario";
            this.txtCodigo._LabelGroup = this.sp_Identificacao;
            this.txtCodigo._LabelText = "Código";
            this.txtCodigo._Multiline = false;
            this.txtCodigo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtCodigo._Password = false;
            this.txtCodigo._Regex = null;
            this.txtCodigo._Table = "Funcionario";
            this.txtCodigo._TamanhoComponente = 132;
            this.txtCodigo._TamanhoMaiorLabel = 150;
            this.txtCodigo._Visible = false;
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.Base = null;
            this.txtCodigo.bConfiguracao = false;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo.Color = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(108, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(108, 3, 15, 3);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.objConfigComponenteModel = null;
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(177, 24);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtxCodigoAlternativo
            // 
            this.txtxCodigoAlternativo._Field = "xCodigoAlternativo";
            this.txtxCodigoAlternativo._Help = "Digite um código alternativo para o funcionário ";
            this.txtxCodigoAlternativo._LabelGroup = this.sp_Identificacao;
            this.txtxCodigoAlternativo._LabelText = "Codigo alternativo";
            this.txtxCodigoAlternativo._Multiline = false;
            this.txtxCodigoAlternativo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCodigoAlternativo._Password = false;
            this.txtxCodigoAlternativo._Regex = null;
            this.txtxCodigoAlternativo._Table = "Funcionario";
            this.txtxCodigoAlternativo._TamanhoComponente = 157;
            this.txtxCodigoAlternativo._TamanhoMaiorLabel = 150;
            this.txtxCodigoAlternativo._Visible = false;
            this.txtxCodigoAlternativo.BackColor = System.Drawing.Color.Transparent;
            this.txtxCodigoAlternativo.Base = null;
            this.txtxCodigoAlternativo.bConfiguracao = false;
            this.txtxCodigoAlternativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCodigoAlternativo.Color = System.Drawing.Color.White;
            this.txtxCodigoAlternativo.Location = new System.Drawing.Point(50, 58);
            this.txtxCodigoAlternativo.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
            this.txtxCodigoAlternativo.MaxLength = 32767;
            this.txtxCodigoAlternativo.Name = "txtxCodigoAlternativo";
            this.txtxCodigoAlternativo.objConfigComponenteModel = null;
            this.txtxCodigoAlternativo.ReadOnly = false;
            this.txtxCodigoAlternativo.Size = new System.Drawing.Size(260, 24);
            this.txtxCodigoAlternativo.TabIndex = 5;
            // 
            // txtxSaudacao
            // 
            this.txtxSaudacao._Field = "xSaudacao";
            this.txtxSaudacao._Help = "Especifique a forma de saudação preferencial de um funcionário";
            this.txtxSaudacao._LabelGroup = this.sp_Identificacao;
            this.txtxSaudacao._LabelText = "Saudacao";
            this.txtxSaudacao._Multiline = false;
            this.txtxSaudacao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSaudacao._Password = false;
            this.txtxSaudacao._Regex = null;
            this.txtxSaudacao._Table = "Funcionario";
            this.txtxSaudacao._TamanhoComponente = 412;
            this.txtxSaudacao._TamanhoMaiorLabel = 150;
            this.txtxSaudacao._Visible = false;
            this.txtxSaudacao.BackColor = System.Drawing.Color.Transparent;
            this.txtxSaudacao.Base = null;
            this.txtxSaudacao.bConfiguracao = false;
            this.txtxSaudacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSaudacao.Color = System.Drawing.Color.White;
            this.txtxSaudacao.Location = new System.Drawing.Point(96, 88);
            this.txtxSaudacao.Margin = new System.Windows.Forms.Padding(96, 3, 15, 3);
            this.txtxSaudacao.MaxLength = 32767;
            this.txtxSaudacao.Name = "txtxSaudacao";
            this.txtxSaudacao.objConfigComponenteModel = null;
            this.txtxSaudacao.ReadOnly = false;
            this.txtxSaudacao.Size = new System.Drawing.Size(469, 24);
            this.txtxSaudacao.TabIndex = 6;
            // 
            // txtxNome
            // 
            this.txtxNome._Field = "xNome";
            this.txtxNome._Help = "Informe o nome do funcionário";
            this.txtxNome._LabelGroup = this.sp_Identificacao;
            this.txtxNome._LabelText = "Nome";
            this.txtxNome._Multiline = false;
            this.txtxNome._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxNome._Password = false;
            this.txtxNome._Regex = null;
            this.txtxNome._Table = "Funcionario";
            this.txtxNome._TamanhoComponente = 390;
            this.txtxNome._TamanhoMaiorLabel = 150;
            this.txtxNome._Visible = false;
            this.txtxNome.BackColor = System.Drawing.Color.Transparent;
            this.txtxNome.Base = null;
            this.txtxNome.bConfiguracao = false;
            this.txtxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxNome.Color = System.Drawing.Color.White;
            this.txtxNome.Location = new System.Drawing.Point(116, 118);
            this.txtxNome.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxNome.MaxLength = 32767;
            this.txtxNome.Name = "txtxNome";
            this.txtxNome.objConfigComponenteModel = null;
            this.txtxNome.ReadOnly = false;
            this.txtxNome.Size = new System.Drawing.Size(427, 24);
            this.txtxNome.TabIndex = 30;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo._Field = "Ativo";
            this.cbxAtivo._Help = "Informe o status do funcionário, se ele está ativo ou não para a empresa";
            this.cbxAtivo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxAtivo._Itens")));
            this.cbxAtivo._LabelGroup = this.sp_Identificacao;
            this.cbxAtivo._LabelText = "Ativo";
            this.cbxAtivo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxAtivo._Regex = null;
            this.cbxAtivo._situacao = true;
            this.cbxAtivo._Table = "Funcionario";
            this.cbxAtivo._TamanhoComponente = 80;
            this.cbxAtivo._TamanhoMaiorLabel = 150;
            this.cbxAtivo._Visible = false;
            this.cbxAtivo.BackColor = System.Drawing.Color.Transparent;
            this.cbxAtivo.Base = null;
            this.cbxAtivo.bConfiguracao = false;
            this.cbxAtivo.Color = System.Drawing.Color.White;
            this.cbxAtivo.DataSource = null;
            this.cbxAtivo.DisplayMember = "DisplayMember";
            this.cbxAtivo.Location = new System.Drawing.Point(120, 148);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(120, 3, 15, 3);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.objConfigComponenteModel = null;
            this.cbxAtivo.SelectedIndex = -1;
            this.cbxAtivo.SelectedValue = 0;
            this.cbxAtivo.Size = new System.Drawing.Size(113, 21);
            this.cbxAtivo.TabIndex = 16;
            this.cbxAtivo.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidCargo
            // 
            this.hlP_PesquisaidCargo._Field = "idCargo";
            this.hlP_PesquisaidCargo._Help = "Informe o cargo do funcionário";
            this.hlP_PesquisaidCargo._LabelGroup = this.sp_Identificacao;
            this.hlP_PesquisaidCargo._LabelText = "Cargo";
            this.hlP_PesquisaidCargo._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCargo._ListaCamposDisplay")));
            this.hlP_PesquisaidCargo._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCargo._ListaValoresDisplay")));
            this.hlP_PesquisaidCargo._NomeCampoPK = "ID";
            this.hlP_PesquisaidCargo._NomeFormCadastroOriginal = "FormCargo";
            this.hlP_PesquisaidCargo._NomeView = "vwCargo";
            this.hlP_PesquisaidCargo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCargo._Regex = null;
            this.hlP_PesquisaidCargo._Table = "Funcionario";
            this.hlP_PesquisaidCargo._TamanhoComponente = 300;
            this.hlP_PesquisaidCargo._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidCargo._Vinculado = false;
            this.hlP_PesquisaidCargo._Visible = false;
            this.hlP_PesquisaidCargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCargo.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCargo.Base = null;
            this.hlP_PesquisaidCargo.bConfiguracao = false;
            this.hlP_PesquisaidCargo.Location = new System.Drawing.Point(115, 175);
            this.hlP_PesquisaidCargo.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.hlP_PesquisaidCargo.Name = "hlP_PesquisaidCargo";
            this.hlP_PesquisaidCargo.objConfigComponenteModel = null;
            this.hlP_PesquisaidCargo.ReadOnly = false;
            this.hlP_PesquisaidCargo.Size = new System.Drawing.Size(338, 21);
            this.hlP_PesquisaidCargo.TabIndex = 32;
            this.hlP_PesquisaidCargo.Value = 0;
            // 
            // hlP_Pesquisa_idDepartamento
            // 
            this.hlP_Pesquisa_idDepartamento._Field = "idDepartamento";
            this.hlP_Pesquisa_idDepartamento._Help = "Informar o departamento do funcionário";
            this.hlP_Pesquisa_idDepartamento._LabelGroup = this.sp_Identificacao;
            this.hlP_Pesquisa_idDepartamento._LabelText = "Departamento";
            this.hlP_Pesquisa_idDepartamento._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_Pesquisa_idDepartamento._ListaCamposDisplay")));
            this.hlP_Pesquisa_idDepartamento._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_Pesquisa_idDepartamento._ListaValoresDisplay")));
            this.hlP_Pesquisa_idDepartamento._NomeCampoPK = "ID";
            this.hlP_Pesquisa_idDepartamento._NomeFormCadastroOriginal = "FormDepartamento";
            this.hlP_Pesquisa_idDepartamento._NomeView = "vwDepartamento";
            this.hlP_Pesquisa_idDepartamento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_Pesquisa_idDepartamento._Regex = null;
            this.hlP_Pesquisa_idDepartamento._Table = "Funcionario";
            this.hlP_Pesquisa_idDepartamento._TamanhoComponente = 300;
            this.hlP_Pesquisa_idDepartamento._TamanhoMaiorLabel = 150;
            this.hlP_Pesquisa_idDepartamento._Vinculado = false;
            this.hlP_Pesquisa_idDepartamento._Visible = false;
            this.hlP_Pesquisa_idDepartamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_Pesquisa_idDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.hlP_Pesquisa_idDepartamento.Base = null;
            this.hlP_Pesquisa_idDepartamento.bConfiguracao = false;
            this.hlP_Pesquisa_idDepartamento.Location = new System.Drawing.Point(72, 202);
            this.hlP_Pesquisa_idDepartamento.Margin = new System.Windows.Forms.Padding(72, 3, 15, 3);
            this.hlP_Pesquisa_idDepartamento.Name = "hlP_Pesquisa_idDepartamento";
            this.hlP_Pesquisa_idDepartamento.objConfigComponenteModel = null;
            this.hlP_Pesquisa_idDepartamento.ReadOnly = false;
            this.hlP_Pesquisa_idDepartamento.Size = new System.Drawing.Size(381, 21);
            this.hlP_Pesquisa_idDepartamento.TabIndex = 38;
            this.hlP_Pesquisa_idDepartamento.Value = 0;
            // 
            // sp_administracao
            // 
            this.sp_administracao._LabelText = "Identificação";
            this.sp_administracao._TamanhoMaiorLabel = 0;
            this.sp_administracao.BackColor = System.Drawing.Color.Transparent;
            this.sp_administracao.Location = new System.Drawing.Point(0, 229);
            this.sp_administracao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_administracao.Name = "sp_administracao";
            this.sp_administracao.Size = new System.Drawing.Size(565, 19);
            this.sp_administracao.TabIndex = 36;
            this.sp_administracao.TabStop = false;
            // 
            // cbxstPerfil
            // 
            this.cbxstPerfil._Field = "stPerfil";
            this.cbxstPerfil._Help = "Informe o tipo de perfil do funcionário sendo";
            this.cbxstPerfil._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstPerfil._Itens")));
            this.cbxstPerfil._LabelGroup = this.sp_administracao;
            this.cbxstPerfil._LabelText = "Perfil do usuário";
            this.cbxstPerfil._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstPerfil._Regex = null;
            this.cbxstPerfil._situacao = false;
            this.cbxstPerfil._Table = "Funcionario";
            this.cbxstPerfil._TamanhoComponente = 194;
            this.cbxstPerfil._TamanhoMaiorLabel = 150;
            this.cbxstPerfil._Visible = false;
            this.cbxstPerfil.BackColor = System.Drawing.Color.Transparent;
            this.cbxstPerfil.Base = null;
            this.cbxstPerfil.bConfiguracao = false;
            this.cbxstPerfil.Color = System.Drawing.Color.White;
            this.cbxstPerfil.DataSource = null;
            this.cbxstPerfil.DisplayMember = "DisplayMember";
            this.cbxstPerfil.Location = new System.Drawing.Point(61, 254);
            this.cbxstPerfil.Margin = new System.Windows.Forms.Padding(61, 3, 15, 3);
            this.cbxstPerfil.Name = "cbxstPerfil";
            this.cbxstPerfil.objConfigComponenteModel = null;
            this.cbxstPerfil.SelectedIndex = -1;
            this.cbxstPerfil.SelectedValue = 0;
            this.cbxstPerfil.Size = new System.Drawing.Size(286, 21);
            this.cbxstPerfil.TabIndex = 19;
            this.cbxstPerfil.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidCalendário
            // 
            this.hlP_PesquisaidCalendário._Field = "idCalendario";
            this.hlP_PesquisaidCalendário._Help = "Informe um tipo de calendário para o funcionário.";
            this.hlP_PesquisaidCalendário._LabelGroup = this.sp_administracao;
            this.hlP_PesquisaidCalendário._LabelText = "Calendário";
            this.hlP_PesquisaidCalendário._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCalendário._ListaCamposDisplay")));
            this.hlP_PesquisaidCalendário._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidCalendário._ListaValoresDisplay")));
            this.hlP_PesquisaidCalendário._NomeCampoPK = "ID";
            this.hlP_PesquisaidCalendário._NomeFormCadastroOriginal = "FormCalendario";
            this.hlP_PesquisaidCalendário._NomeView = "vwCalendario";
            this.hlP_PesquisaidCalendário._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidCalendário._Regex = null;
            this.hlP_PesquisaidCalendário._Table = "Funcionario";
            this.hlP_PesquisaidCalendário._TamanhoComponente = 300;
            this.hlP_PesquisaidCalendário._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidCalendário._Vinculado = false;
            this.hlP_PesquisaidCalendário._Visible = false;
            this.hlP_PesquisaidCalendário.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidCalendário.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidCalendário.Base = null;
            this.hlP_PesquisaidCalendário.bConfiguracao = false;
            this.hlP_PesquisaidCalendário.Location = new System.Drawing.Point(90, 281);
            this.hlP_PesquisaidCalendário.Margin = new System.Windows.Forms.Padding(90, 3, 15, 3);
            this.hlP_PesquisaidCalendário.Name = "hlP_PesquisaidCalendário";
            this.hlP_PesquisaidCalendário.objConfigComponenteModel = null;
            this.hlP_PesquisaidCalendário.ReadOnly = false;
            this.hlP_PesquisaidCalendário.Size = new System.Drawing.Size(363, 21);
            this.hlP_PesquisaidCalendário.TabIndex = 33;
            this.hlP_PesquisaidCalendário.Value = 0;
            // 
            // sp_reqCompras
            // 
            this.sp_reqCompras._LabelText = "Requisição de compras";
            this.sp_reqCompras._TamanhoMaiorLabel = 0;
            this.sp_reqCompras.BackColor = System.Drawing.Color.Transparent;
            this.sp_reqCompras.Location = new System.Drawing.Point(0, 308);
            this.sp_reqCompras.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_reqCompras.Name = "sp_reqCompras";
            this.sp_reqCompras.Size = new System.Drawing.Size(565, 19);
            this.sp_reqCompras.TabIndex = 37;
            this.sp_reqCompras.TabStop = false;
            // 
            // txtxInformacaoAtencao
            // 
            this.txtxInformacaoAtencao._Field = "xInformacaoAtencao";
            this.txtxInformacaoAtencao._Help = "Insira informações sobre endereço de entrega adicional para um funcionário como, " +
    "por exemplo, localização do escritório";
            this.txtxInformacaoAtencao._LabelGroup = this.sp_reqCompras;
            this.txtxInformacaoAtencao._LabelText = "Informação de atenção";
            this.txtxInformacaoAtencao._Multiline = false;
            this.txtxInformacaoAtencao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxInformacaoAtencao._Password = false;
            this.txtxInformacaoAtencao._Regex = null;
            this.txtxInformacaoAtencao._Table = "Funcionario";
            this.txtxInformacaoAtencao._TamanhoComponente = 100;
            this.txtxInformacaoAtencao._TamanhoMaiorLabel = 150;
            this.txtxInformacaoAtencao._Visible = false;
            this.txtxInformacaoAtencao.BackColor = System.Drawing.Color.Transparent;
            this.txtxInformacaoAtencao.Base = null;
            this.txtxInformacaoAtencao.bConfiguracao = false;
            this.txtxInformacaoAtencao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxInformacaoAtencao.Color = System.Drawing.Color.White;
            this.txtxInformacaoAtencao.Location = new System.Drawing.Point(28, 333);
            this.txtxInformacaoAtencao.Margin = new System.Windows.Forms.Padding(28, 3, 15, 3);
            this.txtxInformacaoAtencao.MaxLength = 32767;
            this.txtxInformacaoAtencao.Name = "txtxInformacaoAtencao";
            this.txtxInformacaoAtencao.objConfigComponenteModel = null;
            this.txtxInformacaoAtencao.ReadOnly = false;
            this.txtxInformacaoAtencao.Size = new System.Drawing.Size(225, 24);
            this.txtxInformacaoAtencao.TabIndex = 7;
            // 
            // hlP_PesquisaidSite
            // 
            this.hlP_PesquisaidSite._Field = "idSite";
            this.hlP_PesquisaidSite._Help = "Selecione um site";
            this.hlP_PesquisaidSite._LabelGroup = this.sp_reqCompras;
            this.hlP_PesquisaidSite._LabelText = "Site padrão";
            this.hlP_PesquisaidSite._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidSite._ListaCamposDisplay")));
            this.hlP_PesquisaidSite._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidSite._ListaValoresDisplay")));
            this.hlP_PesquisaidSite._NomeCampoPK = "ID";
            this.hlP_PesquisaidSite._NomeFormCadastroOriginal = "FormSite";
            this.hlP_PesquisaidSite._NomeView = "vwSite";
            this.hlP_PesquisaidSite._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidSite._Regex = null;
            this.hlP_PesquisaidSite._Table = "Funcionario";
            this.hlP_PesquisaidSite._TamanhoComponente = 300;
            this.hlP_PesquisaidSite._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidSite._Vinculado = false;
            this.hlP_PesquisaidSite._Visible = false;
            this.hlP_PesquisaidSite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidSite.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidSite.Base = null;
            this.hlP_PesquisaidSite.bConfiguracao = false;
            this.hlP_PesquisaidSite.Location = new System.Drawing.Point(87, 363);
            this.hlP_PesquisaidSite.Margin = new System.Windows.Forms.Padding(87, 3, 15, 3);
            this.hlP_PesquisaidSite.Name = "hlP_PesquisaidSite";
            this.hlP_PesquisaidSite.objConfigComponenteModel = null;
            this.hlP_PesquisaidSite.ReadOnly = false;
            this.hlP_PesquisaidSite.Size = new System.Drawing.Size(366, 21);
            this.hlP_PesquisaidSite.TabIndex = 34;
            this.hlP_PesquisaidSite.Value = 0;
            // 
            // hlP_PesquisaidDeposito
            // 
            this.hlP_PesquisaidDeposito._Field = "idDeposito";
            this.hlP_PesquisaidDeposito._Help = "Selecione um depósito";
            this.hlP_PesquisaidDeposito._LabelGroup = this.sp_reqCompras;
            this.hlP_PesquisaidDeposito._LabelText = "Depósito";
            this.hlP_PesquisaidDeposito._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDeposito._ListaCamposDisplay")));
            this.hlP_PesquisaidDeposito._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidDeposito._ListaValoresDisplay")));
            this.hlP_PesquisaidDeposito._NomeCampoPK = "ID";
            this.hlP_PesquisaidDeposito._NomeFormCadastroOriginal = "FormDeposito";
            this.hlP_PesquisaidDeposito._NomeView = "vwDeposito";
            this.hlP_PesquisaidDeposito._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidDeposito._Regex = null;
            this.hlP_PesquisaidDeposito._Table = "Funcionario";
            this.hlP_PesquisaidDeposito._TamanhoComponente = 300;
            this.hlP_PesquisaidDeposito._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidDeposito._Vinculado = false;
            this.hlP_PesquisaidDeposito._Visible = false;
            this.hlP_PesquisaidDeposito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidDeposito.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidDeposito.Base = null;
            this.hlP_PesquisaidDeposito.bConfiguracao = false;
            this.hlP_PesquisaidDeposito.Location = new System.Drawing.Point(99, 390);
            this.hlP_PesquisaidDeposito.Margin = new System.Windows.Forms.Padding(99, 3, 15, 3);
            this.hlP_PesquisaidDeposito.Name = "hlP_PesquisaidDeposito";
            this.hlP_PesquisaidDeposito.objConfigComponenteModel = null;
            this.hlP_PesquisaidDeposito.ReadOnly = false;
            this.hlP_PesquisaidDeposito.Size = new System.Drawing.Size(354, 21);
            this.hlP_PesquisaidDeposito.TabIndex = 35;
            this.hlP_PesquisaidDeposito.Value = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEndereco);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1052, 475);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Tag = false;
            this.tabPage2.Text = "Endereço";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.Altera = false;
            this.dgvEndereco.AutoGenerateColumns = false;
            this.dgvEndereco.cm = null;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stPrincipal,
            this.xNome,
            this.stTipoEnderecoDataGridViewTextBoxColumn,
            this.xEnderecoDataGridViewTextBoxColumn,
            this.xCepDataGridViewTextBoxColumn,
            this.xNumeroDataGridViewTextBoxColumn,
            this.xComplementoDataGridViewTextBoxColumn,
            this.xBairroDataGridViewTextBoxColumn,
            this.xLatitudeDataGridViewTextBoxColumn,
            this.xLongitudeDataGridViewTextBoxColumn,
            this.xFusoHorarioDataGridViewTextBoxColumn,
            this.xCaixaPostalDataGridViewTextBoxColumn,
            this.idCidade});
            this.dgvEndereco.DataSource = this.bsFuncionarioEndereco;
            this.dgvEndereco.DragDropLinha = false;
            this.dgvEndereco.Exclui = false;
            this.dgvEndereco.Inclui = false;
            this.dgvEndereco.Location = new System.Drawing.Point(0, 0);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.Size = new System.Drawing.Size(1052, 475);
            this.dgvEndereco.TabIndex = 0;
            this.dgvEndereco.Tag = "Funcionario_Endereco";
            // 
            // stPrincipal
            // 
            this.stPrincipal.DataPropertyName = "stPrincipal";
            this.stPrincipal.HeaderText = "Principal";
            this.stPrincipal.Items.AddRange(new object[] {
            "0-NÃO",
            "1-SIM"});
            this.stPrincipal.Name = "stPrincipal";
            this.stPrincipal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stPrincipal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stPrincipal.ToolTipText = "Se esta caixa de seleção estiver selecionada, o endereço será o endereço principa" +
    "l para o funcionário";
            this.stPrincipal.Width = 120;
            // 
            // xNome
            // 
            this.xNome.DataPropertyName = "xNome";
            this.xNome.HeaderText = "Nome";
            this.xNome.Name = "xNome";
            this.xNome.ToolTipText = "O nome da organização ou pessoa de contato para o endereço selecionado ";
            this.xNome.Width = 150;
            // 
            // stTipoEnderecoDataGridViewTextBoxColumn
            // 
            this.stTipoEnderecoDataGridViewTextBoxColumn.DataPropertyName = "stTipoEndereco";
            this.stTipoEnderecoDataGridViewTextBoxColumn.HeaderText = "Tipo Endereco";
            this.stTipoEnderecoDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "0-COMERCIAL",
            "1-ENTREGA",
            "2-ENTREGA ALT",
            "3-NOTA FISCAL",
            "4-RESIDÊNCIA",
            "5-SERVIÇO",
            "6-SWIFT",
            "PAGAMENTO",
            "9-OUTRO"});
            this.stTipoEnderecoDataGridViewTextBoxColumn.Name = "stTipoEnderecoDataGridViewTextBoxColumn";
            this.stTipoEnderecoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stTipoEnderecoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stTipoEnderecoDataGridViewTextBoxColumn.ToolTipText = "Especifique como usar o endereço selecionado";
            this.stTipoEnderecoDataGridViewTextBoxColumn.Width = 150;
            // 
            // xEnderecoDataGridViewTextBoxColumn
            // 
            this.xEnderecoDataGridViewTextBoxColumn.DataPropertyName = "xEndereco";
            this.xEnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.xEnderecoDataGridViewTextBoxColumn.Name = "xEnderecoDataGridViewTextBoxColumn";
            this.xEnderecoDataGridViewTextBoxColumn.ToolTipText = "Informar o Endereço do funcionario";
            // 
            // xCepDataGridViewTextBoxColumn
            // 
            this.xCepDataGridViewTextBoxColumn.DataPropertyName = "xCep";
            this.xCepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.xCepDataGridViewTextBoxColumn.Mask = "00000-000";
            this.xCepDataGridViewTextBoxColumn.Name = "xCepDataGridViewTextBoxColumn";
            this.xCepDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xCepDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xCepDataGridViewTextBoxColumn.ToolTipText = "Informar o Código de Endereçamento Postal principal do funcionário";
            this.xCepDataGridViewTextBoxColumn.Width = 100;
            // 
            // xNumeroDataGridViewTextBoxColumn
            // 
            this.xNumeroDataGridViewTextBoxColumn.DataPropertyName = "xNumero";
            this.xNumeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.xNumeroDataGridViewTextBoxColumn.Name = "xNumeroDataGridViewTextBoxColumn";
            // 
            // xComplementoDataGridViewTextBoxColumn
            // 
            this.xComplementoDataGridViewTextBoxColumn.DataPropertyName = "xComplemento";
            this.xComplementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.xComplementoDataGridViewTextBoxColumn.Name = "xComplementoDataGridViewTextBoxColumn";
            this.xComplementoDataGridViewTextBoxColumn.Width = 110;
            // 
            // xBairroDataGridViewTextBoxColumn
            // 
            this.xBairroDataGridViewTextBoxColumn.DataPropertyName = "xBairro";
            this.xBairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.xBairroDataGridViewTextBoxColumn.Name = "xBairroDataGridViewTextBoxColumn";
            // 
            // xLatitudeDataGridViewTextBoxColumn
            // 
            this.xLatitudeDataGridViewTextBoxColumn.DataPropertyName = "xLatitude";
            this.xLatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.xLatitudeDataGridViewTextBoxColumn.Name = "xLatitudeDataGridViewTextBoxColumn";
            // 
            // xLongitudeDataGridViewTextBoxColumn
            // 
            this.xLongitudeDataGridViewTextBoxColumn.DataPropertyName = "xLongitude";
            this.xLongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.xLongitudeDataGridViewTextBoxColumn.Name = "xLongitudeDataGridViewTextBoxColumn";
            // 
            // xFusoHorarioDataGridViewTextBoxColumn
            // 
            this.xFusoHorarioDataGridViewTextBoxColumn.DataPropertyName = "xFusoHorario";
            this.xFusoHorarioDataGridViewTextBoxColumn.HeaderText = "Fuso Horario";
            this.xFusoHorarioDataGridViewTextBoxColumn.Name = "xFusoHorarioDataGridViewTextBoxColumn";
            this.xFusoHorarioDataGridViewTextBoxColumn.Width = 120;
            // 
            // xCaixaPostalDataGridViewTextBoxColumn
            // 
            this.xCaixaPostalDataGridViewTextBoxColumn.DataPropertyName = "xCaixaPostal";
            this.xCaixaPostalDataGridViewTextBoxColumn.HeaderText = "Caixa Postal";
            this.xCaixaPostalDataGridViewTextBoxColumn.Name = "xCaixaPostalDataGridViewTextBoxColumn";
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "Cidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCidade.Width = 160;
            // 
            // bsFuncionarioEndereco
            // 
            this.bsFuncionarioEndereco.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_EnderecoModel);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.kryptonPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1052, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = false;
            this.tabPage3.Text = "Informações";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.flowLayoutPanel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1052, 475);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.sp_InfPessoal);
            this.flowLayoutPanel2.Controls.Add(this.mskxCpf);
            this.flowLayoutPanel2.Controls.Add(this.txtxRg);
            this.flowLayoutPanel2.Controls.Add(this.txtxConjugue);
            this.flowLayoutPanel2.Controls.Add(this.txtxFilhos);
            this.flowLayoutPanel2.Controls.Add(this.dtdAniversario);
            this.flowLayoutPanel2.Controls.Add(this.cbxstSexo);
            this.flowLayoutPanel2.Controls.Add(this.dtdFalecimento);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidContaBancaria);
            this.flowLayoutPanel2.Controls.Add(this.spVisto);
            this.flowLayoutPanel2.Controls.Add(this.txtxVisto);
            this.flowLayoutPanel2.Controls.Add(this.txtxVistoTrabalho);
            this.flowLayoutPanel2.Controls.Add(this.dtdFinalVisto);
            this.flowLayoutPanel2.Controls.Add(this.dtdFinalVistoTrabalho);
            this.flowLayoutPanel2.Controls.Add(this.sp_deptoPessoal);
            this.flowLayoutPanel2.Controls.Add(this.nudvDiaria);
            this.flowLayoutPanel2.Controls.Add(this.nudvSalario);
            this.flowLayoutPanel2.Controls.Add(this.nudvSalarioHora);
            this.flowLayoutPanel2.Controls.Add(this.dtdAdmissao);
            this.flowLayoutPanel2.Controls.Add(this.cbxstSalario);
            this.flowLayoutPanel2.Controls.Add(this.hlP_PesquisaidResponsavel);
            this.flowLayoutPanel2.Controls.Add(this.sp_qtdehorastrab);
            this.flowLayoutPanel2.Controls.Add(this.txtTotalHorasTab);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasSegunda);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasTerca);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasQuarta);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasQuinta);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasSexta);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasSabado);
            this.flowLayoutPanel2.Controls.Add(this.dtdQtdHorasDomingo);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1046, 475);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // sp_InfPessoal
            // 
            this.sp_InfPessoal._LabelText = "Informações pessoal";
            this.sp_InfPessoal._TamanhoMaiorLabel = 0;
            this.sp_InfPessoal.BackColor = System.Drawing.Color.Transparent;
            this.sp_InfPessoal.Location = new System.Drawing.Point(0, 3);
            this.sp_InfPessoal.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_InfPessoal.Name = "sp_InfPessoal";
            this.sp_InfPessoal.Size = new System.Drawing.Size(573, 19);
            this.sp_InfPessoal.TabIndex = 6;
            this.sp_InfPessoal.TabStop = false;
            // 
            // mskxCpf
            // 
            this.mskxCpf._Field = "xCpf";
            this.mskxCpf._Help = "Informar o cadastro de pessoa física do funcionário";
            this.mskxCpf._LabelGroup = this.sp_InfPessoal;
            this.mskxCpf._LabelText = "Cpf";
            this.mskxCpf._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.mskxCpf._Regex = null;
            this.mskxCpf._Table = "Funcionario";
            this.mskxCpf._TamanhoComponente = 125;
            this.mskxCpf._TamanhoMaiorLabel = 180;
            this.mskxCpf._TpValidacao = HLP.Comum.Components.HLP_MaskedTextBox.TipoValidacao.DEFAULT;
            this.mskxCpf._UF = null;
            this.mskxCpf.BackColor = System.Drawing.Color.Transparent;
            this.mskxCpf.Base = null;
            this.mskxCpf.bConfiguracao = false;
            this.mskxCpf.Color = System.Drawing.Color.White;
            this.mskxCpf.Location = new System.Drawing.Point(158, 28);
            this.mskxCpf.Margin = new System.Windows.Forms.Padding(158, 3, 15, 3);
            this.mskxCpf.Mask = "000,000,000-00";
            this.mskxCpf.MaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskxCpf.MaxLength = 32767;
            this.mskxCpf.Name = "mskxCpf";
            this.mskxCpf.objConfigComponenteModel = null;
            this.mskxCpf.ReadOnly = false;
            this.mskxCpf.Size = new System.Drawing.Size(150, 21);
            this.mskxCpf.TabIndex = 10;
            // 
            // txtxRg
            // 
            this.txtxRg._Field = "xRg";
            this.txtxRg._Help = "Informar o registro geral do funcionário";
            this.txtxRg._LabelGroup = this.sp_InfPessoal;
            this.txtxRg._LabelText = "Rg";
            this.txtxRg._Multiline = false;
            this.txtxRg._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRg._Password = false;
            this.txtxRg._Regex = null;
            this.txtxRg._Table = "Funcionario";
            this.txtxRg._TamanhoComponente = 135;
            this.txtxRg._TamanhoMaiorLabel = 180;
            this.txtxRg.BackColor = System.Drawing.Color.Transparent;
            this.txtxRg.Base = null;
            this.txtxRg.bConfiguracao = false;
            this.txtxRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRg.Color = System.Drawing.Color.White;
            this.txtxRg.Location = new System.Drawing.Point(162, 55);
            this.txtxRg.Margin = new System.Windows.Forms.Padding(162, 3, 15, 3);
            this.txtxRg.MaxLength = 32767;
            this.txtxRg.Name = "txtxRg";
            this.txtxRg.objConfigComponenteModel = null;
            this.txtxRg.ReadOnly = false;
            this.txtxRg.Size = new System.Drawing.Size(156, 21);
            this.txtxRg.TabIndex = 11;
            // 
            // txtxConjugue
            // 
            this.txtxConjugue._Field = "xConjugue";
            this.txtxConjugue._Help = "Informar o nome do conjugue do funcionário, quando houver";
            this.txtxConjugue._LabelGroup = this.sp_InfPessoal;
            this.txtxConjugue._LabelText = "Conjugue";
            this.txtxConjugue._Multiline = false;
            this.txtxConjugue._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxConjugue._Password = false;
            this.txtxConjugue._Regex = null;
            this.txtxConjugue._Table = "Funcionario";
            this.txtxConjugue._TamanhoComponente = 131;
            this.txtxConjugue._TamanhoMaiorLabel = 180;
            this.txtxConjugue.BackColor = System.Drawing.Color.Transparent;
            this.txtxConjugue.Base = null;
            this.txtxConjugue.bConfiguracao = false;
            this.txtxConjugue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxConjugue.Color = System.Drawing.Color.White;
            this.txtxConjugue.Location = new System.Drawing.Point(125, 82);
            this.txtxConjugue.Margin = new System.Windows.Forms.Padding(125, 3, 15, 3);
            this.txtxConjugue.MaxLength = 32767;
            this.txtxConjugue.Name = "txtxConjugue";
            this.txtxConjugue.objConfigComponenteModel = null;
            this.txtxConjugue.ReadOnly = false;
            this.txtxConjugue.Size = new System.Drawing.Size(189, 21);
            this.txtxConjugue.TabIndex = 12;
            // 
            // txtxFilhos
            // 
            this.txtxFilhos._Field = "xFilhos";
            this.txtxFilhos._Help = "Informar o nome dos filhos do funcionário, quando houver.";
            this.txtxFilhos._LabelGroup = this.sp_InfPessoal;
            this.txtxFilhos._LabelText = "Filhos";
            this.txtxFilhos._Multiline = false;
            this.txtxFilhos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFilhos._Password = false;
            this.txtxFilhos._Regex = null;
            this.txtxFilhos._Table = "Funcionario";
            this.txtxFilhos._TamanhoComponente = 132;
            this.txtxFilhos._TamanhoMaiorLabel = 180;
            this.txtxFilhos.BackColor = System.Drawing.Color.Transparent;
            this.txtxFilhos.Base = null;
            this.txtxFilhos.bConfiguracao = false;
            this.txtxFilhos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFilhos.Color = System.Drawing.Color.White;
            this.txtxFilhos.Location = new System.Drawing.Point(145, 109);
            this.txtxFilhos.Margin = new System.Windows.Forms.Padding(145, 3, 15, 3);
            this.txtxFilhos.MaxLength = 32767;
            this.txtxFilhos.Name = "txtxFilhos";
            this.txtxFilhos.objConfigComponenteModel = null;
            this.txtxFilhos.ReadOnly = false;
            this.txtxFilhos.Size = new System.Drawing.Size(170, 21);
            this.txtxFilhos.TabIndex = 13;
            // 
            // dtdAniversario
            // 
            this.dtdAniversario._Field = "dAniversario";
            this.dtdAniversario._Help = "Informe a data de aniversário do funcionário";
            this.dtdAniversario._LabelGroup = this.sp_InfPessoal;
            this.dtdAniversario._LabelText = "Data de aniversário";
            this.dtdAniversario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdAniversario._Regex = null;
            this.dtdAniversario._Table = "Funcionario";
            this.dtdAniversario._TamanhoComponente = 114;
            this.dtdAniversario._TamanhoMaiorLabel = 180;
            this.dtdAniversario.BackColor = System.Drawing.Color.Transparent;
            this.dtdAniversario.Base = null;
            this.dtdAniversario.bConfiguracao = false;
            this.dtdAniversario.Color = System.Drawing.Color.Empty;
            this.dtdAniversario.CustomFormat = "";
            this.dtdAniversario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdAniversario.Location = new System.Drawing.Point(77, 136);
            this.dtdAniversario.Margin = new System.Windows.Forms.Padding(77, 3, 15, 3);
            this.dtdAniversario.Name = "dtdAniversario";
            this.dtdAniversario.objConfigComponenteModel = null;
            this.dtdAniversario.Size = new System.Drawing.Size(220, 21);
            this.dtdAniversario.TabIndex = 7;
            this.dtdAniversario.Value = new System.DateTime(2012, 8, 15, 13, 47, 38, 34);
            // 
            // cbxstSexo
            // 
            this.cbxstSexo._Field = "stSexo";
            this.cbxstSexo._Help = "Informe o sexo do funcionário";
            this.cbxstSexo._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstSexo._Itens")));
            this.cbxstSexo._LabelGroup = this.sp_InfPessoal;
            this.cbxstSexo._LabelText = "Sexo";
            this.cbxstSexo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstSexo._Regex = null;
            this.cbxstSexo._situacao = false;
            this.cbxstSexo._Table = "Funcionario";
            this.cbxstSexo._TamanhoComponente = 111;
            this.cbxstSexo._TamanhoMaiorLabel = 180;
            this.cbxstSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbxstSexo.Base = null;
            this.cbxstSexo.bConfiguracao = false;
            this.cbxstSexo.Color = System.Drawing.Color.White;
            this.cbxstSexo.DataSource = null;
            this.cbxstSexo.DisplayMember = "DisplayMember";
            this.cbxstSexo.Location = new System.Drawing.Point(152, 163);
            this.cbxstSexo.Margin = new System.Windows.Forms.Padding(152, 3, 15, 3);
            this.cbxstSexo.Name = "cbxstSexo";
            this.cbxstSexo.objConfigComponenteModel = null;
            this.cbxstSexo.SelectedIndex = -1;
            this.cbxstSexo.SelectedValue = 0;
            this.cbxstSexo.Size = new System.Drawing.Size(142, 21);
            this.cbxstSexo.TabIndex = 8;
            this.cbxstSexo.ValueMember = "ValueMember";
            // 
            // dtdFalecimento
            // 
            this.dtdFalecimento._Field = "dFalecimento";
            this.dtdFalecimento._Help = "Informe a data de falecimento do funcionário";
            this.dtdFalecimento._LabelGroup = this.sp_InfPessoal;
            this.dtdFalecimento._LabelText = "Data de falecimento";
            this.dtdFalecimento._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdFalecimento._Regex = null;
            this.dtdFalecimento._Table = "Funcionario";
            this.dtdFalecimento._TamanhoComponente = 117;
            this.dtdFalecimento._TamanhoMaiorLabel = 180;
            this.dtdFalecimento.BackColor = System.Drawing.Color.Transparent;
            this.dtdFalecimento.Base = null;
            this.dtdFalecimento.bConfiguracao = false;
            this.dtdFalecimento.Color = System.Drawing.Color.Empty;
            this.dtdFalecimento.CustomFormat = "";
            this.dtdFalecimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdFalecimento.Location = new System.Drawing.Point(73, 190);
            this.dtdFalecimento.Margin = new System.Windows.Forms.Padding(73, 3, 15, 3);
            this.dtdFalecimento.Name = "dtdFalecimento";
            this.dtdFalecimento.objConfigComponenteModel = null;
            this.dtdFalecimento.Size = new System.Drawing.Size(227, 21);
            this.dtdFalecimento.TabIndex = 9;
            this.dtdFalecimento.Value = new System.DateTime(2012, 8, 15, 13, 47, 38, 34);
            // 
            // hlP_PesquisaidContaBancaria
            // 
            this.hlP_PesquisaidContaBancaria._Field = "idContaBancaria";
            this.hlP_PesquisaidContaBancaria._Help = "Informar a conta bancária do funcionário para eventual pagamento ou recebidos";
            this.hlP_PesquisaidContaBancaria._LabelGroup = this.sp_InfPessoal;
            this.hlP_PesquisaidContaBancaria._LabelText = "Conta bancária";
            this.hlP_PesquisaidContaBancaria._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidContaBancaria._ListaCamposDisplay")));
            this.hlP_PesquisaidContaBancaria._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidContaBancaria._ListaValoresDisplay")));
            this.hlP_PesquisaidContaBancaria._NomeCampoPK = "ID";
            this.hlP_PesquisaidContaBancaria._NomeFormCadastroOriginal = "FormContaBancaria";
            this.hlP_PesquisaidContaBancaria._NomeView = "vwContaBancaria";
            this.hlP_PesquisaidContaBancaria._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidContaBancaria._Regex = null;
            this.hlP_PesquisaidContaBancaria._Table = "Funcionario";
            this.hlP_PesquisaidContaBancaria._TamanhoComponente = 300;
            this.hlP_PesquisaidContaBancaria._TamanhoMaiorLabel = 180;
            this.hlP_PesquisaidContaBancaria._Vinculado = false;
            this.hlP_PesquisaidContaBancaria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidContaBancaria.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidContaBancaria.Base = null;
            this.hlP_PesquisaidContaBancaria.bConfiguracao = false;
            this.hlP_PesquisaidContaBancaria.Location = new System.Drawing.Point(98, 217);
            this.hlP_PesquisaidContaBancaria.Margin = new System.Windows.Forms.Padding(98, 3, 15, 3);
            this.hlP_PesquisaidContaBancaria.Name = "hlP_PesquisaidContaBancaria";
            this.hlP_PesquisaidContaBancaria.objConfigComponenteModel = null;
            this.hlP_PesquisaidContaBancaria.ReadOnly = false;
            this.hlP_PesquisaidContaBancaria.Size = new System.Drawing.Size(385, 21);
            this.hlP_PesquisaidContaBancaria.TabIndex = 14;
            this.hlP_PesquisaidContaBancaria.Value = 0;
            // 
            // spVisto
            // 
            this.spVisto._LabelText = "Visto";
            this.spVisto._TamanhoMaiorLabel = 0;
            this.spVisto.BackColor = System.Drawing.Color.Transparent;
            this.spVisto.Location = new System.Drawing.Point(0, 244);
            this.spVisto.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.spVisto.Name = "spVisto";
            this.spVisto.Size = new System.Drawing.Size(573, 19);
            this.spVisto.TabIndex = 44;
            this.spVisto.TabStop = false;
            // 
            // txtxVisto
            // 
            this.txtxVisto._Field = "xVisto";
            this.txtxVisto._Help = "Informar o visto de permanência brasileira do funcionário";
            this.txtxVisto._LabelGroup = this.spVisto;
            this.txtxVisto._LabelText = "Visto";
            this.txtxVisto._Multiline = false;
            this.txtxVisto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxVisto._Password = false;
            this.txtxVisto._Regex = null;
            this.txtxVisto._Table = "Funcionario";
            this.txtxVisto._TamanhoComponente = 133;
            this.txtxVisto._TamanhoMaiorLabel = 180;
            this.txtxVisto.BackColor = System.Drawing.Color.Transparent;
            this.txtxVisto.Base = null;
            this.txtxVisto.bConfiguracao = false;
            this.txtxVisto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxVisto.Color = System.Drawing.Color.White;
            this.txtxVisto.Location = new System.Drawing.Point(150, 269);
            this.txtxVisto.Margin = new System.Windows.Forms.Padding(150, 3, 15, 3);
            this.txtxVisto.MaxLength = 32767;
            this.txtxVisto.Name = "txtxVisto";
            this.txtxVisto.objConfigComponenteModel = null;
            this.txtxVisto.ReadOnly = false;
            this.txtxVisto.Size = new System.Drawing.Size(166, 21);
            this.txtxVisto.TabIndex = 15;
            // 
            // txtxVistoTrabalho
            // 
            this.txtxVistoTrabalho._Field = "xVistoTrabalho";
            this.txtxVistoTrabalho._Help = "Informar a data final do visto de trabalho do funcionário";
            this.txtxVistoTrabalho._LabelGroup = this.spVisto;
            this.txtxVistoTrabalho._LabelText = "Visto de trabalho";
            this.txtxVistoTrabalho._Multiline = false;
            this.txtxVistoTrabalho._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxVistoTrabalho._Password = false;
            this.txtxVistoTrabalho._Regex = null;
            this.txtxVistoTrabalho._Table = "Funcionario";
            this.txtxVistoTrabalho._TamanhoComponente = 131;
            this.txtxVistoTrabalho._TamanhoMaiorLabel = 180;
            this.txtxVistoTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.txtxVistoTrabalho.Base = null;
            this.txtxVistoTrabalho.bConfiguracao = false;
            this.txtxVistoTrabalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxVistoTrabalho.Color = System.Drawing.Color.White;
            this.txtxVistoTrabalho.Location = new System.Drawing.Point(87, 296);
            this.txtxVistoTrabalho.Margin = new System.Windows.Forms.Padding(87, 3, 15, 3);
            this.txtxVistoTrabalho.MaxLength = 32767;
            this.txtxVistoTrabalho.Name = "txtxVistoTrabalho";
            this.txtxVistoTrabalho.objConfigComponenteModel = null;
            this.txtxVistoTrabalho.ReadOnly = false;
            this.txtxVistoTrabalho.Size = new System.Drawing.Size(227, 21);
            this.txtxVistoTrabalho.TabIndex = 17;
            this.txtxVistoTrabalho.Load += new System.EventHandler(this.txtxVistoTrabalho_Load);
            // 
            // dtdFinalVisto
            // 
            this.dtdFinalVisto._Field = "dFinalVisto";
            this.dtdFinalVisto._Help = "Informar a data final do visto de permanência brasileira do funcionário";
            this.dtdFinalVisto._LabelGroup = this.spVisto;
            this.dtdFinalVisto._LabelText = "Data final do visto";
            this.dtdFinalVisto._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdFinalVisto._Regex = null;
            this.dtdFinalVisto._Table = "Funcionario";
            this.dtdFinalVisto._TamanhoComponente = 114;
            this.dtdFinalVisto._TamanhoMaiorLabel = 180;
            this.dtdFinalVisto.BackColor = System.Drawing.Color.Transparent;
            this.dtdFinalVisto.Base = null;
            this.dtdFinalVisto.bConfiguracao = false;
            this.dtdFinalVisto.Color = System.Drawing.Color.Empty;
            this.dtdFinalVisto.CustomFormat = "";
            this.dtdFinalVisto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdFinalVisto.Location = new System.Drawing.Point(82, 323);
            this.dtdFinalVisto.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.dtdFinalVisto.Name = "dtdFinalVisto";
            this.dtdFinalVisto.objConfigComponenteModel = null;
            this.dtdFinalVisto.Size = new System.Drawing.Size(215, 21);
            this.dtdFinalVisto.TabIndex = 16;
            this.dtdFinalVisto.Value = new System.DateTime(2012, 8, 15, 13, 47, 38, 34);
            // 
            // dtdFinalVistoTrabalho
            // 
            this.dtdFinalVistoTrabalho._Field = "dFinalVistoTrabalho";
            this.dtdFinalVistoTrabalho._LabelGroup = this.spVisto;
            this.dtdFinalVistoTrabalho._LabelText = "Data final do visto de trabalho";
            this.dtdFinalVistoTrabalho._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdFinalVistoTrabalho._Regex = null;
            this.dtdFinalVistoTrabalho._Table = "Funcionario";
            this.dtdFinalVistoTrabalho._TamanhoComponente = 111;
            this.dtdFinalVistoTrabalho._TamanhoMaiorLabel = 180;
            this.dtdFinalVistoTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.dtdFinalVistoTrabalho.Base = null;
            this.dtdFinalVistoTrabalho.bConfiguracao = false;
            this.dtdFinalVistoTrabalho.Color = System.Drawing.Color.Empty;
            this.dtdFinalVistoTrabalho.CustomFormat = "";
            this.dtdFinalVistoTrabalho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdFinalVistoTrabalho.Location = new System.Drawing.Point(19, 350);
            this.dtdFinalVistoTrabalho.Margin = new System.Windows.Forms.Padding(19, 3, 15, 3);
            this.dtdFinalVistoTrabalho.Name = "dtdFinalVistoTrabalho";
            this.dtdFinalVistoTrabalho.objConfigComponenteModel = null;
            this.dtdFinalVistoTrabalho.Size = new System.Drawing.Size(275, 21);
            this.dtdFinalVistoTrabalho.TabIndex = 18;
            this.dtdFinalVistoTrabalho.Value = new System.DateTime(2012, 8, 15, 13, 47, 38, 34);
            // 
            // sp_deptoPessoal
            // 
            this.sp_deptoPessoal._LabelText = "Departamento pessoal";
            this.sp_deptoPessoal._TamanhoMaiorLabel = 0;
            this.sp_deptoPessoal.BackColor = System.Drawing.Color.Transparent;
            this.sp_deptoPessoal.Location = new System.Drawing.Point(0, 377);
            this.sp_deptoPessoal.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_deptoPessoal.Name = "sp_deptoPessoal";
            this.sp_deptoPessoal.Size = new System.Drawing.Size(573, 19);
            this.sp_deptoPessoal.TabIndex = 45;
            this.sp_deptoPessoal.TabStop = false;
            // 
            // nudvDiaria
            // 
            this.nudvDiaria._Field = "vDiaria";
            this.nudvDiaria._Help = "Informar o valor da diária do funcionário";
            this.nudvDiaria._LabelGroup = this.sp_deptoPessoal;
            this.nudvDiaria._LabelText = "Diária";
            this.nudvDiaria._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvDiaria._Regex = null;
            this.nudvDiaria._Table = "Funcionario";
            this.nudvDiaria._TamanhoComponente = 119;
            this.nudvDiaria._TamanhoMaiorLabel = 180;
            this.nudvDiaria.BackColor = System.Drawing.Color.Transparent;
            this.nudvDiaria.Base = null;
            this.nudvDiaria.bConfiguracao = false;
            this.nudvDiaria.Color = System.Drawing.Color.White;
            this.nudvDiaria.DecimalPlaces = 2;
            this.nudvDiaria.Location = new System.Drawing.Point(146, 402);
            this.nudvDiaria.Margin = new System.Windows.Forms.Padding(146, 3, 15, 3);
            this.nudvDiaria.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvDiaria.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvDiaria.Name = "nudvDiaria";
            this.nudvDiaria.objConfigComponenteModel = null;
            this.nudvDiaria.ReadOnly = false;
            this.nudvDiaria.Size = new System.Drawing.Size(156, 22);
            this.nudvDiaria.TabIndex = 20;
            this.nudvDiaria.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvDiaria.ValueInt = 0;
            // 
            // nudvSalario
            // 
            this.nudvSalario._Field = "vSalario";
            this.nudvSalario._Help = "Informar o valor mensal quando o campo tipo de salário tiver mensalista ou valor " +
    "hora quando o campo tipo de salário tiver horista";
            this.nudvSalario._LabelGroup = this.sp_deptoPessoal;
            this.nudvSalario._LabelText = "Salário";
            this.nudvSalario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvSalario._Regex = null;
            this.nudvSalario._Table = "Funcionario";
            this.nudvSalario._TamanhoComponente = 119;
            this.nudvSalario._TamanhoMaiorLabel = 150;
            this.nudvSalario.BackColor = System.Drawing.Color.Transparent;
            this.nudvSalario.Base = null;
            this.nudvSalario.bConfiguracao = false;
            this.nudvSalario.Color = System.Drawing.Color.White;
            this.nudvSalario.DecimalPlaces = 2;
            this.nudvSalario.Location = new System.Drawing.Point(111, 430);
            this.nudvSalario.Margin = new System.Windows.Forms.Padding(111, 3, 15, 3);
            this.nudvSalario.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvSalario.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvSalario.Name = "nudvSalario";
            this.nudvSalario.objConfigComponenteModel = null;
            this.nudvSalario.ReadOnly = false;
            this.nudvSalario.Size = new System.Drawing.Size(161, 22);
            this.nudvSalario.TabIndex = 23;
            this.nudvSalario.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvSalario.ValueInt = 0;
            // 
            // nudvSalarioHora
            // 
            this.nudvSalarioHora._Field = "vSalarioHora";
            this.nudvSalarioHora._Help = "Informar o valor do salário hora do funcionário";
            this.nudvSalarioHora._LabelGroup = this.sp_deptoPessoal;
            this.nudvSalarioHora._LabelText = "Salário hora";
            this.nudvSalarioHora._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudvSalarioHora._Regex = null;
            this.nudvSalarioHora._Table = "Funcionario";
            this.nudvSalarioHora._TamanhoComponente = 118;
            this.nudvSalarioHora._TamanhoMaiorLabel = 150;
            this.nudvSalarioHora.BackColor = System.Drawing.Color.Transparent;
            this.nudvSalarioHora.Base = null;
            this.nudvSalarioHora.bConfiguracao = false;
            this.nudvSalarioHora.Color = System.Drawing.Color.White;
            this.nudvSalarioHora.DecimalPlaces = 2;
            this.nudvSalarioHora.Location = new System.Drawing.Point(672, 3);
            this.nudvSalarioHora.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.nudvSalarioHora.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudvSalarioHora.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudvSalarioHora.Name = "nudvSalarioHora";
            this.nudvSalarioHora.objConfigComponenteModel = null;
            this.nudvSalarioHora.ReadOnly = false;
            this.nudvSalarioHora.Size = new System.Drawing.Size(187, 22);
            this.nudvSalarioHora.TabIndex = 24;
            this.nudvSalarioHora.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudvSalarioHora.ValueInt = 0;
            // 
            // dtdAdmissao
            // 
            this.dtdAdmissao._Field = "dAdmissao";
            this.dtdAdmissao._Help = "Informar a data de admissão do funcionário";
            this.dtdAdmissao._LabelGroup = this.sp_deptoPessoal;
            this.dtdAdmissao._LabelText = "Data de admissão";
            this.dtdAdmissao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdAdmissao._Regex = null;
            this.dtdAdmissao._Table = "Funcionario";
            this.dtdAdmissao._TamanhoComponente = 115;
            this.dtdAdmissao._TamanhoMaiorLabel = 180;
            this.dtdAdmissao.BackColor = System.Drawing.Color.Transparent;
            this.dtdAdmissao.Base = null;
            this.dtdAdmissao.bConfiguracao = false;
            this.dtdAdmissao.Color = System.Drawing.Color.Empty;
            this.dtdAdmissao.CustomFormat = "";
            this.dtdAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdAdmissao.Location = new System.Drawing.Point(673, 31);
            this.dtdAdmissao.Margin = new System.Windows.Forms.Padding(85, 3, 15, 3);
            this.dtdAdmissao.Name = "dtdAdmissao";
            this.dtdAdmissao.objConfigComponenteModel = null;
            this.dtdAdmissao.Size = new System.Drawing.Size(213, 21);
            this.dtdAdmissao.TabIndex = 19;
            this.dtdAdmissao.Value = new System.DateTime(2012, 8, 15, 13, 47, 38, 34);
            this.dtdAdmissao.Load += new System.EventHandler(this.dtdAdmissao_Load);
            // 
            // cbxstSalario
            // 
            this.cbxstSalario._Field = "stSalario";
            this.cbxstSalario._Help = "Informar se a condição de salario do  funcionário é:";
            this.cbxstSalario._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstSalario._Itens")));
            this.cbxstSalario._LabelGroup = this.sp_deptoPessoal;
            this.cbxstSalario._LabelText = "Tipo de salário";
            this.cbxstSalario._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstSalario._Regex = null;
            this.cbxstSalario._situacao = false;
            this.cbxstSalario._Table = "Funcionario";
            this.cbxstSalario._TamanhoComponente = 115;
            this.cbxstSalario._TamanhoMaiorLabel = 150;
            this.cbxstSalario.BackColor = System.Drawing.Color.Transparent;
            this.cbxstSalario.Base = null;
            this.cbxstSalario.bConfiguracao = false;
            this.cbxstSalario.Color = System.Drawing.Color.White;
            this.cbxstSalario.DataSource = null;
            this.cbxstSalario.DisplayMember = "DisplayMember";
            this.cbxstSalario.Location = new System.Drawing.Point(659, 58);
            this.cbxstSalario.Margin = new System.Windows.Forms.Padding(71, 3, 15, 3);
            this.cbxstSalario.Name = "cbxstSalario";
            this.cbxstSalario.objConfigComponenteModel = null;
            this.cbxstSalario.SelectedIndex = -1;
            this.cbxstSalario.SelectedValue = 0;
            this.cbxstSalario.Size = new System.Drawing.Size(197, 21);
            this.cbxstSalario.TabIndex = 22;
            this.cbxstSalario.ValueMember = "ValueMember";
            // 
            // hlP_PesquisaidResponsavel
            // 
            this.hlP_PesquisaidResponsavel._Field = "idResponsavel";
            this.hlP_PesquisaidResponsavel._Help = "Informar o responsável pelo funcionário na empresa";
            this.hlP_PesquisaidResponsavel._LabelGroup = this.sp_deptoPessoal;
            this.hlP_PesquisaidResponsavel._LabelText = "Responsável";
            this.hlP_PesquisaidResponsavel._ListaCamposDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidResponsavel._ListaCamposDisplay")));
            this.hlP_PesquisaidResponsavel._ListaValoresDisplay = ((System.Collections.Generic.List<string>)(resources.GetObject("hlP_PesquisaidResponsavel._ListaValoresDisplay")));
            this.hlP_PesquisaidResponsavel._NomeCampoPK = "ID";
            this.hlP_PesquisaidResponsavel._NomeFormCadastroOriginal = "FormFuncionario";
            this.hlP_PesquisaidResponsavel._NomeView = "vwFuncionario";
            this.hlP_PesquisaidResponsavel._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.hlP_PesquisaidResponsavel._Regex = null;
            this.hlP_PesquisaidResponsavel._Table = "Funcionario";
            this.hlP_PesquisaidResponsavel._TamanhoComponente = 300;
            this.hlP_PesquisaidResponsavel._TamanhoMaiorLabel = 150;
            this.hlP_PesquisaidResponsavel._Vinculado = false;
            this.hlP_PesquisaidResponsavel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hlP_PesquisaidResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.hlP_PesquisaidResponsavel.Base = null;
            this.hlP_PesquisaidResponsavel.bConfiguracao = false;
            this.hlP_PesquisaidResponsavel.Location = new System.Drawing.Point(670, 85);
            this.hlP_PesquisaidResponsavel.Margin = new System.Windows.Forms.Padding(82, 3, 15, 3);
            this.hlP_PesquisaidResponsavel.Name = "hlP_PesquisaidResponsavel";
            this.hlP_PesquisaidResponsavel.objConfigComponenteModel = null;
            this.hlP_PesquisaidResponsavel.ReadOnly = false;
            this.hlP_PesquisaidResponsavel.Size = new System.Drawing.Size(371, 21);
            this.hlP_PesquisaidResponsavel.TabIndex = 35;
            this.hlP_PesquisaidResponsavel.Value = 0;
            // 
            // sp_qtdehorastrab
            // 
            this.sp_qtdehorastrab._LabelText = "Quantidade de horas de trabalho";
            this.sp_qtdehorastrab._TamanhoMaiorLabel = 0;
            this.sp_qtdehorastrab.BackColor = System.Drawing.Color.Transparent;
            this.sp_qtdehorastrab.Location = new System.Drawing.Point(588, 112);
            this.sp_qtdehorastrab.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_qtdehorastrab.Name = "sp_qtdehorastrab";
            this.sp_qtdehorastrab.Size = new System.Drawing.Size(382, 19);
            this.sp_qtdehorastrab.TabIndex = 46;
            this.sp_qtdehorastrab.TabStop = false;
            // 
            // txtTotalHorasTab
            // 
            this.txtTotalHorasTab._LabelGroup = this.sp_qtdehorastrab;
            this.txtTotalHorasTab._LabelText = "Total de horas trabalhada";
            this.txtTotalHorasTab._Multiline = false;
            this.txtTotalHorasTab._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtTotalHorasTab._Password = false;
            this.txtTotalHorasTab._Regex = null;
            this.txtTotalHorasTab._TamanhoComponente = 84;
            this.txtTotalHorasTab._TamanhoMaiorLabel = 150;
            this.txtTotalHorasTab.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalHorasTab.Base = null;
            this.txtTotalHorasTab.bConfiguracao = false;
            this.txtTotalHorasTab.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalHorasTab.Color = System.Drawing.Color.White;
            this.txtTotalHorasTab.Location = new System.Drawing.Point(602, 137);
            this.txtTotalHorasTab.Margin = new System.Windows.Forms.Padding(14, 3, 15, 3);
            this.txtTotalHorasTab.MaxLength = 32767;
            this.txtTotalHorasTab.Name = "txtTotalHorasTab";
            this.txtTotalHorasTab.objConfigComponenteModel = null;
            this.txtTotalHorasTab.ReadOnly = true;
            this.txtTotalHorasTab.Size = new System.Drawing.Size(223, 21);
            this.txtTotalHorasTab.TabIndex = 54;
            // 
            // dtdQtdHorasSegunda
            // 
            this.dtdQtdHorasSegunda._Field = "dQtdHorasSegunda";
            this.dtdQtdHorasSegunda._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasSegunda._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasSegunda._LabelText = "Segunda-feira";
            this.dtdQtdHorasSegunda._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasSegunda._Regex = null;
            this.dtdQtdHorasSegunda._Table = "Funcionario";
            this.dtdQtdHorasSegunda._TamanhoComponente = 90;
            this.dtdQtdHorasSegunda._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasSegunda.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasSegunda.Base = null;
            this.dtdQtdHorasSegunda.bConfiguracao = false;
            this.dtdQtdHorasSegunda.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasSegunda.CustomFormat = "";
            this.dtdQtdHorasSegunda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasSegunda.Location = new System.Drawing.Point(661, 164);
            this.dtdQtdHorasSegunda.Margin = new System.Windows.Forms.Padding(73, 3, 15, 3);
            this.dtdQtdHorasSegunda.Name = "dtdQtdHorasSegunda";
            this.dtdQtdHorasSegunda.objConfigComponenteModel = null;
            this.dtdQtdHorasSegunda.Size = new System.Drawing.Size(170, 21);
            this.dtdQtdHorasSegunda.TabIndex = 47;
            this.dtdQtdHorasSegunda.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            // 
            // dtdQtdHorasTerca
            // 
            this.dtdQtdHorasTerca._Field = "dQtdHorasTerca";
            this.dtdQtdHorasTerca._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasTerca._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasTerca._LabelText = "Terça-feira";
            this.dtdQtdHorasTerca._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasTerca._Regex = null;
            this.dtdQtdHorasTerca._Table = "Funcionario";
            this.dtdQtdHorasTerca._TamanhoComponente = 90;
            this.dtdQtdHorasTerca._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasTerca.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasTerca.Base = null;
            this.dtdQtdHorasTerca.bConfiguracao = false;
            this.dtdQtdHorasTerca.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasTerca.CustomFormat = "";
            this.dtdQtdHorasTerca.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasTerca.Location = new System.Drawing.Point(681, 191);
            this.dtdQtdHorasTerca.Margin = new System.Windows.Forms.Padding(93, 3, 15, 3);
            this.dtdQtdHorasTerca.Name = "dtdQtdHorasTerca";
            this.dtdQtdHorasTerca.objConfigComponenteModel = null;
            this.dtdQtdHorasTerca.Size = new System.Drawing.Size(150, 21);
            this.dtdQtdHorasTerca.TabIndex = 48;
            this.dtdQtdHorasTerca.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            // 
            // dtdQtdHorasQuarta
            // 
            this.dtdQtdHorasQuarta._Field = "dQtdHorasQuarta";
            this.dtdQtdHorasQuarta._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasQuarta._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasQuarta._LabelText = "Quarta-feira";
            this.dtdQtdHorasQuarta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasQuarta._Regex = null;
            this.dtdQtdHorasQuarta._Table = "Funcionario";
            this.dtdQtdHorasQuarta._TamanhoComponente = 91;
            this.dtdQtdHorasQuarta._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasQuarta.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasQuarta.Base = null;
            this.dtdQtdHorasQuarta.bConfiguracao = false;
            this.dtdQtdHorasQuarta.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasQuarta.CustomFormat = "";
            this.dtdQtdHorasQuarta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasQuarta.Location = new System.Drawing.Point(672, 218);
            this.dtdQtdHorasQuarta.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.dtdQtdHorasQuarta.Name = "dtdQtdHorasQuarta";
            this.dtdQtdHorasQuarta.objConfigComponenteModel = null;
            this.dtdQtdHorasQuarta.Size = new System.Drawing.Size(160, 21);
            this.dtdQtdHorasQuarta.TabIndex = 49;
            this.dtdQtdHorasQuarta.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            // 
            // dtdQtdHorasQuinta
            // 
            this.dtdQtdHorasQuinta._Field = "dQtdHorasQuinta";
            this.dtdQtdHorasQuinta._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasQuinta._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasQuinta._LabelText = "Quinta-feira";
            this.dtdQtdHorasQuinta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasQuinta._Regex = null;
            this.dtdQtdHorasQuinta._Table = "Funcionario";
            this.dtdQtdHorasQuinta._TamanhoComponente = 91;
            this.dtdQtdHorasQuinta._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasQuinta.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasQuinta.Base = null;
            this.dtdQtdHorasQuinta.bConfiguracao = false;
            this.dtdQtdHorasQuinta.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasQuinta.CustomFormat = "";
            this.dtdQtdHorasQuinta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasQuinta.Location = new System.Drawing.Point(672, 245);
            this.dtdQtdHorasQuinta.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.dtdQtdHorasQuinta.Name = "dtdQtdHorasQuinta";
            this.dtdQtdHorasQuinta.objConfigComponenteModel = null;
            this.dtdQtdHorasQuinta.Size = new System.Drawing.Size(160, 21);
            this.dtdQtdHorasQuinta.TabIndex = 50;
            this.dtdQtdHorasQuinta.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            // 
            // dtdQtdHorasSexta
            // 
            this.dtdQtdHorasSexta._Field = "dQtdHorasSexta";
            this.dtdQtdHorasSexta._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasSexta._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasSexta._LabelText = "Sexta-feira";
            this.dtdQtdHorasSexta._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasSexta._Regex = null;
            this.dtdQtdHorasSexta._Table = "Funcionario";
            this.dtdQtdHorasSexta._TamanhoComponente = 90;
            this.dtdQtdHorasSexta._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasSexta.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasSexta.Base = null;
            this.dtdQtdHorasSexta.bConfiguracao = false;
            this.dtdQtdHorasSexta.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasSexta.CustomFormat = "";
            this.dtdQtdHorasSexta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasSexta.Location = new System.Drawing.Point(680, 272);
            this.dtdQtdHorasSexta.Margin = new System.Windows.Forms.Padding(92, 3, 15, 3);
            this.dtdQtdHorasSexta.Name = "dtdQtdHorasSexta";
            this.dtdQtdHorasSexta.objConfigComponenteModel = null;
            this.dtdQtdHorasSexta.Size = new System.Drawing.Size(151, 21);
            this.dtdQtdHorasSexta.TabIndex = 51;
            this.dtdQtdHorasSexta.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            // 
            // dtdQtdHorasSabado
            // 
            this.dtdQtdHorasSabado._Field = "dQtdHorasSabado";
            this.dtdQtdHorasSabado._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasSabado._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasSabado._LabelText = "Sábado";
            this.dtdQtdHorasSabado._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasSabado._Regex = null;
            this.dtdQtdHorasSabado._Table = "Funcionario";
            this.dtdQtdHorasSabado._TamanhoComponente = 90;
            this.dtdQtdHorasSabado._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasSabado.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasSabado.Base = null;
            this.dtdQtdHorasSabado.bConfiguracao = false;
            this.dtdQtdHorasSabado.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasSabado.CustomFormat = "";
            this.dtdQtdHorasSabado.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasSabado.Location = new System.Drawing.Point(695, 299);
            this.dtdQtdHorasSabado.Margin = new System.Windows.Forms.Padding(107, 3, 15, 3);
            this.dtdQtdHorasSabado.Name = "dtdQtdHorasSabado";
            this.dtdQtdHorasSabado.objConfigComponenteModel = null;
            this.dtdQtdHorasSabado.Size = new System.Drawing.Size(136, 21);
            this.dtdQtdHorasSabado.TabIndex = 52;
            this.dtdQtdHorasSabado.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            this.dtdQtdHorasSabado.Load += new System.EventHandler(this.dtdQtdHorasSabado_Load);
            // 
            // dtdQtdHorasDomingo
            // 
            this.dtdQtdHorasDomingo._Field = "dQtdHorasDomingo";
            this.dtdQtdHorasDomingo._Help = "Informar a quantidade de horas trabalhada";
            this.dtdQtdHorasDomingo._LabelGroup = this.sp_qtdehorastrab;
            this.dtdQtdHorasDomingo._LabelText = "Domingo";
            this.dtdQtdHorasDomingo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.dtdQtdHorasDomingo._Regex = null;
            this.dtdQtdHorasDomingo._Table = "Funcionario";
            this.dtdQtdHorasDomingo._TamanhoComponente = 90;
            this.dtdQtdHorasDomingo._TamanhoMaiorLabel = 150;
            this.dtdQtdHorasDomingo.BackColor = System.Drawing.Color.Transparent;
            this.dtdQtdHorasDomingo.Base = null;
            this.dtdQtdHorasDomingo.bConfiguracao = false;
            this.dtdQtdHorasDomingo.Color = System.Drawing.Color.Empty;
            this.dtdQtdHorasDomingo.CustomFormat = "";
            this.dtdQtdHorasDomingo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtdQtdHorasDomingo.Location = new System.Drawing.Point(686, 326);
            this.dtdQtdHorasDomingo.Margin = new System.Windows.Forms.Padding(98, 3, 15, 3);
            this.dtdQtdHorasDomingo.Name = "dtdQtdHorasDomingo";
            this.dtdQtdHorasDomingo.objConfigComponenteModel = null;
            this.dtdQtdHorasDomingo.Size = new System.Drawing.Size(145, 21);
            this.dtdQtdHorasDomingo.TabIndex = 53;
            this.dtdQtdHorasDomingo.Value = new System.DateTime(2012, 8, 16, 16, 0, 30, 387);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.kryptonPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1144, 225);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Tag = false;
            this.tabPage4.Text = "Contato";
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.flowLayoutPanel3);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.sp_Comercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxTelefoneComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxRamalComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxCelularComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxRadioFoneComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxPagerComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxFaxComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxEmailComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxSkypeComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxMSNComercial);
            this.flowLayoutPanel3.Controls.Add(this.txtxhttpComercial);
            this.flowLayoutPanel3.Controls.Add(this.sp_Residencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxTelefoneResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxCelularResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxRadioFoneResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxEmailResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxSkypeResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtxMsnResidencial);
            this.flowLayoutPanel3.Controls.Add(this.txtXhttpPessoal);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1144, 225);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // sp_Comercial
            // 
            this.sp_Comercial._LabelText = "Comercial";
            this.sp_Comercial._TamanhoMaiorLabel = 0;
            this.sp_Comercial.BackColor = System.Drawing.Color.Transparent;
            this.sp_Comercial.Location = new System.Drawing.Point(0, 3);
            this.sp_Comercial.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Comercial.Name = "sp_Comercial";
            this.sp_Comercial.Size = new System.Drawing.Size(63, 19);
            this.sp_Comercial.TabIndex = 10;
            this.sp_Comercial.TabStop = false;
            // 
            // txtxTelefoneComercial
            // 
            this.txtxTelefoneComercial._Field = "xTelefoneComercial";
            this.txtxTelefoneComercial._Help = "Insira o número do telefone comercial do funcionário";
            this.txtxTelefoneComercial._LabelGroup = this.sp_Comercial;
            this.txtxTelefoneComercial._LabelText = "Telefone";
            this.txtxTelefoneComercial._Multiline = false;
            this.txtxTelefoneComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTelefoneComercial._Password = false;
            this.txtxTelefoneComercial._Regex = null;
            this.txtxTelefoneComercial._Table = "Funcionario";
            this.txtxTelefoneComercial._TamanhoComponente = 133;
            this.txtxTelefoneComercial._TamanhoMaiorLabel = 150;
            this.txtxTelefoneComercial._Visible = false;
            this.txtxTelefoneComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxTelefoneComercial.Base = null;
            this.txtxTelefoneComercial.bConfiguracao = false;
            this.txtxTelefoneComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTelefoneComercial.Color = System.Drawing.Color.White;
            this.txtxTelefoneComercial.Location = new System.Drawing.Point(102, 28);
            this.txtxTelefoneComercial.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.txtxTelefoneComercial.MaxLength = 32767;
            this.txtxTelefoneComercial.Name = "txtxTelefoneComercial";
            this.txtxTelefoneComercial.objConfigComponenteModel = null;
            this.txtxTelefoneComercial.ReadOnly = false;
            this.txtxTelefoneComercial.Size = new System.Drawing.Size(184, 21);
            this.txtxTelefoneComercial.TabIndex = 22;
            // 
            // txtxRamalComercial
            // 
            this.txtxRamalComercial._Field = "xRamalComercial";
            this.txtxRamalComercial._Help = "Insira o número do ramal do funcionário";
            this.txtxRamalComercial._LabelGroup = this.sp_Comercial;
            this.txtxRamalComercial._LabelText = "Ramal";
            this.txtxRamalComercial._Multiline = false;
            this.txtxRamalComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRamalComercial._Password = false;
            this.txtxRamalComercial._Regex = null;
            this.txtxRamalComercial._Table = "Funcionario";
            this.txtxRamalComercial._TamanhoComponente = 134;
            this.txtxRamalComercial._TamanhoMaiorLabel = 150;
            this.txtxRamalComercial._Visible = false;
            this.txtxRamalComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxRamalComercial.Base = null;
            this.txtxRamalComercial.bConfiguracao = false;
            this.txtxRamalComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRamalComercial.Color = System.Drawing.Color.White;
            this.txtxRamalComercial.Location = new System.Drawing.Point(115, 55);
            this.txtxRamalComercial.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.txtxRamalComercial.MaxLength = 32767;
            this.txtxRamalComercial.Name = "txtxRamalComercial";
            this.txtxRamalComercial.objConfigComponenteModel = null;
            this.txtxRamalComercial.ReadOnly = false;
            this.txtxRamalComercial.Size = new System.Drawing.Size(172, 21);
            this.txtxRamalComercial.TabIndex = 20;
            // 
            // txtxCelularComercial
            // 
            this.txtxCelularComercial._Field = "xCelularComercial";
            this.txtxCelularComercial._Help = "Insira o número do celular do funcionário.";
            this.txtxCelularComercial._LabelGroup = this.sp_Comercial;
            this.txtxCelularComercial._LabelText = "Celular";
            this.txtxCelularComercial._Multiline = false;
            this.txtxCelularComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCelularComercial._Password = false;
            this.txtxCelularComercial._Regex = null;
            this.txtxCelularComercial._Table = "Funcionario";
            this.txtxCelularComercial._TamanhoComponente = 133;
            this.txtxCelularComercial._TamanhoMaiorLabel = 150;
            this.txtxCelularComercial._Visible = false;
            this.txtxCelularComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxCelularComercial.Base = null;
            this.txtxCelularComercial.bConfiguracao = false;
            this.txtxCelularComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCelularComercial.Color = System.Drawing.Color.White;
            this.txtxCelularComercial.Location = new System.Drawing.Point(110, 82);
            this.txtxCelularComercial.Margin = new System.Windows.Forms.Padding(110, 3, 15, 3);
            this.txtxCelularComercial.MaxLength = 32767;
            this.txtxCelularComercial.Name = "txtxCelularComercial";
            this.txtxCelularComercial.objConfigComponenteModel = null;
            this.txtxCelularComercial.ReadOnly = false;
            this.txtxCelularComercial.Size = new System.Drawing.Size(176, 21);
            this.txtxCelularComercial.TabIndex = 23;
            // 
            // txtxRadioFoneComercial
            // 
            this.txtxRadioFoneComercial._Field = "xRadioFoneComercial";
            this.txtxRadioFoneComercial._Help = "Insira o número do radio do funcionário";
            this.txtxRadioFoneComercial._LabelGroup = this.sp_Comercial;
            this.txtxRadioFoneComercial._LabelText = "Radio";
            this.txtxRadioFoneComercial._Multiline = false;
            this.txtxRadioFoneComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRadioFoneComercial._Password = false;
            this.txtxRadioFoneComercial._Regex = null;
            this.txtxRadioFoneComercial._Table = "Funcionario";
            this.txtxRadioFoneComercial._TamanhoComponente = 133;
            this.txtxRadioFoneComercial._TamanhoMaiorLabel = 150;
            this.txtxRadioFoneComercial._Visible = false;
            this.txtxRadioFoneComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxRadioFoneComercial.Base = null;
            this.txtxRadioFoneComercial.bConfiguracao = false;
            this.txtxRadioFoneComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRadioFoneComercial.Color = System.Drawing.Color.White;
            this.txtxRadioFoneComercial.Location = new System.Drawing.Point(116, 109);
            this.txtxRadioFoneComercial.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxRadioFoneComercial.MaxLength = 32767;
            this.txtxRadioFoneComercial.Name = "txtxRadioFoneComercial";
            this.txtxRadioFoneComercial.objConfigComponenteModel = null;
            this.txtxRadioFoneComercial.ReadOnly = false;
            this.txtxRadioFoneComercial.Size = new System.Drawing.Size(170, 21);
            this.txtxRadioFoneComercial.TabIndex = 3;
            // 
            // txtxPagerComercial
            // 
            this.txtxPagerComercial._Field = "xPagerComercial";
            this.txtxPagerComercial._Help = "Insira o número do pager do funcionário.";
            this.txtxPagerComercial._LabelGroup = this.sp_Comercial;
            this.txtxPagerComercial._LabelText = "Pager";
            this.txtxPagerComercial._Multiline = false;
            this.txtxPagerComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxPagerComercial._Password = false;
            this.txtxPagerComercial._Regex = null;
            this.txtxPagerComercial._Table = "Funcionario";
            this.txtxPagerComercial._TamanhoComponente = 134;
            this.txtxPagerComercial._TamanhoMaiorLabel = 150;
            this.txtxPagerComercial._Visible = false;
            this.txtxPagerComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxPagerComercial.Base = null;
            this.txtxPagerComercial.bConfiguracao = false;
            this.txtxPagerComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxPagerComercial.Color = System.Drawing.Color.White;
            this.txtxPagerComercial.Location = new System.Drawing.Point(117, 136);
            this.txtxPagerComercial.Margin = new System.Windows.Forms.Padding(117, 3, 15, 3);
            this.txtxPagerComercial.MaxLength = 32767;
            this.txtxPagerComercial.Name = "txtxPagerComercial";
            this.txtxPagerComercial.objConfigComponenteModel = null;
            this.txtxPagerComercial.ReadOnly = false;
            this.txtxPagerComercial.Size = new System.Drawing.Size(170, 21);
            this.txtxPagerComercial.TabIndex = 4;
            // 
            // txtxFaxComercial
            // 
            this.txtxFaxComercial._Field = "xFaxComercial";
            this.txtxFaxComercial._Help = "Insira o número do fax do funcionário";
            this.txtxFaxComercial._LabelGroup = this.sp_Comercial;
            this.txtxFaxComercial._LabelText = "Fax";
            this.txtxFaxComercial._Multiline = false;
            this.txtxFaxComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxFaxComercial._Password = false;
            this.txtxFaxComercial._Regex = null;
            this.txtxFaxComercial._Table = "Funcionario";
            this.txtxFaxComercial._TamanhoComponente = 134;
            this.txtxFaxComercial._TamanhoMaiorLabel = 150;
            this.txtxFaxComercial._Visible = false;
            this.txtxFaxComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxFaxComercial.Base = null;
            this.txtxFaxComercial.bConfiguracao = false;
            this.txtxFaxComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxFaxComercial.Color = System.Drawing.Color.White;
            this.txtxFaxComercial.Location = new System.Drawing.Point(129, 163);
            this.txtxFaxComercial.Margin = new System.Windows.Forms.Padding(129, 3, 15, 3);
            this.txtxFaxComercial.MaxLength = 32767;
            this.txtxFaxComercial.Name = "txtxFaxComercial";
            this.txtxFaxComercial.objConfigComponenteModel = null;
            this.txtxFaxComercial.ReadOnly = false;
            this.txtxFaxComercial.Size = new System.Drawing.Size(158, 21);
            this.txtxFaxComercial.TabIndex = 26;
            // 
            // txtxEmailComercial
            // 
            this.txtxEmailComercial._Field = "xEmailComercial";
            this.txtxEmailComercial._Help = "Insira o e-mail do funcionário";
            this.txtxEmailComercial._LabelGroup = this.sp_Comercial;
            this.txtxEmailComercial._LabelText = "E-mail";
            this.txtxEmailComercial._Multiline = false;
            this.txtxEmailComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmailComercial._Password = false;
            this.txtxEmailComercial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxEmailComercial._Table = "Funcionario";
            this.txtxEmailComercial._TamanhoComponente = 269;
            this.txtxEmailComercial._TamanhoMaiorLabel = 150;
            this.txtxEmailComercial._Visible = false;
            this.txtxEmailComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmailComercial.Base = null;
            this.txtxEmailComercial.bConfiguracao = false;
            this.txtxEmailComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmailComercial.Color = System.Drawing.Color.White;
            this.txtxEmailComercial.Location = new System.Drawing.Point(115, 190);
            this.txtxEmailComercial.Margin = new System.Windows.Forms.Padding(115, 3, 15, 3);
            this.txtxEmailComercial.MaxLength = 32767;
            this.txtxEmailComercial.Name = "txtxEmailComercial";
            this.txtxEmailComercial.objConfigComponenteModel = null;
            this.txtxEmailComercial.ReadOnly = false;
            this.txtxEmailComercial.Size = new System.Drawing.Size(307, 21);
            this.txtxEmailComercial.TabIndex = 6;
            // 
            // txtxSkypeComercial
            // 
            this.txtxSkypeComercial._Field = "xSkypeComercial";
            this.txtxSkypeComercial._Help = "Insira o skype do funcionário";
            this.txtxSkypeComercial._LabelGroup = this.sp_Comercial;
            this.txtxSkypeComercial._LabelText = "Skype";
            this.txtxSkypeComercial._Multiline = false;
            this.txtxSkypeComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSkypeComercial._Password = false;
            this.txtxSkypeComercial._Regex = null;
            this.txtxSkypeComercial._Table = "Funcionario";
            this.txtxSkypeComercial._TamanhoComponente = 269;
            this.txtxSkypeComercial._TamanhoMaiorLabel = 150;
            this.txtxSkypeComercial._Visible = false;
            this.txtxSkypeComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxSkypeComercial.Base = null;
            this.txtxSkypeComercial.bConfiguracao = false;
            this.txtxSkypeComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSkypeComercial.Color = System.Drawing.Color.White;
            this.txtxSkypeComercial.Location = new System.Drawing.Point(553, 3);
            this.txtxSkypeComercial.Margin = new System.Windows.Forms.Padding(116, 3, 15, 3);
            this.txtxSkypeComercial.MaxLength = 32767;
            this.txtxSkypeComercial.Name = "txtxSkypeComercial";
            this.txtxSkypeComercial.objConfigComponenteModel = null;
            this.txtxSkypeComercial.ReadOnly = false;
            this.txtxSkypeComercial.Size = new System.Drawing.Size(306, 21);
            this.txtxSkypeComercial.TabIndex = 7;
            // 
            // txtxMSNComercial
            // 
            this.txtxMSNComercial._Field = "xMSNComercial";
            this.txtxMSNComercial._Help = "Insira o msn do funcionário";
            this.txtxMSNComercial._LabelGroup = this.sp_Comercial;
            this.txtxMSNComercial._LabelText = "Msn";
            this.txtxMSNComercial._Multiline = false;
            this.txtxMSNComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxMSNComercial._Password = false;
            this.txtxMSNComercial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxMSNComercial._Table = "Funcionario";
            this.txtxMSNComercial._TamanhoComponente = 272;
            this.txtxMSNComercial._TamanhoMaiorLabel = 150;
            this.txtxMSNComercial._Visible = false;
            this.txtxMSNComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxMSNComercial.Base = null;
            this.txtxMSNComercial.bConfiguracao = false;
            this.txtxMSNComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMSNComercial.Color = System.Drawing.Color.White;
            this.txtxMSNComercial.Location = new System.Drawing.Point(561, 30);
            this.txtxMSNComercial.Margin = new System.Windows.Forms.Padding(124, 3, 15, 3);
            this.txtxMSNComercial.MaxLength = 32767;
            this.txtxMSNComercial.Name = "txtxMSNComercial";
            this.txtxMSNComercial.objConfigComponenteModel = null;
            this.txtxMSNComercial.ReadOnly = false;
            this.txtxMSNComercial.Size = new System.Drawing.Size(301, 21);
            this.txtxMSNComercial.TabIndex = 8;
            // 
            // txtxhttpComercial
            // 
            this.txtxhttpComercial._Field = "xhttpComercial";
            this.txtxhttpComercial._Help = "Insira o endereço do site da empresa do funcionário";
            this.txtxhttpComercial._LabelGroup = this.sp_Comercial;
            this.txtxhttpComercial._LabelText = "Endereço na internet";
            this.txtxhttpComercial._Multiline = false;
            this.txtxhttpComercial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxhttpComercial._Password = false;
            this.txtxhttpComercial._Regex = null;
            this.txtxhttpComercial._Table = "Funcionario";
            this.txtxhttpComercial._TamanhoComponente = 265;
            this.txtxhttpComercial._TamanhoMaiorLabel = 150;
            this.txtxhttpComercial._Visible = false;
            this.txtxhttpComercial.BackColor = System.Drawing.Color.Transparent;
            this.txtxhttpComercial.Base = null;
            this.txtxhttpComercial.bConfiguracao = false;
            this.txtxhttpComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxhttpComercial.Color = System.Drawing.Color.White;
            this.txtxhttpComercial.Location = new System.Drawing.Point(475, 57);
            this.txtxhttpComercial.Margin = new System.Windows.Forms.Padding(38, 3, 15, 3);
            this.txtxhttpComercial.MaxLength = 32767;
            this.txtxhttpComercial.Name = "txtxhttpComercial";
            this.txtxhttpComercial.objConfigComponenteModel = null;
            this.txtxhttpComercial.ReadOnly = false;
            this.txtxhttpComercial.Size = new System.Drawing.Size(380, 21);
            this.txtxhttpComercial.TabIndex = 9;
            // 
            // sp_Residencial
            // 
            this.sp_Residencial._LabelText = "Residencial";
            this.sp_Residencial._TamanhoMaiorLabel = 0;
            this.sp_Residencial.BackColor = System.Drawing.Color.Transparent;
            this.sp_Residencial.Location = new System.Drawing.Point(437, 84);
            this.sp_Residencial.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.sp_Residencial.Name = "sp_Residencial";
            this.sp_Residencial.Size = new System.Drawing.Size(70, 19);
            this.sp_Residencial.TabIndex = 11;
            this.sp_Residencial.TabStop = false;
            // 
            // txtxTelefoneResidencial
            // 
            this.txtxTelefoneResidencial._Field = "xTelefoneResidencial";
            this.txtxTelefoneResidencial._Help = "Insira o número do telefone particular do funcionário, caso possua";
            this.txtxTelefoneResidencial._LabelGroup = this.sp_Residencial;
            this.txtxTelefoneResidencial._LabelText = "Telefone";
            this.txtxTelefoneResidencial._Multiline = false;
            this.txtxTelefoneResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxTelefoneResidencial._Password = false;
            this.txtxTelefoneResidencial._Regex = null;
            this.txtxTelefoneResidencial._Table = "Funcionario";
            this.txtxTelefoneResidencial._TamanhoComponente = 133;
            this.txtxTelefoneResidencial._TamanhoMaiorLabel = 150;
            this.txtxTelefoneResidencial._Visible = false;
            this.txtxTelefoneResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxTelefoneResidencial.Base = null;
            this.txtxTelefoneResidencial.bConfiguracao = false;
            this.txtxTelefoneResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxTelefoneResidencial.Color = System.Drawing.Color.White;
            this.txtxTelefoneResidencial.Location = new System.Drawing.Point(539, 109);
            this.txtxTelefoneResidencial.Margin = new System.Windows.Forms.Padding(102, 3, 15, 3);
            this.txtxTelefoneResidencial.MaxLength = 32767;
            this.txtxTelefoneResidencial.Name = "txtxTelefoneResidencial";
            this.txtxTelefoneResidencial.objConfigComponenteModel = null;
            this.txtxTelefoneResidencial.ReadOnly = false;
            this.txtxTelefoneResidencial.Size = new System.Drawing.Size(184, 21);
            this.txtxTelefoneResidencial.TabIndex = 24;
            // 
            // txtxCelularResidencial
            // 
            this.txtxCelularResidencial._Field = "xCelularResidencial";
            this.txtxCelularResidencial._Help = "Insira o número do celular particular do funcionário, caso possua";
            this.txtxCelularResidencial._LabelGroup = this.sp_Residencial;
            this.txtxCelularResidencial._LabelText = "Celular";
            this.txtxCelularResidencial._Multiline = false;
            this.txtxCelularResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxCelularResidencial._Password = false;
            this.txtxCelularResidencial._Regex = null;
            this.txtxCelularResidencial._Table = "Funcionario";
            this.txtxCelularResidencial._TamanhoComponente = 133;
            this.txtxCelularResidencial._TamanhoMaiorLabel = 150;
            this.txtxCelularResidencial._Visible = false;
            this.txtxCelularResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxCelularResidencial.Base = null;
            this.txtxCelularResidencial.bConfiguracao = false;
            this.txtxCelularResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxCelularResidencial.Color = System.Drawing.Color.White;
            this.txtxCelularResidencial.Location = new System.Drawing.Point(547, 136);
            this.txtxCelularResidencial.Margin = new System.Windows.Forms.Padding(110, 3, 15, 3);
            this.txtxCelularResidencial.MaxLength = 32767;
            this.txtxCelularResidencial.Name = "txtxCelularResidencial";
            this.txtxCelularResidencial.objConfigComponenteModel = null;
            this.txtxCelularResidencial.ReadOnly = false;
            this.txtxCelularResidencial.Size = new System.Drawing.Size(176, 21);
            this.txtxCelularResidencial.TabIndex = 25;
            // 
            // txtxRadioFoneResidencial
            // 
            this.txtxRadioFoneResidencial._Field = "xRadioFoneComercial";
            this.txtxRadioFoneResidencial._Help = "Insira o endereço do radio  pessoal do funcionário, caso possua";
            this.txtxRadioFoneResidencial._LabelGroup = this.sp_Residencial;
            this.txtxRadioFoneResidencial._LabelText = "Radio resid.";
            this.txtxRadioFoneResidencial._Multiline = false;
            this.txtxRadioFoneResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxRadioFoneResidencial._Password = false;
            this.txtxRadioFoneResidencial._Regex = null;
            this.txtxRadioFoneResidencial._Table = "Funcionario";
            this.txtxRadioFoneResidencial._TamanhoComponente = 131;
            this.txtxRadioFoneResidencial._TamanhoMaiorLabel = 150;
            this.txtxRadioFoneResidencial._Visible = false;
            this.txtxRadioFoneResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxRadioFoneResidencial.Base = null;
            this.txtxRadioFoneResidencial.bConfiguracao = false;
            this.txtxRadioFoneResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxRadioFoneResidencial.Color = System.Drawing.Color.White;
            this.txtxRadioFoneResidencial.Location = new System.Drawing.Point(522, 163);
            this.txtxRadioFoneResidencial.Margin = new System.Windows.Forms.Padding(85, 3, 15, 3);
            this.txtxRadioFoneResidencial.MaxLength = 32767;
            this.txtxRadioFoneResidencial.Name = "txtxRadioFoneResidencial";
            this.txtxRadioFoneResidencial.objConfigComponenteModel = null;
            this.txtxRadioFoneResidencial.ReadOnly = false;
            this.txtxRadioFoneResidencial.Size = new System.Drawing.Size(199, 21);
            this.txtxRadioFoneResidencial.TabIndex = 15;
            // 
            // txtxEmailResidencial
            // 
            this.txtxEmailResidencial._Field = "xEmailResidencial";
            this.txtxEmailResidencial._Help = "Insira o e-mail particular do funcionário, caso possua";
            this.txtxEmailResidencial._LabelGroup = this.sp_Residencial;
            this.txtxEmailResidencial._LabelText = "E-mail resid.";
            this.txtxEmailResidencial._Multiline = false;
            this.txtxEmailResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxEmailResidencial._Password = false;
            this.txtxEmailResidencial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxEmailResidencial._Table = "Funcionario";
            this.txtxEmailResidencial._TamanhoComponente = 268;
            this.txtxEmailResidencial._TamanhoMaiorLabel = 150;
            this.txtxEmailResidencial._Visible = false;
            this.txtxEmailResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxEmailResidencial.Base = null;
            this.txtxEmailResidencial.bConfiguracao = false;
            this.txtxEmailResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxEmailResidencial.Color = System.Drawing.Color.White;
            this.txtxEmailResidencial.Location = new System.Drawing.Point(521, 190);
            this.txtxEmailResidencial.Margin = new System.Windows.Forms.Padding(84, 3, 15, 3);
            this.txtxEmailResidencial.MaxLength = 32767;
            this.txtxEmailResidencial.Name = "txtxEmailResidencial";
            this.txtxEmailResidencial.objConfigComponenteModel = null;
            this.txtxEmailResidencial.ReadOnly = false;
            this.txtxEmailResidencial.Size = new System.Drawing.Size(337, 21);
            this.txtxEmailResidencial.TabIndex = 19;
            // 
            // txtxSkypeResidencial
            // 
            this.txtxSkypeResidencial._Field = "xSkypeResidencial";
            this.txtxSkypeResidencial._Help = "Insira o skype particular do funcionário, caso possua";
            this.txtxSkypeResidencial._LabelGroup = this.sp_Residencial;
            this.txtxSkypeResidencial._LabelText = "Skype resid.";
            this.txtxSkypeResidencial._Multiline = false;
            this.txtxSkypeResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxSkypeResidencial._Password = false;
            this.txtxSkypeResidencial._Regex = null;
            this.txtxSkypeResidencial._Table = "Funcionario";
            this.txtxSkypeResidencial._TamanhoComponente = 268;
            this.txtxSkypeResidencial._TamanhoMaiorLabel = 150;
            this.txtxSkypeResidencial._Visible = false;
            this.txtxSkypeResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxSkypeResidencial.Base = null;
            this.txtxSkypeResidencial.bConfiguracao = false;
            this.txtxSkypeResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxSkypeResidencial.Color = System.Drawing.Color.White;
            this.txtxSkypeResidencial.Location = new System.Drawing.Point(962, 3);
            this.txtxSkypeResidencial.Margin = new System.Windows.Forms.Padding(85, 3, 15, 3);
            this.txtxSkypeResidencial.MaxLength = 32767;
            this.txtxSkypeResidencial.Name = "txtxSkypeResidencial";
            this.txtxSkypeResidencial.objConfigComponenteModel = null;
            this.txtxSkypeResidencial.ReadOnly = false;
            this.txtxSkypeResidencial.Size = new System.Drawing.Size(336, 21);
            this.txtxSkypeResidencial.TabIndex = 16;
            // 
            // txtxMsnResidencial
            // 
            this.txtxMsnResidencial._Field = "xMsnResidencial";
            this.txtxMsnResidencial._Help = "Insira o msn particular do funcionário, caso possua.\t";
            this.txtxMsnResidencial._LabelGroup = this.sp_Residencial;
            this.txtxMsnResidencial._LabelText = "Msn resid.";
            this.txtxMsnResidencial._Multiline = false;
            this.txtxMsnResidencial._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtxMsnResidencial._Password = false;
            this.txtxMsnResidencial._Regex = "^\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
            this.txtxMsnResidencial._Table = "Funcionario";
            this.txtxMsnResidencial._TamanhoComponente = 270;
            this.txtxMsnResidencial._TamanhoMaiorLabel = 160;
            this.txtxMsnResidencial._Visible = false;
            this.txtxMsnResidencial.BackColor = System.Drawing.Color.Transparent;
            this.txtxMsnResidencial.Base = null;
            this.txtxMsnResidencial.bConfiguracao = false;
            this.txtxMsnResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtxMsnResidencial.Color = System.Drawing.Color.White;
            this.txtxMsnResidencial.Location = new System.Drawing.Point(980, 30);
            this.txtxMsnResidencial.Margin = new System.Windows.Forms.Padding(103, 3, 15, 3);
            this.txtxMsnResidencial.MaxLength = 32767;
            this.txtxMsnResidencial.Name = "txtxMsnResidencial";
            this.txtxMsnResidencial.objConfigComponenteModel = null;
            this.txtxMsnResidencial.ReadOnly = false;
            this.txtxMsnResidencial.Size = new System.Drawing.Size(330, 21);
            this.txtxMsnResidencial.TabIndex = 17;
            // 
            // txtXhttpPessoal
            // 
            this.txtXhttpPessoal._Field = "XhttpPessoal";
            this.txtXhttpPessoal._Help = "Insira o endereço de internet  pessoal do funcionário, caso possua";
            this.txtXhttpPessoal._LabelGroup = this.sp_Residencial;
            this.txtXhttpPessoal._LabelText = "Endereço na internet pessoal";
            this.txtXhttpPessoal._Multiline = false;
            this.txtXhttpPessoal._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.txtXhttpPessoal._Password = false;
            this.txtXhttpPessoal._Regex = null;
            this.txtXhttpPessoal._Table = "Funcionario";
            this.txtXhttpPessoal._TamanhoComponente = 264;
            this.txtXhttpPessoal._TamanhoMaiorLabel = 160;
            this.txtXhttpPessoal._Visible = false;
            this.txtXhttpPessoal.BackColor = System.Drawing.Color.Transparent;
            this.txtXhttpPessoal.Base = null;
            this.txtXhttpPessoal.bConfiguracao = false;
            this.txtXhttpPessoal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtXhttpPessoal.Color = System.Drawing.Color.White;
            this.txtXhttpPessoal.Location = new System.Drawing.Point(883, 57);
            this.txtXhttpPessoal.Margin = new System.Windows.Forms.Padding(6, 3, 15, 3);
            this.txtXhttpPessoal.MaxLength = 32767;
            this.txtXhttpPessoal.Name = "txtXhttpPessoal";
            this.txtXhttpPessoal.objConfigComponenteModel = null;
            this.txtXhttpPessoal.ReadOnly = false;
            this.txtXhttpPessoal.Size = new System.Drawing.Size(421, 21);
            this.txtXhttpPessoal.TabIndex = 18;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.kryptonPanel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1144, 225);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Tag = false;
            this.tabPage5.Text = "Certificações";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel6.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel6.TabIndex = 0;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Altera = false;
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.cm = null;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stCertificacaoDataGridViewTextBoxColumn,
            this.xCertificacaoDataGridViewTextBoxColumn,
            this.xMemorandoDataGridViewTextBoxColumn,
            this.dConclusaoDataGridViewTextBoxColumn,
            this.dValidadeDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.bsFuncionarioCertificacao;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.DragDropLinha = false;
            this.kryptonDataGridView1.Exclui = false;
            this.kryptonDataGridView1.Inclui = false;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1144, 225);
            this.kryptonDataGridView1.TabIndex = 1;
            this.kryptonDataGridView1.Tag = "Funcionario_Certificacao";
            // 
            // stCertificacaoDataGridViewTextBoxColumn
            // 
            this.stCertificacaoDataGridViewTextBoxColumn.DataPropertyName = "stCertificacao";
            this.stCertificacaoDataGridViewTextBoxColumn.HeaderText = "Tipo de Certificação";
            this.stCertificacaoDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "0-ENSINO MÉDIO; ",
            "1-ENSINO SUPERIOR; ",
            "2-MBA/PÓS-GRADUAÇÃO;",
            "3- MESTRADO; ",
            "4-DOUTORADO; ",
            "5-PÓS-DOUTORADO; ",
            "6-CURSOS COMPLEMENTARES; ",
            "9-OUTROS"});
            this.stCertificacaoDataGridViewTextBoxColumn.Name = "stCertificacaoDataGridViewTextBoxColumn";
            this.stCertificacaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stCertificacaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stCertificacaoDataGridViewTextBoxColumn.ToolTipText = "Informar a certificação que o funcionário obteve, são eles:";
            this.stCertificacaoDataGridViewTextBoxColumn.Width = 200;
            // 
            // xCertificacaoDataGridViewTextBoxColumn
            // 
            this.xCertificacaoDataGridViewTextBoxColumn.DataPropertyName = "xCertificacao";
            this.xCertificacaoDataGridViewTextBoxColumn.HeaderText = "Certificacao";
            this.xCertificacaoDataGridViewTextBoxColumn.Name = "xCertificacaoDataGridViewTextBoxColumn";
            this.xCertificacaoDataGridViewTextBoxColumn.ToolTipText = "Descrição da Certificação do funcionário";
            // 
            // xMemorandoDataGridViewTextBoxColumn
            // 
            this.xMemorandoDataGridViewTextBoxColumn.DataPropertyName = "xMemorando";
            this.xMemorandoDataGridViewTextBoxColumn.HeaderText = "Memorando";
            this.xMemorandoDataGridViewTextBoxColumn.Name = "xMemorandoDataGridViewTextBoxColumn";
            this.xMemorandoDataGridViewTextBoxColumn.ToolTipText = "Detalhar o certificado";
            // 
            // dConclusaoDataGridViewTextBoxColumn
            // 
            this.dConclusaoDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.dConclusaoDataGridViewTextBoxColumn.Checked = false;
            this.dConclusaoDataGridViewTextBoxColumn.DataPropertyName = "dConclusao";
            this.dConclusaoDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dConclusaoDataGridViewTextBoxColumn.HeaderText = "Conclusão";
            this.dConclusaoDataGridViewTextBoxColumn.Name = "dConclusaoDataGridViewTextBoxColumn";
            this.dConclusaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dConclusaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dConclusaoDataGridViewTextBoxColumn.ToolTipText = "Informar a data de conclusão do certificado do funcionário";
            this.dConclusaoDataGridViewTextBoxColumn.Width = 100;
            // 
            // dValidadeDataGridViewTextBoxColumn
            // 
            this.dValidadeDataGridViewTextBoxColumn.CalendarTodayDate = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.dValidadeDataGridViewTextBoxColumn.Checked = false;
            this.dValidadeDataGridViewTextBoxColumn.DataPropertyName = "dValidade";
            this.dValidadeDataGridViewTextBoxColumn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dValidadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.dValidadeDataGridViewTextBoxColumn.Name = "dValidadeDataGridViewTextBoxColumn";
            this.dValidadeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dValidadeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dValidadeDataGridViewTextBoxColumn.ToolTipText = "Informar a data de validade do certificado do funcionário";
            this.dValidadeDataGridViewTextBoxColumn.Width = 100;
            // 
            // bsFuncionarioCertificacao
            // 
            this.bsFuncionarioCertificacao.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_CertificacaoModel);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.kryptonTabControl3);
            this.tabPage6.Controls.Add(this.kryptonPanel9);
            this.tabPage6.Controls.Add(this.splitter1);
            this.tabPage6.Controls.Add(this.kryptonTabControl2);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1144, 225);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Tag = false;
            this.tabPage6.Text = "Representante";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // kryptonTabControl3
            // 
            this.kryptonTabControl3.AllowCloseButton = false;
            this.kryptonTabControl3.AllowContextButton = false;
            this.kryptonTabControl3.AllowNavigatorButtons = false;
            this.kryptonTabControl3.AllowSelectedTabHigh = false;
            this.kryptonTabControl3.BorderWidth = 1;
            this.kryptonTabControl3.Controls.Add(this.tabPage11);
            this.kryptonTabControl3.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl3.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl3.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl3.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl3.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl3.HotTrack = true;
            this.kryptonTabControl3.Location = new System.Drawing.Point(0, 176);
            this.kryptonTabControl3.Name = "kryptonTabControl3";
            this.kryptonTabControl3.PreserveTabColor = false;
            this.kryptonTabControl3.SelectedIndex = 0;
            this.kryptonTabControl3.Size = new System.Drawing.Size(1144, 49);
            this.kryptonTabControl3.TabIndex = 8;
            this.kryptonTabControl3.UseExtendedLayout = false;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage11.Controls.Add(this.dgvFuncionario_Comissao_Produto);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1136, 20);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Tag = false;
            this.tabPage11.Text = "Produtos";
            // 
            // dgvFuncionario_Comissao_Produto
            // 
            this.dgvFuncionario_Comissao_Produto.Altera = false;
            this.dgvFuncionario_Comissao_Produto.AutoGenerateColumns = false;
            this.dgvFuncionario_Comissao_Produto.cm = null;
            this.dgvFuncionario_Comissao_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario_Comissao_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.pComissaoAvistaDataGridViewTextBoxColumn,
            this.pComissaoAprazoDataGridViewTextBoxColumn});
            this.dgvFuncionario_Comissao_Produto.DataSource = this.bsFuncionarioComissaoProduto;
            this.dgvFuncionario_Comissao_Produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario_Comissao_Produto.DragDropLinha = false;
            this.dgvFuncionario_Comissao_Produto.Exclui = false;
            this.dgvFuncionario_Comissao_Produto.Inclui = false;
            this.dgvFuncionario_Comissao_Produto.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionario_Comissao_Produto.Name = "dgvFuncionario_Comissao_Produto";
            this.dgvFuncionario_Comissao_Produto.Size = new System.Drawing.Size(1136, 20);
            this.dgvFuncionario_Comissao_Produto.TabIndex = 5;
            this.dgvFuncionario_Comissao_Produto.Tag = "Funcionario_Comissao_Produto";
            // 
            // idProduto
            // 
            this.idProduto.DataPropertyName = "idProduto";
            this.idProduto.HeaderText = "Produto";
            this.idProduto.Name = "idProduto";
            this.idProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idProduto.ToolTipText = "Informar o produto para lançamento das comissões";
            this.idProduto.Width = 400;
            // 
            // pComissaoAvistaDataGridViewTextBoxColumn
            // 
            this.pComissaoAvistaDataGridViewTextBoxColumn.DataPropertyName = "pComissaoAvista";
            this.pComissaoAvistaDataGridViewTextBoxColumn.HeaderText = "% comissao a vista";
            this.pComissaoAvistaDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissaoAvistaDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissaoAvistaDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissaoAvistaDataGridViewTextBoxColumn.Name = "pComissaoAvistaDataGridViewTextBoxColumn";
            this.pComissaoAvistaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAvistaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAvistaDataGridViewTextBoxColumn.ToolTipText = "Informar a alíquota em percentual da comissão ";
            this.pComissaoAvistaDataGridViewTextBoxColumn.Width = 150;
            // 
            // pComissaoAprazoDataGridViewTextBoxColumn
            // 
            this.pComissaoAprazoDataGridViewTextBoxColumn.DataPropertyName = "pComissaoAprazo";
            this.pComissaoAprazoDataGridViewTextBoxColumn.HeaderText = "% comissao a prazo";
            this.pComissaoAprazoDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissaoAprazoDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissaoAprazoDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissaoAprazoDataGridViewTextBoxColumn.Name = "pComissaoAprazoDataGridViewTextBoxColumn";
            this.pComissaoAprazoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAprazoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAprazoDataGridViewTextBoxColumn.ToolTipText = "Informar a alíquota em percentual da comissão ";
            this.pComissaoAprazoDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsFuncionarioComissaoProduto
            // 
            this.bsFuncionarioComissaoProduto.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_Comissao_ProdutoModel);
            // 
            // kryptonPanel9
            // 
            this.kryptonPanel9.Controls.Add(this.btnAplicarComissao);
            this.kryptonPanel9.Controls.Add(this.btnCarregarProdutos);
            this.kryptonPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel9.Location = new System.Drawing.Point(0, 143);
            this.kryptonPanel9.Name = "kryptonPanel9";
            this.kryptonPanel9.Size = new System.Drawing.Size(1144, 33);
            this.kryptonPanel9.TabIndex = 7;
            // 
            // btnAplicarComissao
            // 
            this.btnAplicarComissao._LabelGroup = null;
            this.btnAplicarComissao._LabelText = "Aplicar taxa de comissão aos produtos";
            this.btnAplicarComissao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnAplicarComissao._Regex = null;
            this.btnAplicarComissao._TamanhoComponente = 232;
            this.btnAplicarComissao._TamanhoMaiorLabel = 0;
            this.btnAplicarComissao._Visible = false;
            this.btnAplicarComissao.Base = null;
            this.btnAplicarComissao.bConfiguracao = false;
            this.btnAplicarComissao.Location = new System.Drawing.Point(212, 4);
            this.btnAplicarComissao.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnAplicarComissao.Name = "btnAplicarComissao";
            this.btnAplicarComissao.objConfigComponenteModel = null;
            this.btnAplicarComissao.Size = new System.Drawing.Size(232, 24);
            this.btnAplicarComissao.TabIndex = 3;
            // 
            // btnCarregarProdutos
            // 
            this.btnCarregarProdutos._LabelGroup = null;
            this.btnCarregarProdutos._LabelText = "Carregar todos os produtos";
            this.btnCarregarProdutos._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.btnCarregarProdutos._Regex = null;
            this.btnCarregarProdutos._TamanhoComponente = 168;
            this.btnCarregarProdutos._TamanhoMaiorLabel = 0;
            this.btnCarregarProdutos._Visible = false;
            this.btnCarregarProdutos.Base = null;
            this.btnCarregarProdutos.bConfiguracao = false;
            this.btnCarregarProdutos.Location = new System.Drawing.Point(7, 4);
            this.btnCarregarProdutos.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnCarregarProdutos.Name = "btnCarregarProdutos";
            this.btnCarregarProdutos.objConfigComponenteModel = null;
            this.btnCarregarProdutos.Size = new System.Drawing.Size(168, 24);
            this.btnCarregarProdutos.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 140);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1144, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // kryptonTabControl2
            // 
            this.kryptonTabControl2.AllowCloseButton = false;
            this.kryptonTabControl2.AllowContextButton = false;
            this.kryptonTabControl2.AllowNavigatorButtons = false;
            this.kryptonTabControl2.AllowSelectedTabHigh = false;
            this.kryptonTabControl2.BorderWidth = 1;
            this.kryptonTabControl2.Controls.Add(this.tabPage10);
            this.kryptonTabControl2.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl2.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl2.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl2.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonTabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.kryptonTabControl2.HotTrack = true;
            this.kryptonTabControl2.Location = new System.Drawing.Point(0, 0);
            this.kryptonTabControl2.Name = "kryptonTabControl2";
            this.kryptonTabControl2.PreserveTabColor = false;
            this.kryptonTabControl2.SelectedIndex = 0;
            this.kryptonTabControl2.Size = new System.Drawing.Size(1144, 140);
            this.kryptonTabControl2.TabIndex = 4;
            this.kryptonTabControl2.UseExtendedLayout = false;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage10.Controls.Add(this.kryptonPanel1);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1136, 111);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Tag = false;
            this.tabPage10.Text = "Dados de comissão";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.BorderWidth = 0;
            this.kryptonPanel1.Controls.Add(this.flowLayoutPanel4);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanel1.GradientToogleColors = false;
            this.kryptonPanel1.GradientUseBlend = false;
            this.kryptonPanel1.GradientUseSolid = true;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PersistentColors = false;
            this.kryptonPanel1.Size = new System.Drawing.Size(1136, 111);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.spComissao);
            this.flowLayoutPanel4.Controls.Add(this.cbxstComissao);
            this.flowLayoutPanel4.Controls.Add(this.nudpComissaoAvista);
            this.flowLayoutPanel4.Controls.Add(this.nudpComissaoAprazo);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1136, 111);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // spComissao
            // 
            this.spComissao._LabelText = "Comissão";
            this.spComissao._TamanhoMaiorLabel = 0;
            this.spComissao.BackColor = System.Drawing.Color.Transparent;
            this.spComissao.Location = new System.Drawing.Point(0, 3);
            this.spComissao.Margin = new System.Windows.Forms.Padding(0, 3, 15, 3);
            this.spComissao.Name = "spComissao";
            this.spComissao.Size = new System.Drawing.Size(300, 19);
            this.spComissao.TabIndex = 3;
            this.spComissao.TabStop = false;
            // 
            // cbxstComissao
            // 
            this.cbxstComissao._Field = "stComissao";
            this.cbxstComissao._Help = "Informar o tipo de comissão a ser calculada para o representante, são elas:";
            this.cbxstComissao._Itens = ((System.Collections.Generic.List<string>)(resources.GetObject("cbxstComissao._Itens")));
            this.cbxstComissao._LabelGroup = this.spComissao;
            this.cbxstComissao._LabelText = "Tipo de comissão";
            this.cbxstComissao._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.cbxstComissao._Regex = null;
            this.cbxstComissao._situacao = false;
            this.cbxstComissao._Table = "Funcionario";
            this.cbxstComissao._TamanhoComponente = 218;
            this.cbxstComissao._TamanhoMaiorLabel = 160;
            this.cbxstComissao._Visible = false;
            this.cbxstComissao.BackColor = System.Drawing.Color.Transparent;
            this.cbxstComissao.Base = null;
            this.cbxstComissao.bConfiguracao = false;
            this.cbxstComissao.Color = System.Drawing.Color.White;
            this.cbxstComissao.DataSource = null;
            this.cbxstComissao.DisplayMember = "DisplayMember";
            this.cbxstComissao.Location = new System.Drawing.Point(68, 28);
            this.cbxstComissao.Margin = new System.Windows.Forms.Padding(68, 3, 15, 3);
            this.cbxstComissao.Name = "cbxstComissao";
            this.cbxstComissao.objConfigComponenteModel = null;
            this.cbxstComissao.SelectedIndex = 0;
            this.cbxstComissao.SelectedValue = 0;
            this.cbxstComissao.Size = new System.Drawing.Size(313, 21);
            this.cbxstComissao.TabIndex = 0;
            this.cbxstComissao.ValueMember = "ValueMember";
            // 
            // nudpComissaoAvista
            // 
            this.nudpComissaoAvista._Field = "pComissaoAvista";
            this.nudpComissaoAvista._Help = "Informar a alíquota em percentual da comissão somente para valores a vista, quand" +
    "o a condição de vendas for igual avista";
            this.nudpComissaoAvista._LabelGroup = this.spComissao;
            this.nudpComissaoAvista._LabelText = "Percentual comissão a vista";
            this.nudpComissaoAvista._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpComissaoAvista._Regex = null;
            this.nudpComissaoAvista._Table = "Funcionario";
            this.nudpComissaoAvista._TamanhoComponente = 90;
            this.nudpComissaoAvista._TamanhoMaiorLabel = 160;
            this.nudpComissaoAvista._Visible = false;
            this.nudpComissaoAvista.BackColor = System.Drawing.Color.Transparent;
            this.nudpComissaoAvista.Base = null;
            this.nudpComissaoAvista.bConfiguracao = false;
            this.nudpComissaoAvista.Color = System.Drawing.Color.White;
            this.nudpComissaoAvista.DecimalPlaces = 2;
            this.nudpComissaoAvista.Location = new System.Drawing.Point(17, 55);
            this.nudpComissaoAvista.Margin = new System.Windows.Forms.Padding(17, 3, 15, 3);
            this.nudpComissaoAvista.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpComissaoAvista.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpComissaoAvista.Name = "nudpComissaoAvista";
            this.nudpComissaoAvista.objConfigComponenteModel = null;
            this.nudpComissaoAvista.ReadOnly = false;
            this.nudpComissaoAvista.Size = new System.Drawing.Size(236, 22);
            this.nudpComissaoAvista.TabIndex = 1;
            this.nudpComissaoAvista.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpComissaoAvista.ValueInt = 0;
            // 
            // nudpComissaoAprazo
            // 
            this.nudpComissaoAprazo._Field = "pComissaoAprazo";
            this.nudpComissaoAprazo._Help = "Informar a alíquota em percentual da comissão somente para valores a prazo";
            this.nudpComissaoAprazo._LabelGroup = this.spComissao;
            this.nudpComissaoAprazo._LabelText = "Percentual comissão a prazo";
            this.nudpComissaoAprazo._Obrigatorio = HLP.Comum.Components.UserControlBase.CampoObrigatorio.NÃO;
            this.nudpComissaoAprazo._Regex = null;
            this.nudpComissaoAprazo._Table = "Funcionario";
            this.nudpComissaoAprazo._TamanhoComponente = 74;
            this.nudpComissaoAprazo._TamanhoMaiorLabel = 160;
            this.nudpComissaoAprazo._Visible = false;
            this.nudpComissaoAprazo.BackColor = System.Drawing.Color.Transparent;
            this.nudpComissaoAprazo.Base = null;
            this.nudpComissaoAprazo.bConfiguracao = false;
            this.nudpComissaoAprazo.Color = System.Drawing.Color.White;
            this.nudpComissaoAprazo.DecimalPlaces = 2;
            this.nudpComissaoAprazo.Location = new System.Drawing.Point(11, 83);
            this.nudpComissaoAprazo.Margin = new System.Windows.Forms.Padding(11, 3, 15, 3);
            this.nudpComissaoAprazo.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudpComissaoAprazo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudpComissaoAprazo.Name = "nudpComissaoAprazo";
            this.nudpComissaoAprazo.objConfigComponenteModel = null;
            this.nudpComissaoAprazo.ReadOnly = false;
            this.nudpComissaoAprazo.Size = new System.Drawing.Size(226, 22);
            this.nudpComissaoAprazo.TabIndex = 2;
            this.nudpComissaoAprazo.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.nudpComissaoAprazo.ValueInt = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.kryptonPanel3);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1144, 225);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Tag = false;
            this.tabPage7.Text = "Comissão / Faixa de margem de lucro";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonDataGridView2);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel3.TabIndex = 0;
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.Altera = false;
            this.kryptonDataGridView2.AutoGenerateColumns = false;
            this.kryptonDataGridView2.cm = null;
            this.kryptonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pDeMargemVendaDataGridViewTextBoxColumn,
            this.pAteMargemVendaDataGridViewTextBoxColumn,
            this.pComissaoAvistaDataGridViewTextBoxColumn1,
            this.pComissaoAprazoDataGridViewTextBoxColumn1});
            this.kryptonDataGridView2.DataSource = this.bsFuncionarioMargemLucroComissao;
            this.kryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView2.DragDropLinha = false;
            this.kryptonDataGridView2.Exclui = false;
            this.kryptonDataGridView2.Inclui = false;
            this.kryptonDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.Size = new System.Drawing.Size(1144, 225);
            this.kryptonDataGridView2.TabIndex = 0;
            this.kryptonDataGridView2.Tag = "Funcionario_Margem_Lucro_Comissao";
            // 
            // pDeMargemVendaDataGridViewTextBoxColumn
            // 
            this.pDeMargemVendaDataGridViewTextBoxColumn.DataPropertyName = "pDeMargemVenda";
            this.pDeMargemVendaDataGridViewTextBoxColumn.HeaderText = "De";
            this.pDeMargemVendaDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pDeMargemVendaDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pDeMargemVendaDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pDeMargemVendaDataGridViewTextBoxColumn.Name = "pDeMargemVendaDataGridViewTextBoxColumn";
            this.pDeMargemVendaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pDeMargemVendaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pDeMargemVendaDataGridViewTextBoxColumn.ToolTipText = "Informar a alíquota em percentual da comissão ";
            this.pDeMargemVendaDataGridViewTextBoxColumn.Width = 100;
            // 
            // pAteMargemVendaDataGridViewTextBoxColumn
            // 
            this.pAteMargemVendaDataGridViewTextBoxColumn.DataPropertyName = "pAteMargemVenda";
            this.pAteMargemVendaDataGridViewTextBoxColumn.HeaderText = "Até";
            this.pAteMargemVendaDataGridViewTextBoxColumn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pAteMargemVendaDataGridViewTextBoxColumn.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pAteMargemVendaDataGridViewTextBoxColumn.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pAteMargemVendaDataGridViewTextBoxColumn.Name = "pAteMargemVendaDataGridViewTextBoxColumn";
            this.pAteMargemVendaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pAteMargemVendaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pAteMargemVendaDataGridViewTextBoxColumn.ToolTipText = "Informar o inicio da faixa de Margem de Venda.\t";
            this.pAteMargemVendaDataGridViewTextBoxColumn.Width = 100;
            // 
            // pComissaoAvistaDataGridViewTextBoxColumn1
            // 
            this.pComissaoAvistaDataGridViewTextBoxColumn1.DataPropertyName = "pComissaoAvista";
            this.pComissaoAvistaDataGridViewTextBoxColumn1.HeaderText = "% Comissão a vista";
            this.pComissaoAvistaDataGridViewTextBoxColumn1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissaoAvistaDataGridViewTextBoxColumn1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissaoAvistaDataGridViewTextBoxColumn1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissaoAvistaDataGridViewTextBoxColumn1.Name = "pComissaoAvistaDataGridViewTextBoxColumn1";
            this.pComissaoAvistaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAvistaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAvistaDataGridViewTextBoxColumn1.ToolTipText = "Informar a alíquota em percentual da comissão somente para valores a Vista, quand" +
    "o a condução de vendas for por Dinheiro";
            this.pComissaoAvistaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // pComissaoAprazoDataGridViewTextBoxColumn1
            // 
            this.pComissaoAprazoDataGridViewTextBoxColumn1.DataPropertyName = "pComissaoAprazo";
            this.pComissaoAprazoDataGridViewTextBoxColumn1.HeaderText = "% Comissão a prazo";
            this.pComissaoAprazoDataGridViewTextBoxColumn1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pComissaoAprazoDataGridViewTextBoxColumn1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pComissaoAprazoDataGridViewTextBoxColumn1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pComissaoAprazoDataGridViewTextBoxColumn1.Name = "pComissaoAprazoDataGridViewTextBoxColumn1";
            this.pComissaoAprazoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pComissaoAprazoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pComissaoAprazoDataGridViewTextBoxColumn1.ToolTipText = "Informar a alíquota em percentual da comissão somente para valores a Prazo, quand" +
    "o a condução de vendas for Cartão de Débito e Crédito, Cheques e valores Líquido" +
    "s ou Duplicatas geradas";
            this.pComissaoAprazoDataGridViewTextBoxColumn1.Width = 150;
            // 
            // bsFuncionarioMargemLucroComissao
            // 
            this.bsFuncionarioMargemLucroComissao.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_Margem_Lucro_ComissaoModel);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.kryptonPanel4);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1144, 225);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Tag = false;
            this.tabPage8.Text = "Arquivos";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.dgvArquivos);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel4.TabIndex = 0;
            // 
            // dgvArquivos
            // 
            this.dgvArquivos.Altera = false;
            this.dgvArquivos.AutoGenerateColumns = false;
            this.dgvArquivos.cm = null;
            this.dgvArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xArquivoDataGridViewTextBoxColumn,
            this.xLinkDataGridViewTextBoxColumn});
            this.dgvArquivos.DataSource = this.bsFuncionarioArquivo;
            this.dgvArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArquivos.DragDropLinha = false;
            this.dgvArquivos.Exclui = false;
            this.dgvArquivos.Inclui = false;
            this.dgvArquivos.Location = new System.Drawing.Point(0, 0);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.Size = new System.Drawing.Size(1144, 225);
            this.dgvArquivos.TabIndex = 0;
            this.dgvArquivos.Tag = "Funcionario_Arquivo";
            this.dgvArquivos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView3_CellDoubleClick);
            this.dgvArquivos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvArquivos_KeyDown);
            // 
            // xArquivoDataGridViewTextBoxColumn
            // 
            this.xArquivoDataGridViewTextBoxColumn.DataPropertyName = "xArquivo";
            this.xArquivoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.xArquivoDataGridViewTextBoxColumn.Name = "xArquivoDataGridViewTextBoxColumn";
            this.xArquivoDataGridViewTextBoxColumn.ToolTipText = "Informativo sobre o arquivo";
            this.xArquivoDataGridViewTextBoxColumn.Width = 200;
            // 
            // xLinkDataGridViewTextBoxColumn
            // 
            this.xLinkDataGridViewTextBoxColumn.DataPropertyName = "xLink";
            this.xLinkDataGridViewTextBoxColumn.HeaderText = "Caminho do Arquivo (F5 para Pesquisar e Duplo Clique para Abrir)";
            this.xLinkDataGridViewTextBoxColumn.Name = "xLinkDataGridViewTextBoxColumn";
            this.xLinkDataGridViewTextBoxColumn.ToolTipText = "Informar o local do arquivo a ser registrado ao funcionário";
            this.xLinkDataGridViewTextBoxColumn.Width = 400;
            // 
            // bsFuncionarioArquivo
            // 
            this.bsFuncionarioArquivo.DataSource = typeof(HLP.Models.Entries.Gerais.Funcionario_ArquivoModel);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.kryptonPanel8);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1144, 225);
            this.tabPage9.TabIndex = 9;
            this.tabPage9.Tag = false;
            this.tabPage9.Text = "Hierarquia";
            // 
            // kryptonPanel8
            // 
            this.kryptonPanel8.Controls.Add(this.treeHierarquia);
            this.kryptonPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel8.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel8.Name = "kryptonPanel8";
            this.kryptonPanel8.Size = new System.Drawing.Size(1144, 225);
            this.kryptonPanel8.TabIndex = 0;
            // 
            // treeHierarquia
            // 
            this.treeHierarquia.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.treeHierarquia.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ContextMenuInner;
            this.treeHierarquia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHierarquia.ItemHeight = 21;
            this.treeHierarquia.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.treeHierarquia.Location = new System.Drawing.Point(0, 0);
            this.treeHierarquia.Name = "treeHierarquia";
            this.treeHierarquia.OverrideFocus.Node.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.treeHierarquia.Size = new System.Drawing.Size(1144, 225);
            this.treeHierarquia.StateCommon.Node.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.treeHierarquia.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.treeHierarquia.TabIndex = 1;
            // 
            // kryptonDataGridViewDateTimePickerColumn1
            // 
            this.kryptonDataGridViewDateTimePickerColumn1.CalendarTodayDate = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn1.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn1.DataPropertyName = "dConclusao";
            this.kryptonDataGridViewDateTimePickerColumn1.HeaderText = "Conclusão";
            this.kryptonDataGridViewDateTimePickerColumn1.Name = "kryptonDataGridViewDateTimePickerColumn1";
            this.kryptonDataGridViewDateTimePickerColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn1.Width = 100;
            // 
            // kryptonDataGridViewDateTimePickerColumn2
            // 
            this.kryptonDataGridViewDateTimePickerColumn2.CalendarTodayDate = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn2.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn2.DataPropertyName = "dValidade";
            this.kryptonDataGridViewDateTimePickerColumn2.HeaderText = "Validade";
            this.kryptonDataGridViewDateTimePickerColumn2.Name = "kryptonDataGridViewDateTimePickerColumn2";
            this.kryptonDataGridViewDateTimePickerColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn2.Width = 100;
            // 
            // kryptonDataGridViewDateTimePickerColumn3
            // 
            this.kryptonDataGridViewDateTimePickerColumn3.CalendarTodayDate = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn3.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn3.DataPropertyName = "dConclusao";
            this.kryptonDataGridViewDateTimePickerColumn3.HeaderText = "Conclusão";
            this.kryptonDataGridViewDateTimePickerColumn3.Name = "kryptonDataGridViewDateTimePickerColumn3";
            this.kryptonDataGridViewDateTimePickerColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn3.Width = 100;
            // 
            // kryptonDataGridViewDateTimePickerColumn4
            // 
            this.kryptonDataGridViewDateTimePickerColumn4.CalendarTodayDate = new System.DateTime(2012, 8, 15, 0, 0, 0, 0);
            this.kryptonDataGridViewDateTimePickerColumn4.Checked = false;
            this.kryptonDataGridViewDateTimePickerColumn4.DataPropertyName = "dValidade";
            this.kryptonDataGridViewDateTimePickerColumn4.HeaderText = "Validade";
            this.kryptonDataGridViewDateTimePickerColumn4.Name = "kryptonDataGridViewDateTimePickerColumn4";
            this.kryptonDataGridViewDateTimePickerColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewDateTimePickerColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kryptonDataGridViewDateTimePickerColumn4.Width = 100;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 561);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFuncionario";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = -10;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.FormContato_Load);
            this.Controls.SetChildIndex(this.kryptonPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsRetPesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPadrao)).EndInit();
            this.panelPadrao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioEndereco)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioCertificacao)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.kryptonTabControl3.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario_Comissao_Produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioComissaoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel9)).EndInit();
            this.kryptonPanel9.ResumeLayout(false);
            this.kryptonTabControl2.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.kryptonPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioMargemLucroComissao)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioArquivo)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel8)).EndInit();
            this.kryptonPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Comum.Components.HLP_TextBox txtCodigo;
        private Comum.Components.HLP_TextBox txtxCodigoAlternativo;
        private Comum.Components.HLP_TextBox txtxSaudacao;
        private Comum.Components.HLP_TextBox txtxInformacaoAtencao;
        private Comum.Components.HLP_ComboBox cbxAtivo;
        private Comum.Components.HLP_ComboBox cbxstPerfil;
        private System.Windows.Forms.TabPage tabPage3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage2;
        private HLP_DataGridView dgvEndereco;
        private System.Windows.Forms.TabPage tabPage4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Comum.Components.HLP_LabelSeparator sp_Identificacao;
        private Comum.Components.HLP_LabelSeparator sp_InfPessoal;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private Comum.Components.HLP_TextBox txtxNome;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCargo;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidCalendário;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidSite;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidDeposito;
        private System.Windows.Forms.BindingSource bsFuncionarioEndereco;
        private Comum.Components.HLP_DateTimePicker dtdAniversario;
        private Comum.Components.HLP_ComboBox cbxstSexo;
        private Comum.Components.HLP_DateTimePicker dtdFalecimento;
        private Comum.Components.HLP_MaskedTextBox mskxCpf;
        private Comum.Components.HLP_TextBox txtxRg;
        private Comum.Components.HLP_TextBox txtxConjugue;
        private Comum.Components.HLP_TextBox txtxFilhos;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidContaBancaria;
        private Comum.Components.HLP_TextBox txtxVisto;
        private Comum.Components.HLP_DateTimePicker dtdFinalVisto;
        private Comum.Components.HLP_TextBox txtxVistoTrabalho;
        private Comum.Components.HLP_DateTimePicker dtdFinalVistoTrabalho;
        private Comum.Components.HLP_DateTimePicker dtdAdmissao;
        private Comum.Components.HLP_NumericUpDown nudvDiaria;
        private Comum.Components.HLP_ComboBox cbxstSalario;
        private Comum.Components.HLP_NumericUpDown nudvSalario;
        private Comum.Components.HLP_NumericUpDown nudvSalarioHora;
        private Comum.Components.HLP_Pesquisa hlP_PesquisaidResponsavel;
        private Comum.Components.HLP_LabelSeparator sp_Comercial;
        private Comum.Components.HLP_TextBox txtxTelefoneComercial;
        private Comum.Components.HLP_TextBox txtxRamalComercial;
        private Comum.Components.HLP_TextBox txtxCelularComercial;
        private Comum.Components.HLP_TextBox txtxRadioFoneComercial;
        private Comum.Components.HLP_TextBox txtxPagerComercial;
        private Comum.Components.HLP_TextBox txtxFaxComercial;
        private Comum.Components.HLP_TextBox txtxEmailComercial;
        private Comum.Components.HLP_TextBox txtxSkypeComercial;
        private Comum.Components.HLP_TextBox txtxMSNComercial;
        private Comum.Components.HLP_TextBox txtxhttpComercial;
        private Comum.Components.HLP_LabelSeparator sp_Residencial;
        private Comum.Components.HLP_TextBox txtxTelefoneResidencial;
        private Comum.Components.HLP_TextBox txtxCelularResidencial;
        private Comum.Components.HLP_TextBox txtxRadioFoneResidencial;
        private Comum.Components.HLP_TextBox txtxEmailResidencial;
        private Comum.Components.HLP_TextBox txtxSkypeResidencial;
        private Comum.Components.HLP_TextBox txtxMsnResidencial;
        private Comum.Components.HLP_TextBox txtXhttpPessoal;
        private HLP_DataGridView kryptonDataGridView1;
        private System.Windows.Forms.BindingSource bsFuncionarioCertificacao;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.BindingSource bsFuncionarioComissaoProduto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Comum.Components.HLP_ComboBox cbxstComissao;
        private Comum.Components.HLP_NumericUpDown nudpComissaoAvista;
        private Comum.Components.HLP_NumericUpDown nudpComissaoAprazo;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private Comum.Components.HLP_LabelSeparator sp_administracao;
        private Comum.Components.HLP_LabelSeparator sp_reqCompras;
        private Comum.Components.HLP_LabelSeparator spVisto;
        private Comum.Components.HLP_LabelSeparator sp_deptoPessoal;
        private Comum.Components.HLP_LabelSeparator sp_qtdehorastrab;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private HLP_DataGridView kryptonDataGridView2;
        private System.Windows.Forms.BindingSource bsFuncionarioMargemLucroComissao;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private HLP_DataGridView dgvArquivos;
        private System.Windows.Forms.BindingSource bsFuncionarioArquivo;
        private System.Windows.Forms.TabPage tabPage9;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel8;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn2;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasSegunda;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasTerca;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasQuarta;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasQuinta;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasSexta;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasSabado;
        private Comum.Components.HLP_DateTimePicker dtdQtdHorasDomingo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn kryptonDataGridViewDateTimePickerColumn4;
        private System.Windows.Forms.Splitter splitter1;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl2;
        private System.Windows.Forms.TabPage tabPage10;
        private AC.ExtendedRenderer.Toolkit.KryptonPanel kryptonPanel1;
        private Comum.Components.HLP_Pesquisa hlP_Pesquisa_idDepartamento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView treeHierarquia;
        private Comum.Components.HLP_TextBox txtTotalHorasTab;
        private System.Windows.Forms.DataGridViewComboBoxColumn stPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNome;
        private System.Windows.Forms.DataGridViewComboBoxColumn stTipoEnderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEnderecoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn xCepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xComplementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xBairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFusoHorarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCaixaPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCidade;
        private System.Windows.Forms.DataGridViewComboBoxColumn stCertificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCertificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMemorandoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dConclusaoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn dValidadeDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pDeMargemVendaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pAteMargemVendaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissaoAvistaDataGridViewTextBoxColumn1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissaoAprazoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xArquivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLinkDataGridViewTextBoxColumn;
        private HLP_LabelSeparator spComissao;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl3;
        private System.Windows.Forms.TabPage tabPage11;
        private HLP_DataGridView dgvFuncionario_Comissao_Produto;
        private System.Windows.Forms.DataGridViewComboBoxColumn idProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissaoAvistaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn pComissaoAprazoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel9;
        private HLP_Button btnAplicarComissao;
        private HLP_Button btnCarregarProdutos;
    }
}

