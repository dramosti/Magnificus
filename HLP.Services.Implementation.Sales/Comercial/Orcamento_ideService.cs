using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Comercial;
using HLP.Models.Entries.Gerais;
using HLP.Models.Sales.Comercial;
using HLP.Repository.Interfaces.Sales.Comercial;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Sales.Comercial;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Entries.Fiscal;
using HLP.Services.Interfaces.Entries.Parametros;
using HLP.Models.Entries.Parametros;
using HLP.Models.Entries.Gerais;
using System.Drawing;
using System.Windows.Forms;

namespace HLP.Services.Implementation.Sales.Comercial
{
    public class Orcamento_ideService : IOrcamento_ideService
    {
        [Inject]
        public IOrcamento_ideRepository _Orcamento_ideRepository { get; set; }

        [Inject]
        public IOrcamento_ItemRepository _Orcamento_itemRepository { get; set; }

        [Inject]
        public IOrcamento_Item_ImpostosRepository _Orcamento_Item_ImpostosRepository { get; set; }

        [Inject]
        public IOrcamento_retTranspRepository _Orcamento_retTranspRepository { get; set; }

        [Inject]
        public IOrcamento_Total_ImpostosRepository _Orcamento_Total_ImpostosRepository { get; set; }

        [Inject]
        public ICliente_fornecedorService clienteService { get; set; }

        [Inject]
        public ILista_precoService listaPrecoService { get; set; }

        [Inject]
        public IContatoService contatoService { get; set; }

        [Inject]
        public IFuncionarioService funcionarioService { get; set; }

        [Inject]
        public IProdutoService produtoService { get; set; }

        [Inject]
        public IUnidade_medidaService unidade_MedidaService { get; set; }

        [Inject]
        public ICidadeService cidadeService { get; set; }

        [Inject]
        public ICondicao_pagamentoService condicao_PagamentoService { get; set; }

        [Inject]
        public IFamilia_ProdutoService familia_ProdutoService { get; set; }

        [Inject]
        public ITipo_operacaoService tipo_OperacaoService { get; set; }

        [Inject]
        public IEmpresa_EnderecoService empresa_EnderecoService { get; set; }

        [Inject]
        public IClassificacao_fiscalService classificacao_FiscalService { get; set; }

        [Inject]
        public IOperacao_reducao_baseService operacao_ReducaoService { get; set; }

        [Inject]
        public ICodigo_IcmsService codigo_IcmsService { get; set; }

        [Inject]
        public ICarga_trib_media_st_icmsService carga_Trib_mediaService { get; set; }

        [Inject]
        public IRamo_atividadeService ramo_AtividadeService { get; set; }

        [Inject]
        public IParametro_FiscalService parametro_FiscalService { get; set; }

        [Inject]
        public ISituacao_tributaria_pisService sit_trib_PisService { get; set; }

        [Inject]
        public ITipo_documentoService tipo_documentoService { get; set; }

        private struct InfTreeViewOrcamento
        {
            public string idOrcamento;
            public string dDataCriacaoOrcamento;
        }

