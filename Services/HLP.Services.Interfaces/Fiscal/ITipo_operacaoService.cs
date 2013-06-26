using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Fiscal;

namespace HLP.Services.Interfaces.Entries.Fiscal
{
    public interface ITipo_operacaoService
    {
        Tipo_operacaoModel GetOperacao(int idTipoOperacao);
        void Save(Tipo_operacaoModel operacao);
        void Delete(int idTipoOperacao);
        void Begin();
        void Commit();
        void RollBack();
        int Copy(int idTipoOperacao);
    }
}
