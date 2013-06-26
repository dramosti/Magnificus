using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Financeiro;
using HLP.Models.Entries.Financeiro;
using Ninject;
using HLP.Repository.Interfaces.Entries.Financeiro;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Financeiro
{
    public class Dia_PagamentoService : IDia_PagamentoService
    {

        [Inject]
        public IDia_PagamentoRepository _Dia_pagamentoRepository { get; set; }

        [Inject]
        public IDia_pagamento_linhasRepository _Dia_pagamento_linhasRepository { get; set; }

        public void Save(Dia_pagamentoModel objDia_pagamento)
        {
            try
            {
                _Dia_pagamentoRepository.BeginTransaction();
                _Dia_pagamentoRepository.Save(objDia_pagamento);

                #region Dia_pagamento_linhas
                foreach (Dia_pagamento_linhasModel item in objDia_pagamento.lDia_pagamento_linhas.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    
                    item.idDiaPagamento = (int)objDia_pagamento.idDiaPagamento;
                    _Dia_pagamento_linhasRepository.Save(item);
                }
                foreach (Dia_pagamento_linhasModel item in objDia_pagamento.lDia_pagamento_linhas.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Dia_pagamento_linhasRepository.Update(item);
                }
                foreach (Dia_pagamento_linhasModel item in objDia_pagamento.lDia_pagamento_linhas.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Dia_pagamento_linhasRepository.Delete(item);
                }
                #endregion

                _Dia_pagamentoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Dia_pagamentoRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(Dia_pagamentoModel objDia_pagamento)
        {
            try
            {

                _Dia_pagamentoRepository.BeginTransaction();

                //Deleta Filho
                _Dia_pagamento_linhasRepository.Delete((int)objDia_pagamento.idDiaPagamento);

                _Dia_pagamentoRepository.Delete(objDia_pagamento);
                _Dia_pagamentoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Dia_pagamentoRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Dia_pagamentoModel objDia_pagamento)
        {
            try
            {

                _Dia_pagamentoRepository.BeginTransaction();
                _Dia_pagamentoRepository.Copy(objDia_pagamento);

                foreach (Dia_pagamento_linhasModel item in objDia_pagamento.lDia_pagamento_linhas)
                {
                    item.idDiaPagamento = (int)objDia_pagamento.idDiaPagamento; //codigo do novo pai
                    _Dia_pagamento_linhasRepository.Copy(item);
                }

                _Dia_pagamentoRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Dia_pagamentoRepository.RollackTransaction();
                throw;
            }
        }

        public Dia_pagamentoModel GetDia_pagamento(int idDiaPagamento, bool bChildren = false)
        {
            Dia_pagamentoModel objDia_pagamento = _Dia_pagamentoRepository.GetDia_pagamento(idDiaPagamento);

            if (bChildren)
            {
                objDia_pagamento.lDia_pagamento_linhas = _Dia_pagamento_linhasRepository.GetAllDia_pagamento_linhas(idDiaPagamento);
            }

            return objDia_pagamento;
        }



    }
}
