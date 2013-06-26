using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class TransportadorModel
    {
        [ParameterOrder(Order = 1)]
        public int? idTransportador { get; set; }
        [ParameterOrder(Order = 2)]
        public string xCodigoAlternativo { get; set; }
        [ParameterOrder(Order = 3)]
        public byte stPessoa { get; set; }
        [ParameterOrder(Order = 4)]
        public string xCnpj { get; set; }
        [ParameterOrder(Order = 5)]
        public string xIe { get; set; }
        [ParameterOrder(Order = 6)]
        public string xIm { get; set; }
        [ParameterOrder(Order = 7)]
        public string xRg { get; set; }
        [ParameterOrder(Order = 8)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 9)]
        public string xFantasia { get; set; }
        [ParameterOrder(Order = 10)]
        public string xTelefone1 { get; set; }
        [ParameterOrder(Order = 11)]
        public string xTelefone2 { get; set; }
        [ParameterOrder(Order = 12)]
        public string xFax { get; set; }
        [ParameterOrder(Order = 13)]
        public string xEmail { get; set; }
        [ParameterOrder(Order = 14)]
        public string xHttp { get; set; }
        [ParameterOrder(Order = 15)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 16)]
        public string xObs { get; set; }
        [ParameterOrder(Order = 17)]
        public string xCpf { get; set; }
        [ParameterOrder(Order = 18)]
        public string xRntrc { get; set; }

        public List<Transportador_EnderecoModel> lTransportador_Endereco = new List<Transportador_EnderecoModel>();
        public List<Transportador_VeiculosModel> lTransportador_Veiculos = new List<Transportador_VeiculosModel>();
        public List<Transportador_ContatoModel> lTransportador_Contato = new List<Transportador_ContatoModel>();
        public List<Transportador_MotoristaModel> lTransportador_Motorista = new List<Transportador_MotoristaModel>();

    }
    public class Transportador_EnderecoModel : BaseModelFilhos
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
        public int idTransportador { get; set; }
        [ParameterOrder(Order = 16)]
        public int idCidade { get; set; }

    }
    public class Transportador_VeiculosModel : BaseModelFilhos
    {
        private int? _idTransportadorVeiculo;
        [ParameterOrder(Order = 1)]
        public int? idTransportadorVeiculo
        {
            get { return _idTransportadorVeiculo; }
            set
            {
                _idTransportadorVeiculo = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public string xPlacaVeiculo { get; set; }
        [ParameterOrder(Order = 3)]
        public int idUf { get; set; }
        [ParameterOrder(Order = 4)]
        public int idTransportador { get; set; }
        [ParameterOrder(Order = 5)]
        public string xMarca { get; set; }
        [ParameterOrder(Order = 6)]
        public string xModelo { get; set; }
    }
    public class Transportador_ContatoModel : BaseModelFilhos
    {
        private int? _idTransportdorContato;
        [ParameterOrder(Order = 1)]
        public int? idTransportdorContato
        {
            get { return _idTransportdorContato; }
            set
            {
                _idTransportdorContato = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idTransportador { get; set; }
        [ParameterOrder(Order = 3)]
        public int idContato { get; set; }
    }
    public class Transportador_MotoristaModel : BaseModelFilhos
    {
        private int? _idTransportdorMotorista;
        [ParameterOrder(Order = 1)]
        public int? idTransportdorMotorista
        {
            get { return _idTransportdorMotorista; }
            set
            {
                _idTransportdorMotorista = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int? idTransportador { get; set; }
        [ParameterOrder(Order = 3)]
        public int? idContato { get; set; }
        [ParameterOrder(Order = 4)]
        public string xRntrc { get; set; }
    }



}
