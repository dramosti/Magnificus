using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Infrastructure;

namespace HLP.Models.Entries.Gerais
{
    public class Familia_Produto_ClassesModel : BaseModelFilhos
    {
       
        private int? _idFamilia_Produto_Classes;
        [ParameterOrder(Order = 1)]
        public int? idFamilia_Produto_Classes
        {
            get { return _idFamilia_Produto_Classes; }
            set
            {
                _idFamilia_Produto_Classes = value;
                base.SetID(value);
            }
        }
        [ParameterOrder(Order = 2)]
        public int idTipoOperacao { get; set; }
        [ParameterOrder(Order = 3)]
        public int idClasseFinanceira { get; set; }
        [ParameterOrder(Order = 4)]
        public int idFamiliaProduto { get; set; }
    }
}
