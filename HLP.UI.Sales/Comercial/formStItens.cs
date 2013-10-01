using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLP.Comum.UI.Metodos;
using Ninject;
using HLP.Comum.Services.Interface;
using HLP.Dependencies;
using HLP.Comum.Services.Interface.Configuracao;
using ComponentFactory.Krypton.Toolkit;
using HLP.Comum.UI.Exception;

namespace HLP.UI.Sales.Comercial
{
    public enum TipoSituacao
    {
        enviado,
        confirmado,
        perdido,
        cancelado
    }

    public partial class formStItens : Form
    {
        List<Orcamento_ItemModel> lOrcamento_item;
        byte iTpSt;
        bool bSel = false;

        public formStItens(TipoSituacao tpSt, List<Orcamento_ItemModel> lItens, DataGridViewComboBoxColumn clProdutos,
            DataGridViewComboBoxColumn clIdMotivo)
        {
            InitializeComponent();

            #region Atribuição de eventos

            this.btnConfirmar.btn.Click += new EventHandler(btnConfirmar_Click);
            this.btnCancelar.btn.Click += new EventHandler(btnCancelar_Click);

            #endregion

            this.clProduto.DataSource = clProdutos.DataSource;
            this.clProduto.DisplayMember = clProdutos.DisplayMember;
            this.clProduto.ValueMember = clProdutos.ValueMember;

            this.clMotPerda.DataSource = clIdMotivo.DataSource;
            this.clMotPerda.DisplayMember = clIdMotivo.DisplayMember;
            this.clMotPerda.ValueMember = clIdMotivo.ValueMember;
            this.OrganizaTelaByTpSt(tpSt: tpSt);
            try
            {
                List<stItensModel> lStItens = (from i in lItens
                                               where i.stOrcamentoItem == 0 || i.stOrcamentoItem == 1
                                               select (new stItensModel
                                               {
                                                   codItemOrcamento = i.idItem,
                                                   codItem = i.idProduto,
                                                   dPrevEntrega = i.dPrevisaoEntrega,
                                                   quantPendente = i.qProduto,
                                                   quantItens = i.qProduto,
                                                   obsItem = i.xObservacaoItem
                                               })).ToList();
                this.bsItens.DataSource = lStItens;
                this.lOrcamento_item = lItens;
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }

        }

        private void cbSelDes_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void OrganizaTelaByTpSt(TipoSituacao tpSt)
        {
            switch (tpSt)
            {
                case TipoSituacao.enviado:
                    {
                        this.Text = "Enviar itens";
                        this.btnConfirmar._LabelText = "Enviar";
                        iTpSt = 1;
                    }
                    break;
                case TipoSituacao.confirmado:
                    {
                        this.Text = "Confirmar itens";
                        this.btnConfirmar._LabelText = "Confirmar";
                        this.quantItensDataGridViewTextBoxColumn.Visible =
                        this.dConfirmacaoDataGridViewTextBoxColumn.Visible =
                        this.clObs.Visible = true;
                        iTpSt = 2;
                    }
                    break;
                case TipoSituacao.perdido:
                    {
                        this.Text = "Itens perdidos";
                        this.btnConfirmar._LabelText = "Confirmar";
                        this.quantItensDataGridViewTextBoxColumn.Visible =
                        this.dConfirmacaoDataGridViewTextBoxColumn.Visible =
                        this.clObs.Visible = this.clMotPerda.Visible = true;
                        iTpSt = 3;
                    }
                    break;
                case TipoSituacao.cancelado:
                    {
                        this.Text = "Itens cancelados";
                        this.btnConfirmar._LabelText = "Confirmar";
                        this.quantItensDataGridViewTextBoxColumn.Visible =
                        this.dConfirmacaoDataGridViewTextBoxColumn.Visible =
                        this.clObs.Visible = this.clMotPerda.Visible = true;
                        iTpSt = 4;
                    }
                    break;
            }
        }

