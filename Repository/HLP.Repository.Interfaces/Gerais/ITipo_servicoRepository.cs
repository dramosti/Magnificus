using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Gerais;

namespace HLP.Repository.Interfaces.Entries.Gerais
{
    public interface ITipo_servicoRepository
    {
        Tipo_servicoModel GetTipo(int idTipoServico);
        void Save(Tipo_servicoModel tipo);
        void Delete(int idTipoServico);
        int Copy(int idTipoServico);
    }
}
