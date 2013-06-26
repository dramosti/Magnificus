using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Financeiro
{
    public class AgenciaModel
    {
        [ParameterOrder(Order = 1)]
        public int? idAgencia { get; set; }
        [ParameterOrder(Order = 2)]
        public int idBanco { get; set; }
        [ParameterOrder(Order = 3)]
        public string cAgencia { get; set; }
        [ParameterOrder(Order = 4)]
        public string xAgencia { get; set; }
        [ParameterOrder(Order = 5)]
        public string xTelefone { get; set; }
        [ParameterOrder(Order = 6)]
        public string xFax { get; set; }

        public List<Agencia_EnderecoModel> lAgencia_Endereco = new List<Agencia_EnderecoModel>();
        public List<Agencia_ContatoModel> lAgencia_Contato = new List<Agencia_ContatoModel>();
    }
}
