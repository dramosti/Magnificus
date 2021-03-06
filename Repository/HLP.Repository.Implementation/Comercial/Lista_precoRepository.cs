﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Comercial;
using HLP.Models.Entries.Comercial;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Comercial
{
    public class Lista_precoRepository : ILista_precoRepository
    {

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Lista_precoModel> regAcessor;

        public void Save(Lista_precoModel objLista_preco)
        {
            objLista_preco.idListaPreco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Lista_preco]",
            ParameterBase<Lista_precoModel>.SetParameterValue(objLista_preco));

            objLista_preco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Lista_precoModel objLista_preco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Lista_preco]",
            ParameterBase<Lista_precoModel>.SetParameterValue(objLista_preco));

            objLista_preco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Lista_precoModel objLista_preco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Lista_preco]",
                  UserData.idUser,
                  objLista_preco.idListaPreco);

            objLista_preco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idListaPrecoPai)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Lista_preco WHERE idListaPrecoPai = " + idListaPrecoPai);
        }

        public void Copy(Lista_precoModel objLista_preco)
        {
            objLista_preco.idListaPreco = null;
            objLista_preco.idListaPreco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Lista_preco]",
        ParameterBase<Lista_precoModel>.SetParameterValue(objLista_preco));
        }

        public Lista_precoModel GetLista_preco(int idListaPreco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Lista_preco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idListaPreco"),
                   MapBuilder<Lista_precoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idListaPreco).FirstOrDefault();
        }

        public List<Lista_precoModel> GetAllLista_preco(int idListaPrecoPai)
        {
            DataAccessor<Lista_precoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Lista_preco WHERE idListaPrecoPai = @idListaPrecoPai", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idListaPrecoPai"),
            MapBuilder<Lista_precoModel>.MapAllProperties().Build());

            return reg.Execute(idListaPrecoPai).ToList();
        }

        public List<int> ReturnProducts(List<int> lidProduto)
        {
            List<int> lRetorno = new List<int>();
            string sql = "";
            if (lidProduto.Count() > 0)
            {
                string notIn = String.Join(",", lidProduto);
                sql = "SELECT idProduto FROM Produto WHERE idProduto NOT IN (" + notIn + ")";
            }
            else
            {
                sql = "SELECT idProduto FROM Produto";
            }

            DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sql);
            IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);

            while (reader.Read())
            {
                lRetorno.Add((int)reader.GetValue(0));
            }
            return lRetorno;


        }
       
    }
}
