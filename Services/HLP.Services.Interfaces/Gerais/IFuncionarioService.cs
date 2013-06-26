using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IFuncionarioService
    {
        void Save(FuncionarioModel objFuncionario);
        void Delete(FuncionarioModel objFuncionario);
        void Copy(FuncionarioModel objFuncionario);
        FuncionarioModel GetFuncionario(int idFuncionario, bool bChildren = false);
        List<FuncionarioModel> GetAllFuncionario(bool bChildren = false);
        string GetQueryFuncionarios();
        string CalculaTotalHorasTrabSemanal(List<DateTime> lHorasTrab);
        bool ValidaNomeUsuario(string xId);
        bool ValidaAcesso(int idEmpresa, int idUsuario);
        FuncionarioModel ValidaUsuario(string xID, string xSenha);
        int GetIdUserHLP();
        int GetIdUserDEFAULT();
        string GetQueryUserByEmpresaToComboBox();
    }
}
