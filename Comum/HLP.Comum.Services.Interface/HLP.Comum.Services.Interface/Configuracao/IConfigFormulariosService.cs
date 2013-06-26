using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;
using System.Windows.Forms;

namespace HLP.Comum.Services.Interface.Configuracao
{
    public interface IConfigFormulariosService
    {

        List<Control> lControl { get; set; }
        List<Control> lFlowLayoutPanel { get; set; }
        ConfigFormulariosModel objConfigFormularioModel { get; set; }
        bool bEndSincronizacao { get; set; }

        void InitializeFormulario(ComponentFactory.Krypton.Toolkit.KryptonPanel pnPrincipal, string sViewForm);
        void Save(ConfigFormulariosModel formulario);
        void Delete(string sNameFormulario, int idUsuario);
        ConfigFormulariosModel GetFormulario(string xNameFormulario, int idUser);
        ConfigFormulariosModel GetFormulario(int idFormulario, bool bChildren = false, int idUser = 0);
        void MudaPosicaoScrollFlowPanelTabControl();
        void SicnronizaRelatorios();
        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
        List<TabPage> GetTabPages();



    }
}
