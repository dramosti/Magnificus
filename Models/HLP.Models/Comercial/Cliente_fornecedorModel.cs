using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Comercial
{

    public class Cliente_fornecedorModel
    {
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 2)]
        public int idEmpresa { get; set; }
        [ParameterOrder(Order = 3)]
        public string cAlternativo { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stCatalogo { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stPessoa { get; set; }
        [ParameterOrder(Order = 6)]
        public string xCnpj { get; set; }
        [ParameterOrder(Order = 7)]
        public string xIE { get; set; }
        [ParameterOrder(Order = 8)]
        public string xIm { get; set; }
        [ParameterOrder(Order = 9)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 10)]
        public string xRg { get; set; }
        [ParameterOrder(Order = 11)]
        public string xFantasia { get; set; }
        [ParameterOrder(Order = 12)]
        public int idRamoAtividade { get; set; }
        [ParameterOrder(Order = 13)]
        public int idRota { get; set; }
        [ParameterOrder(Order = 14)]
        public DateTime dCadastro { get; set; }
        [ParameterOrder(Order = 15)]
        public string xTelefone1 { get; set; }
        [ParameterOrder(Order = 16)]
        public string xTelefone2 { get; set; }
        [ParameterOrder(Order = 17)]
        public string xFax { get; set; }
        [ParameterOrder(Order = 18)]
        public string xEmail { get; set; }
        [ParameterOrder(Order = 19)]
        public string xHttp { get; set; }
        [ParameterOrder(Order = 20)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 21)]
        public string xMemorando { get; set; }
        [ParameterOrder(Order = 22)]
        public byte stCreditoAprovado { get; set; }
        [ParameterOrder(Order = 23)]
        public decimal vLimiteCredito { get; set; }
        [ParameterOrder(Order = 24)]
        public byte stLimiteCreditoObrigatorio { get; set; }
        [ParameterOrder(Order = 25)]
        public byte stFrete { get; set; }
        [ParameterOrder(Order = 26)]
        public int idCanalVenda { get; set; }
        [ParameterOrder(Order = 27)]
        public byte stExigeRelacaoProduto { get; set; }
        [ParameterOrder(Order = 28)]
        public int idListaPrecoPai { get; set; }
        [ParameterOrder(Order = 29)]
        public string xCpf { get; set; }
        [ParameterOrder(Order = 30)]
        public int idContaBancaria { get; set; }
        [ParameterOrder(Order = 31)]
        public int idMoeda { get; set; }
        [ParameterOrder(Order = 32)]
        public int idCondicaoPagamento { get; set; }
        [ParameterOrder(Order = 33)]
        public string xCEP { get; set; }
        [ParameterOrder(Order = 34)]
        public string xEndereco { get; set; }
        [ParameterOrder(Order = 35)]
        public string nNumero { get; set; }
        [ParameterOrder(Order = 36)]
        public string xComplemento { get; set; }
        [ParameterOrder(Order = 37)]
        public string xBairro { get; set; }
        [ParameterOrder(Order = 38)]
        public string xLatitude { get; set; }
        [ParameterOrder(Order = 39)]
        public string xLongitude { get; set; }
        [ParameterOrder(Order = 40)]
        public string xFusoHorario { get; set; }
        [ParameterOrder(Order = 41)]
        public string xCaixaPostal { get; set; }
        [ParameterOrder(Order = 42)]
        public int? idFuncionario { get; set; }
        [ParameterOrder(Order = 43)]
        public byte stParado { get; set; }
        [ParameterOrder(Order = 44)]
        public int nFuncionarios { get; set; }
        [ParameterOrder(Order = 45)]
        public byte stCategoria { get; set; }
        [ParameterOrder(Order = 46)]
        public string xSaudacao { get; set; }
        [ParameterOrder(Order = 47)]
        public string xApelido { get; set; }
        [ParameterOrder(Order = 48)]
        public byte stEstadoCivil { get; set; }
        [ParameterOrder(Order = 49)]
        public DateTime dDataNascimento { get; set; }
        [ParameterOrder(Order = 50)]
        public string xFilhos { get; set; }
        [ParameterOrder(Order = 51)]
        public string xConjugue { get; set; }
        [ParameterOrder(Order = 52)]
        public DateTime dDataAdmissao { get; set; }
        [ParameterOrder(Order = 53)]
        public string xEmpresaTrabalha { get; set; }
        [ParameterOrder(Order = 54)]
        public string xTelefoneEmpresaTrabalha { get; set; }
        [ParameterOrder(Order = 55)]
        public string xLocalNascimento { get; set; }
        [ParameterOrder(Order = 56)]
        public string xUFNascimento { get; set; }
        [ParameterOrder(Order = 57)]
        public string xProfissao { get; set; }
        [ParameterOrder(Order = 58)]
        public string xNomePai { get; set; }
        [ParameterOrder(Order = 59)]
        public string xRGPai { get; set; }
        [ParameterOrder(Order = 60)]
        public string xCPFPai { get; set; }
        [ParameterOrder(Order = 61)]
        public string xNomeMae { get; set; }
        [ParameterOrder(Order = 62)]
        public string xRGMae { get; set; }
        [ParameterOrder(Order = 63)]
        public string xCPFMae { get; set; }
        [ParameterOrder(Order = 64)]
        public byte stResidencia { get; set; }
        [ParameterOrder(Order = 65)]
        public string xPontoReferenciaResidencia { get; set; }
        [ParameterOrder(Order = 66)]
        public decimal vSalario { get; set; }
        [ParameterOrder(Order = 67)]
        public string xCPFConjugue { get; set; }
        [ParameterOrder(Order = 68)]
        public string xRGConjugue { get; set; }
        [ParameterOrder(Order = 69)]
        public string xProfissaoConjugue { get; set; }
        [ParameterOrder(Order = 70)]
        public string xEmpresaConjugue { get; set; }
        [ParameterOrder(Order = 71)]
        public string xInformacaoComercialNome1 { get; set; }
        [ParameterOrder(Order = 72)]
        public string xInformacaoComercialNome2 { get; set; }
        [ParameterOrder(Order = 73)]
        public string xInformacaoComercialNome3 { get; set; }
        [ParameterOrder(Order = 74)]
        public string xInformacaoComercialTelefone1 { get; set; }
        [ParameterOrder(Order = 75)]
        public string xInformacaoComercialTelefone2 { get; set; }
        [ParameterOrder(Order = 76)]
        public string xInformacaoComercialTelefone3 { get; set; }
        [ParameterOrder(Order = 77)]
        public DateTime dInformacaoComercialClienteDesde1 { get; set; }
        [ParameterOrder(Order = 78)]
        public DateTime dInformacaoComercialClienteDesde2 { get; set; }
        [ParameterOrder(Order = 79)]
        public DateTime dInformacaoComercialClienteDesde3 { get; set; }
        [ParameterOrder(Order = 80)]
        public decimal vInformacaoComercialMaiorCompra1 { get; set; }
        [ParameterOrder(Order = 81)]
        public decimal vInformacaoComercialMaiorCompra2 { get; set; }
        [ParameterOrder(Order = 82)]
        public decimal vInformacaoComercialMaiorCompra3 { get; set; }
        [ParameterOrder(Order = 83)]
        public DateTime dInformacaoComercialUltimaCompra1 { get; set; }
        [ParameterOrder(Order = 84)]
        public DateTime dInformacaoComercialUltimaCompra2 { get; set; }
        [ParameterOrder(Order = 85)]
        public DateTime dInformacaoComercialUltimaCompra3 { get; set; }
        [ParameterOrder(Order = 86)]
        public string xInformacaoComercialInformante1 { get; set; }
        [ParameterOrder(Order = 87)]
        public string xInformacaoComercialInformante2 { get; set; }
        [ParameterOrder(Order = 88)]
        public string xInformacaoComercialInformante3 { get; set; }
        [ParameterOrder(Order = 89)]
        public decimal vSalarioConjugue { get; set; }
        [ParameterOrder(Order = 90)]
        public byte stSexo { get; set; }
        [ParameterOrder(Order = 91)]
        public int idCondicaoEntrega { get; set; }
        [ParameterOrder(Order = 92)]
        public int? idModosEntrega { get; set; }
        [ParameterOrder(Order = 93)]
        public int? idCalendario { get; set; }
        [ParameterOrder(Order = 94)]
        public int? idTipoDocumento { get; set; }
        [ParameterOrder(Order = 95)]
        public int? idSite { get; set; }
        [ParameterOrder(Order = 96)]
        public int? idDeposito { get; set; }
        [ParameterOrder(Order = 97)]
        public int? idDescontos { get; set; }
        [ParameterOrder(Order = 98)]
        public int? idPlanoPagamento { get; set; }
        [ParameterOrder(Order = 99)]
        public int? idDiaPagamento { get; set; }
        [ParameterOrder(Order = 100)]
        public int? idJuros { get; set; }
        [ParameterOrder(Order = 101)]
        public byte stMostraProdutosRelacionado { get; set; }
        [ParameterOrder(Order = 102)]
        public int? idTransportador { get; set; }
        [ParameterOrder(Order = 103)]
        public byte stSpc { get; set; }
        [ParameterOrder(Order = 104)]
        public byte stSituacaoSci { get; set; }
        [ParameterOrder(Order = 105)]
        public byte stAssociacaoComercial { get; set; }
        [ParameterOrder(Order = 106)]
        public int? idMultas { get; set; }
        [ParameterOrder(Order = 107)]
        public byte? stObrigaListaPreco { get; set; }

        public List<Cliente_Fornecedor_ObservacaoModel> lCliente_Fornecedor_Observacao = new List<Cliente_Fornecedor_ObservacaoModel>();
        public List<Cliente_fornecedor_representanteModel> lCliente_fornecedor_representante = new List<Cliente_fornecedor_representanteModel>();
        public List<Cliente_fornecedor_EnderecoModel> lCliente_Fornecedor_Endereco = new List<Cliente_fornecedor_EnderecoModel>();
        public List<Cliente_fornecedor_contatoModel> lCliente_fornecedor_contato = new List<Cliente_fornecedor_contatoModel>();
        public List<Cliente_fornecedor_arquivoModel> lCliente_fornecedor_arquivo = new List<Cliente_fornecedor_arquivoModel>();
        public List<Cliente_fornecedor_produtoModel> lCliente_fornecedor_produto = new List<Cliente_fornecedor_produtoModel>();
        public Cliente_fornecedor_fiscalModel cliforFiscalModel = new Cliente_fornecedor_fiscalModel();
    }

    public class Cliente_fornecedor_representanteModel : BaseModelFilhos
    {
        private int? _idClienteFornecedorRepresentante;
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedorRepresentante
        {
            get { return _idClienteFornecedorRepresentante; }
            set
            {
                _idClienteFornecedorRepresentante = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public decimal pComissaoAvista { get; set; }
        [ParameterOrder(Order = 3)]
        public decimal pComissaoAprazo { get; set; }
        [ParameterOrder(Order = 4)]
        public int idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 5)]
        public int idFuncionario { get; set; }


    }

    public class Cliente_fornecedor_produtoModel : BaseModelFilhos
    {
        private int? _idClienteFornecedorProduto;
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedorProduto
        {
            get { return _idClienteFornecedorProduto; }
            set
            {
                _idClienteFornecedorProduto = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idProduto { get; set; }
        [ParameterOrder(Order = 3)]
        public int idListaPrecoPai { get; set; }
        [ParameterOrder(Order = 4)]
        public int idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stObrigaListaPreco { get; set; }

    }

    public class Cliente_Fornecedor_ObservacaoModel : BaseModelFilhos
    {
        private int? _idClienteFornecedorObservacao;
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedorObservacao
        {
            get { return _idClienteFornecedorObservacao; }
            set
            {
                _idClienteFornecedorObservacao = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public string xObservacao { get; set; }
        [ParameterOrder(Order = 3)]
        public int? idClienteFornecedor { get; set; }


    }

    public class Cliente_fornecedor_fiscalModel : BaseModelFilhos
    {
        private int? _idClienteFornecedorFiscal;
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedorFiscal
        {
            get { return _idClienteFornecedorFiscal; }
            set
            {
                _idClienteFornecedorFiscal = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public byte stSimplesNacional { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stProdutorRural { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stExportador { get; set; }
        [ParameterOrder(Order = 5)]
        public byte stCooperativaAgricola { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stDescontaIcmsSuframa { get; set; }
        [ParameterOrder(Order = 7)]
        public decimal pDescontaIcmsSuframa { get; set; }
        [ParameterOrder(Order = 8)]
        public byte stDescontaPisCofinsSuframa { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal pDescontaPisSuframa { get; set; }
        [ParameterOrder(Order = 10)]
        public decimal pDescontaCofinsSuframa { get; set; }
        [ParameterOrder(Order = 11)]
        public string xCodigoSuframa { get; set; }
        [ParameterOrder(Order = 12)]
        public byte stCalculaFunrural { get; set; }
        [ParameterOrder(Order = 13)]
        public decimal pFunrural { get; set; }
        [ParameterOrder(Order = 14)]
        public string xCodigoSuspensaoPisCofins { get; set; }
        [ParameterOrder(Order = 15)]
        public byte stRetemIss { get; set; }
        [ParameterOrder(Order = 16)]
        public byte stRetemCsll { get; set; }
        [ParameterOrder(Order = 17)]
        public byte stRetemInss { get; set; }
        [ParameterOrder(Order = 18)]
        public byte stRetemPisCofins { get; set; }
        [ParameterOrder(Order = 19)]
        public byte stRetemIrrf { get; set; }
        [ParameterOrder(Order = 20)]
        public byte stConsumidorFinal { get; set; }
        [ParameterOrder(Order = 21)]
        public byte stContribuienteIcms { get; set; }
        [ParameterOrder(Order = 22)]
        public byte stSubsticaoTributariaIcmsDiferenciada { get; set; }
        [ParameterOrder(Order = 23)]
        public int idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 24)]
        public byte stCalculaIcms { get; set; }
        [ParameterOrder(Order = 25)]
        public byte stCalculaIpi { get; set; }


    }

    public class Cliente_fornecedor_EnderecoModel : BaseModelFilhos
    {

        private int? _idEndereco;
        [ParameterOrder(Order = 1)]
        public int? idEndereco
        {
            get { return _idEndereco; }
            set
            {
                _idEndereco = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public byte? stPrincipal { get; set; }
        [ParameterOrder(Order = 3)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 4)]
        public byte stTipoEndereco { get; set; }
        [ParameterOrder(Order = 5)]
        public string xCEP { get; set; }
        [ParameterOrder(Order = 6)]
        public byte stLogradouro { get; set; }
        [ParameterOrder(Order = 7)]
        public string xEndereco { get; set; }
        [ParameterOrder(Order = 8)]
        public string nNumero { get; set; }
        [ParameterOrder(Order = 9)]
        public string xComplemento { get; set; }
        [ParameterOrder(Order = 10)]
        public string xBairro { get; set; }
        [ParameterOrder(Order = 11)]
        public string xLatitude { get; set; }
        [ParameterOrder(Order = 12)]
        public string xLongitude { get; set; }
        [ParameterOrder(Order = 13)]
        public string xFusoHorario { get; set; }
        [ParameterOrder(Order = 14)]
        public string xCaixaPostal { get; set; }
        [ParameterOrder(Order = 15)]
        public int idClienteFornecedor { get; set; }
        [ParameterOrder(Order = 16)]
        public int idCidade { get; set; }


    }

    public class Cliente_fornecedor_contatoModel : BaseModelFilhos
    {
        private int? _idClienteFornecedorContato;
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedorContato
        {
            get { return _idClienteFornecedorContato; }
            set
            {
                _idClienteFornecedorContato = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idContato { get; set; }
        [ParameterOrder(Order = 3)]
        public int idClienteFornecedor { get; set; }

    }

    public class Cliente_fornecedor_arquivoModel : BaseModelFilhos
    {
        private int? _idClienteFornecedorArquivo;
        [ParameterOrder(Order = 1)]
        public int? idClienteFornecedorArquivo
        {
            get { return _idClienteFornecedorArquivo; }
            set
            {
                _idClienteFornecedorArquivo = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public string xArquivo { get; set; }
        [ParameterOrder(Order = 3)]
        public string xLinkArquivo { get; set; }
        [ParameterOrder(Order = 4)]
        public int idClienteFornecedor { get; set; }

    }
}
