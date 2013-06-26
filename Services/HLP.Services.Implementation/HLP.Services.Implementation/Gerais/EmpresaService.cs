using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class EmpresaService : IEmpresaService
    {

        [Inject]
        public IEmpresaRepository _EmpresaRepository { get; set; }

        [Inject]
        public IEmpresa_EnderecoRepository _Empresa_EnderecoRepository { get; set; }

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
    }
}
