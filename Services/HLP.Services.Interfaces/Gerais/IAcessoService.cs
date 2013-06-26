using HLP.Models.Entries.Gerais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IAcessoService
    {
        void Save(Funcionario_AcessoModel objAcesso);
        void Delete(int idAcesso);
        int Copy(int idAcesso);
        Funcionario_AcessoModel GetAcesso(int idAcesso);
        List<Funcionario_AcessoModel> GetAllAcesso_Funcionario(int idFuncionario);
    }
}
