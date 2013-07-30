using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Parametros;
using HLP.Comum.Models;

namespace HLP.Repository.Interfaces.Entries.Parametros
{
    public interface IParametro_GeralRepository
    {
        Parametro_GeralModel GetGeralByEmpresa();
    }
}
