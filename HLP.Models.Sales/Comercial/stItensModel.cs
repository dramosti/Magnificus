using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Models.Sales.Comercial
{
    public class stItensModel
    {
        public bool bSel { get; set; }
        public int codItem { get; set; }
        public int codItemOrcamento { get; set; }
        public decimal quantPendente { get; set; }
        public DateTime? dPrevEntrega { get; set; }
        public decimal? quantItens { get; set; }
        public DateTime? dConfirmacao { get; set; }
        public int? codMotPerda { get; set; }
        public string obsItem { get; set; }
        public decimal qEstoque { get; set; }
    }
}
