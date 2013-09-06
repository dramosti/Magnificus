using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Entries.Gerais
{
    public class ItemPorcAcimaListaModel
    {
        public int numProduto { get; set; }
        public int idProduto { get; set; }
        public string xNomeProduto { get; set; }
        public decimal porAtual { get; set; }
        public decimal porLista { get; set; }
    }
}
