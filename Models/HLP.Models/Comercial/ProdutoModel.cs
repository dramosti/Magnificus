using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{
    public class ProdutoModel
    {
        [ParameterOrder(Order = 1)]
        public int? idProduto { get; set; }
        [ParameterOrder(Order = 2)]
        public string cAlternativo { get; set; }
        [ParameterOrder(Order = 3)]
        public string cEan { get; set; }
        [ParameterOrder(Order = 4)]
        public string xPesquisa { get; set; }
        [ParameterOrder(Order = 5)]
        public string xComercial { get; set; }
        [ParameterOrder(Order = 6)]
        public string xFiscal { get; set; }
        [ParameterOrder(Order = 7)]
        public string xIngles { get; set; }
        [ParameterOrder(Order = 8)]
        public int idUnidadeMedidaEstoque { get; set; }
        [ParameterOrder(Order = 9)]
        public int idTipoProduto { get; set; }
        [ParameterOrder(Order = 10)]
        public int idFamiliaProduto { get; set; }
        [ParameterOrder(Order = 11)]
        public int idFabricante { get; set; }
        [ParameterOrder(Order = 12)]
        public decimal nPesoBruto { get; set; }
        [ParameterOrder(Order = 13)]
        public decimal nPesoLiquido { get; set; }
        [ParameterOrder(Order = 14)]
        public int Cod_centro_custo { get; set; }
        [ParameterOrder(Order = 15)]
        public int? idProdutoLocalizacao { get; set; }
        [ParameterOrder(Order = 16)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 17)]
        public DateTime? dBloqueio { get; set; }
        [ParameterOrder(Order = 18)]
        public decimal nEstoqueMinimo { get; set; }
        [ParameterOrder(Order = 19)]
        public decimal nEstoqueMaximo { get; set; }
        [ParameterOrder(Order = 20)]
        public byte tpLote { get; set; }
        [ParameterOrder(Order = 21)]
        public string IniLote { get; set; }
        [ParameterOrder(Order = 22)]
        public int nPrazoValidade { get; set; }
        [ParameterOrder(Order = 23)]
        public string xFoto { get; set; }
        [ParameterOrder(Order = 24)]
        public string xObs { get; set; }
        [ParameterOrder(Order = 25)]
        public byte stCusto { get; set; }
        [ParameterOrder(Order = 26)]
        public byte stCustoMedio { get; set; }
        [ParameterOrder(Order = 27)]
        public decimal pInss { get; set; }
        [ParameterOrder(Order = 28)]
        public TimeSpan dleadTimeCotacao { get; set; }
        [ParameterOrder(Order = 29)]
        public TimeSpan dleadTimePedido { get; set; }
        [ParameterOrder(Order = 30)]
        public TimeSpan dleadTimeRecebimento { get; set; }
        [ParameterOrder(Order = 31)]
        public byte stLogisticaReversa { get; set; }
        [ParameterOrder(Order = 32)]
        public byte stFornecedorHomologado { get; set; }
        [ParameterOrder(Order = 33)]
        public int? idTipoServico { get; set; }
        [ParameterOrder(Order = 34)]
        public int? idEmpresa { get; set; }
        [ParameterOrder(Order = 35)]
        public int idDeposito { get; set; }
        [ParameterOrder(Order = 36)]
        public DateTime dCadastro { get; set; }
        [ParameterOrder(Order = 37)]
        public int idFuncionario { get; set; }
        [ParameterOrder(Order = 38)]
        public byte stOrigemMercadoria { get; set; }
        [ParameterOrder(Order = 39)]
        public int? idCSTIcms { get; set; }
        [ParameterOrder(Order = 40)]
        public byte stInss { get; set; }
        [ParameterOrder(Order = 41)]
        public decimal pImportacao { get; set; }
        [ParameterOrder(Order = 42)]
        public int? idCodigoIcmsPaiVenda { get; set; }
        [ParameterOrder(Order = 43)]
        public int? idCSTIpiVenda { get; set; }
        [ParameterOrder(Order = 44)]
        public int? idCSTPisVenda { get; set; }
        [ParameterOrder(Order = 45)]
        public int? idCSTCofinsVenda { get; set; }
        [ParameterOrder(Order = 46)]
        public int? idClassificacaoFiscalVenda { get; set; }
        [ParameterOrder(Order = 47)]
        public int? idCodigoIcmsPaiCompra { get; set; }
        [ParameterOrder(Order = 48)]
        public int? idCSTIpiCompra { get; set; }
        [ParameterOrder(Order = 49)]
        public int? idCSTPisCompra { get; set; }
        [ParameterOrder(Order = 50)]
        public int? idCSTCofinsCompra { get; set; }
        [ParameterOrder(Order = 51)]
        public int? idClassificacaoFiscalCompra { get; set; }
        [ParameterOrder(Order = 52)]
        public decimal vVenda { get; set; }
        [ParameterOrder(Order = 53)]
        public int idUnidadeMedidaVendas { get; set; }
        [ParameterOrder(Order = 54)]
        public decimal vAquisicao { get; set; }
        [ParameterOrder(Order = 55)]
        public int idUnidadeMedidaCompras { get; set; }
        [ParameterOrder(Order = 56)]
        public decimal vProducao { get; set; }
        [ParameterOrder(Order = 57)]
        public int idUnidadeMedidaProducao { get; set; }
        [ParameterOrder(Order = 58)]
        public byte stFornecedorHomologadoProduto { get; set; }
        [ParameterOrder(Order = 59)]
        public decimal nLoteMinimoCompras { get; set; }
        [ParameterOrder(Order = 60)]
        public decimal nProfundidadeBruta { get; set; }
        [ParameterOrder(Order = 61)]
        public decimal nLarguraBruta { get; set; }
        [ParameterOrder(Order = 62)]
        public decimal nAlturaBruta { get; set; }
        [ParameterOrder(Order = 63)]
        public decimal pEntregaExcedenteCompra { get; set; }
        [ParameterOrder(Order = 64)]
        public decimal pEntregaInsuficienteCompra { get; set; }
        [ParameterOrder(Order = 65)]
        public decimal vPerdaConstante { get; set; }
        [ParameterOrder(Order = 66)]
        public decimal pPerdaVariavel { get; set; }
        [ParameterOrder(Order = 67)]
        public decimal pEntregaExcedenteVenda { get; set; }
        [ParameterOrder(Order = 68)]
        public DateTime dValorVenda { get; set; }
        [ParameterOrder(Order = 69)]
        public decimal pEntregaInsuficienteVenda { get; set; }
        [ParameterOrder(Order = 70)]
        public decimal vCompra { get; set; }
        [ParameterOrder(Order = 71)]
        public decimal pPerdaConstante { get; set; }


        public List<Produto_Fornecedor_HomologadoModel> lProduto_Fornecedor_Homologado = new List<Produto_Fornecedor_HomologadoModel>();
        public List<Produto_RevisaoModel> lProduto_Revisao = new List<Produto_RevisaoModel>();

    }
    public class Produto_Fornecedor_HomologadoModel : BaseModelFilhos
    {
        public int? _idProdutoFornecedorHomologado;
        [ParameterOrder(Order = 1)]
        public int? idProdutoFornecedorHomologado
        { 
            get{ return _idProdutoFornecedorHomologado; }
            set
            {
                _idProdutoFornecedorHomologado = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 3)]
        public int idProduto { get; set; }
        [ParameterOrder(Order = 4)]
        public int idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 5)]
        public decimal nLeadTimeEntrega { get; set; }
        [ParameterOrder(Order = 6)]
        public decimal nLoteMinimoCompra { get; set; }



    }
    public class Produto_RevisaoModel : BaseModelFilhos
    {
        public int? _idProdutoRevisao;
        [ParameterOrder(Order = 1)]
        public int? idProdutoRevisao
        {
            get { return _idProdutoRevisao; }
            set 
            {
                _idProdutoRevisao = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idProduto { get; set; }
        [ParameterOrder(Order = 3)]
        public DateTime dInicial { get; set; }
        [ParameterOrder(Order = 4)]
        public string xRevisao { get; set; }
        [ParameterOrder(Order = 5)]
        public int idUsuario { get; set; }
        [ParameterOrder(Order = 6)]
        public DateTime dFinal { get; set; }

    }
}
