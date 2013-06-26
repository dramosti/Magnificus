using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Services.Interfaces.Entries.Financeiro
{
    public interface IDia_PagamentoService
    {
        void Save(Dia_pagamentoModel objDia_pagamento);
        void Delete(Dia_pagamentoModel objDia_pagamento);
        void Copy(Dia_pagamentoModel objDia_pagamento);
        Dia_pagamentoModel GetDia_pagamento(int idDiaPagamento, bool bChildren = false);
    }
}
