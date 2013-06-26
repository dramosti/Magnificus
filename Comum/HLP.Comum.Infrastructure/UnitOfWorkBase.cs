using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace HLP.Comum.Infrastructure
{
    public abstract class UnitOfWorkBase : IDisposable
    {
        public abstract Database dbPrincipal { get; }
        public DbTransaction dbTransaction
        {
            get
            {
                return _dbTransaction;
            }
        }

        private DbTransaction _dbTransaction;
        private DbConnection _transactConnection;

        public UnitOfWorkBase()
        {
        }

        public void AddParameterToCommand(DbCommand cmd, string parameterName, DbType type, object value)
        {
            DbParameter param = cmd.CreateParameter();

            param.ParameterName = parameterName;
            param.DbType = type;
            param.Value = value;

            cmd.Parameters.Add(param);
        }

        public void BeginTransaction()
        {
            if (this._dbTransaction != null ||
                this._transactConnection != null)
            {
                throw new Exception("Já existe uma transação aberta no banco de dados!");
            }

            this._transactConnection = this.dbPrincipal.CreateConnection();
            this._transactConnection.Open();
            this._dbTransaction = this._transactConnection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (this._dbTransaction == null ||
                this._transactConnection == null)
            {
                throw new Exception("Não existe uma transação aberta no banco de dados!");
            }

            this._dbTransaction.Commit();
            this._dbTransaction = null;

            this._transactConnection.Close();
            this._transactConnection = null;
        }

        public void RollBackTransaction()
        {
            if (this._dbTransaction != null)
            {
                this._dbTransaction.Rollback();
                this._dbTransaction = null;

                this._transactConnection.Close();
                this._transactConnection = null;
            }
        }

        public void Dispose()
        {
            if (this._dbTransaction != null)
            {
                this._dbTransaction.Rollback();
                this._dbTransaction = null;
            }

            if (this._transactConnection != null)
            {
                this._transactConnection.Close();
                this._transactConnection = null;
            }
        }

        public bool TableExistis(string nm_Table)
        {
            int iCount = (int)this.dbPrincipal.ExecuteScalar(
              "dbo.Proc_ExistsTable", nm_Table);

            if (iCount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ViewExistis(string nm_View)
        {
            int iCount = (int)this.dbPrincipal.ExecuteScalar(
              "dbo.Proc_ExistsView", nm_View);

            if (iCount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
