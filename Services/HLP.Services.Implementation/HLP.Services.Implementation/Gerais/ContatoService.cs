using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class ContatoService : IContatoService
    {
        [Inject]
        public IContatoRepository _ContatoRepository { get; set; }

        [Inject]
        public IContato_EnderecoRepository _Contato_EnderecoRepository { get; set; }

        public void Save(ContatoModel objContato)
        {
            try
            {
                _ContatoRepository.BeginTransaction();
                _ContatoRepository.Save(objContato);

                #region Contato_Endereco
                foreach (Contato_EnderecoModel item in objContato.lContato_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idContato = (int)objContato.idContato;
                    _Contato_EnderecoRepository.Save(item);
                }
                foreach (Contato_EnderecoModel item in objContato.lContato_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Contato_EnderecoRepository.Update(item);
                }
                foreach (Contato_EnderecoModel item in objContato.lContato_Endereco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Contato_EnderecoRepository.Delete(item);
                }
                #endregion

                _ContatoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _ContatoRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(ContatoModel objContato)
        {
            try
            {

                _ContatoRepository.BeginTransaction();

                //Deleta Filho
                _Contato_EnderecoRepository.Delete((int)objContato.idContato);

                _ContatoRepository.Delete(objContato);
                _ContatoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _ContatoRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(ContatoModel objContato)
        {
            try
            {

                _ContatoRepository.BeginTransaction();
                _ContatoRepository.Copy(objContato);

                foreach (Contato_EnderecoModel item in objContato.lContato_Endereco)
                {
                    item.idContato = (int)objContato.idContato; //codigo do novo pai
                    _Contato_EnderecoRepository.Copy(item);
                }

                _ContatoRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _ContatoRepository.RollackTransaction();
                throw;
            }
        }

        public ContatoModel GetContato(int idContato, bool bChildren = false)
        {
            ContatoModel objContato = _ContatoRepository.GetContato(idContato);

            if (bChildren)
            {
                objContato.lContato_Endereco = _Contato_EnderecoRepository.GetAllContato_Endereco(idContato);
            }

            return objContato;
        }
    }
}
