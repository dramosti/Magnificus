using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class UsuarioService : IUsuarioService
    {
        [Inject]
        public IUsuarioRepository usuarioRepository { get; set; }
        public UsuarioModel ValidaUsuario(string xID, string xSenha)
        {
            xSenha = Criptografia.Encripta(xSenha);
            return usuarioRepository.ValidaUsuario(xID, xSenha);
        }


        public bool ValidaNomeUsuario(string xId)
        {
            if (usuarioRepository.ValidaNomeUsuario(xId) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public bool ValidaAcesso(int idEmpresa, int idUsuario)
        {
            if (usuarioRepository.ValidaAcesso(idEmpresa, idUsuario) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public UsuarioModel GetUsuario(int idUsuario)
        {
            return usuarioRepository.GetUsuario(idUsuario);
        }


        public string GetQueryUserByEmpresaToComboBox()
        {
            return usuarioRepository.GetQueryUserByEmpresaToComboBox();
        }


        public int GetIdUserHLP()
        {
            return usuarioRepository.GetIdUserHLP();
        }

        public int GetIdUserDEFAULT()
        {
            return usuarioRepository.GetIdUserDEFAULT();
        }
    }
}
