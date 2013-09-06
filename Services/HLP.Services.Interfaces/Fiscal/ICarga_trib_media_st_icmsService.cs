using HLP.Models.Entries.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ICarga_trib_media_st_icmsService
    {
        void Save(Carga_trib_media_st_icmsModel objCarga_trib_media_st_icms);
        void Delete(int idCargaTribMediaStIcms);
        int Copy(int idCargaTribMediaStIcms);
        Carga_trib_media_st_icmsModel GetCarga_trib_media_st_icms(int idCargaTribMediaStIcms);
        List<Carga_trib_media_st_icmsModel> GetAllCarga_trib_media_st_icms();
        Carga_trib_media_st_icmsModel GetGetCarga_trib_media_st_icmsByUf(int idUf);
    }
}
