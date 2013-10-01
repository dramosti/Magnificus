using HLP.Comum.Infrastructure;
using HLP.Comum.Infrastructure.Static;
using HLP.Models.Sales.Comercial;
using HLP.Repository.Interfaces.Sales.Comercial;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Implementation.Sales.Comercial
{
    public class Orcamento_ItemRepository : IOrcamento_ItemRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Orcamento_ItemModel> regOrcamento_ItemAccessor;
        private DataAccessor<Orcamento_ItemModel> regAllOrcamento_ItemAccessor;

        public void Save(Orcamento_ItemModel objOrcamento_Item)
        {
            if (objOrcamento_Item.idOrcamentoItem == null)
            {
                objOrcamento_Item.idOrcamentoItem = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Orcamento_Item",
                ParameterBase<Orcamento_ItemModel>.SetParameterValue(objOrcamento_Item));
                objOrcamento_Item.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Orcamento_Item]",
            ParameterBase<Orcamento_ItemModel>.SetParameterValue(objOrcamento_Item));
                objOrcamento_Item.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
            }
        }

        public void Delete(int idOrcamentoItem)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Orcamento_Item",
                 UserData.idUser,
                 idOrcamentoItem);
        }

        public int Copy(int idOrcamentoItem)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Orcamento_Item",
                       idOrcamentoItem);
        }

        public Orcamento_ItemModel GetOrcamento_Item(int idOrcamentoItem)
        {
            if (regOrcamento_ItemAccessor == null)
            {
                regOrcamento_ItemAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Orcamento_Item",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idOrcamentoItem"),
                                 MapBuilder<Orcamento_ItemModel>.MapAllProperties().Build());
            }

            return regOrcamento_ItemAccessor.Execute(idOrcamentoItem).FirstOrDefault();
        }

        public List<Orcamento_ItemModel> GetAllOrcamento_Item(int idOrcamento)
        {
            if (regOrcamento_ItemAccessor == null)
            {
                regOrcamento_ItemAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("select * from Orcamento_Item " +
                                            "where idOrcamento = @idOrcamento",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idOrcamento"),
                                 MapBuilder<Orcamento_ItemModel>.MapAllProperties().DoNotMap(i => i.Orcamento_Item_Impostos)
                                 .DoNotMap(i => i.idItem)
                                 .Build());
            }
            return regOrcamento_ItemAccessor.Execute(idOrcamento).ToList();
        }

        public List<Orcamento_ItemModel> GetAllOrcamento_Item()
        {
            if (regAllOrcamento_ItemAccessor == null)
            {
                regAllOrcamento_ItemAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Orcamento_Item",
                                MapBuilder<Orcamento_ItemModel>.MapAllProperties().Build());
            }
            return regAllOrcamento_ItemAccessor.Execute().ToList();
        }


        public void BebingTransaction()
        {
            UndTrabalho.BeginTransaction();
        }

        public void Commit()
        {
            UndTrabalho.CommitTransaction();
        }

        public void Rollback()
        {
            UndTrabalho.RollBackTransaction();
        }
    }
}
