﻿using HLP.Comum.Infrastructure;
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
    public class Orcamento_Item_ImpostosRepository : IOrcamento_Item_ImpostosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Orcamento_Item_ImpostosModel> regOrcamento_Item_ImpostosAccessor;
        private DataAccessor<Orcamento_Item_ImpostosModel> regAllOrcamento_Item_ImpostosAccessor;

        public void Save(Orcamento_Item_ImpostosModel objOrcamento_Item_Impostos)
        {
            if (objOrcamento_Item_Impostos.idOrcamentoTotalizadorImpostos == null)
            {
                objOrcamento_Item_Impostos.idOrcamentoTotalizadorImpostos = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Orcamento_Item_Impostos",
                ParameterBase<Orcamento_Item_ImpostosModel>.SetParameterValue(objOrcamento_Item_Impostos));
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_update_Orcamento_Item_Impostos]",
                ParameterBase<Orcamento_Item_ImpostosModel>.SetParameterValue(objOrcamento_Item_Impostos));
            }
        }

        public void Delete(int idOrcamentoTotalizadorImpostos)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Orcamento_Item_Impostos",
                 UserData.idUser,
                 idOrcamentoTotalizadorImpostos);
        }

        public int Copy(int idOrcamentoTotalizadorImpostos)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Orcamento_Item_Impostos",
                       idOrcamentoTotalizadorImpostos);
        }

        public Orcamento_Item_ImpostosModel GetOrcamento_Item_Impostos(int idOrcamentoTotalizadorImpostos)
        {
            if (regOrcamento_Item_ImpostosAccessor == null)
            {
                regOrcamento_Item_ImpostosAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Orcamento_Item_Impostos",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idOrcamentoTotalizadorImpostos"),
                                 MapBuilder<Orcamento_Item_ImpostosModel>.MapAllProperties().Build());
            }

            return regOrcamento_Item_ImpostosAccessor.Execute(idOrcamentoTotalizadorImpostos).FirstOrDefault();
        }

        public List<Orcamento_Item_ImpostosModel> GetAllOrcamento_Item_Impostos()
        {
            if (regAllOrcamento_Item_ImpostosAccessor == null)
            {
                regAllOrcamento_Item_ImpostosAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Orcamento_Item_Impostos",
                                MapBuilder<Orcamento_Item_ImpostosModel>.MapAllProperties().Build());
            }
            return regAllOrcamento_Item_ImpostosAccessor.Execute().ToList();
        }

        public Orcamento_Item_ImpostosModel GetOrcamento_Item_ImpostosByItem(int idOrcamento_Item)
        {
            if (regAllOrcamento_Item_ImpostosAccessor == null)
            {
                regAllOrcamento_Item_ImpostosAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Orcamento_Item_Impostos" +
                " where idOrcamentoItem = @idOrcamentoItem", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idOrcamentoItem"),
                                MapBuilder<Orcamento_Item_ImpostosModel>.MapAllProperties().Build());
            }
            return regAllOrcamento_Item_ImpostosAccessor.Execute(idOrcamento_Item).FirstOrDefault();
        }
    }
}
