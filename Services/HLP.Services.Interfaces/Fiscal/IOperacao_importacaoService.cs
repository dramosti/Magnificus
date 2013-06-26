﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface IOperacao_importacaoService
    {
        List<Operacao_importacaoModel> GetAll(int idTipoOperacao);
        void Save(Operacao_importacaoModel operacaoImportacao);
        void Delete(int idOperacaoImportacao);
        void Delete(int idTipoOperacao, List<int?> lidOperacaoImportacao);
    }
}
