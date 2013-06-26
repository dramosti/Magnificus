using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Parametros;
using Ninject;
using HLP.Repository.Interfaces.Entries.Parametros;

namespace HLP.Services.Implementation.Entries.Parametros
{
    public class Parametro_financeiroService : IParametro_financeiroService
    {
        [Inject]
        public IParametro_financeiroRepository parametroRepository { get; set; }

        public bool CreditoAprovado()
        {
            return parametroRepository.CreditoAprovado();
        }
    }
}
