﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLP.Comum.Repository.Interfaces.Configuracao;
using HLP.Comum.Services.Interface.Configuracao;
using Ninject;
using HLP.Comum.Models;

namespace HLP.Comum.Services.Implementation.Configuracao
{

    public class ConfigPesquisaService : IConfigPesquisaService
    {
        [Inject]
        public IConfigPesquisaRepository iconfigPesquisaRepository { get; set; }


        public void Save(List<CONFIG_PesquisaModel> lobjCONFIG_Pesquisa)
        {
            foreach (CONFIG_PesquisaModel item in lobjCONFIG_Pesquisa)
            {
                iconfigPesquisaRepository.Save(item);
            }
        }
    }
}
