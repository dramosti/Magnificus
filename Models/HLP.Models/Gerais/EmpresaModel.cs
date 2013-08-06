using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Comercial;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Entries.Parametros;

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

    public class Empresa_EnderecoModel : BaseModelFilhos
    {
        [ParameterOrder(Order = 1)]
        public int? idEmpresaEndereco { get; set; }

        private int _idEmpresa { get; set; }
        [ParameterOrder(Order = 2)]
        public int idEmpresa
        {
            get { return _idEmpresa; }
            set
            {
                _idEmpresa = value;
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

    public class EmpresaParametrosModel
    {
        private int idEmpresa
        {
            get
            {
                return CompanyData.idEmpresa;
            }
        }

        private Parametro_EstoqueModel objParametro_EstoqueModel;

        public Parametro_EstoqueModel ObjParametro_EstoqueModel
        {
            get { return objParametro_EstoqueModel; }
            set
            {
                objParametro_EstoqueModel = value;
                objParametro_EstoqueModel.idEmpresa = this.idEmpresa;
            }
        }

        private Parametro_CustosModel objParametro_CustosModel;

        public Parametro_CustosModel ObjParametro_CustosModel
        {
            get { return objParametro_CustosModel; }
            set
            {
                objParametro_CustosModel = value;
                objParametro_CustosModel.idEmpresa = this.idEmpresa;
            }
        }

        private Parametro_ComprasModel objParametro_ComprasModel;

        public Parametro_ComprasModel ObjParametro_ComprasModel
        {
            get { return objParametro_ComprasModel; }
            set
            {
                objParametro_ComprasModel = value;
                objParametro_ComprasModel.idEmpresa = this.idEmpresa;
            }
        }

        private Parametro_Ordem_ProducaoModel objParametro_Ordem_ProducaoModel;

        public Parametro_Ordem_ProducaoModel ObjParametro_Ordem_ProducaoModel
        {
            get { return objParametro_Ordem_ProducaoModel; }
            set
            {
                objParametro_Ordem_ProducaoModel = value;
                objParametro_Ordem_ProducaoModel.idEmpresa = this.idEmpresa;
            }
        }

        private Parametro_FiscalModel objParametro_FiscalModel;

        public Parametro_FiscalModel ObjParametro_FiscalModel
        {
            get { return objParametro_FiscalModel; }
            set
            {
                objParametro_FiscalModel = value;
                objParametro_FiscalModel.idEmpresa = this.idEmpresa;
            }
        }

        private Parametro_ComercialModel objParametro_ComercialModel;

        public Parametro_ComercialModel ObjParametro_ComercialModel
        {
            get { return objParametro_ComercialModel; }
            set
            {
                objParametro_ComercialModel = value;
                objParametro_ComercialModel.idEmpresa = this.idEmpresa;
            }
        }

        private Parametro_FinanceiroModel objParametro_FinanceiroModel;

        public Parametro_FinanceiroModel ObjParametro_FinanceiroModel
        {
            get { return objParametro_FinanceiroModel; }
            set
            {
                objParametro_FinanceiroModel = value;
                objParametro_FinanceiroModel.idEmpresa = this.idEmpresa;
            }
        }
    }
}
