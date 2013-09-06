using HLP.Models.Entries.Fiscal;
using HLP.Repository.Interfaces.Entries.Fiscal;
using HLP.Services.Interfaces.Entries.Fiscal;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Carga_trib_media_st_icmsService : ICarga_trib_media_st_icmsService
    {
        [Inject]
        public ICarga_trib_media_st_icmsRepository _Carga_trib_media_st_icmsRepository { get; set; }

        public void Save(Carga_trib_media_st_icmsModel objCarga_trib_media_st_icms)
        {
            _Carga_trib_media_st_icmsRepository.Save(objCarga_trib_media_st_icms);
        }

        public void Delete(int idCargaTribMediaStIcms)
        {
            _Carga_trib_media_st_icmsRepository.Delete(idCargaTribMediaStIcms);
        }

        public int Copy(int idCargaTribMediaStIcms)
        {
            return _Carga_trib_media_st_icmsRepository.Copy(idCargaTribMediaStIcms);
        }

        public Carga_trib_media_st_icmsModel GetCarga_trib_media_st_icms(int idCargaTribMediaStIcms)
        {
            return _Carga_trib_media_st_icmsRepository.GetCarga_trib_media_st_icms(idCargaTribMediaStIcms);
        }

        public List<Carga_trib_media_st_icmsModel> GetAllCarga_trib_media_st_icms()
        {
            return _Carga_trib_media_st_icmsRepository.GetAllCarga_trib_media_st_icms();
        }

        public Carga_trib_media_st_icmsModel GetGetCarga_trib_media_st_icmsByUf(int idUf)
        {
            return _Carga_trib_media_st_icmsRepository.GetCarga_trib_media_st_icmsByUf(idUf: idUf);
        }
    }
}
