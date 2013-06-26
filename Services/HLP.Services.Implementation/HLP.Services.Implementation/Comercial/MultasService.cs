using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Repository.Interfaces.Entries.Comercial;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class MultasService : IMultasService
    {
        [Inject]
        public IMultasRepository multasRepository { get; set; }

        public MultasModel GetMulta(int idMultas)
        {
            return multasRepository.GetMulta(idMultas);
        }

        public void Save(MultasModel multa)
        {
            multasRepository.Save(multa);
        }

        public void Delete(int idMultas)
        {
            multasRepository.Delete(idMultas);
        }


        public int Copy(int idMultas)
        {
            return multasRepository.Copy(idMultas);
        }
    }
}
