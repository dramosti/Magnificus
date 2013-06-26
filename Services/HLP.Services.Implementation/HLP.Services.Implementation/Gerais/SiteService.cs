using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class SiteService : ISiteService
    {
        [Inject]
        public ISiteRepository _SiteRepository { get; set; }

        [Inject]
        public ISite_enderecoRepository _Site_EnderecoRepository { get; set; }

        public void Save(SiteModel objSite)
        {
            try
            {
                _SiteRepository.BeginTransaction();
                _SiteRepository.Save(objSite);

                #region Site_Endereco
                foreach (Site_enderecoModel item in objSite.lSite_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idSite = (int)objSite.idSite;
                    _Site_EnderecoRepository.Save(item);
                }
                foreach (Site_enderecoModel item in objSite.lSite_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Site_EnderecoRepository.Update(item);
                }
                foreach (Site_enderecoModel item in objSite.lSite_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Site_EnderecoRepository.Delete(item);
                }
                #endregion

                _SiteRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _SiteRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(SiteModel objSite)
        {
            try
            {

                _SiteRepository.BeginTransaction();

                //Deleta Filho
                _Site_EnderecoRepository.Delete((int)objSite.idSite);

                _SiteRepository.Delete(objSite);
                _SiteRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _SiteRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(SiteModel objSite)
        {
            try
            {

                _SiteRepository.BeginTransaction();
                _SiteRepository.Copy(objSite);

                foreach (Site_enderecoModel item in objSite.lSite_Endereco)
                {
                    item.idSite = (int)objSite.idSite; //codigo do novo pai
                    _Site_EnderecoRepository.Copy(item);
                }

                _SiteRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _SiteRepository.RollackTransaction();
                throw;
            }
        }

        public SiteModel GetSite(int idSite, bool bChildren = false)
        {
            SiteModel objSite = _SiteRepository.GetSite(idSite);

            if (bChildren)
            {
                objSite.lSite_Endereco = _Site_EnderecoRepository.GetAllSite_Endereco(idSite);
            }

            return objSite;
        }

        public List<SiteModel> GetAll()
        {
            return _SiteRepository.GetAll();
        }
    }
}
