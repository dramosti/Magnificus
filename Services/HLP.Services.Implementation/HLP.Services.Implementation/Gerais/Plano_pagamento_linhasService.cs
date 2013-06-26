using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Plano_pagamento_linhasService : IPlano_pagamento_linhasService
    {
        [Inject]
        public IPlano_pagamento_linhasRepository _Plano_pagamento_linhasRepository { get; set; }

        public void Save(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            _Plano_pagamento_linhasRepository.Save(objPlano_pagamento_linhas);
        }

        public void Update(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            _Plano_pagamento_linhasRepository.Update(objPlano_pagamento_linhas);
        }

        public void Delete(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            _Plano_pagamento_linhasRepository.Delete(objPlano_pagamento_linhas);
        }

        public void Delete(int idPlanoPagamento)
        {
            _Plano_pagamento_linhasRepository.Delete(idPlanoPagamento);
        }

        public void Copy(Plano_pagamento_linhasModel objPlano_pagamento_linhas)
        {
            _Plano_pagamento_linhasRepository.Copy(objPlano_pagamento_linhas);
        }

        public Plano_pagamento_linhasModel GetPlano_pagamento_linhas(int idLinhasPagamento)
        {
            return _Plano_pagamento_linhasRepository.GetPlano_pagamento_linhas(idLinhasPagamento);
        }

        public List<Plano_pagamento_linhasModel> GetAllPlano_pagamento_linhas(int idPlanoPagamento)
        {
            return _Plano_pagamento_linhasRepository.GetAllPlano_pagamento_linhas(idPlanoPagamento);
        }
    }
}
