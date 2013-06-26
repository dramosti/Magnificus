using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Comercial;

namespace HLP.Models.Entries.Gerais
{
    public class EmpresaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 3)]
        public string xFantasia { get; set; }
        [ParameterOrder(Order = 4)]
        public string xCNPJ { get; set; }
        [ParameterOrder(Order = 5)]
        public string xIE { get; set; }
        [ParameterOrder(Order = 6)]
        public string xIM { get; set; }
        [ParameterOrder(Order = 7)]
        public string xSuframa { get; set; }
        [ParameterOrder(Order = 8)]
        public string xTelefone { get; set; }
        [ParameterOrder(Order = 9)]
        public string xFax { get; set; }
        [ParameterOrder(Order = 10)]
        public string xEmail { get; set; }
        [ParameterOrder(Order = 11)]
        public string xHttp { get; set; }
        [ParameterOrder(Order = 12)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 13)]
        public string xLinkLogoEmpresa { get; set; }
        [ParameterOrder(Order = 14)]
        public string xLinkPastas { get; set; }
        [ParameterOrder(Order = 15)]
        public int idRamoAtividade { get; set; }
        [ParameterOrder(Order = 16)]
        public byte stCodigoRegimeTributario { get; set; }

        public List<Empresa_EnderecoModel> lEmpresa_endereco = new List<Empresa_EnderecoModel>();
        public List<ParametroEstoqueModel> lparametroEstoque { get; set; }
    }

    public class Empresa_EnderecoModel: BaseModelFilhos
    {
        [ParameterOrder(Order = 1)]
        public int? idEmpresaEndereco { get; set; }
        
        private int _idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int idEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value;
            base.SetID(value);
            }
        }

        [ParameterOrder(Order = 3)]
        public byte StTipoEnd { get; set; }
        [ParameterOrder(Order = 4)]
        public string xLgr { get; set; }
        [ParameterOrder(Order = 5)]
        public string nro { get; set; }
        [ParameterOrder(Order = 6)]
        public string xCpl { get; set; }
        [ParameterOrder(Order = 7)]
        public string xBairro { get; set; }
        [ParameterOrder(Order = 8)]
        public string Cep { get; set; }
        [ParameterOrder(Order = 9)]
        public string xCxPostal { get; set; }
        [ParameterOrder(Order = 10)]
        public int idCidade { get; set; }
    }
}
