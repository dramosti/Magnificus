namespace Magnificus
{
    partial class FormScripts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScripts));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.hlP_DataGridView1 = new HLP.Comum.Components.HLP_DataGridView();
            this.versao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtExecucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.script = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAtualizacoes = new System.Windows.Forms.BindingSource(this.components);
            this.bwAtualizacoes = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatusScripts = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hlP_DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtualizacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblStatusScripts);
            this.kryptonPanel1.Controls.Add(this.progressBar1);
            this.kryptonPanel1.Controls.Add(this.btnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 281);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(540, 51);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(423, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.hlP_DataGridView1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(540, 281);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // hlP_DataGridView1
            // 
            this.hlP_DataGridView1.AllowUserToAddRows = false;
            this.hlP_DataGridView1.AllowUserToDeleteRows = false;
            this.hlP_DataGridView1.Altera = false;
            this.hlP_DataGridView1.AutoGenerateColumns = false;
            this.hlP_DataGridView1.cm = null;
            this.hlP_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hlP_DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.versao,
            this.dtExecucao,
            this.script});
            this.hlP_DataGridView1.DataSource = this.bsAtualizacoes;
            this.hlP_DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hlP_DataGridView1.DragDropLinha = false;
            this.hlP_DataGridView1.Exclui = false;
            this.hlP_DataGridView1.Inclui = false;
            this.hlP_DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.hlP_DataGridView1.Name = "hlP_DataGridView1";
            this.hlP_DataGridView1.ReadOnly = true;
            this.hlP_DataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hlP_DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hlP_DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hlP_DataGridView1.Size = new System.Drawing.Size(540, 281);
            this.hlP_DataGridView1.TabIndex = 0;
            this.hlP_DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hlP_DataGridView1_CellContentClick);
            this.hlP_DataGridView1.Click += new System.EventHandler(this.hlP_DataGridView1_Click);
            // 
            // versao
            // 
            this.versao.DataPropertyName = "xVersao";
            this.versao.HeaderText = "Versão";
            this.versao.Name = "versao";
            this.versao.ReadOnly = true;
            this.versao.Width = 150;
            // 
            // dtExecucao
            // 
            this.dtExecucao.DataPropertyName = "dtExec";
            this.dtExecucao.HeaderText = "Data de Execução";
            this.dtExecucao.Name = "dtExecucao";
            this.dtExecucao.ReadOnly = true;
            this.dtExecucao.Width = 150;
            // 
            // script
            // 
            this.script.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.script.DataPropertyName = "script";
            this.script.HeaderText = "script";
            this.script.Name = "script";
            this.script.ReadOnly = true;
            // 
            // bsAtualizacoes
            // 
            this.bsAtualizacoes.DataSource = typeof(HLP.Models.Entries.Gerais.Log_ScriptsModel);
            // 
            // bwAtualizacoes
            // 
            this.bwAtualizacoes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAtualizacoes_DoWork);
            this.bwAtualizacoes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAtualizacoes_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(169, 18);
            this.progressBar1.TabIndex = 1;
            // 
            // lblStatusScripts
            // 
            this.lblStatusScripts.Location = new System.Drawing.Point(12, 28);
            this.lblStatusScripts.Name = "lblStatusScripts";
            this.lblStatusScripts.Size = new System.Drawing.Size(88, 20);
            this.lblStatusScripts.TabIndex = 2;
            this.lblStatusScripts.Values.Text = "kryptonLabel1";
            // 
            // FormScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 332);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScripts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scripts a serem executados";
            this.Load += new System.EventHandler(this.FormScripts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hlP_DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtualizacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private HLP.Comum.Components.HLP_DataGridView hlP_DataGridView1;
        private System.Windows.Forms.BindingSource bsAtualizacoes;
        private System.ComponentModel.BackgroundWorker bwAtualizacoes;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn versao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtExecucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn script;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStatusScripts;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}