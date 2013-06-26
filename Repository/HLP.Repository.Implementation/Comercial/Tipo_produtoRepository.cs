using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Tipo_produtoRepository : ITipo_produtoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Tipo_produtoModel> regCanalAccessor;

        public  Tipo_produtoModel GetTipo(int idTipoProduto)
        {
            if (regCanalAccessor == null)
            {
                regCanalAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_tipo_produto",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idTipoProduto"),
                                    MapBuilder<Tipo_produtoModel>.MapAllProperties().Build());
            }
            return regCanalAccessor.Execute(idTipoProduto).FirstOrDefault();
        }

        public void Save(Tipo_produtoModel tipo)
        {
            if (tipo.idTipoProduto == null)
            {
                int idTipoProduto = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                   "dbo.Proc_save_tipo_produto",
                  ParameterBase<Tipo_produtoModel>.SetParameterValue(tipo));

                tipo.idTipoProduto = idTipoProduto;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
                   "[dbo].[Proc_update_Tipo_produto]",
                  ParameterBase<Tipo_produtoModel>.SetParameterValue(tipo));
            }
        }

        public void Delete(int idTipoProduto)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                    "dbo.Proc_delete_tipo_produto",
                     UserData.idUser,
                     idTipoProduto);
        }

        public int Copy(int idTipoProduto)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                         "dbo.Proc_copy_tipo_produto",
                          idTipoProduto);
        }
    }
}
