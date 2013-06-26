using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Ninject;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Site_enderecoService : ISite_enderecoService
    {
        [Inject]
        public ISite_enderecoRepository _Site_EnderecoRepository { get; set; }

        public void Save(Site_enderecoModel objSite_Endereco)
        {
            _Site_EnderecoRepository.Save(objSite_Endereco);
        }

        public void Update(Site_enderecoModel objSite_Endereco)
        {
            _Site_EnderecoRepository.Update(objSite_Endereco);
        }

        public void Delete(Site_enderecoModel objSite_Endereco)
        {
            _Site_EnderecoRepository.Delete(objSite_Endereco);
        }

        public void Delete(int idSite)
        {
            _Site_EnderecoRepository.Delete(idSite);
        }

        public void Copy(Site_enderecoModel objSite_Endereco)
        {
            _Site_EnderecoRepository.Copy(objSite_Endereco);
        }

        public Site_enderecoModel GetSite_Endereco(int idEndereco)
        {
            return _Site_EnderecoRepository.GetSite_Endereco(idEndereco);
        }

        public List<Site_enderecoModel> GetAllSite_Endereco(int idSite)
        {
            return _Site_EnderecoRepository.GetAllSite_Endereco(idSite);
        }
    }
}
