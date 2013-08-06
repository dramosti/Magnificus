using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;
using HLP.Services.Interfaces.Entries.Parametros;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class EmpresaService : IEmpresaService
    {

        [Inject]
        public IEmpresaRepository _EmpresaRepository { get; set; }

        [Inject]
        public IEmpresa_EnderecoRepository _Empresa_EnderecoRepository { get; set; }

        [Inject]
        public IParametro_ComercialService _Parametro_ComercialService { get; set; }

        [Inject]
        public IParametro_ComprasService _Parametro_ComprasService { get; set; }

        [Inject]
        public IParametro_CustosService _Parametro_CustosService { get; set; }

        [Inject]
        public IParametro_EstoqueService _Parametro_EstoqueService { get; set; }

        [Inject]
        public IParametro_FinanceiroService _Parametro_FinanceiroService { get; set; }

        [Inject]
        public IParametro_FiscalService _Parametro_FiscalService { get; set; }

        [Inject]
        public IParametro_Ordem_ProducaoService _Parametro_Ordem_ProducaoService { get; set; }

        public void Save(EmpresaModel objEmpresa)
        {
            try
            {
                _EmpresaRepository.BeginTransaction();
                _EmpresaRepository.Save(objEmpresa);


                foreach (Empresa_EnderecoModel item in objEmpresa.lEmpresa_endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    item.idEmpresa = (int)objEmpresa.idEmpresa;
                    _Empresa_EnderecoRepository.Save(item);
                }
                foreach (Empresa_EnderecoModel item in objEmpresa.lEmpresa_endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    item.idEmpresa = (int)objEmpresa.idEmpresa;
                    _Empresa_EnderecoRepository.Update(item);
                }
                foreach (Empresa_EnderecoModel item in objEmpresa.lEmpresa_endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    item.idEmpresa = (int)objEmpresa.idEmpresa;
                    _Empresa_EnderecoRepository.Delete(item);
                }
                _EmpresaRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _EmpresaRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(int idEmpresa)
        {
            _EmpresaRepository.Delete(idEmpresa);
        }

        public int Copy(EmpresaModel objEmpresa)
        {
            try
            {
                _EmpresaRepository.BeginTransaction();
                int id = _EmpresaRepository.Copy(objEmpresa);

                foreach (Empresa_EnderecoModel item in objEmpresa.lEmpresa_endereco)
                {
                    item.idEmpresa = (int)objEmpresa.idEmpresa;
                    _Empresa_EnderecoRepository.Copy(item);
                }

                _EmpresaRepository.CommitTransaction();
                return id;
            }
            catch (Exception)
            {
                _EmpresaRepository.RollackTransaction();
                throw;
            }
        }

        public EmpresaModel GetEmpresa(int idEmpresa, bool bChildren = false)
        {
            EmpresaModel objEmpresa = _EmpresaRepository.GetEmpresa(idEmpresa);
            if (bChildren)
            {
                objEmpresa.lEmpresa_endereco = _Empresa_EnderecoRepository.GetAllEmpresa_Endereco(idEmpresa);
            }
            return objEmpresa;
        }

        public List<EmpresaModel> GetAllEmpresa(bool bEstruturaComboBox)
        {
            if (bEstruturaComboBox)
            {
                List<EmpresaModel> lret = new List<EmpresaModel>();

                foreach (EmpresaModel emp in _EmpresaRepository.GetAllEmpresa())
                {
                    emp.xFantasia = emp.idEmpresa + " - " + emp.xFantasia.Trim();
                    emp.xNome = emp.idEmpresa + " - " + emp.xNome.Trim();
                    lret.Add(emp);
                }
                return lret;
            }
            else
            {
                return _EmpresaRepository.GetAllEmpresa();
            }
        }

        public void SalvarParametrosEmpresa(EmpresaParametrosModel objParametrosModel)
        {
            try
            {
                _Parametro_ComercialService.Save(objParametrosModel.ObjParametro_ComercialModel);
                _Parametro_ComprasService.Save(objParametrosModel.ObjParametro_ComprasModel);
                _Parametro_CustosService.Save(objParametrosModel.ObjParametro_CustosModel);
                _Parametro_EstoqueService.Save(objParametrosModel.ObjParametro_EstoqueModel);
                _Parametro_FinanceiroService.Save(objParametrosModel.ObjParametro_FinanceiroModel);
                _Parametro_FiscalService.Save(objParametrosModel.ObjParametro_FiscalModel);
                _Parametro_Ordem_ProducaoService.Save(objParametrosModel.ObjParametro_Ordem_ProducaoModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public EmpresaParametrosModel GetParametrosEmpresa()
        {
            try
            {
                EmpresaParametrosModel objEmpresaParametrosModel = new EmpresaParametrosModel();
                objEmpresaParametrosModel.ObjParametro_ComercialModel = _Parametro_ComercialService.GetParametro_Comercial();
                objEmpresaParametrosModel.ObjParametro_ComprasModel = _Parametro_ComprasService.GetParametro_Compras();
                objEmpresaParametrosModel.ObjParametro_CustosModel = _Parametro_CustosService.GetParametro_Custos();
                objEmpresaParametrosModel.ObjParametro_EstoqueModel = _Parametro_EstoqueService.GetParametro_Estoque();
                objEmpresaParametrosModel.ObjParametro_FinanceiroModel = _Parametro_FinanceiroService.GetParametro_Financeiro();
                objEmpresaParametrosModel.ObjParametro_FiscalModel = _Parametro_FiscalService.GetParametro_Fiscal();
                objEmpresaParametrosModel.ObjParametro_Ordem_ProducaoModel = _Parametro_Ordem_ProducaoService.GetParametro_Ordem_Producao();
                return objEmpresaParametrosModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
