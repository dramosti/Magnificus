using HLP.Models.Entries.Comercial;
using HLP.Models.Entries.Fiscal;
using HLP.Models.Entries.Gerais;
using HLP.Models.Entries.Parametros;
using HLP.Models.Sales.Comercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLP.Services.Interfaces.Sales.Comercial
{
    public interface IOrcamento_ideService
    {
        void Save(Orcamento_ideModel objOrcamento_ide);
        void Delete(Orcamento_ideModel objOrcamento_ide);
        void Copy(Orcamento_ideModel objOrcamento_ide);
        Orcamento_ideModel GetOrcamento_ide(int idOrcamento);
        List<Orcamento_ideModel> GetAllOrcamento_ide();
        Cliente_fornecedorModel GetClienteFornOrcamento(int idClienteFornecedor);
        Cliente_fornecedor_EnderecoModel GetClienteForn_EnderecoOrcamento(int idClienteFornecedor);
        List<Lista_precoModel> GetListaPrecoOrcamento(int idListaPrecoPai);
        Cliente_fornecedor_representanteModel GetClienteFornRepresentante(int idClienteFornecedor);
        List<ContatoModel> GetContatosByClienteForn(int idClienteForn);
        ContatoModel GetInformacoesContato(int idContato);
        FuncionarioModel GetInformacoesFuncionario(int idFuncionario);
        ProdutoModel GetInformacoesProduto(int idProduto);
        Unidade_medidaModel GetInformacoesUnidade(int idUnidadeMedida);
        List<Unidade_medidaModel> GetUnidadeByConversaoProduto(int idUnidadeMedida, int idProduto);
        CidadeModel GetCidadeClienteForn_Orcamento(int idCidade);
        UFModel GetUfByCidadeClienteForn_Orcamento(int idCidade);
        byte GetStatusOrcamento(List<Orcamento_ItemModel> lItens);
        byte GetTipoComissao(Orcamento_ItemModel orc_itemModel);
        void GetComissao<T>(int idCondicao_Pagamento, Orcamento_ItemModel itemModel, T objeto) where T : class;
        Familia_produtoModel GetFamiliaProduto(int idFamilia_produto);
        int GetCfopByOperacao(int idOperacao, int idCliente);
        void PopulaObjetoItem(Orcamento_ItemModel objOrcamento_Item, Orcamento_ideModel objOrcamento_ide, CalculoDescontoPrincipal stCalculoPrincipal);
        Codigo_IcmsModel GetCodigo_Icms(int idCodigoIcmsPai, int idCidade);
        Carga_trib_media_st_icmsModel GetCarga_trib_mediaByUf(int idUf);
        void ValidaTipoOperacao(Orcamento_ItemModel objOrcamento_item, Cliente_fornecedorModel objClienteForn, int stContribuinteIcms);
        Ramo_atividadeModel GetRamo_atividade(int idRamo_atividade);
        Empresa_EnderecoModel GetEmpresa_enderecoPrincipal();
        Parametro_FiscalModel GetParametro_Fiscal();
        Situacao_tributaria_pisModel GetSit_Trib_PisByidCstPis(int idCstPis);
        decimal GetvVendaListaPrecoByIdProduto(int idListaPrecoPai, int idProduto);
        bool IsServiceByTipoOperacao(int idTipoOp);
        decimal CalculaProdutoTotal(List<Orcamento_ItemModel> lOrcamento_ItemModel);
        decimal CalculaServicoTotal(List<Orcamento_ItemModel> lOrcamento_ItemModel);
        decimal CalculaDescontoTotal(List<Orcamento_ItemModel> lOrcamento_ItemModel);
        void RateiaValorTotalNosItens(decimal vTotal, List<Orcamento_ItemModel> lOrcamento_ItemModel,
            PropriedadeCalculo iPropCalculo);
        void ValidaPorcListaPrecoItem(Orcamento_ItemModel objOrcamento_item, decimal porDescAcr, List<ItemPorcAcimaListaModel> lItensPorcAcimaLista);
        void ValidaPorcListaPrecoLista(List<Orcamento_ItemModel> lOrcamento_item,
            decimal porDescAcrTotal, List<ItemPorcAcimaListaModel> lItensPorcAcimaLista);
        decimal CalculaPorcDescontoTotal(decimal vDescontoTotal, decimal vProdutosTotal);
        Tipo_documentoModel GetInfTipoDocumento(int idTipoDocumento);
        bool IsNfSuframa(int idTipoDocumento);
        decimal CalculaTotalOrcamento(decimal vProdutoTotal, decimal vServicoTotal, decimal vIpiTotal, decimal vIcmsSubsTributaria,
            decimal vSeguroTotal, decimal vOutrasDespesasTotal, decimal vDescontoTotal, decimal vDescontoSuframaTotal);
        decimal CalculaPesoLiquido(List<Orcamento_ItemModel> lOrcamento_ItemModel);
        decimal CalculaPesoBruto(List<Orcamento_ItemModel> lOrcamento_ItemModel);
        void CarregaUnidMedProdutos(int idProduto, DataGridViewComboBoxCell cellDgv);
        string GetVersaoByOrigem(int idOrcamento);
        void CarregaTreeViewOrcamentos(int idOrcamento, ComponentFactory.Krypton.Toolkit.KryptonTreeView tree);
        void DestacarNodeTreeView(ComponentFactory.Krypton.Toolkit.KryptonTreeView tree, object valor);
        bool NodeTreeViewPossuiFilho(ComponentFactory.Krypton.Toolkit.KryptonTreeView tree, object valor);
    }

    public enum CalculoDescontoPrincipal //Enumeração criada para definir qual o cálculo de porcentagem será realizado primeiro, por porcentagem, ou por valor
    {
        porPorcentagem,
        porValor
    }

    public enum PropriedadeCalculo
    {
        descontoTotal,
        freteTotal,
        seguroTotal,
        outrasDespesasTotal
    }
}
