using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Comum.Repository.Interfaces.Configuracao
{
    public interface IConfigTabPageRepository
    {
        void Save(ConfigTabPageModel tabPage);
        List<ConfigTabPageModel> GetListTabPage(ConfigTabPageModel objTabPage, int idUsuario);
        ConfigTabPageUsuModel GetConfigTabPageUsu(int idTabPage, int idUsuario);
        List<ConfigTabPageModel> GetTabPagesByForm(int idFormulario, int idUsuario);
    }
}
