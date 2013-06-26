using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Financeiro;
using Ninject;
using HLP.Repository.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;

namespace HLP.Services.Implementation.Entries.Financeiro
{
    public class Dia_Pagamento_LinhasService : IDia_Pagamento_LinhasService
    {
        [Inject]
        public IDia_pagamento_linhasRepository _Dia_pagamento_linhasRepository { get; set; }

        public void Save(Dia_pagamento_linhasModel objDia_pagamento_linhas)
        {
            _Dia_pagamento_linhasRepository.Save(objDia_pagamento_linhas);
        }

        public void Update(Dia_pagamento_linhasModel objDia_pagamento_linhas)
        {
            _Dia_pagamento_linhasRepository.Update(objDia_pagamento_linhas);
        }

        public void Delete(Dia_pagamento_linhasModel objDia_pagamento_linhas)
        {
            _Dia_pagamento_linhasRepository.Delete(objDia_pagamento_linhas);
        }

        public void Delete(int idDiaPagamento)
        {
            _Dia_pagamento_linhasRepository.Delete(idDiaPagamento);
        }

        public void Copy(Dia_pagamento_linhasModel objDia_pagamento_linhas)
        {
            _Dia_pagamento_linhasRepository.Copy(objDia_pagamento_linhas);
        }

        public Dia_pagamento_linhasModel GetDia_pagamento_linhas(int idDiaPagamentoLinhas)
        {
            return _Dia_pagamento_linhasRepository.GetDia_pagamento_linhas(idDiaPagamentoLinhas);
        }

        public List<Dia_pagamento_linhasModel> GetAllDia_pagamento_linhas(int idDiaPagamento)
        {
            return _Dia_pagamento_linhasRepository.GetAllDia_pagamento_linhas(idDiaPagamento);
        }


    }
}
