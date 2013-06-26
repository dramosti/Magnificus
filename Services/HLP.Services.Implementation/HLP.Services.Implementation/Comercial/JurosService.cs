using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class JurosService : IJurosService
    {
        [Inject]
        public IJurosRepository jurosRepository { get; set; }

        public JurosModel GetJuros(int idJuros)
        {
            return jurosRepository.GetJuros(idJuros);
        }

        public void Save(JurosModel juros)
        {
            jurosRepository.Save(juros);
        }

        public void Delete(int idJuros)
        {
            jurosRepository.Delete(idJuros);
        }


        public int Copy(int idJuros)
        {
            return jurosRepository.Copy(idJuros);
        }
    }
}
