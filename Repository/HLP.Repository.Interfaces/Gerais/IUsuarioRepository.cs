using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
  public  interface IUsuarioRepository
    {
      UsuarioModel ValidaUsuario(string xID, string xSenha);

      int ValidaNomeUsuario(string xId);

      int ValidaAcesso(int idEmpresa, int idUsuario);

      UsuarioModel GetUsuario(int idUsuario);

      string GetQueryUserByEmpresaToComboBox();

      int GetIdUserHLP();
      int GetIdUserDEFAULT();
    }
}
