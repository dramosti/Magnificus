using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Repository.Interfaces;
using System.Data;
using Ninject;
using HLP.Comum.Infrastructure;
using System.Data.Common;
using System.Data.SqlClient;

namespace HLP.Comum.Repository.Implementation
{
    public class ConfiguraBaseRepository : IConfiguraBaseRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        public DataTable GetServer()
        {
            try
            {
                DataTable dt = new DataTable();
                DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory("System.Data.SqlClient");

                if (dbProviderFactory.CanCreateDataSourceEnumerator)
                {
                    DbDataSourceEnumerator dbDataSourceEnumerator = dbProviderFactory.CreateDataSourceEnumerator();

                    if (dbDataSourceEnumerator != null)
                    {
                        dt = dbDataSourceEnumerator.GetDataSources();
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet GetDatabases(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = connectionString;
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand("SELECT name FROM sys.Databases", connection);
                da.Fill(ds, "sys.Databases");
                connection.Close();
                return ds;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool TestConnection(string connectionString)
        {
            bool ret = false;
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        ret = true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return ret;
        }

        public string GetConnectionString()         
        {
            return UndTrabalho.dbPrincipal.ConnectionString;
        }
    }
}
