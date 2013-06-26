using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Services.Interfaces.Entries.Gerais
{
    public interface IPlano_pagamento_linhasService
    {
        void Save(Plano_pagamento_linhasModel objPlano_pagamento_linhas);
        void Update(Plano_pagamento_linhasModel objPlano_pagamento_linhas);
        void Delete(Plano_pagamento_linhasModel objPlano_pagamento_linhas);
        void Delete(int idPlanoPagamento);
        void Copy(Plano_pagamento_linhasModel objPlano_pagamento_linhas);
        Plano_pagamento_linhasModel GetPlano_pagamento_linhas(int idLinhasPagamento);
        List<Plano_pagamento_linhasModel> GetAllPlano_pagamento_linhas(int idPlanoPagamento);
    }
}
