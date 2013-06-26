using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IFuncionarioRepository
    {
        void Save(FuncionarioModel objFuncionario);
        void Delete(FuncionarioModel objFuncionario);
        void Copy(FuncionarioModel objFuncionario);
        FuncionarioModel GetFuncionario(int idFuncionario);
        List<FuncionarioModel> GetAllFuncionario();
        int ValidaNomeUsuario(string xId);
        int ValidaAcesso(int idEmpresa, int idUsuario);
        FuncionarioModel ValidaUsuario(string xID, string xSenha);
        int GetIdUserHLP();
        int GetIdUserDEFAULT();

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
        string GetQueryFuncionarios();
        string GetQueryUserByEmpresaToComboBox();
    }
}
