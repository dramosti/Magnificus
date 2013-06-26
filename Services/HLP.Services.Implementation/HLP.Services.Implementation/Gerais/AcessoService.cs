using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class AcessoService : IAcessoService
    {
        [Inject]
        public IAcessoRepository _AcessoRepository { get; set; }

        public void Save(Funcionario_AcessoModel objAcesso)
        {
            _AcessoRepository.Save(objAcesso);
        }

        public void Delete(int idAcesso)
        {
            _AcessoRepository.Delete(idAcesso);
        }

        public int Copy(int idAcesso)
        {
            return _AcessoRepository.Copy(idAcesso);
        }

        public Funcionario_AcessoModel GetAcesso(int idAcesso)
        {
            return _AcessoRepository.GetAcesso(idAcesso);
        }

        public List<Funcionario_AcessoModel> GetAllAcesso_Funcionario(int idFuncionario)
        {
            return _AcessoRepository.GetAllAcesso_Funcionario(idFuncionario);
        }

        //public List<Funcionario_AcessoModel> GetAllAcesso()
        //{
        //    return _AcessoRepository.GetAll();
        //}

    }
}
