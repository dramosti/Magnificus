using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using HLP.Repository.Interfaces.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Comercial
{
    public class Lista_Preco_PaiService : ILista_Preco_PaiService
    {
        [Inject]
        public ILista_Preco_PaiRepository _Lista_Preco_PaiRepository { get; set; }

        [Inject]
        public ILista_precoRepository _Lista_precoRepository { get; set; }

        public void Save(Lista_Preco_PaiModel objLista_Preco_Pai)
        {
            try
            {
                _Lista_Preco_PaiRepository.BeginTransaction();
                _Lista_Preco_PaiRepository.Save(objLista_Preco_Pai);

                #region Lista_preco
                foreach (Lista_precoModel item in objLista_Preco_Pai.lLista_preco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.dAlteracaoCusto = DateTime.Now;
                    item.idListaPrecoPai = (int)objLista_Preco_Pai.idListaPrecoPai;

                    _Lista_precoRepository.Save(item);
                }
                foreach (Lista_precoModel item in objLista_Preco_Pai.lLista_preco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    decimal vCusto = _Lista_precoRepository.GetLista_preco((int)item.idListaPreco).vCustoProduto;
                    if (vCusto != item.vCustoProduto)
                    {
                        item.dAlteracaoCusto = DateTime.Now;
                    }
                    _Lista_precoRepository.Update(item);
                }
                foreach (Lista_precoModel item in objLista_Preco_Pai.lLista_preco.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Lista_precoRepository.Delete(item);
                }
                #endregion

                _Lista_Preco_PaiRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Lista_Preco_PaiRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(Lista_Preco_PaiModel objLista_Preco_Pai)
        {
            try
            {

                _Lista_Preco_PaiRepository.BeginTransaction();

                //Deleta Filho
                _Lista_precoRepository.Delete((int)objLista_Preco_Pai.idListaPrecoPai);

                _Lista_Preco_PaiRepository.Delete(objLista_Preco_Pai);
                _Lista_Preco_PaiRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Lista_Preco_PaiRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Lista_Preco_PaiModel objLista_Preco_Pai)
        {
            try
            {

                _Lista_Preco_PaiRepository.BeginTransaction();
                _Lista_Preco_PaiRepository.Copy(objLista_Preco_Pai);

                foreach (Lista_precoModel item in objLista_Preco_Pai.lLista_preco)
                {
                    item.idListaPrecoPai = (int)objLista_Preco_Pai.idListaPrecoPai; //codigo do novo pai
                    _Lista_precoRepository.Copy(item);
                }

                _Lista_Preco_PaiRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Lista_Preco_PaiRepository.RollackTransaction();
                throw;
            }
        }

        public Lista_Preco_PaiModel GetLista_Preco_Pai(int idListaPrecoPai, bool bChildren = false)
        {
            Lista_Preco_PaiModel objLista_Preco_Pai = _Lista_Preco_PaiRepository.GetLista_Preco_Pai(idListaPrecoPai);

            if (bChildren)
            {
                objLista_Preco_Pai.lLista_preco = _Lista_precoRepository.GetAllLista_preco(idListaPrecoPai);
            }

            return objLista_Preco_Pai;
        }
    }
}
