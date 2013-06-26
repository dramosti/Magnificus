using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Comum.Infrastructure;

namespace HLP.Services.Implementation.Entries.Gerais
{
    public class Plano_pagamentoService : IPlano_pagamentoService
    {
        [Inject]
        public IPlano_pagamentoRepository _Plano_pagamentoRepository { get; set; }

        [Inject]
        public IPlano_pagamento_linhasRepository _Plano_pagamento_linhasRepository { get; set; }

        public void Save(Plano_pagamentoModel objPlano_pagamento)
        {
            try
            {
                _Plano_pagamentoRepository.BeginTransaction();
                _Plano_pagamentoRepository.Save(objPlano_pagamento);

                #region Plano_pagamento_linhas
                foreach (Plano_pagamento_linhasModel item in objPlano_pagamento.lPlano_pagamento_linhas.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Incluido))
                {
                    //Aqui deve-se setar as Fks' que devem ser carregadas de classes estaticas (se houver)
                    //Exemplo:
                    //item.idUsuario = (int)AcessoUser.idUser;

                    item.idPlanoPagamento = (int)objPlano_pagamento.idPlanoPagamento;
                    _Plano_pagamento_linhasRepository.Save(item);
                }
                foreach (Plano_pagamento_linhasModel item in objPlano_pagamento.lPlano_pagamento_linhas.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Alterado))
                {
                    _Plano_pagamento_linhasRepository.Update(item);
                }
                foreach (Plano_pagamento_linhasModel item in objPlano_pagamento.lPlano_pagamento_linhas.Where(p => p.GetStatusRegistro() == BaseModelFilhos.statusRegistroFilho.Excluido))
                {
                    _Plano_pagamento_linhasRepository.Delete(item);
                }
                #endregion

                _Plano_pagamentoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Plano_pagamentoRepository.RollackTransaction();
                throw;
            }
        }

        public void Delete(Plano_pagamentoModel objPlano_pagamento)
        {
            try
            {

                _Plano_pagamentoRepository.BeginTransaction();

                //Deleta Filho
                _Plano_pagamento_linhasRepository.Delete((int)objPlano_pagamento.idPlanoPagamento);

                _Plano_pagamentoRepository.Delete(objPlano_pagamento);
                _Plano_pagamentoRepository.CommitTransaction();

            }
            catch (Exception)
            {
                _Plano_pagamentoRepository.RollackTransaction();
                throw;
            }
        }

        public void Copy(Plano_pagamentoModel objPlano_pagamento)
        {
            try
            {

                _Plano_pagamentoRepository.BeginTransaction();
                _Plano_pagamentoRepository.Copy(objPlano_pagamento);

                foreach (Plano_pagamento_linhasModel item in objPlano_pagamento.lPlano_pagamento_linhas)
                {
                    item.idPlanoPagamento = (int)objPlano_pagamento.idPlanoPagamento; //codigo do novo pai
                    _Plano_pagamento_linhasRepository.Copy(item);
                }

                _Plano_pagamentoRepository.CommitTransaction();
            }
            catch (Exception)
            {
                _Plano_pagamentoRepository.RollackTransaction();
                throw;
            }
        }

        public Plano_pagamentoModel GetPlano_pagamento(int idPlanoPagamento, bool bChildren = false)
        {
            Plano_pagamentoModel objPlano_pagamento = _Plano_pagamentoRepository.GetPlano_pagamento(idPlanoPagamento);

            if (bChildren)
            {
                objPlano_pagamento.lPlano_pagamento_linhas = _Plano_pagamento_linhasRepository.GetAllPlano_pagamento_linhas(idPlanoPagamento);
            }

            return objPlano_pagamento;
        }
    }
}
