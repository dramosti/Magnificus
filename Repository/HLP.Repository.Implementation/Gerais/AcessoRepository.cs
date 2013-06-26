using HLP.Comum.Infrastructure;
using HLP.Comum.Models.Static;
using HLP.Models.Entries.Gerais;
using HLP.Repository.Interfaces.Entries.Gerais;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLP.Repository.Implementation.Entries.Gerais
{
    public class AcessoRepository:IAcessoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<Funcionario_AcessoModel> regAcessoAccessor;
        private DataAccessor<Funcionario_AcessoModel> regAllAcessoAccessor;

        public void Save(Funcionario_AcessoModel objAcesso)
        {
            objAcesso.idAcesso = (int)UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_save_Acesso",
            ParameterBase<Funcionario_AcessoModel>.SetParameterValue(objAcesso));
        }

        public void Update(Funcionario_AcessoModel objAcesso)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar(
            "[dbo].[Proc_update_Acesso]",
            ParameterBase<Funcionario_AcessoModel>.SetParameterValue(objAcesso));

            objAcesso.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public void Delete(int idAcesso)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Acesso",
                 UserData.idUser,
                 idAcesso);
        }

        public void Delete(Funcionario_AcessoModel objAcesso)
        {
            UndTrabalho.dbPrincipal.ExecuteScalar("dbo.Proc_delete_Acesso",
                  UserData.idUser,
                  objAcesso.idAcesso, objAcesso.idEmpresa, objAcesso.idFuncionario);

            objAcesso.SetStatusRegistro(BaseModelFilhos.statusRegistroFilho.SemMudanca);
        }

        public int Copy(int idAcesso)
        {
            return (int)UndTrabalho.dbPrincipal.ExecuteScalar(
                      "dbo.Proc_copy_Acesso",
                       idAcesso);
        }

        public Funcionario_AcessoModel GetAcesso(int idAcesso)
        {
            if (regAcessoAccessor == null)
            {
                regAcessoAccessor = UndTrabalho.dbPrincipal.CreateSprocAccessor("dbo.Proc_sel_Acesso",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<int>("idAcesso"),
                                 MapBuilder<Funcionario_AcessoModel>.MapAllProperties().Build());
            }

            return regAcessoAccessor.Execute(idAcesso).FirstOrDefault();
        }

        public List<Funcionario_AcessoModel> GetAllAcesso()
        {
            if (regAllAcessoAccessor == null)
            {
                regAllAcessoAccessor = UndTrabalho.dbPrincipal.CreateSqlStringAccessor("SELECT * FROM Acesso",
                                MapBuilder<Funcionario_AcessoModel>.MapAllProperties().Build());
            }
            return regAllAcessoAccessor.Execute().ToList();
        }

        public List<Funcionario_AcessoModel> GetAllAcesso_Funcionario(int idFuncionario)
        {
            DataAccessor<Funcionario_AcessoModel> reg = UndTrabalho.dbPrincipal.CreateSqlStringAccessor
            ("SELECT * FROM Acesso WHERE idFuncionario = @idFuncionario", new Parameters(UndTrabalho.dbPrincipal).AddParameter<int>("idFuncionario"),
            MapBuilder<Funcionario_AcessoModel>.MapAllProperties().Build());

            return reg.Execute(idFuncionario).ToList();
        }
    }
}
