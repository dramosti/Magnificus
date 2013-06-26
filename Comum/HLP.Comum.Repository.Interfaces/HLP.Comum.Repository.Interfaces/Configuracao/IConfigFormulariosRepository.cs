using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.Repository.Interfaces.Configuracao
{
    public interface IConfigFormulariosRepository
    {
        void Save(ConfigFormulariosModel formulario);
        void DeleteFormularioUsuario(int idFormularios, int idUsuario);
        int DeleteFormularioUsuario(string sNameFormulario, int idUsuario);


        ConfigFormulariosModel GetFormulario(string xNameFormulario, int idUsuario);
        ConfigFormulariosModel GetFormulario(int idFormularios, int idUsuario);


        List<ConfigFormulariosModel> GetAll();
        bool FormularioExistInDataBase(string xName);
        bool FormularioExistInDataBase(string xName, int idUser);
      

        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
    }
}
