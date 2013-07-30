using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using System.Windows.Forms;
using HLP.Comum.Models;

namespace HLP.Comum.Services.Interface.Configuracao
{
    public interface IConfigTabPageService
    {
        List<ConfigComponenteModel> GetListaControlesConfigComponenteModel();
        List<TabPage> lTabPageControl { get; set; }
        List<ConfigTabPageModel> lTabPageModel { get; set; }
        void Save(ConfigTabPageModel tabPage);
        void GetInfoTabPagesRecursiovo(Control.ControlCollection lControles, List<ConfigTabPageModel> lConfigTabPage, List<Control> lControl);
        /// <summary>
        /// Busca informações da TabPage da Base de Dados
        /// </summary>
        /// <param name="idFormulario"></param>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        List<ConfigTabPageModel> GetTabPageByForm(int idFormulario, int idUsuario);
        void GetTabPageRecursivo(ConfigTabPageModel objTabPage, int idUsuario);
        void SetConfigToTabPagesRecursivo(List<ConfigTabPageModel> objTabPage, List<Control> lControl);
    }
}
