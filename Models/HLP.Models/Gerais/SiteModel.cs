using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class SiteModel
    {
        [ParameterOrder(Order = 1)]
        public int? idSite { get; set; }
        [ParameterOrder(Order = 2)]
        public string xSite { get; set; }
        [ParameterOrder(Order = 3)]
        public string xDescricao { get; set; }

        public List<Site_enderecoModel> lSite_Endereco = new List<Site_enderecoModel>();
    }
}
