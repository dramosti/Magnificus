using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Empresa_enderecoService : IEmpresa_EnderecoService
    {
        [Inject]
        public IEmpresa_EnderecoRepository _Empresa_EnderecoRepository { get; set; }

        public void Save(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            _Empresa_EnderecoRepository.Save(objEmpresa_Endereco);
        }

        public void Update(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            _Empresa_EnderecoRepository.Update(objEmpresa_Endereco);
        }

        public void Delete(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            _Empresa_EnderecoRepository.Delete(objEmpresa_Endereco);
        }

        public void Delete(int idEmpresa)
        {
            _Empresa_EnderecoRepository.Delete(idEmpresa);
        }

        public void Copy(Empresa_EnderecoModel objEmpresa_Endereco)
        {
            _Empresa_EnderecoRepository.Copy(objEmpresa_Endereco);
        }

        public Empresa_EnderecoModel GetEmpresa_Endereco(int idEndereco)
        {
            return _Empresa_EnderecoRepository.GetEmpresa_Endereco(idEndereco);
        }

        public List<Empresa_EnderecoModel> GetAllEmpresa_Endereco(int idEmpresa)
        {
            return _Empresa_EnderecoRepository.GetAllEmpresa_Endereco(idEmpresa);
        }
    }
}
