﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ISituacao_tributaria_ipiService
    {
        Situacao_tributaria_ipiModel GetStIpi(int idCSTIpi);
        void Save(Situacao_tributaria_ipiModel ipi);
        void Delete(int idCSTIpi);
        int Copy(int idCSTIpi);
    }
}
