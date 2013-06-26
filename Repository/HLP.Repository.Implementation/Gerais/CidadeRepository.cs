using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Repository.Interfaces.Entries.Gerais;
using HLP.Models.Entries.Gerais;
using Ninject;
using HLP.Comum.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Models.Static;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class CidadeRepository : ICidadeRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<CidadeModel> regCidadeByUfAccessor;

        private DataAccessor<CidadeModel> regCidadeAccessor;

        private DataAccessor<UFModel> regUfByCidadeAccessor;



        public List<CidadeModel> GetCidadeByUf(int idUf)
        {
            if (regCidadeByUfAccessor == null)
            {
                regCidadeByUfAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Cidade WHERE idUf = @idUf",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idUf"),
                                  MapBuilder<CidadeModel>.MapAllProperties().Build());
            }


            return regCidadeByUfAccessor.Execute(idUf).ToList();
        }

        public CidadeModel GetCidade(int idCidade)
        {
            if (regCidadeAccessor == null)
            {
                regCidadeAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_cidade",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<int>("idCidade"),
                                  MapBuilder<CidadeModel>.MapAllProperties().Build());
            }


            return regCidadeAccessor.Execute(idCidade).FirstOrDefault();
        }

        public CidadeModel GetCidadeByName(string xName)
        {
            if (regCidadeAccessor == null)
            {
                regCidadeAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("select * from Cidade where xCidade = @xName",
                                  new Parameters(UndTrabalho.dbPrincipal)
                                    .AddParameter<string>("xName"),
                                  MapBuilder<CidadeModel>.MapAllProperties().Build());
            }


            return regCidadeAccessor.Execute(xName).FirstOrDefault();
        }

        public UFModel GetUfByCidade(int idCidade)
        {
            if (regUfByCidadeAccessor == null)
                {
                    regUfByCidadeAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * from Cidade as c, UF as u WHERE c.idUF = u.idUf AND c.idCidade = @idCidade",
                                      new Parameters(UndTrabalho.dbPrincipal)
                                        .AddParameter<int>("idCidade"),
                                      MapBuilder<UFModel>.MapAllProperties().Build());
                }


            return regUfByCidadeAccessor.Execute(idCidade).FirstOrDefault();
        }

        public void Save(CidadeModel cidade)
        {
            if (cidade.idCidade == null)
            {
                int idCidade = (int)UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_save_cidade]",
              ParameterBase<CidadeModel>.SetParameterValue(cidade));

                cidade.idCidade = idCidade;
            }
            else
            {
                UndTrabalho.dbPrincipal.ExecuteScalar(
               "[dbo].[Proc_update_Cidade]",
              ParameterBase<CidadeModel>.SetParameterValue(cidade));
            }
            
        }

        public void Delete(int idCidade)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
                    "dbo.Proc_delete_cidade",
                     UserData.idUser,
                     idCidade);
        }


        public List<CidadeModel> GetAll()
        {
            regCidadeAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM  CIDADE",
                              MapBuilder<CidadeModel>.MapAllProperties().Build());

            return regCidadeAccessor.Execute().ToList();
        }


        public int Copy(int idCidade)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                          "dbo.Proc_copy_cidade",
                           idCidade);
        }
    }
}
