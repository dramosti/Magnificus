﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IDepositoRepository
    {
        List<DepositoModel> GetBySite(int idSite);
        DepositoModel GetDeposito(int idDeposito);
        void Save(DepositoModel deposito);
        void Delete(int idDeposito);
        int Copy(int idDeposito);
    }
}
