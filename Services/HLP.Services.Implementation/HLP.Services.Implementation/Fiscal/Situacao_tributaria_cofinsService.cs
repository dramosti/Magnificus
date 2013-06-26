using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Situacao_tributaria_cofinsService : ISituacao_tributaria_cofinsService
    {
        [Inject]
        public ISituacao_tributaria_cofinsRepository cofinsRepository { get; set; }


        public Situacao_tributaria_cofinsModel GetStCofins(int idCSTCofins)
        {
            return cofinsRepository.GetStCofins(idCSTCofins);
        }

        public void Save(Situacao_tributaria_cofinsModel cofins)
        {
            cofinsRepository.Save(cofins);
        }

        public void Delete(int idCSTCofins)
        {
            cofinsRepository.Delete(idCSTCofins);
        }


        public int Copy(int idCSTCofins)
        {
            return cofinsRepository.Copy(idCSTCofins);
        }
    }
}
