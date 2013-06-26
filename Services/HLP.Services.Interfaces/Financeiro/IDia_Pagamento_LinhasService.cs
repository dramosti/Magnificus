using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Interfaces.Entries.Financeiro
{
    public interface IDia_Pagamento_LinhasService
    {

        void Save(Dia_pagamento_linhasModel objDia_pagamento_linhas);

        void Update(Dia_pagamento_linhasModel objDia_pagamento_linhas);
        void Delete(Dia_pagamento_linhasModel objDia_pagamento_linhas);
        void Delete(int idDiaPagamento);
        void Copy(Dia_pagamento_linhasModel objDia_pagamento_linhas);
        Dia_pagamento_linhasModel GetDia_pagamento_linhas(int idDiaPagamentoLinhas);
        List<Dia_pagamento_linhasModel> GetAllDia_pagamento_linhas(int idDiaPagamento);
        
    }
}
