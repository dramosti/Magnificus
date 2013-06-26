using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class UsuarioModel
    {
        [ParameterOrder(Order = 1)]
        public int idUsuario { get; set; }
        [ParameterOrder(Order = 2)]
        public string xNome { get; set; }
        [ParameterOrder(Order = 3)]
        public string xID { get; set; }
        [ParameterOrder(Order = 4)]
        public string xSenha { get; set; }
        [ParameterOrder(Order = 5)]
        public bool Ativo { get; set; }
        [ParameterOrder(Order = 6)]
        public string xEmail { get; set; }
        [ParameterOrder(Order = 7)]
        public string xTelefone { get; set; }
        [ParameterOrder(Order = 8)]
        public string xRamal { get; set; }
        [ParameterOrder(Order = 9)]
        public decimal vCompraAprovaAuto { get; set; }
        [ParameterOrder(Order = 10)]
        public int idGrupoUsuario { get; set; }

    }
}
