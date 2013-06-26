using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Funcionario_Margem_Lucro_ComissaoService : IFuncionario_Margem_Lucro_ComissaoService
    {
        [Inject]
        public IFuncionario_Margem_Lucro_ComissaoRepository _Funcionario_Margem_Lucro_ComissaoRepository { get; set; }

        public void Save(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            _Funcionario_Margem_Lucro_ComissaoRepository.Save(objFuncionario_Margem_Lucro_Comissao);
        }

        public void Update(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            _Funcionario_Margem_Lucro_ComissaoRepository.Update(objFuncionario_Margem_Lucro_Comissao);
        }

        public void Delete(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            _Funcionario_Margem_Lucro_ComissaoRepository.Delete(objFuncionario_Margem_Lucro_Comissao);
        }

        public void Delete(int idFuncionario)
        {
            _Funcionario_Margem_Lucro_ComissaoRepository.Delete(idFuncionario);
        }

        public void Copy(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao)
        {
            _Funcionario_Margem_Lucro_ComissaoRepository.Copy(objFuncionario_Margem_Lucro_Comissao);
        }

        public Funcionario_Margem_Lucro_ComissaoModel GetFuncionario_Margem_Lucro_Comissao(int idFuncionarioMargemLucroComissao)
        {
            return _Funcionario_Margem_Lucro_ComissaoRepository.GetFuncionario_Margem_Lucro_Comissao(idFuncionarioMargemLucroComissao);
        }

        public List<Funcionario_Margem_Lucro_ComissaoModel> GetAllFuncionario_Margem_Lucro_Comissao(int idFuncionario)
        {
            return _Funcionario_Margem_Lucro_ComissaoRepository.GetAllFuncionario_Margem_Lucro_Comissao(idFuncionario);
        }
    }
}