        #region operacoes básicas
        public void Save(Orcamento_ideModel objOrcamento_ide)
        {
            try
            {
                _Orcamento_ideRepository.BeginTransaction();
                _Orcamento_ideRepository.Save(objOrcamento_ide);
                objOrcamento_ide.Orcamento_retTransp.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                _Orcamento_retTranspRepository.Save(objOrcamento_ide.Orcamento_retTransp);
                objOrcamento_ide.Orcamento_Total_Impostos.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                _Orcamento_Total_ImpostosRepository.Save(objOrcamento_ide.Orcamento_Total_Impostos);
                _Orcamento_ideRepository.CommitTransaction();
                #region Itens orçamento
                foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_Itens)
                {
                    try
                    {
                        _Orcamento_itemRepository.BebingTransaction();
                        item.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                        item.idEmpresa = CompanyData.idEmpresa;
                        switch (item.GetStatusRegistro())
                        {
                            case BaseModelFilhos.statusRegistroFilho.Incluido:
                                {
                                    _Orcamento_itemRepository.Save(item);
                                    item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                                    _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                                }
                                break;
                            case BaseModelFilhos.statusRegistroFilho.Alterado:
                                {
                                    _Orcamento_itemRepository.Save(item);
                                    item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                                    _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                                }
                                break;
                            case BaseModelFilhos.statusRegistroFilho.Excluido:
                                {
                                    _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                                    _Orcamento_Item_ImpostosRepository.Delete((int)item.Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                                }
                                break;
                        }

                        _Orcamento_itemRepository.Commit();
                    }
                    catch (Exception)
                    {
                        _Orcamento_itemRepository.Rollback();
                        throw;
                    }
                #endregion
                    #region Apos testes, excluir


                    //}
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_Itens.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        _Orcamento_itemRepository.Update(item);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }

                    //}
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_Itens.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Delete((int)item.Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }

                    //}


                    //#region Itens orçamento vendidos
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_ItensVendidos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        item.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                    //        _Orcamento_itemRepository.Save(item);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }
                    //}
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_ItensVendidos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        _Orcamento_itemRepository.Update(item);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }
                    //}
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_ItensVendidos.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Delete((int)item.Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }
                    //}
                    //#endregion

                    //#region Itens orçamento cancelados ou perdidos
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_ItensCancelPerd.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        item.idOrcamento = (int)objOrcamento_ide.idOrcamento;
                    //        _Orcamento_itemRepository.Save(item);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }
                    //}
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_ItensCancelPerd.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        _Orcamento_itemRepository.Update(item);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Save(item.Orcamento_Item_Impostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }
                    //}
                    //foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_ItensCancelPerd.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                    //{
                    //    try
                    //    {
                    //        _Orcamento_itemRepository.BebingTransaction();
                    //        _Orcamento_itemRepository.Delete((int)item.idOrcamentoItem);
                    //        item.Orcamento_Item_Impostos.idOrcamentoItem = (int)item.idOrcamentoItem;
                    //        _Orcamento_Item_ImpostosRepository.Delete((int)item.Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                    //        _Orcamento_itemRepository.Commit();
                    //    }
                    //    catch (Exception)
                    //    {
                    //        _Orcamento_itemRepository.Rollback();
                    //        throw;
                    //    }
                    //}
                    //#endregion
                    #endregion
                }
            }
            catch (Exception)
            {
                _Orcamento_ideRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(Orcamento_ideModel objOrcamento_ide)
        {
            try
            {
                _Orcamento_ideRepository.BeginTransaction();
                _Orcamento_Item_ImpostosRepository.Delete(
                    (int)objOrcamento_ide.LOrcamento_Itens[0].Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                //_Orcamento_Item_ImpostosRepository.Delete(
                //    (int)objOrcamento_ide.LOrcamento_ItensVendidos[0].Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                //_Orcamento_Item_ImpostosRepository.Delete(
                //    (int)objOrcamento_ide.LOrcamento_ItensCancelPerd[0].Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                _Orcamento_itemRepository.Delete((int)objOrcamento_ide.LOrcamento_Itens[0].idOrcamentoItem);
                //_Orcamento_itemRepository.Delete((int)objOrcamento_ide.LOrcamento_ItensVendidos[0].idOrcamentoItem);
                //_Orcamento_itemRepository.Delete((int)objOrcamento_ide.LOrcamento_ItensCancelPerd[0].idOrcamentoItem);
                _Orcamento_Total_ImpostosRepository.Delete((int)objOrcamento_ide.Orcamento_Total_Impostos.idOrcamentoTotalImpostos);
                _Orcamento_retTranspRepository.Delete((int)objOrcamento_ide.Orcamento_retTransp.idRetTransp);
                _Orcamento_ideRepository.Delete((int)objOrcamento_ide.idOrcamento);
                _Orcamento_ideRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Orcamento_ideRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Orcamento_ideModel objOrcamento_ide)
        {
            try
            {
                _Orcamento_ideRepository.BeginTransaction();

                objOrcamento_ide.idOrcamentoOrigem = objOrcamento_ide.idOrcamento;
                objOrcamento_ide.idOrcamento = _Orcamento_ideRepository.Copy((int)objOrcamento_ide.idOrcamento);
                foreach (Orcamento_ItemModel item in objOrcamento_ide.LOrcamento_Itens)
                {
                    _Orcamento_itemRepository.Copy((int)item.idOrcamentoItem);
                    _Orcamento_Item_ImpostosRepository.Copy((int)item.Orcamento_Item_Impostos.idOrcamentoTotalizadorImpostos);
                }

                if (objOrcamento_ide.Orcamento_retTransp.idRetTransp != null)
                    _Orcamento_retTranspRepository.Copy((int)objOrcamento_ide.Orcamento_retTransp.idRetTransp);

                if (objOrcamento_ide.Orcamento_Total_Impostos.idOrcamentoTotalImpostos != null)
                    _Orcamento_Total_ImpostosRepository.Copy((int)objOrcamento_ide.Orcamento_Total_Impostos.idOrcamentoTotalImpostos);

                _Orcamento_ideRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Orcamento_ideRepository.RollackTransaction();
                throw;
            }
        }
        #endregion

        #region operações de pesquisa
        public Orcamento_ideModel GetOrcamento_ide(int idOrcamento)
        {
            Orcamento_ideModel objOrcamento = _Orcamento_ideRepository.GetOrcamento_ide(idOrcamento);
            objOrcamento.LOrcamento_Itens = _Orcamento_itemRepository.GetAllOrcamento_Item((int)objOrcamento.idOrcamento);

            foreach (Orcamento_ItemModel orcamento_Item in objOrcamento.LOrcamento_Itens)
            {
                orcamento_Item.Orcamento_Item_Impostos = _Orcamento_Item_ImpostosRepository.GetOrcamento_Item_ImpostosByItem(
                    idOrcamento_Item: (int)orcamento_Item.idOrcamentoItem);
            }

            return objOrcamento;
        }

        public List<Orcamento_ideModel> GetAllOrcamento_ide()
        {
            return _Orcamento_ideRepository.GetAllOrcamento_ide();
        }

        public Cliente_fornecedorModel GetClienteFornOrcamento(int idClienteFornecedor)
        {
            return clienteService.GetCliente_fornecedor(idClienteFornecedor: idClienteFornecedor, bChildren: true);
        }

        public Cliente_fornecedor_EnderecoModel GetClienteForn_EnderecoOrcamento(int idClienteFornecedor)
        {
            return clienteService.GetCliente_enderecoPrincipal(idClienteFornecedor);
        }

        public List<Lista_precoModel> GetListaPrecoOrcamento(int idListaPrecoPai)
        {
            return listaPrecoService.GetAllLista_preco((int)idListaPrecoPai);
        }

        public Cliente_fornecedor_representanteModel GetClienteFornRepresentante(int idClienteFornecedor)
        {
            return clienteService.GetCliente_fornecedor_Representante(
                    (int)idClienteFornecedor).FirstOrDefault();
        }

        public List<ContatoModel> GetContatosByClienteForn(int idClienteForn)
        {
            return contatoService.GetContato_ByClienteFornec(idClienteForn);
        }

        public ContatoModel GetInformacoesContato(int idContato)
        {
            return contatoService.GetContato(idContato: idContato);
        }

        public FuncionarioModel GetInformacoesFuncionario(int idFuncionario)
        {
            return funcionarioService.GetFuncionario(idFuncionario: idFuncionario);
        }

        public ProdutoModel GetInformacoesProduto(int idProduto)
        {
            return produtoService.GetProduto(idProduto: idProduto);
        }

        public Unidade_medidaModel GetInformacoesUnidade(int idUnidadeMedida)
        {
            return unidade_MedidaService.GetUnidade(idUnidadeMedida: idUnidadeMedida);
        }

        public List<Unidade_medidaModel> GetUnidadeByConversaoProduto(int idUnidadeMedida, int idProduto)
        {
            return unidade_MedidaService.GetUnidadeByConversaoProduto(idParaUnidadeMedida: idUnidadeMedida,
                idProduto: idProduto);
        }

        public CidadeModel GetCidadeClienteForn_Orcamento(int idCidade)
        {
            return cidadeService.GetCidade(idCidade: idCidade);
        }

        public UFModel GetUfByCidadeClienteForn_Orcamento(int idCidade)
        {
            UFModel objUf = null;
            objUf = cidadeService.GetUfByCidade(idCidade: idCidade);
            return objUf != null ? objUf : objUf = new UFModel();
        }

        public byte GetStatusOrcamento(List<Orcamento_ItemModel> lItens)
        {
            //0-Criado
            //1-Enviado
            //2-Confirmado
            //3-Confirmado Parcialmente
            //4-Perdido
            //5-Cancelado
            int iCriados = 0;
            int iEnviado = 0;
            int iConfirmado = 0;
            int iPerdido = 0;
            int iCancelado = 0;
            int iTotalItens = 0;

            iTotalItens = lItens.Count;

            iCriados = lItens.Count(i => i.stOrcamentoItem == 0);
            iEnviado = lItens.Count(i => i.stOrcamentoItem == 1);
            iConfirmado = lItens.Count(i => i.stOrcamentoItem == 2);
            iPerdido = lItens.Count(i => i.stOrcamentoItem == 4);
            iCancelado = lItens.Count(i => i.stOrcamentoItem == 5);

            if (iCriados == iTotalItens)
                return 0;
            else if (iEnviado == iTotalItens)
                return 1;
            else if (iConfirmado == iTotalItens)
                return 2;
            else if (iPerdido == iTotalItens)
                return 4;
            else if (iCancelado == iTotalItens)
                return 5;
            else return 3;
        }

        public byte GetTipoComissao(Orcamento_ItemModel orc_itemModel)
        {
            //0 - a vista; 1 - a prazo
            FuncionarioModel objFuncionario = new FuncionarioModel();
            objFuncionario = funcionarioService.GetFuncionario((int)orc_itemModel.idFuncionarioRepresentante, true);
            return objFuncionario.stComissao;
        }

        public void GetComissao<T>(int idCondicao_Pagamento, Orcamento_ItemModel itemModel, T objeto) where T : class
        {
            Condicao_pagamentoModel objCondicao_pagamento = new Condicao_pagamentoModel();
            objCondicao_pagamento = condicao_PagamentoService.GetCondicao(idCondicaoPagamento: idCondicao_Pagamento);
            Type tipo = objeto.GetType();

            itemModel.pComissao = objCondicao_pagamento.stCondicao == 0 ?
                (decimal)tipo.GetProperty("pComissaoAvista").GetValue(objeto) :
                (decimal)tipo.GetProperty("pComissaoAprazo").GetValue(objeto);

        }

        public Familia_produtoModel GetFamiliaProduto(int idFamilia_produto)
        {
            return familia_ProdutoService.GetFamilia_produto(idfamilia_produto: idFamilia_produto, bChildren: false);
        }

        public int GetCfopByOperacao(int idOperacao, int idCliente)
        {
            try
            {
                Cliente_fornecedorModel objCliente = clienteService.GetCliente_fornecedor(idCliente, true);
                if (objCliente == null)
                    objCliente = new Cliente_fornecedorModel();

                if (objCliente.lCliente_Fornecedor_Endereco.Count(i => i.stPrincipal == 1) < 1)
                    return 0;

                List<Empresa_EnderecoModel> lEmpresa_endereco = empresa_EnderecoService.GetAllEmpresa_Endereco(CompanyData.idEmpresa);

                if (lEmpresa_endereco == null)
                    lEmpresa_endereco = new List<Empresa_EnderecoModel>();

                if (lEmpresa_endereco.Count(e => e.stPrincipal == 1) < 1)
                    return 0;


                return this.GetUfByCidadeClienteForn_Orcamento(objCliente.lCliente_Fornecedor_Endereco
                .FirstOrDefault(i => i.stPrincipal == 1).idCidade).idUF ==
                this.GetUfByCidadeClienteForn_Orcamento(
                lEmpresa_endereco.FirstOrDefault(
                i => i.stPrincipal == 1).idCidade).idUF ?
                tipo_OperacaoService.GetOperacao(idOperacao).cCfopNaUf : tipo_OperacaoService.GetOperacao(idOperacao).cCfopOutraUf;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string GetcNcm(int idClassificaoFiscal)
        {
            return classificacao_FiscalService.GetClassificacao(idClassificacaoFiscal: idClassificaoFiscal).cNCM;
        }

        public Codigo_IcmsModel GetCodigo_Icms(int idCodigoIcmsPai, int idCidade)
        {
            Codigo_IcmsModel objCodigo_Icms = null;
            objCodigo_Icms = codigo_IcmsService.GetAllCodigo_Icms(idCodigoIcmsPai).FirstOrDefault(
                                i => i.idUf == this.GetUfByCidadeClienteForn_Orcamento(
                                idCidade).idUF);

            return objCodigo_Icms != null ? objCodigo_Icms : objCodigo_Icms = new Codigo_IcmsModel();
        }

        public Carga_trib_media_st_icmsModel GetCarga_trib_mediaByUf(int idUf)
        {
            Carga_trib_media_st_icmsModel objCarga_trib_media_st_icms = carga_Trib_mediaService.GetGetCarga_trib_media_st_icmsByUf(idUf: idUf);
            return objCarga_trib_media_st_icms != null ? objCarga_trib_media_st_icms : objCarga_trib_media_st_icms = new Carga_trib_media_st_icmsModel();
        }

        public Ramo_atividadeModel GetRamo_atividade(int idRamo_atividade)
        {
            Ramo_atividadeModel objRamo_atividade = null;
            objRamo_atividade = ramo_AtividadeService.GetRamo(idRamoAtividade: idRamo_atividade);
            return objRamo_atividade != null ? objRamo_atividade : objRamo_atividade = new Ramo_atividadeModel();
        }

        public Empresa_EnderecoModel GetEmpresa_enderecoPrincipal()
        {
            Empresa_EnderecoModel objEmpresa_endereco = null;
            objEmpresa_endereco = empresa_EnderecoService.GetAllEmpresa_Endereco(CompanyData.idEmpresa).FirstOrDefault(
                e => e.StTipoEnd == 0);

            return objEmpresa_endereco != null ? objEmpresa_endereco : objEmpresa_endereco = new Empresa_EnderecoModel();
        }

        public Parametro_FiscalModel GetParametro_Fiscal()
        {
            Parametro_FiscalModel objParametro_Fiscal = null;

            objParametro_Fiscal = parametro_FiscalService.GetParametro_Fiscal();

            return objParametro_Fiscal != null ? objParametro_Fiscal : objParametro_Fiscal = new Parametro_FiscalModel();
        }

        public Situacao_tributaria_pisModel GetSit_Trib_PisByidCstPis(int idCstPis)
        {
            Situacao_tributaria_pisModel objSit_TribPis = null;
            objSit_TribPis = sit_trib_PisService.GetStPis(idCSTPis: idCstPis);
            return objSit_TribPis != null ? objSit_TribPis : objSit_TribPis = new Situacao_tributaria_pisModel();
        }

        public decimal GetvVendaListaPrecoByIdProduto(int idListaPrecoPai, int idProduto)
        {
            List<Lista_precoModel> lListaPreco = this.GetListaPrecoOrcamento(idListaPrecoPai: idListaPrecoPai);
            Lista_precoModel iListaPreco = lListaPreco.FirstOrDefault(i => i.idProduto == idProduto);
            return iListaPreco != null ? iListaPreco.vVenda : 0;
        }

        public Tipo_documentoModel GetInfTipoDocumento(int idTipoDocumento)
        {
            Tipo_documentoModel objTipo_documento = null;
            objTipo_documento = tipo_documentoService.GetDocumento(idTipoDocumento: idTipoDocumento);
            return objTipo_documento != null ? objTipo_documento : objTipo_documento = new Tipo_documentoModel();
        }

        public string GetVersaoByOrigem(int idOrcamento)
        {
            string xVersao = "";
            Orcamento_ideModel objOrcamento_ide = _Orcamento_ideRepository.GetOrcamento_ide(
                idOrcamento: idOrcamento);
            while (true)
            {
                xVersao = xVersao == "" ? objOrcamento_ide.idOrcamento.ToString() :
                    objOrcamento_ide.idOrcamento.ToString() + "." + xVersao;
                if (objOrcamento_ide.idOrcamentoOrigem == null)
                    break;
                try
                {
                    objOrcamento_ide = _Orcamento_ideRepository.GetOrcamentoByOrigem(idOrcamento: (int)(objOrcamento_ide.idOrcamentoOrigem));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return "V" + (xVersao.Count(c => c == '.') + 1).ToString() + "." + xVersao;
        }

        #endregion

        #region operações de validações

        public void ValidaTipoOperacao(Orcamento_ItemModel objOrcamento_item, Cliente_fornecedorModel objClienteForn, int stContribuinteIcms)
        {
            if (objClienteForn == null)
                return;

            if (tipo_OperacaoService.GetOperacao(idTipoOperacao: objOrcamento_item.idTipoOperacao).stCompoeBaseIcms == 4
                && (objClienteForn.cliforFiscalModel.stCalculaIcms == 1
                || objClienteForn.cliforFiscalModel.stZeraIcms == 0))
                throw new Exception("Tipo de operação inválida.");

            if (tipo_OperacaoService.GetOperacao(idTipoOperacao: objOrcamento_item.idTipoOperacao).stCompoeBaseIcmsSubstituicaoTributaria == 5
                && (objOrcamento_item.Orcamento_Item_Impostos.PIS_stCompoeBaseCalculoSubstituicaoTributaria == 1
                || objOrcamento_item.stConsumidorFinal == 0)
                && stContribuinteIcms == 1)
                throw new Exception("Tipo de operação inválida.");
        }

        public bool IsServiceByTipoOperacao(int idTipoOp)
        {
            Tipo_operacaoModel objTipo_operacao = tipo_OperacaoService.GetOperacao(idTipoOperacao: idTipoOp);

            return objTipo_operacao == null ? false : objTipo_operacao.stServico == 0 ? false : true;
        }

        public void ValidaPorcListaPrecoItem(Orcamento_ItemModel objOrcamento_item, decimal porDescAcr, List<ItemPorcAcimaListaModel> lItensPorcAcimaLista)
        {
            Lista_precoModel objLista_preco = null;
            ItemPorcAcimaListaModel objItemPorcAcimaListaModel;
            objLista_preco = listaPrecoService.GetAllLista_preco(idListaPrecoPai: objOrcamento_item.idListaPrecoPai).FirstOrDefault(
                i => i.idProduto == objOrcamento_item.idProduto);
            if (objLista_preco == null)
                return;

            decimal? dValor = this.VerifPorcItemPorcListaPreco(porDescAcr: porDescAcr,
                objLista_preco: objLista_preco, lItensPorcAcimaLista: lItensPorcAcimaLista);

            if (dValor != null)
            {
                objItemPorcAcimaListaModel = new ItemPorcAcimaListaModel();
                objItemPorcAcimaListaModel.idProduto = objOrcamento_item.idProduto;
                //objItemPorcAcimaListaModel.numProduto = (int)objOrcamento_item.idOrcamentoItem;
                objItemPorcAcimaListaModel.porAtual = porDescAcr;
                objItemPorcAcimaListaModel.porLista = (decimal)(objLista_preco.pDescontoMaximo * -1);
                lItensPorcAcimaLista.Add(objItemPorcAcimaListaModel);
            }
        }

        public void ValidaPorcListaPrecoLista(List<Orcamento_ItemModel> lOrcamento_item,
            decimal porDescAcrTotal, List<ItemPorcAcimaListaModel> lItensPorcAcimaLista)
        {
            Lista_precoModel objLista_preco = null;
            ItemPorcAcimaListaModel objItemPorcAcimaListaModel;
            decimal porDescAcr;
            decimal? dValor = null;
            foreach (Orcamento_ItemModel item in lOrcamento_item)
            {
                objLista_preco = listaPrecoService.GetAllLista_preco(idListaPrecoPai: item.idListaPrecoPai).FirstOrDefault(
                i => i.idProduto == item.idProduto);
                porDescAcr = (100 *
                    ((((item.vTotalItem / lOrcamento_item.Sum(i => i.vTotalSemDescontoItem)
                    ) * 100) * porDescAcrTotal) / 100)
                    ) / item.vTotalSemDescontoItem;
                dValor = this.VerifPorcItemPorcListaPreco(porDescAcr: porDescAcr,
                objLista_preco: objLista_preco, lItensPorcAcimaLista: lItensPorcAcimaLista);
                if (dValor != null)
                {
                    objItemPorcAcimaListaModel = new ItemPorcAcimaListaModel();
                    objItemPorcAcimaListaModel.idProduto = item.idProduto;
                    objItemPorcAcimaListaModel.porAtual = porDescAcr;
                    objItemPorcAcimaListaModel.porLista = (decimal)(objLista_preco.pDescontoMaximo * -1);
                    lItensPorcAcimaLista.Add(objItemPorcAcimaListaModel);
                }
            }
        }

        private decimal? VerifPorcItemPorcListaPreco(decimal porDescAcr, Lista_precoModel objLista_preco, List<ItemPorcAcimaListaModel> lItensPorcAcimaLista)
        {
            if (objLista_preco == null)
                return null;

            if (porDescAcr < 0)
            {
                if (objLista_preco.pDescontoMaximo < Math.Abs(porDescAcr))
                {
                    return objLista_preco.pDescontoMaximo;
                }
            }
            else
            {
                if (objLista_preco.pAcrescimoMaximo < porDescAcr)
                {
                    return objLista_preco.pAcrescimoMaximo;
                }
            }
            return null;
        }

        public bool IsNfSuframa(int idTipoDocumento)
        {
            return this.GetInfTipoDocumento(idTipoDocumento: idTipoDocumento).stNfSuframa == 1 ?
                true : false;
        }

        #endregion

        #region cálculos

        public decimal CalculaProdutoTotal(List<Orcamento_ItemModel> lOrcamento_ItemModel)
        {
            return lOrcamento_ItemModel.Where(i => !this.IsServiceByTipoOperacao(idTipoOp: i.idTipoOperacao)).Sum(i => i.vTotalSemDescontoItem);
        }

        public decimal CalculaServicoTotal(List<Orcamento_ItemModel> lOrcamento_ItemModel)
        {
            return lOrcamento_ItemModel.Where(i => this.IsServiceByTipoOperacao(idTipoOp: i.idTipoOperacao)).Sum(i => i.vTotalSemDescontoItem);
        }

        public decimal CalculaDescontoTotal(List<Orcamento_ItemModel> lOrcamento_ItemModel)
        {
            decimal dValorTotalDesconto = 0;
            try
            {
                foreach (Orcamento_ItemModel item in lOrcamento_ItemModel)
                {
                    if (item.idTipoOperacao > 0)
                    {
                        if ((this.IsServiceByTipoOperacao(idTipoOp: item.idTipoOperacao)))
                            dValorTotalDesconto += item.vDesconto;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dValorTotalDesconto;
        }

        public decimal CalculaPorcDescontoTotal(decimal vDescontoTotal, decimal vProdutosTotal)
        {
            return vProdutosTotal == 0 ? 0 : (vDescontoTotal * 100) / vProdutosTotal;
        }

        public void RateiaValorTotalNosItens(decimal vTotal, List<Orcamento_ItemModel> lOrcamento_ItemModel,
            PropriedadeCalculo iPropCalculo)
        {
            decimal vTotalProdutos = lOrcamento_ItemModel.Sum(i => i.vTotalSemDescontoItem);

            try
            {
                switch (iPropCalculo)
                {
                    case PropriedadeCalculo.descontoTotal:
                        {

                            foreach (Orcamento_ItemModel item in lOrcamento_ItemModel)
                            {
                                item.vDesconto = (((item.vTotalSemDescontoItem / vTotalProdutos) * 100) * vTotal) / 100;
                                item.pDesconto = (100 * item.vDesconto) / item.vTotalSemDescontoItem;
                            }

                        }
                        break;
                    case PropriedadeCalculo.freteTotal:
                        {
                            foreach (Orcamento_ItemModel item in lOrcamento_ItemModel)
                            {
                                item.vFreteItem = (((item.vTotalItem / vTotalProdutos) * 100) * vTotal) / 100;
                            }
                        }
                        break;
                    case PropriedadeCalculo.seguroTotal:
                        {
                            foreach (Orcamento_ItemModel item in lOrcamento_ItemModel)
                            {
                                item.vSegurosItem = (((item.vTotalItem / vTotalProdutos) * 100) * vTotal) / 100;
                            }
                        }
                        break;
                    case PropriedadeCalculo.outrasDespesasTotal:
                        {
                            foreach (Orcamento_ItemModel item in lOrcamento_ItemModel)
                            {
                                item.vOutrasDespesasItem = (((item.vTotalItem / vTotalProdutos) * 100) * vTotal) / 100;
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal CalculaTotalOrcamento(decimal vProdutoTotal, decimal vServicoTotal, decimal vIpiTotal, decimal vIcmsSubsTributaria,
            decimal vSeguroTotal, decimal vOutrasDespesasTotal, decimal vDescontoTotal, decimal vDescontoSuframaTotal)
        {
            return (vProdutoTotal + vServicoTotal + vIpiTotal + vIcmsSubsTributaria + vSeguroTotal + vOutrasDespesasTotal
                + vDescontoTotal - vDescontoSuframaTotal);
        }

        public decimal CalculaPesoLiquido(List<Orcamento_ItemModel> lOrcamento_ItemModel)
        {
            return lOrcamento_ItemModel.Sum(i => i.qProduto * this.GetInformacoesProduto(i.idProduto).nPesoLiquido);
        }

        public decimal CalculaPesoBruto(List<Orcamento_ItemModel> lOrcamento_ItemModel)
        {
            return lOrcamento_ItemModel.Sum(i => i.qProduto * this.GetInformacoesProduto(i.idProduto).nPesoBruto);
        }

        #endregion

        #region Popula Objeto
        public void PopulaObjetoItem(Orcamento_ItemModel objOrcamento_Item, Orcamento_ideModel objOrcamento_ide, CalculoDescontoPrincipal stCalculoPrincipal)
        {
            try
            {
                if (objOrcamento_Item.idProduto == 0 && objOrcamento_Item.idTipoOperacao == 0)
                    return;
                if (objOrcamento_Item.Orcamento_Item_Impostos == null)
                    objOrcamento_Item.Orcamento_Item_Impostos = new Orcamento_Item_ImpostosModel();

                Cliente_fornecedorModel objClienteForn = clienteService.GetCliente_fornecedor(objOrcamento_ide.idClienteFornecedor, true);
                List<Cliente_fornecedor_EnderecoModel> lClienteForn_Endereco = objClienteForn != null ?
                    objClienteForn.lCliente_Fornecedor_Endereco : lClienteForn_Endereco = new List<Cliente_fornecedor_EnderecoModel>();
                Cliente_fornecedor_fiscalModel objClienteForn_Fiscal = objClienteForn != null ?
                    objClienteForn.cliforFiscalModel : objClienteForn_Fiscal = new Cliente_fornecedor_fiscalModel();

                #region Produto
                ProdutoModel objProduto = new ProdutoModel();

                objProduto = this.GetInformacoesProduto(
                idProduto: objOrcamento_Item.idProduto);
                if (objProduto != null)
                {
                    objOrcamento_Item.xComercial = objProduto.xComercial;
                    objOrcamento_Item.nPesoLiquido = objProduto.nPesoLiquido;
                    objOrcamento_Item.nPesoBruto = objProduto.nPesoBruto;
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stOrigemMercadoria = objProduto.stOrigemMercadoria;
                    if (objOrcamento_Item.vVenda == 0 && objOrcamento_Item.vVendaSemDesconto == 0)
                        objOrcamento_Item.vVenda = objOrcamento_Item.vVendaSemDesconto = this.GetvVendaListaPrecoByIdProduto(
                            idListaPrecoPai: (int)objOrcamento_Item.idListaPrecoPai, idProduto: (int)objProduto.idProduto);
                }

                #endregion

                #region Valores Totais item
                objOrcamento_Item.vTotalSemDescontoItem = objOrcamento_Item.vVenda * objOrcamento_Item.qProduto;
                switch (stCalculoPrincipal)
                {
                    case CalculoDescontoPrincipal.porPorcentagem:
                        {
                            objOrcamento_Item.vDesconto = (objOrcamento_Item.vTotalSemDescontoItem * objOrcamento_Item.pDesconto) / 100;
                        }
                        break;
                    case CalculoDescontoPrincipal.porValor:
                        {
                            if (objOrcamento_Item.vTotalSemDescontoItem != 0)
                                objOrcamento_Item.pDesconto = (objOrcamento_Item.vDesconto * 100) / objOrcamento_Item.vTotalSemDescontoItem;
                        }
                        break;
                }
                objOrcamento_Item.vTotalItem = objOrcamento_Item.vTotalSemDescontoItem + objOrcamento_Item.vDesconto;
                objOrcamento_Item.vDescontoSuframa =
                        objClienteForn_Fiscal.stDescontaIcmsSuframa == 1 ?
                        (objOrcamento_Item.vTotalItem * objClienteForn.cliforFiscalModel.pDescontaIcmsSuframa) / 100 : 0;
                #endregion

                #region Tipo Operacao
                Tipo_operacaoModel objTipo_operacao = null;
                Classificacao_fiscalModel objClassificacao_fiscal = new Classificacao_fiscalModel();
                objTipo_operacao = tipo_OperacaoService.GetOperacao(idTipoOperacao: objOrcamento_Item.idTipoOperacao);

                if (objTipo_operacao != null)
                {
                    #region Ipi
                    objOrcamento_Item.Orcamento_Item_Impostos.IPI_stCalculaIpi = objTipo_operacao.stCalculaIpi;
                    objOrcamento_Item.Orcamento_Item_Impostos.idClassificacaoFiscal = objTipo_operacao.idClassificacaoFiscal != 0 ? objTipo_operacao.idClassificacaoFiscal :
                        objProduto.idClassificacaoFiscalVenda != null ?
                       (int)objProduto.idClassificacaoFiscalVenda : 0;

                    objClassificacao_fiscal = classificacao_FiscalService.GetClassificacao(idClassificacaoFiscal: (int)objOrcamento_Item.Orcamento_Item_Impostos.idClassificacaoFiscal);
                    objOrcamento_Item.Orcamento_Item_Impostos.IPI_pIPI = objClassificacao_fiscal != null ? objClassificacao_fiscal.pIPI :
                        objTipo_operacao.pIpi;
                    objOrcamento_Item.Orcamento_Item_Impostos.IPI_stCompoeBaseCalculo = objTipo_operacao.stCompoeBaseIpi;
                    objOrcamento_Item.Orcamento_Item_Impostos.idCSTIpi = objTipo_operacao.idCSTIpi;

                    switch (objOrcamento_Item.Orcamento_Item_Impostos.IPI_stCompoeBaseCalculo)
                    {
                        case 0:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.IPI_vBaseCalculo = objOrcamento_Item.vTotalItem;
                            } break;
                        case 1:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.IPI_vBaseCalculo = objOrcamento_Item.vTotalItem
                                    + objOrcamento_Item.vFreteItem;
                            } break;
                        case 2:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.IPI_vBaseCalculo = objOrcamento_Item.vTotalItem
                                    + objOrcamento_Item.vFreteItem + objOrcamento_Item.vSegurosItem
                                    + objOrcamento_Item.vOutrasDespesasItem;
                            } break;
                        case 3:
                            {
                                //TODO: Verificar com Paulo, ou Hamilto
                                //4-NENHUM
                                //Valor “0” caso o campo “Cliente_Fornecedor_Fiscal.stCalculaIpi” seja igual a “0-NÃO” 
                                //Dúvida, se já é NENHUM, o porque da validação sobre o campo stCalculaIpi
                                objOrcamento_Item.Orcamento_Item_Impostos.IPI_vBaseCalculo = 0;
                            } break;
                    }

                    objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI =
                        objOrcamento_Item.Orcamento_Item_Impostos.IPI_vBaseCalculo *
                        (objOrcamento_Item.Orcamento_Item_Impostos.IPI_pIPI / 100);

                    #endregion

                    #region Icms
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBase = 0;
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBaseSubstituicaoTributaria = 0;

                    if (objTipo_operacao.stNaoReduzBase == 1)
                    {
                        if (objOrcamento_Item.stConsumidorFinal == 0)
                        {
                            List<Operacao_reducao_baseModel> lOperacao_reducaoModel = new List<Operacao_reducao_baseModel>();
                            Operacao_reducao_baseModel operacao_ReducaoModel = null;
                            lOperacao_reducaoModel = operacao_ReducaoService.GetAll((int)objTipo_operacao.idTipoOperacao);
                            operacao_ReducaoModel = lOperacao_reducaoModel.FirstOrDefault(i => i.idUf ==
                                (lClienteForn_Endereco.Count > 0 ? this.GetUfByCidadeClienteForn_Orcamento(
                                lClienteForn_Endereco.FirstOrDefault(
                                 e => e.stPrincipal == 1).idCidade).idUF : 0));

                            if (operacao_ReducaoModel != null)
                            {
                                if (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo == 1 ||
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo == 2)
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBase = operacao_ReducaoModel.pReducaoIcms;

                                if (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo == 1 ||
                                objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo == 3)
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBaseSubstituicaoTributaria = operacao_ReducaoModel.pReducaoIcmsSubstTributaria;
                            }
                        }
                    }
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaIcms = objClienteForn_Fiscal.stCalculaIcms == ((byte)0) ?
                        ((byte)0) : objTipo_operacao.stCalculaIcms;
                    objOrcamento_Item.Orcamento_Item_Impostos.idCodigoIcmsPai = objTipo_operacao.idCodigoIcmsPai != 0 ?
                        objTipo_operacao.idCodigoIcmsPai : objProduto.idCodigoIcmsPaiVenda ?? 0;
                    objOrcamento_Item.Orcamento_Item_Impostos.idCSTIcms = objTipo_operacao.idCSTIcms != 0 ? objTipo_operacao.idCSTIcms :
                        objProduto.idCSTIcms ?? 0;

                    if (objClienteForn_Fiscal.stZeraIcms == 0)
                    {
                        if (objTipo_operacao.stCalculaIcms == 1)
                        {
                            if (lClienteForn_Endereco.Count > 0)
                                objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pICMS = (decimal?)this.GetCodigo_Icms(
                                    idCodigoIcmsPai: objOrcamento_Item.Orcamento_Item_Impostos.idCodigoIcmsPai,
                                    idCidade: (int)this.GetUfByCidadeClienteForn_Orcamento(
                                    lClienteForn_Endereco.FirstOrDefault(
                                     e => e.stPrincipal == 1).idCidade).idUF).pIcmsEstado ??
                                     this.GetCodigo_Icms(
                                    idCodigoIcmsPai: (int)objProduto.idCodigoIcmsPaiVenda,
                                    idCidade: (int)this.GetUfByCidadeClienteForn_Orcamento(
                                lClienteForn_Endereco.FirstOrDefault(
                                 e => e.stPrincipal == 1).idCidade).idUF).pIcmsEstado;
                        }
                    }

                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCompoeBaseCalculo = objTipo_operacao.stCompoeBaseIcms;

                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo = 0;
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vIcmsProprio = 0;
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaSubstituicaoTributaria = objTipo_operacao.stCalculaIcmsSubstituicaoTributaria;

                    switch (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaSubstituicaoTributaria)
                    {
                        case 0:
                            {
                                switch (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCompoeBaseCalculo)
                                {
                                    case 0:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo = objOrcamento_Item.vTotalItem;
                                        } break;
                                    case 1:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo =
                                                objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI;
                                        } break;
                                    case 2:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo =
                                                objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI + objOrcamento_Item.vFreteItem;
                                        }; break;
                                    case 3:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo =
                                                objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI
                                                + objOrcamento_Item.vFreteItem + objOrcamento_Item.vOutrasDespesasItem;
                                        }; break;
                                    case 4:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo = 0;
                                        }; break;
                                }
                                switch (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo)
                                {
                                    case 2:
                                    case 3:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo -=
                                                (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo *
                                                (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBase / 100));
                                        } break;
                                }
                                objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vICMS =
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculo * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pICMS / 100);
                            }
                            break;
                        case 1:
                            {
                                switch (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCompoeBaseCalculo)
                                {
                                    case 0:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio = objOrcamento_Item.vTotalItem;
                                        } break;
                                    case 1:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio =
                                                objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI;
                                        } break;
                                    case 2:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio =
                                                objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI + objOrcamento_Item.vFreteItem;
                                        }; break;
                                    case 3:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio =
                                                objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI
                                                + objOrcamento_Item.vFreteItem + objOrcamento_Item.vOutrasDespesasItem;
                                        }; break;
                                    case 4:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio = 0;
                                        }; break;
                                }
                                switch (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo)
                                {
                                    case 2:
                                    case 3:
                                        {
                                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio -=
                                                (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio *
                                                (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBase / 100));
                                        } break;
                                }
                                objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vIcmsProprio =
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoIcmsProprio * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pICMS / 100);
                            }
                            break;
                    }
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pIcmsInterno = objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaSubstituicaoTributaria == 1 ?
                        lClienteForn_Endereco.Count > 0 ?
                        (this.GetCodigo_Icms(idCodigoIcmsPai: objOrcamento_Item.Orcamento_Item_Impostos.idCodigoIcmsPai,
                        idCidade: (int)this.GetUfByCidadeClienteForn_Orcamento(
                                lClienteForn_Endereco.FirstOrDefault(
                                e => e.stPrincipal == 1).idCidade).idUF).pIcmsInterna) : 0 : 0;
                    //TODO: Implementar Carga Tributária MVA
                    #endregion

                    #region Icms Substituição Tributária
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pMvaSubstituicaoTributaria =
                        objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaSubstituicaoTributaria == 1 ?
                        this.GetCodigo_Icms(idCodigoIcmsPai: objOrcamento_Item.Orcamento_Item_Impostos.idCodigoIcmsPai,
                        idCidade: lClienteForn_Endereco.Count > 0 ? (int)this.GetUfByCidadeClienteForn_Orcamento(
                                lClienteForn_Endereco.FirstOrDefault(
                                e => e.stPrincipal == 1).idCidade).idUF : 0).pMvaSubstituicaoTributaria : 0;
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pCargaTributariaMedia = this.GetCarga_trib_mediaByUf(
                        idUf: lClienteForn_Endereco.Count > 0 ? (int)this.GetUfByCidadeClienteForn_Orcamento((int)
                                lClienteForn_Endereco.FirstOrDefault(
                                e => e.stPrincipal == 1).idCidade).idUF : 0).pCargaTributariaMedia;
                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCompoeBaseCalculoSubstituicaoTributaria =
                        objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada == 1 ? (byte)4 :
                        objTipo_operacao.stCompoeBaseIcmsSubstituicaoTributaria;

                    if (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaSubstituicaoTributaria == 1
                        && objOrcamento_Item.stConsumidorFinal == 0)
                    {
                        switch (objOrcamento_Item.Orcamento_Item_Impostos.PIS_stCompoeBaseCalculoSubstituicaoTributaria)
                        {
                            case 0:
                                {
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria =
                                        ((objOrcamento_Item.vTotalItem * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pMvaSubstituicaoTributaria / 100))
                                        + objOrcamento_Item.vTotalItem);
                                } break;
                            case 1:
                                {
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria =
                                        (((objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI)
                                        * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pMvaSubstituicaoTributaria / 100))
                                        + objOrcamento_Item.vTotalItem);
                                } break;
                            case 2:
                                {
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria =
                                        (((objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI +
                                        objOrcamento_Item.vFreteItem)
                                        * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pMvaSubstituicaoTributaria / 100))
                                        + objOrcamento_Item.vTotalItem);
                                } break;
                            case 3:
                                {
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria =
                                        (((objOrcamento_Item.vTotalItem + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI +
                                        objOrcamento_Item.vFreteItem + objOrcamento_Item.vSegurosItem + objOrcamento_Item.vOutrasDespesasItem)
                                        * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pMvaSubstituicaoTributaria / 100))
                                        + objOrcamento_Item.vTotalItem);
                                } break;
                            case 4:
                                {
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria =
                                        ((objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vIcmsProprio + objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vSubstituicaoTributaria)
                                        / objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pIcmsInterno);
                                } break;
                            case 5:
                                {
                                    objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria = 0;
                                } break;
                        }

                        if (objOrcamento_Item.Orcamento_Item_Impostos.PIS_stCompoeBaseCalculoSubstituicaoTributaria != 5)
                        {
                            switch (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stReduzBaseCalculo)
                            {
                                case 1:
                                case 3:
                                    {
                                        objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria =
                                            (((objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria -
                                            (objOrcamento_Item.vTotalItem * (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBaseSubstituicaoTributaria / 100))
                                            + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI + objOrcamento_Item.vFreteItem + objOrcamento_Item.vOutrasDespesasItem) *
                                            (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pMvaSubstituicaoTributaria / 100)) + objOrcamento_Item.vTotalItem);
                                    } break;
                            }
                        }
                    }

                    if (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_stCalculaSubstituicaoTributaria == 1)
                    {
                        if (objOrcamento_Item.stConsumidorFinal == 0 &&
                            objOrcamento_ide.stContribuinteIcms == 1 &&
                            objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada != 0)
                        {
                            // **Cálculo** (((“Orçamento_Item_Impostos.ICMS_vBaseCalculoIcmsSubstituicaoTributaria”
                            //X Orçamento_Item_Impostos.ICMS_pIcmsInterno / 100) - Orcamento_Icms.vIcmsInterno ) 

                            //TODO: pedir orientação para término de cálculo, pois campo ICMS_vIcmsInterno não existe na base de dados

                            //objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vSubstituicaoTributaria = 
                            //    (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria *
                            //    (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pIcmsInterno/100)) - 
                            //objOrcamento_Item.Orcamento_Item_Impostos
                        }
                        else if (objOrcamento_Item.stConsumidorFinal == 1 &&
                            objOrcamento_ide.stContribuinteIcms == 1 &&
                            this.GetRamo_atividade(idRamo_atividade: objClienteForn.idRamoAtividade).xRamo == "1" &&
                            (lClienteForn_Endereco.Count > 0 ?
                            this.GetUfByCidadeClienteForn_Orcamento(lClienteForn_Endereco.FirstOrDefault(e => e.stTipoEndereco == 1).idCidade).idUF : 0)
                            != this.GetUfByCidadeClienteForn_Orcamento(this.GetEmpresa_enderecoPrincipal().idCidade).idUF &&
                            objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada != 0
                            )
                        {
                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vSubstituicaoTributaria =
                                (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria *
                                (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pICMS - objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pIcmsInterno))
                                / 100;
                        }
                        else if (objOrcamento_Item.stConsumidorFinal == 0 &&
                            objOrcamento_ide.stContribuinteIcms == 1 &&
                            objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada != 1 &&
                            (lClienteForn_Endereco.Count > 0 ? this.GetUfByCidadeClienteForn_Orcamento(
                            lClienteForn_Endereco.FirstOrDefault(e => e.stTipoEndereco == 1).idCidade).xSiglaUf : "") == "MT")
                        {
                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vSubstituicaoTributaria =
                                (objOrcamento_Item.vTotalItem - (objOrcamento_Item.Orcamento_Item_Impostos.ICMS_pReduzBaseSubstituicaoTributaria * 100)
                                + objOrcamento_Item.Orcamento_Item_Impostos.IPI_vIPI + objOrcamento_Item.vFreteItem + objOrcamento_Item.vSegurosItem
                                + objOrcamento_Item.vOutrasDespesasItem) * this.GetCarga_trib_mediaByUf(
                                idUf: lClienteForn_Endereco.Count > 0 ?
                                (int)this.GetUfByCidadeClienteForn_Orcamento(lClienteForn_Endereco.FirstOrDefault(
                                i => i.stPrincipal == 1).idCidade).idUF : 0).pCargaTributariaMedia;
                        }
                        else if (objOrcamento_Item.stConsumidorFinal == 1 &&
                            objOrcamento_ide.stContribuinteIcms == 0 &&
                            this.GetParametro_Fiscal().stIcmsSubstDif == 1 &&
                            this.GetRamo_atividade(objClienteForn.idRamoAtividade).xRamo == "1" &&
                            this.GetUfByCidadeClienteForn_Orcamento(
                            lClienteForn_Endereco.FirstOrDefault(e => e.stTipoEndereco == 1).idCidade).idUF ==
                            (lClienteForn_Endereco.Count > 0 ?
                            this.GetUfByCidadeClienteForn_Orcamento(this.GetEmpresa_enderecoPrincipal().idCidade).idUF : 0) &&
                                objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada == 0)
                        {
                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria = 0;
                        }
                        else if (objOrcamento_Item.stConsumidorFinal == 1 &&
                            objOrcamento_ide.stContribuinteIcms == 1 &&
                            this.GetParametro_Fiscal().stIcmsSubstDif == 0 &&
                            this.GetRamo_atividade(objClienteForn.idRamoAtividade).xRamo == "1" &&
                            (lClienteForn_Endereco.Count > 0 ? this.GetUfByCidadeClienteForn_Orcamento(
                            lClienteForn_Endereco.FirstOrDefault(e => e.stTipoEndereco == 1).idCidade).idUF : 0) !=
                            this.GetUfByCidadeClienteForn_Orcamento(this.GetEmpresa_enderecoPrincipal().idCidade).idUF &&
                            objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada == 0)
                        {
                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria = 0;
                        }
                        else if (objOrcamento_Item.stConsumidorFinal == 1 &&
                            objOrcamento_ide.stContribuinteIcms == 1 &&
                            this.GetParametro_Fiscal().stIcmsSubstDif == 1 &&
                            this.GetRamo_atividade(objClienteForn.idRamoAtividade).xRamo == "1" &&
                            (lClienteForn_Endereco.Count > 0 ? this.GetUfByCidadeClienteForn_Orcamento(
                            lClienteForn_Endereco.FirstOrDefault(e => e.stTipoEndereco == 1).idCidade).idUF : 0) !=
                            this.GetUfByCidadeClienteForn_Orcamento(this.GetEmpresa_enderecoPrincipal().idCidade).idUF &&
                            objClienteForn_Fiscal.stSubsticaoTributariaIcmsDiferenciada != 0)
                        {
                            objOrcamento_Item.Orcamento_Item_Impostos.ICMS_vBaseCalculoSubstituicaoTributaria = 0;
                        }
                    }
                    #endregion

                    #region Pis Cofins

                    objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins = objTipo_operacao.stCalculaPisCofins;
                    objOrcamento_Item.Orcamento_Item_Impostos.stRegimeTributacaoPisCofins = objTipo_operacao.stRegimeTributacaoPisCofins;
                    objOrcamento_Item.Orcamento_Item_Impostos.PIS_nCoeficienteSubstituicaoTributaria =
                        objTipo_operacao.nCoeficienteSubstituicaoTributariaPis;

                    if (objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins == 3 &&
                        objOrcamento_Item.Orcamento_Item_Impostos.PIS_nCoeficienteSubstituicaoTributaria <= 0)
                        throw new Exception("Ao ser selecionado situação de cálculo pis/cofins com opção 3 - Substituição Tributária, " +
                    "o coeficiente substituição tributária do Pis deve ser superior a 0");

                    objOrcamento_Item.Orcamento_Item_Impostos.COFINS_nCoeficienteSubstituicaoTributaria =
                        objTipo_operacao.nCoeficienteSubstituicaoTributariaCofins;

                    if (objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins == 3 &&
                        objOrcamento_Item.Orcamento_Item_Impostos.COFINS_nCoeficienteSubstituicaoTributaria <= 0)
                        throw new Exception("Ao ser selecionado situação de cálculo pis/cofins com opção 3 - Substituição Tributária, " +
                    "o coeficiente substituição tributária do Cofins deve ser superior a 0");

                    objOrcamento_Item.Orcamento_Item_Impostos.PIS_pPIS = objTipo_operacao.pPis;

                    if ((objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins == 2 ||
                        objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins == 3) &&
                        objOrcamento_Item.Orcamento_Item_Impostos.PIS_pPIS <= 0)
                        throw new Exception("Ao ser selecionado situação de cálculo pis/cofins com opção 2 - Normal ou 3 - Substituição Tributária, " +
                    "a porcentagem do PIS deve ser superior a 0");

                    objOrcamento_Item.Orcamento_Item_Impostos.COFINS_pCOFINS = objTipo_operacao.pCofins;

                    if ((objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins == 2 ||
                        objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins == 3) &&
                        objOrcamento_Item.Orcamento_Item_Impostos.COFINS_pCOFINS <= 0)
                        throw new Exception("Ao ser selecionado situação de cálculo pis/cofins com opção 2 - Normal ou 3 - Substituição Tributária, " +
                    "a porcentagem do COFINS deve ser superior a 0");

                    objOrcamento_Item.Orcamento_Item_Impostos.idCSTPis = objTipo_operacao.idCSTPis;
                    objOrcamento_Item.Orcamento_Item_Impostos.idCSTCofins = objTipo_operacao.idCSTCofins;

                    switch (objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins)
                    {
                        case 0:
                        case 2:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.stCompoeBaseCalculoPisCofins = 4;
                            }; break;
                        case 1:
                            {
                                if (objTipo_operacao.stCompoeBaseNormalPiscofins == 4)
                                    throw new Exception("Selecionada opção inválida para Compõe Base Pis/Cofins para a situação Calcula PIS/COFINS 2 - Normal." +
                                Environment.NewLine + "Selecione outra opção");

                                objOrcamento_Item.Orcamento_Item_Impostos.stCompoeBaseCalculoPisCofins = objTipo_operacao.stCompoeBaseNormalPiscofins;
                            }; break;
                    }

                    switch (objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins)
                    {
                        case 0:
                        case 1:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.stCompoeBaseCalculoPisCofins = 4;
                            }; break;
                        case 2:
                            {
                                if (objTipo_operacao.stCompoeBaseSubtTribCofins == 4)
                                    throw new Exception("Selecionada opção inválida para Compõe Base Substituição Tributária Cofins para a situação Calcula PIS/COFINS 3-SUBSTITUIÇÃO TRIBUTÁRIA." +
                                Environment.NewLine + "Selecione outra opção");

                                objOrcamento_Item.Orcamento_Item_Impostos.COFINS_stCompoeBaseCalculoSubstituicaoTributaria =
                                    objTipo_operacao.stCompoeBaseSubtTribCofins;
                            }; break;
                    }

                    switch (objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins)
                    {
                        case 0:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.PIS_vBaseCalculo =
                                    objOrcamento_Item.Orcamento_Item_Impostos.PIS_vPIS = 0;
                            }; break;
                        case 1:
                        case 2:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.PIS_vPIS = objOrcamento_Item.Orcamento_Item_Impostos.PIS_vBaseCalculo *
                                    (objOrcamento_Item.Orcamento_Item_Impostos.PIS_pPIS / 100);
                            }; break;
                    }

                    switch (objOrcamento_Item.Orcamento_Item_Impostos.stCalculaPisCofins)
                    {
                        case 0:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.COFINS_vBaseCalculo =
                                    objOrcamento_Item.Orcamento_Item_Impostos.COFINS_vCOFINS = 0;
                            }; break;
                        case 1:
                        case 2:
                            {
                                objOrcamento_Item.Orcamento_Item_Impostos.PIS_vPIS = objOrcamento_Item.Orcamento_Item_Impostos.COFINS_vBaseCalculo *
                                    (objOrcamento_Item.Orcamento_Item_Impostos.COFINS_pCOFINS / 100);
                            }; break;
                    }

                    #endregion

                    #region ISS

                    objOrcamento_Item.Orcamento_Item_Impostos.ISS_stCalculaIss = objTipo_operacao.stCalculaIss;
                    objOrcamento_Item.Orcamento_Item_Impostos.ISS_pIss = objTipo_operacao.pIss;
                    objOrcamento_Item.Orcamento_Item_Impostos.ISS_vBaseCalculo = objOrcamento_Item.vTotalItem;
                    objOrcamento_Item.Orcamento_Item_Impostos.ISS_vIss = objOrcamento_Item.Orcamento_Item_Impostos.ISS_stCalculaIss == 0 ?
                        0 : objOrcamento_Item.Orcamento_Item_Impostos.IPI_vBaseCalculo * (objOrcamento_Item.Orcamento_Item_Impostos.ISS_pIss / 100);

                    #endregion
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void CarregaUnidMedProdutos(int idProduto, DataGridViewComboBoxCell cellDgv)
        {
            try
            {
                //TODO: Recontinuar os deste ponto:
                //Descrição: Refazer método para receber idProduto e popular coluna de unidade de medida
                List<Unidade_medidaModel> lUnidadeMedida = new List<Unidade_medidaModel>();
                lUnidadeMedida.Add(this.GetInformacoesUnidade(idUnidadeMedida:
                    this.GetInformacoesProduto(idProduto:
                    idProduto).idUnidadeMedidaVendas));

                List<Unidade_medidaModel> lUnidadeMedidaProduto = idProduto != 0 ?
                    this.GetUnidadeByConversaoProduto(
                    this.GetInformacoesProduto(
                    idProduto: idProduto).idUnidadeMedidaVendas
                    , idProduto) : null;

                if (lUnidadeMedidaProduto != null)
                {
                    lUnidadeMedida.AddRange(lUnidadeMedidaProduto);

                    if (cellDgv.Items.Count > 0)
                    {
                        cellDgv.DataSource = null;
                        cellDgv.Items.Clear();
                    }
                    cellDgv.DataSource =
                        lUnidadeMedida;
                    cellDgv.DisplayMember =
                        "xUnidadeMedida";
                    cellDgv.ValueMember =
                        "idUnidadeMedida";
                }
                //GetComissao();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CarregaTreeViewOrcamentos(int idOrcamento, ComponentFactory.Krypton.Toolkit.KryptonTreeView tree)
        {
            Stack<InfTreeViewOrcamento> lIdOrcamentos = new Stack<InfTreeViewOrcamento>();
            InfTreeViewOrcamento infTreeViewOrc;
            Orcamento_ideModel objOrcamento_ide = _Orcamento_ideRepository.GetOrcamento_ide(
                idOrcamento: idOrcamento);
            TreeNode node;

            #region Carrega Nodes Pai
            while (true)
            {
                infTreeViewOrc = new InfTreeViewOrcamento();
                infTreeViewOrc.idOrcamento = objOrcamento_ide.idOrcamento.ToString();
                infTreeViewOrc.dDataCriacaoOrcamento = objOrcamento_ide.dDataHora.ToString();
                lIdOrcamentos.Push(item: infTreeViewOrc);

                if (objOrcamento_ide.idOrcamentoOrigem == null)
                    break;
                try
                {
                    objOrcamento_ide = _Orcamento_ideRepository.GetOrcamentoByOrigem(idOrcamento: (int)(objOrcamento_ide.idOrcamentoOrigem));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            TreeNode nodeAnterior = new TreeNode();

            tree.Nodes.Clear();

            while (lIdOrcamentos.Count > 0)
            {
                infTreeViewOrc = new InfTreeViewOrcamento();
                infTreeViewOrc = lIdOrcamentos.Pop();
                node = new TreeNode(text: infTreeViewOrc.idOrcamento + " - " +
                    infTreeViewOrc.dDataCriacaoOrcamento);
                node.Tag = infTreeViewOrc.idOrcamento;

                if (tree.Nodes.Count == 0)
                    tree.Nodes.Add(node: node);
                else
                    nodeAnterior.Nodes.Add(node: node);

                nodeAnterior = node;
            }
            #endregion

            #region Carrega Nodes Filho

            objOrcamento_ide = _Orcamento_ideRepository.GetOrcamentoFilho(idOrcamento: idOrcamento);
            TreeNode ultimoNode = null;

            while (objOrcamento_ide != null)
            {
                if (ultimoNode == null)
                {
                    ultimoNode = tree.Nodes[0];
                    while (ultimoNode.LastNode != null)
                    {
                        ultimoNode = ultimoNode.LastNode;
                    }
                }

                node = new TreeNode();
                node.Text = objOrcamento_ide.idOrcamento + " - " +
                    objOrcamento_ide.dDataHora.ToString();
                node.Tag = objOrcamento_ide.idOrcamento;
                ultimoNode.Nodes.Add(node: node);
                ultimoNode = node;
                try
                {
                    objOrcamento_ide = _Orcamento_ideRepository.GetOrcamentoFilho(idOrcamento: (int)objOrcamento_ide.idOrcamento);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            #endregion
        }

        public void DestacarNodeTreeView(ComponentFactory.Krypton.Toolkit.KryptonTreeView tree, object valor)
        {
            TreeNode node = new TreeNode();
            node = BuscarNodeTreeView(node: tree.Nodes[0], valor: valor);
            node.ForeColor = Color.Red;
        }

        public bool NodeTreeViewPossuiFilho(ComponentFactory.Krypton.Toolkit.KryptonTreeView tree, object valor)
        {
            return BuscarNodeTreeView(valor: valor, node: tree.Nodes[0]).LastNode != null ?
                true : false;
        }

        private TreeNode BuscarNodeTreeView(object valor, TreeNode node)
        {
            TreeNode nodeTemp = node;
            while (true)
            {
                if (nodeTemp.Tag.ToString() == valor.ToString())
                {
                    break;
                }
                else
                {
                    nodeTemp = nodeTemp.LastNode;
                }
            }
            return nodeTemp;
        }

        #endregion

    }
}