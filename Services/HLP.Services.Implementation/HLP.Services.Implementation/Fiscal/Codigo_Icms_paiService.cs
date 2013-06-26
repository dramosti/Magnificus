using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using Ninject;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Codigo_Icms_paiService : ICodigo_Icms_paiService
    {
        [Inject]
        public ICodigo_Icms_paiRepository _Codigo_Icms_paiRepository { get; set; }

        [Inject]
        public ICodigo_IcmsRepository _Codigo_IcmsRepository { get; set; }

        public void Save(Codigo_Icms_paiModel objCodigo_Icms_pai)
        {
            try
            {
                _Codigo_Icms_paiRepository.BeginTransaction();
                _Codigo_Icms_paiRepository.Save(objCodigo_Icms_pai);

                #region Codigo_Icms
                foreach (Codigo_IcmsModel item in objCodigo_Icms_pai.lCodigo_Icms.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idCodigoIcmsPai = (int)objCodigo_Icms_pai.idCodigoIcmsPai;
                    _Codigo_IcmsRepository.Save(item);
                }
                foreach (Codigo_IcmsModel item in objCodigo_Icms_pai.lCodigo_Icms.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Codigo_IcmsRepository.Update(item);
                }
                foreach (Codigo_IcmsModel item in objCodigo_Icms_pai.lCodigo_Icms.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Codigo_IcmsRepository.Delete(item);
                }
                #endregion

                _Codigo_Icms_paiRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Codigo_Icms_paiRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(Codigo_Icms_paiModel objCodigo_Icms_pai)
        {
            try
            {

                _Codigo_Icms_paiRepository.BeginTransaction();

                //Deleta Filho
                _Codigo_IcmsRepository.Delete((int)objCodigo_Icms_pai.idCodigoIcmsPai);

                _Codigo_Icms_paiRepository.Delete(objCodigo_Icms_pai);
                _Codigo_Icms_paiRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Codigo_Icms_paiRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Codigo_Icms_paiModel objCodigo_Icms_pai)
        {
            try
            {

                _Codigo_Icms_paiRepository.BeginTransaction();
                _Codigo_Icms_paiRepository.Copy(objCodigo_Icms_pai);

                foreach (Codigo_IcmsModel item in objCodigo_Icms_pai.lCodigo_Icms)
                {
                    item.idCodigoIcmsPai = (int)objCodigo_Icms_pai.idCodigoIcmsPai; //codigo do novo pai
                    _Codigo_IcmsRepository.Copy(item);
                }

                _Codigo_Icms_paiRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Codigo_Icms_paiRepository.RollackTransaction();
                throw;
            }
        }

        public Codigo_Icms_paiModel GetCodigo_Icms_pai(int idCodigoIcmsPai, bool bChildren = false)
        {
            Codigo_Icms_paiModel objCodigo_Icms_pai = _Codigo_Icms_paiRepository.GetCodigo_Icms_pai(idCodigoIcmsPai);

            if (bChildren)
            {
                objCodigo_Icms_pai.lCodigo_Icms = _Codigo_IcmsRepository.GetAllCodigo_Icms(idCodigoIcmsPai);
            }

            return objCodigo_Icms_pai;
        }
    }
}
