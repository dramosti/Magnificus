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
    public class Tipo_servicoService : ITipo_servicoService
    {
        [Inject]
        public ITipo_servicoRepository tipoRepository { get; set; }

        public Tipo_servicoModel GetTipo(int idTipoServico)
        {
            return tipoRepository.GetTipo(idTipoServico);
        }

        public void Save(Tipo_servicoModel tipo)
        {
            tipoRepository.Save(tipo);
        }

        public void Delete(int idTipoServico)
        {
            tipoRepository.Delete(idTipoServico);
        }

        public int Copy(int idTipoServico)
        {
            return tipoRepository.Copy(idTipoServico);
        }
    }
}
