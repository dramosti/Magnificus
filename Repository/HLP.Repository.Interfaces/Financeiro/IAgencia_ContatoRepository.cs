using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Models.Entries.Financeiro;

namespace HLP.Repository.Interfaces.Entries.Financeiro
{
    public interface IAgencia_ContatoRepository
    {
        void Save(Agencia_ContatoModel objAgencia_Contato);
        void Update(Agencia_ContatoModel objAgencia_Contato);
        void Delete(Agencia_ContatoModel objAgencia_Contato);
        void Delete(int idAgencia);
        void Copy(Agencia_ContatoModel objAgencia_Contato);
        Agencia_ContatoModel GetAgencia_Contato(int idAgenciaContato);
        List<Agencia_ContatoModel> GetAllAgencia_Contato(int idAgencia);
    }
}
