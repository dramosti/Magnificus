using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure;

using System.Data.Common;
using System.Data;
using HLP.Comum.Infrastructure.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class Site_enderecoRepository : ISite_enderecoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Site_enderecoModel> regAcessor;

        public void Save(Site_enderecoModel objSite_Endereco)
        {
            objSite_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
           "[dbo].[Proc_save_Site_Endereco]",
            ParameterBase<Site_enderecoModel>.SetParameterValue(objSite_Endereco));

            objSite_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Update(Site_enderecoModel objSite_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Site_Endereco]",
            ParameterBase<Site_enderecoModel>.SetParameterValue(objSite_Endereco));

            objSite_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(Site_enderecoModel objSite_Endereco)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("[dbo].[Proc_delete_Site_Endereco]",
                  UserData.idUser,
                  objSite_Endereco.idEndereco);

            objSite_Endereco.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idSite)
        {
            UndTrabalho.dbPrincipal.ExecuteNonQuery(System.Data.CommandType.Text,
              "DELETE Site_Endereco WHERE idSite = " + idSite);
        }

        public void Copy(Site_enderecoModel objSite_Endereco)
        {
            objSite_Endereco.idEndereco = null;
            objSite_Endereco.idEndereco = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                                           UndTrabalho.dbTransaction,
                                           "[dbo].[Proc_save_Site_Endereco]",
        ParameterBase<Site_enderecoModel>.SetParameterValue(objSite_Endereco));
        }

        public Site_enderecoModel GetSite_Endereco(int idEndereco)
        {
            if (regAcessor == null)
            {
                regAcessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("[dbo].[Proc_sel_Site_Endereco]",
                   new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idEndereco"),
                   MapBuilder<Site_enderecoModel>.MapAllProperties().Build());
            }
            return regAcessor.Execute(idEndereco).FirstOrDefault();
        }

        public List<Site_enderecoModel> GetAllSite_Endereco(int idSite)
        {
            DataAccessor<Site_enderecoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Site_Endereco WHERE idSite = @idSite", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idSite"),
            MapBuilder<Site_enderecoModel>.MapAllProperties().Build());

            return reg.Execute(idSite).ToList();
        }
    }
}
