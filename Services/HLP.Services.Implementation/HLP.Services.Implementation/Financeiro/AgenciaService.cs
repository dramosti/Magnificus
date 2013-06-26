using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using HLP.Repository.Interfaces.Entries.Financeiro;
using Ninject;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Financeiro
{
    public class AgenciaService : IAgenciaService
    {
       
        [Inject]
        public IAgenciaRepository _AgenciaRepository { get; set; }

        [Inject]
        public IAgencia_EnderecoRepository _Agencia_EnderecoRepository { get; set; }

        [Inject]
        public IAgencia_ContatoRepository _Agencia_ContatoRepository { get; set; }

        public void Save(AgenciaModel objAgencia)
        {
            try
            {
                _AgenciaRepository.BeginTransaction();
                _AgenciaRepository.Save(objAgencia);

                #region Agencia_Endereco
                foreach (Agencia_EnderecoModel item in objAgencia.lAgencia_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idAgencia = (int)objAgencia.idAgencia;
                    _Agencia_EnderecoRepository.Save(item);
                }
                foreach (Agencia_EnderecoModel item in objAgencia.lAgencia_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Agencia_EnderecoRepository.Update(item);
                }
                foreach (Agencia_EnderecoModel item in objAgencia.lAgencia_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Agencia_EnderecoRepository.Delete(item);
                }
                #endregion

                #region Agencia_Contato
                foreach (Agencia_ContatoModel item in objAgencia.lAgencia_Contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idAgencia = (int)objAgencia.idAgencia;
                    _Agencia_ContatoRepository.Save(item);
                }
                foreach (Agencia_ContatoModel item in objAgencia.lAgencia_Contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Agencia_ContatoRepository.Update(item);
                }
                foreach (Agencia_ContatoModel item in objAgencia.lAgencia_Contato.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Agencia_ContatoRepository.Delete(item);
                }
                #endregion

                _AgenciaRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _AgenciaRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(AgenciaModel objAgencia)
        {
            try
            {

                _AgenciaRepository.BeginTransaction();

                //Deleta Filho
                _Agencia_EnderecoRepository.Delete((int)objAgencia.idAgencia);

                //Deleta Filho
                _Agencia_ContatoRepository.Delete((int)objAgencia.idAgencia);

                _AgenciaRepository.Delete(objAgencia);
                _AgenciaRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _AgenciaRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(AgenciaModel objAgencia)
        {
            try
            {

                _AgenciaRepository.BeginTransaction();
                _AgenciaRepository.Copy(objAgencia);

                foreach (Agencia_EnderecoModel item in objAgencia.lAgencia_Endereco)
                {
                    item.idAgencia = (int)objAgencia.idAgencia; //codigo do novo pai
                    _Agencia_EnderecoRepository.Copy(item);
                }

                foreach (Agencia_ContatoModel item in objAgencia.lAgencia_Contato)
                {
                    item.idAgencia = (int)objAgencia.idAgencia; //codigo do novo pai
                    _Agencia_ContatoRepository.Copy(item);
                }

                _AgenciaRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _AgenciaRepository.RollackTransaction();
                throw;
            }
        }

        public AgenciaModel GetAgencia(int idAgencia, bool bChildren = false)
        {
            AgenciaModel objAgencia = _AgenciaRepository.GetAgencia(idAgencia);

            if (bChildren)
            {
                objAgencia.lAgencia_Endereco = _Agencia_EnderecoRepository.GetAllAgencia_Endereco(idAgencia);
                objAgencia.lAgencia_Contato = _Agencia_ContatoRepository.GetAllAgencia_Contato(idAgencia);
            }

            return objAgencia;
        }

        public List<AgenciaModel> GetByBanco(int idBanco)
        {
            return _AgenciaRepository.GetByBanco(idBanco);
        }
        
    }
}
