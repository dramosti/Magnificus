using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFuncionario_Margem_Lucro_ComissaoRepository
    {
        void Save(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao);
        void Update(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao);
        void Delete(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao);
        void Delete(int idFuncionario);
        void Copy(Funcionario_Margem_Lucro_ComissaoModel objFuncionario_Margem_Lucro_Comissao);
        Funcionario_Margem_Lucro_ComissaoModel GetFuncionario_Margem_Lucro_Comissao(int idFuncionarioMargemLucroComissao);
        List<Funcionario_Margem_Lucro_ComissaoModel> GetAllFuncionario_Margem_Lucro_Comissao(int idFuncionario);
    }
}
