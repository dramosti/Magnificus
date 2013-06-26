using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class CfopService : ICfopService
    {
        [Inject]
        public ICfopRepository cfopRepository { get; set; }


        public CfopModel GetCfop(int idCfop)
        {
            return cfopRepository.GetCfop(idCfop);
        }

        public void Save(CfopModel cfop)
        {
            cfopRepository.Save(cfop);
        }


        public void Delete(int idCfop)
        {
            cfopRepository.Delete(idCfop);
        }


        public int Copy(int idCfop)
        {
            return cfopRepository.Copy(idCfop);
        }
    }
}
