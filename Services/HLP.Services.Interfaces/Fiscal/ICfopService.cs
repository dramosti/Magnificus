﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ICfopService
    {
        CfopModel GetCfop(int idCfop);
        void Save(CfopModel cfop);
        void Delete(int idCfop);
        int Copy(int idCfop);
    }
}
