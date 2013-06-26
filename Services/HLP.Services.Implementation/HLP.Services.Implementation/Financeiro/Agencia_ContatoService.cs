using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using HLP.Repository.Interfaces.Entries.Financeiro;
using Ninject;

namespace HLP.Services.Implementation.Entries.Financeiro
{
    public class Agencia_ContatoService : IAgencia_ContatoService
    {
        [Inject]
        public IAgencia_ContatoRepository _Agencia_ContatoRepository { get; set; }

        public void Save(Agencia_ContatoModel objAgencia_Contato)
        {
            _Agencia_ContatoRepository.Save(objAgencia_Contato);
        }

        public void Update(Agencia_ContatoModel objAgencia_Contato)
        {
            _Agencia_ContatoRepository.Update(objAgencia_Contato);
        }

        public void Delete(Agencia_ContatoModel objAgencia_Contato)
        {
            _Agencia_ContatoRepository.Delete(objAgencia_Contato);
        }

        public void Delete(int idAgencia)
        {
            _Agencia_ContatoRepository.Delete(idAgencia);
        }

        public void Copy(Agencia_ContatoModel objAgencia_Contato)
        {
            _Agencia_ContatoRepository.Copy(objAgencia_Contato);
        }

        public Agencia_ContatoModel GetAgencia_Contato(int idAgenciaContato)
        {
            return _Agencia_ContatoRepository.GetAgencia_Contato(idAgenciaContato);
        }

        public List<Agencia_ContatoModel> GetAllAgencia_Contato(int idAgencia)
        {
            return _Agencia_ContatoRepository.GetAllAgencia_Contato(idAgencia);
        }
    }
}
