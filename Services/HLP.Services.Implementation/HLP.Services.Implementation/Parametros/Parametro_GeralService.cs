using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Parametros;
using HLP.Models.Entries.Parametros;
using Ninject;
using HLP.Repository.Interfaces.Entries.Parametros;
using HLP.Comum.Models;

namespace HLP.Services.Implementation.Entries.Parametros
{
    public class Parametro_GeralService : IParametro_GeralService
    {
        [Inject]
        public IParametro_GeralRepository parametroRepository { get; set; }

        public Parametro_GeralModel GetGeralByEmpresa()
        {
            return parametroRepository.GetGeralByEmpresa();
        }

        public bool isToUpper()
        {
            bool Upper = false;
            Parametro_GeralModel param = this.GetGeralByEmpresa();
            if (param != null)
            {
                Upper = param.stMaiusculo == 0 ? false : true;
            }
            return Upper;
        }
    }
}
