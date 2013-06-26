using HLP.Models.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IEmpresa_EnderecoRepository
    {
        void Save(Empresa_EnderecoModel objEmpresa_Endereco);
        void Update(Empresa_EnderecoModel objEmpresa_Endereco);
        void Delete(Empresa_EnderecoModel objEmpresa_Endereco);
        void Delete(int idEmpresa);
        void Copy(Empresa_EnderecoModel objEmpresa_Endereco);
        Empresa_EnderecoModel GetEmpresa_Endereco(int idEmpresaEndereco);
        List<Empresa_EnderecoModel> GetAllEmpresa_Endereco(int idEmpresa);
    }
}
