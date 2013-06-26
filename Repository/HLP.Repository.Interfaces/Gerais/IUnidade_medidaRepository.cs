﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface IUnidade_medidaRepository
    {
        Unidade_medidaModel GetUnidade(int idUnidadeMedida);
        void Save(Unidade_medidaModel unidade);
        void Delete(int idUnidadeMedida);
        int Copy(int idUnidadeMedida);
        bool IsNew(string xSiglaPadrao);
    }
}
