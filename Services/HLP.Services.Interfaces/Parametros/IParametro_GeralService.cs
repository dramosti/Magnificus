using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Parametros;

namespace HLP.Services.Interfaces.Entries.Parametros
{
    public interface IParametro_GeralService
    {
        Parametro_GeralModel GetGeralByEmpresa();

        bool isToUpper();
    }
}