        private void dgvItens_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == quantItensDataGridViewTextBoxColumn.Index)
                {
                    if (Convert.ToDecimal(e.FormattedValue) > (bsItens.Current as stItensModel).quantPendente)
                    {
                        throw new Exception("Quantidade não pode ser maior que quantidade pendente");
                    }
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                new HLPexception(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Orcamento_ItemModel itemDup;
                Orcamento_ItemModel itemTempor;
                foreach (stItensModel it in (bsItens.List as List<stItensModel>)
                .Where(i => i.bSel))
                {
                    itemTempor = lOrcamento_item.First(i => i.idItem == it.codItemOrcamento);
                    switch (iTpSt)
                    {
                        case 1:
                            {
                                if (itemTempor.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.SemMudanca)
                                    itemTempor.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado);
                            } break;
                        case 2:
                        case 3:
                        case 4:
                            {
                                if (it.quantItens == it.quantPendente)
                                {
                                    if (itemTempor.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.SemMudanca)
                                        itemTempor.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado);

                                    itemTempor.stOrcamentoItem = iTpSt;

                                    itemTempor.idMotivo = iTpSt == 4 || iTpSt == 5 ?
                                        it.codMotPerda : null;
                                }
                                else
                                {
                                    itemDup = (from t in lOrcamento_item
                                               where t.idItem == it.codItemOrcamento
                                               select (new Orcamento_ItemModel()
                                               {
                                                   dConfirmacaoItem = it.dConfirmacao,
                                                   dPrevisaoEntrega = t.dPrevisaoEntrega,
                                                   idCfop = t.idCfop,
                                                   idDeposito = t.idDeposito,
                                                   idEmpresa = t.idEmpresa,
                                                   idFuncionarioRepresentante = t.idFuncionarioRepresentante,
                                                   idListaPrecoPai = t.idListaPrecoPai,
                                                   idMotivo = it.codMotPerda,
                                                   idOrcamento = t.idOrcamento,
                                                   idProduto = t.idProduto,
                                                   idSite = t.idSite,
                                                   idTipoOperacao = t.idTipoOperacao,
                                                   idUnidadeMedida = t.idUnidadeMedida,
                                                   nItemCliente = t.nItemCliente,
                                                   nPedidoClienteItem = t.nPedidoClienteItem,
                                                   nPesoBruto = t.nPesoBruto,
                                                   nPesoLiquido = t.nPesoLiquido,
                                                   pComissao = t.pComissao,
                                                   pDesconto = t.pDesconto,
                                                   qProduto = (int)it.quantItens,
                                                   stConsumidorFinal = t.stConsumidorFinal,
                                                   stOrcamentoItem = iTpSt,
                                                   vDesconto = t.vDesconto,
                                                   vDescontoSuframa = t.vDescontoSuframa,
                                                   vFreteItem = t.vFreteItem,
                                                   vOutrasDespesasItem = t.vOutrasDespesasItem,
                                                   vSegurosItem = t.vSegurosItem,
                                                   vTotalItem = (decimal)(t.vVenda * it.quantItens),
                                                   vTotalSemDescontoItem = t.vTotalSemDescontoItem,
                                                   vVenda = t.vVenda,
                                                   vVendaSemDesconto = t.vVendaSemDesconto,
                                                   xCodigoProdutoCliente = t.xCodigoProdutoCliente,
                                                   xComercial = t.xComercial,
                                                   xObservacaoItem = t.xObservacaoItem,
                                                   xPedidoCliente = t.xPedidoCliente,
                                               })).First();
                                    itemTempor.qProduto = (decimal)(it.quantPendente - it.quantItens);

                                    if (itemTempor.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.SemMudanca)
                                        itemTempor.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Alterado);

                                    if (itemDup.GetStatusRegistro() == Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.SemMudanca)
                                        itemDup.SetStatusRegistro(Comum.Infrastructure.BaseModelFilhos.statusRegistroFilho.Incluido);
                                    lOrcamento_item.Add(item: itemDup);
                                }
                            } break;
                    }

                }
            }
            catch (Exception ex)
            {
                new HLPexception(ex);
            }
            this.Close();
        }

        private void dgvItens_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == clSel.Index)
            {
                try
                {
                    bSel = !bSel;
                    foreach (stItensModel item in bsItens.List)
                    {
                        item.bSel = bSel;
                    }
                    dgvItens.Refresh();
                }
                catch (Exception ex)
                {
                    new HLPexception(ex: ex);
                }
            }
        }
    }
}
