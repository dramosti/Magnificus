using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Services.Interfaces.Entries.Fiscal;
using HLP.Models.Entries.Fiscal;
using Ninject;
using HLP.Repository.Interfaces.Entries.Fiscal;

namespace HLP.Services.Implementation.Entries.Fiscal
{
    public class Tipo_operacaoService : ITipo_operacaoService
    {
        [Inject]
        public ITipo_operacaoRepository operacaoRepository { get; set; }

        public Tipo_operacaoModel GetOperacao(int idTipoOperacao)
        {
            Tipo_operacaoModel objTipo_operacao = operacaoRepository.GetOperacao(idTipoOperacao);
            return objTipo_operacao == null ? objTipo_operacao = new Tipo_operacaoModel() : objTipo_operacao;
        }

        public void Save(Tipo_operacaoModel operacao)
        {
            operacaoRepository.Save(operacao);
        }

        public void Delete(int idTipoOperacao)
        {
            operacaoRepository.Delete(idTipoOperacao);
        }


        public void Begin()
        {
            operacaoRepository.Begin();
        }

        public void Commit()
        {
            operacaoRepository.Commit();
        }

        public void RollBack()
        {
            operacaoRepository.RollBack();
        }


        public int Copy(int idTipoOperacao)
        {
            return operacaoRepository.Copy(idTipoOperacao);
        }
    }
}
