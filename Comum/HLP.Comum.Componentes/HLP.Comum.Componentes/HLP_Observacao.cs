﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HLP.Comum.Models;

namespace HLP.Comum.Components
{
    public partial class HLP_Observacao : UserControlBase
    {

        public HLP_Observacao()
        {
            InitializeComponent();
            base.Initialize();
            base.controleBase = this.btnVisualizar;
            base.lblBase = this.lblDescricao;

        }

        [Category("HLP")]
        [Description("Habilita e desabilita o componente")]
        public new bool Enabled
        {
            get { return btnVisualizar.Enabled; }
            set
            {
                btnVisualizar.Enabled = value;
                this.TabStop = value;
            }
        }

        [Category("HLP")]
        public override string Text { get; set; }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FormObservacao frm = new FormObservacao(Text);
                frm.ShowDialog();
                this.Text = frm._Text;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void HLP_Observacao_Load(object sender, EventArgs e)
        {
            //this.Height = 26;
        }
        public event EventHandler _Enter;
        private void HLP_Observacao_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
            {
                _Enter(sender, e);
            }
        }

        private bool _ReadOnly = false;
        [Category("HLP")]
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                btnVisualizar.Enabled = !value;
            }
        }

        [Category("HLP")]
        [Description("Label no modo superior ?")]
        public bool _LabelSuperior
        {
            get { return _labelSuperior; }
            set
            {
                _labelSuperior = value;
                if (value)
                {
                    this.Height = 36;
                }
                else
                {
                    this.Height = 24;
                }
            }
        }
    }
}
