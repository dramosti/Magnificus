﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IPlano_pagamentoRepository
    {
        void Save(Plano_pagamentoModel objPlano_pagamento);
        void Delete(Plano_pagamentoModel objPlano_pagamento);
        void Copy(Plano_pagamentoModel objPlano_pagamento);
        Plano_pagamentoModel GetPlano_pagamento(int idPlanoPagamento);

        void BeginTransaction();
        void CommitTransaction();
        void RollackTransaction();
    }
}
