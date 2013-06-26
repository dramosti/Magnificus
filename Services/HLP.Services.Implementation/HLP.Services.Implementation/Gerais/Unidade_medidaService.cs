using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Unidade_medidaService : IUnidade_medidaService
    {
        [Inject]
        public IUnidade_medidaRepository unidadeRepository { get; set; }

        public Unidade_medidaModel GetUnidade(int idUnidadeMedida)
        {
            return unidadeRepository.GetUnidade(idUnidadeMedida);
        }

        public void Save(Unidade_medidaModel unidade)
        {
            unidadeRepository.Save(unidade);
        }

        public void Delete(int idUnidadeMedida)
        {
            unidadeRepository.Delete(idUnidadeMedida);
        }

        public int Copy(int idUnidadeMedida)
        {
            return unidadeRepository.Copy(idUnidadeMedida);
        }


        public bool IsNew(string xSiglaPadrao)
        {
            return unidadeRepository.IsNew(xSiglaPadrao);
        }
    }
}
