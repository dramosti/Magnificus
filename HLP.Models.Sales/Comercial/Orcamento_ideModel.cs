using HLP.Comum.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Sales.Comercial
{
    public class Orcamento_ideModel
    {
        [ParameterOrder(Order = 1)]
        public int? idOrcamento { get; set; }
        [ParameterOrder(Order = 2)]
        public DateTime dDataHora { get; set; }
        [ParameterOrder(Order = 3)]
        public int idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stOrcamento { get; set; }
        [ParameterOrder(Order = 5)]
        public int idTipoOrcamento { get; set; }
        [ParameterOrder(Order = 6)]
        public DateTime? dVencimento { get; set; }
        [ParameterOrder(Order = 7)]
        public DateTime? dAcompanhamento { get; set; }
        [ParameterOrder(Order = 8)]
        public string xCotacaoComprasCliente { get; set; }
        [ParameterOrder(Order = 9)]
        public string xPedidoCliente { get; set; }
        [ParameterOrder(Order = 10)]
        public int idDeposito { get; set; }
        [ParameterOrder(Order = 11)]
        public string xNomeEntrega { get; set; }
        [ParameterOrder(Order = 12)]
        public int idModosEntrega { get; set; }
        [ParameterOrder(Order = 13)]
        public int idCondicaoEntrega { get; set; }
        [ParameterOrder(Order = 14)]
        public DateTime? dDataRecebimentoSolicitado { get; set; }
        [ParameterOrder(Order = 15)]
        public DateTime? dDataRemessaSolicitada { get; set; }
        [ParameterOrder(Order = 16)]
        public int idCondicaoPagamento { get; set; }
        [ParameterOrder(Order = 17)]
        public int? idMotivo { get; set; }
        [ParameterOrder(Order = 18)]
        public DateTime? dConfirmacao { get; set; }
        [ParameterOrder(Order = 19)]
        public int idUnidadeVenda { get; set; }
        [ParameterOrder(Order = 20)]
        public int idDescontos { get; set; }
        [ParameterOrder(Order = 21)]
        public int idJuros { get; set; }
        [ParameterOrder(Order = 22)]
        public int idMulta { get; set; }
        [ParameterOrder(Order = 23)]
        public string xObservacao { get; set; }
        [ParameterOrder(Order = 24)]
        public byte? stConsumidorFinal { get; set; }
        [ParameterOrder(Order = 25)]
        public byte? stSuframaOrcamento { get; set; }
        [ParameterOrder(Order = 26)]
        public byte? stDescPISCOFINSSuframa { get; set; }
        [ParameterOrder(Order = 27)]
        public int idMoeda { get; set; }
        [ParameterOrder(Order = 28)]
        public int idFuncionarioRepresentante { get; set; }
        [ParameterOrder(Order = 29)]
        public string cIdentificacao { get; set; }
        [ParameterOrder(Order = 30)]
        public int idContaContabil { get; set; }
        [ParameterOrder(Order = 31)]
        public int idTipoDocumento { get; set; }
        [ParameterOrder(Order = 32)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 33)]
        public int? idContato { get; set; }
        [ParameterOrder(Order = 34)]
        public string nPedidoCliente { get; set; }
        [ParameterOrder(Order = 35)]
        public byte stContribuinteIcms { get; set; }
        [ParameterOrder(Order = 36)]
        public int? idOrcamentoOrigem { get; set; }
        [ParameterOrder(Order = 37)]
        public string xVersaoOrcamento { get; set; }
        [ParameterOrder(Order = 38)]
        public int? idSite { get; set; }
        [ParameterOrder(Order = 39)]
        public int? idFuncionario { get; set; }
        [ParameterOrder(Order = 40)]
        public int? idFuncionarioResponsavel { get; set; }
        [ParameterOrder(Order = 41)]
        public byte? stWeb { get; set; }
        [ParameterOrder(Order = 42)]
        public int? idTransportador { get; set; }

        private List<Orcamento_ItemModel> lOrcamento_Itens;

        public List<Orcamento_ItemModel> LOrcamento_Itens
        {
            get
            {
                return lOrcamento_Itens == null ?
                lOrcamento_Itens = new List<Orcamento_ItemModel>() : lOrcamento_Itens;
            }
            set { lOrcamento_Itens = value; }
        }

        private Orcamento_Total_ImpostosModel orcamento_Total_Impostos;

        public Orcamento_Total_ImpostosModel Orcamento_Total_Impostos
        {
            get
            {
                return orcamento_Total_Impostos == null ?
                    orcamento_Total_Impostos = new Orcamento_Total_ImpostosModel() : orcamento_Total_Impostos;
            }
            set { orcamento_Total_Impostos = value; }
        }

        private Orcamento_retTranspModel orcamento_retTransp;

        public Orcamento_retTranspModel Orcamento_retTransp
        {
            get
            {
                return orcamento_retTransp == null ?
                    orcamento_retTransp = new Orcamento_retTranspModel() : orcamento_retTransp;
            }
            set { orcamento_retTransp = value; }
        }

    }

    public class Orcamento_ItemModel : BaseModelFilhos
    {
        static int cont = 0;

        public Orcamento_ItemModel()
        {
            this.idItem = cont + 1;
            cont++;
            this.orcamento_Item_Impostos = new Orcamento_Item_ImpostosModel();
        }

        public int idItem { get; set; } //Adicionei esta propriedade para controle da manipulação da lista, de acordo com o status
        //do item no orçamento, para que o item fique gravado na memória e não se perca no momento
        //da filtragem pelo status de orçamento dos itens e também não se duplique no momento de salva-lo
        //na lista em memória
        private int? _idOrcamentoItem;
        [ParameterOrder(Order = 1)]
        public int? idOrcamentoItem
        {
            get { return _idOrcamentoItem; }
            set
            {
                _idOrcamentoItem = value;
                base.SetID(value);
            }
        }

        [ParameterOrder(Order = 2)]
        public int idOrcamento { get; set; }
        [ParameterOrder(Order = 3)]
        public int idSite { get; set; }
        [ParameterOrder(Order = 4)]
        public int idDeposito { get; set; }
        [ParameterOrder(Order = 5)]
        public int idProduto { get; set; }
        [ParameterOrder(Order = 6)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 7)]
        public int idTipoOperacao { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stConsumidorFinal { get; set; }
        [ParameterOrder(Order = 9)]
        public string xPedidoCliente { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal? nItemCliente { get; set; }
        [ParameterOrder(Order = 11)]
        public string xCodigoProdutoCliente { get; set; }
        [ParameterOrder(Order = 12)]
        public string xComercial { get; set; }
        [ParameterOrder(Order = 13)]
        public int idUnidadeMedida { get; set; }
        [ParameterOrder(Order = 14)]
        public int idListaPrecoPai { get; set; }
        [ParameterOrder(Order = 15)]
        public decimal vVendaSemDesconto { get; set; }
        [ParameterOrder(Order = 16)]
        public decimal vVenda { get; set; }
        [ParameterOrder(Order = 17)]
        public decimal qProduto { get; set; }
        [ParameterOrder(Order = 18)]
        public decimal pDesconto { get; set; }
        [ParameterOrder(Order = 19)]
        public decimal vDesconto { get; set; }
        [ParameterOrder(Order = 20)]
        public decimal vTotalSemDescontoItem { get; set; }
        [ParameterOrder(Order = 21)]
        public decimal vTotalItem { get; set; }
        [ParameterOrder(Order = 22)]
        public decimal vFreteItem { get; set; }
        [ParameterOrder(Order = 23)]
        public DateTime? dPrevisaoEntrega { get; set; }
        [ParameterOrder(Order = 24)]
        public decimal nPesoBruto { get; set; }
        [ParameterOrder(Order = 25)]
        public decimal nPesoLiquido { get; set; }
        [ParameterOrder(Order = 26)]
        public byte stOrcamentoItem { get; set; }
        [ParameterOrder(Order = 27)]
        public string nPedidoClienteItem { get; set; }
        [ParameterOrder(Order = 28)]
        public DateTime? dConfirmacaoItem { get; set; }
        [ParameterOrder(Order = 29)]
        public int? idMotivo { get; set; }
        [ParameterOrder(Order = 30)]
        public string xObservacaoItem { get; set; }
        [ParameterOrder(Order = 31)]
        public decimal vSegurosItem { get; set; }
        [ParameterOrder(Order = 32)]
        public decimal vOutrasDespesasItem { get; set; }
        [ParameterOrder(Order = 33)]
        public int? idCfop { get; set; }
        [ParameterOrder(Order = 34)]
        public int? idFuncionarioRepresentante { get; set; }
        [ParameterOrder(Order = 35)]
        public decimal? pComissao { get; set; }
        [ParameterOrder(Order = 36)]
        public decimal? vDescontoSuframa { get; set; }

        private Orcamento_Item_ImpostosModel orcamento_Item_Impostos;

        public Orcamento_Item_ImpostosModel Orcamento_Item_Impostos
        {
            get
            {
                return orcamento_Item_Impostos;
            }
            set { orcamento_Item_Impostos = value; }
        }
    }

    public class Orcamento_Item_ImpostosModel
    {
        [ParameterOrder(Order = 1)]
        public int? idOrcamentoTotalizadorImpostos { get; set; }
        [ParameterOrder(Order = 2)]
        public byte ICMS_stOrigemMercadoria { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal? ICMS_vBaseCalculo { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal? ICMS_pReduzBase { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal? ICMS_pICMS { get; set; }
        [ParameterOrder(Order = 6)]
        public decimal? ICMS_vICMS { get; set; }
        [ParameterOrder(Order = 7)]
        public decimal? ICMS_pMvaSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 8)]
        public decimal? ICMS_pReduzBaseSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal? ICMS_vBaseCalculoSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal? ICMS_pSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 11)]
        public decimal? ICMS_vSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 12)]
        public decimal? ICMS_vBaseCalculoSubstituicaoTributariaRetido { get; set; }
        [ParameterOrder(Order = 13)]
        public decimal? ICMS_vSubstituicaoTributariaRetido { get; set; }
        [ParameterOrder(Order = 14)]
        public byte ICMS_stReduzBaseCalculo { get; set; }
        [ParameterOrder(Order = 15)]
        public byte ICMS_stCalculaIcms { get; set; }
        [ParameterOrder(Order = 16)]
        public byte ICMS_stCompoeBaseCalculo { get; set; }
        [ParameterOrder(Order = 17)]
        public byte ICMS_stCompoeBaseCalculoSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 18)]
        public decimal? ICMS_vBaseCalculoIcmsProprio { get; set; }
        [ParameterOrder(Order = 19)]
        public decimal? ICMS_vIcmsProprio { get; set; }
        [ParameterOrder(Order = 20)]
        public decimal? ICMS_pIcmsInterno { get; set; }
        [ParameterOrder(Order = 21)]
        public byte ICMS_stCalculaSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 22)]
        public decimal? ICMS_pCargaTributariaMedia { get; set; }
        [ParameterOrder(Order = 23)]
        public int idOrcamentoItem { get; set; }
        [ParameterOrder(Order = 24)]
        public int idCodigoIcmsPai { get; set; }
        [ParameterOrder(Order = 25)]
        public int? idCSTIcms { get; set; }
        [ParameterOrder(Order = 26)]
        public decimal? IPI_vBaseCalculo { get; set; }
        [ParameterOrder(Order = 27)]
        public decimal? IPI_pIPI { get; set; }
        [ParameterOrder(Order = 28)]
        public decimal? IPI_vIPI { get; set; }
        [ParameterOrder(Order = 29)]
        public byte IPI_stCalculaIpi { get; set; }
        [ParameterOrder(Order = 30)]
        public byte IPI_stCompoeBaseCalculo { get; set; }
        [ParameterOrder(Order = 31)]
        public int? idClassificacaoFiscal { get; set; }
        [ParameterOrder(Order = 32)]
        public int? idCSTIpi { get; set; }
        [ParameterOrder(Order = 33)]
        public decimal? ISS_vBaseCalculo { get; set; }
        [ParameterOrder(Order = 34)]
        public decimal? ISS_pIss { get; set; }
        [ParameterOrder(Order = 35)]
        public decimal? ISS_vIss { get; set; }
        [ParameterOrder(Order = 36)]
        public byte ISS_stCalculaIss { get; set; }
        [ParameterOrder(Order = 37)]
        public int? idCSTIss { get; set; }
        [ParameterOrder(Order = 38)]
        public decimal? PIS_vBaseCalculo { get; set; }
        [ParameterOrder(Order = 39)]
        public decimal? PIS_pPIS { get; set; }
        [ParameterOrder(Order = 40)]
        public decimal? PIS_vPIS { get; set; }
        [ParameterOrder(Order = 41)]
        public byte stCalculaPisCofins { get; set; }
        [ParameterOrder(Order = 42)]
        public byte stRegimeTributacaoPisCofins { get; set; }
        [ParameterOrder(Order = 43)]
        public decimal? PIS_nCoeficienteSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 44)]
        public byte stCompoeBaseCalculoPisCofins { get; set; }
        [ParameterOrder(Order = 45)]
        public byte PIS_stCompoeBaseCalculoSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 46)]
        public int? idCSTPis { get; set; }
        [ParameterOrder(Order = 47)]
        public decimal? COFINS_vBaseCalculo { get; set; }
        [ParameterOrder(Order = 48)]
        public decimal? COFINS_pCOFINS { get; set; }
        [ParameterOrder(Order = 49)]
        public decimal? COFINS_vCOFINS { get; set; }
        [ParameterOrder(Order = 50)]
        public decimal? COFINS_nCoeficienteSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 51)]
        public byte? COFINS_stCompoeBaseCalculoSubstituicaoTributaria { get; set; }
        [ParameterOrder(Order = 52)]
        public int? idCSTCofins { get; set; }
        [ParameterOrder(Order = 53)]
        public byte? ICMS_stNaoReduzBase { get; set; }
    }

    public class Orcamento_Total_ImpostosModel
    {
        [ParameterOrder(Order = 1)]
        public int? idOrcamentoTotalImpostos { get; set; }
        [ParameterOrder(Order = 2)]
        public decimal vBaseCalculoIcmsTotal { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal vICMSTotal { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal vBaseCalculoICmsSubstituicaoTributariaTotal { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal vIcmsSubstituicaoTributariaTotal { get; set; }
        [ParameterOrder(Order = 6)]
        public decimal vProdutoTotal { get; set; }
        [ParameterOrder(Order = 7)]
        public decimal vFreteTotal { get; set; }
        [ParameterOrder(Order = 8)]
        public decimal vSeguroTotal { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal vDescontoTotal { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal vIITotal { get; set; }
        [ParameterOrder(Order = 11)]
        public decimal vIPITotal { get; set; }
        [ParameterOrder(Order = 12)]
        public decimal vPISTotal { get; set; }
        [ParameterOrder(Order = 13)]
        public decimal vCOFINSTotal { get; set; }
        [ParameterOrder(Order = 14)]
        public decimal vOutrasDespesasTotal { get; set; }
        [ParameterOrder(Order = 15)]
        public decimal vTotal { get; set; }
        [ParameterOrder(Order = 16)]
        public decimal pDescontoTotal { get; set; }
        [ParameterOrder(Order = 17)]
        public decimal? vDescontoSuframaTotal { get; set; }
        [ParameterOrder(Order = 18)]
        public byte stFrete { get; set; }
        [ParameterOrder(Order = 19)]
        public byte stRateioFrete { get; set; }
        [ParameterOrder(Order = 20)]
        public decimal vBaseCalculoIcmsProprioTotal { get; set; }
        [ParameterOrder(Order = 21)]
        public decimal vIcmsProprioTotal { get; set; }
        [ParameterOrder(Order = 22)]
        public decimal vBaseCalculoIpiTotal { get; set; }
        [ParameterOrder(Order = 23)]
        public decimal vBaseCalculoPisTotal { get; set; }
        [ParameterOrder(Order = 24)]
        public decimal vBaseCalculoCofinsTotal { get; set; }
        [ParameterOrder(Order = 25)]
        public decimal vBaseCalculoIssTotal { get; set; }
        [ParameterOrder(Order = 26)]
        public decimal vIssTotal { get; set; }
        [ParameterOrder(Order = 27)]
        public int idOrcamento { get; set; }
        [ParameterOrder(Order = 28)]
        public decimal? vServicoTotal { get; set; }
    }

    public class Orcamento_retTranspModel
    {
        [ParameterOrder(Order = 1)]
        public int? idRetTransp { get; set; }
        [ParameterOrder(Order = 2)]
        public decimal vServ { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal vBCRet { get; set; }
        [ParameterOrder(Order = 4)]
        public decimal pICMSRet { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal vICMSRet { get; set; }
        [ParameterOrder(Order = 6)]
        public int CFOP { get; set; }
        [ParameterOrder(Order = 7)]
        public int cMunFG { get; set; }
        [ParameterOrder(Order = 8)]
        public int idOrcamento { get; set; }
        [ParameterOrder(Order = 9)]
        public int? idTransportador { get; set; }
        [ParameterOrder(Order = 10)]
        public int? idRedespacho { get; set; }
        [ParameterOrder(Order = 11)]
        public byte stFrete { get; set; }
        [ParameterOrder(Order = 12)]
        public decimal? vPesoLiquido { get; set; }
        [ParameterOrder(Order = 13)]
        public decimal? vPesoBruto { get; set; }
        [ParameterOrder(Order = 14)]
        public decimal? vVolume { get; set; }
        [ParameterOrder(Order = 15)]
        public string xEspecieVolumeNf { get; set; }
        [ParameterOrder(Order = 16)]
        public string xMarcaVolumeNf { get; set; }
        [ParameterOrder(Order = 17)]
        public byte stTransporte { get; set; }
    }
}
