using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.RecursosHumanos;
using HLP.Models.Entries.RecursosHumanos;
using HLP.Comum.Infrastructure;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.RecursosHumanos
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<DepartamentoModel> regDepartamentoAccessor;
        private DataAccessor<DepartamentoModel> regDepartamentoBySetorAcessor;

        public DepartamentoModel GetDepartamento(int idDepartamento)
        {
            if (regDepartamentoAccessor == null)
            {
                regDepartamentoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_departamento",
                                    new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idDepartamento"),
                                    MapBuilder<DepartamentoModel>.MapAllProperties().Build());
            }
            return regDepartamentoAccessor.Execute(idDepartamento).FirstOrDefault();
        }

        public void Save(DepartamentoModel departamento)
        {
            if(departamento.idDepartamento == null)
            {
                int idDepartamento = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
             "dbo.Proc_save_departamento",
            ParameterBase<DepartamentoModel>.SetParameterValue(departamento));
                departamento.idDepartamento = idDepartamento;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
             "dbo.Proc_update_Departamento",
            ParameterBase<DepartamentoModel>.SetParameterValue(departamento));
            }
            
        }

        public void Delete(int idDepartamento)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                     "dbo.Proc_delete_departamento",
                      UserData.idUser,
                      idDepartamento);
        }

        public int Copy(int idDepartamento)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                        "dbo.Proc_copy_departamento",
                         idDepartamento);
        }

        public List<DepartamentoModel> GetBySetor(int idSetor)
        {
            regDepartamentoBySetorAcessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("select d.idDepartamento, d.xDepartamento," +
                    " d.xDescricao, d.idSetor, d.xEmail from Setor s, Departamento d " +
                    "where d.idSetor = s.idSetor and s.idSetor = " + idSetor,
                    MapBuilder<DepartamentoModel>.MapAllProperties().Build());
            return regDepartamentoBySetorAcessor.Execute().ToList();
        }
    }
}
