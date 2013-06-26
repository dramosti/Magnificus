using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ISite_enderecoRepository
    {
        void Save(Site_enderecoModel objSite_Endereco);
        void Update(Site_enderecoModel objSite_Endereco);
        void Delete(Site_enderecoModel objSite_Endereco);
        void Delete(int idSite);
        void Copy(Site_enderecoModel objSite_Endereco);
        Site_enderecoModel GetSite_Endereco(int idEndereco);
        List<Site_enderecoModel> GetAllSite_Endereco(int idSite);
    }
}
