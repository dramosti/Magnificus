using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Valida o Usuário e Retorna o ModelUsuario caso seja válido
        /// </summary>
        /// <param name="xID"></param>
        /// <param name="xSenha"></param>
        /// <returns></returns>
        UsuarioModel ValidaUsuario(string xID, string xSenha);

        bool ValidaNomeUsuario(string xId);

        bool ValidaAcesso(int idEmpresa, int idUsuario);

        UsuarioModel GetUsuario(int idUsuario);

        string GetQueryUserByEmpresaToComboBox();

        int GetIdUserHLP();
        int GetIdUserDEFAULT();

    }
}
