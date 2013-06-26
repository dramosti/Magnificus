using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Repository.Interfaces;
using Ninject;
using Microsoft.Practices.EnterpriseLibrary.Data;
using HLP.Comum.Infrastructure;
using HLP.Comum.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace HLP.Comum.Repository.Implementation
{
    public class PesquisaPadraoRepository : IPesquisaPadraoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<PesquisaPadraoModel> regPesquisaPadraoAccessor;


        public List<PesquisaPadraoModel> GetTableInformation(string sViewName)
        {
            if (regPesquisaPadraoAccessor == null)
            {

                regPesquisaPadraoAccessor = UndTrabalho.dbPrincipal
                  .CreateSqlStringAccessor(@"select COLUMN_NAME, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS
                                           where TABLE_NAME = @sViewName",
                                 new Parameters(UndTrabalho.dbPrincipal)
                                 .AddParameter<string>("sViewName"),
                  MapBuilder<PesquisaPadraoModel>.MapAllProperties().DoNotMap(C => C.Operador)
                                                                    .DoNotMap(C => C.Valor)
                                                                    .DoNotMap(C => C.EOU)
                                                                    .DoNotMap(C => C.HeaderText)
                                                                    .Build());

            }
            return regPesquisaPadraoAccessor.Execute(sViewName).ToList();
        }


        public DataTable GetData(string sSelect, bool addDefault = false, string sWhere = "", bool bOrdena = true)
        {
            try
            {


                if (sWhere != "")
                {
                    if (sSelect.ToUpper().Contains("WHERE"))
                    {
                        sSelect += " and " + sWhere;
                    }
                    else
                    {
                        sSelect += " where " + sWhere;
                    }
                }
                if (sSelect.Contains("DISPLAY") && bOrdena)
                {
                    sSelect += " ORDER BY DISPLAY";
                }
                DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sSelect);
                IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);

                DataTable dt = new DataTable();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                }
                if (addDefault)
                {
                    dt.Rows.Add(0, "...");
                }
                while (reader.Read())
                {
                    object[] array = new object[reader.FieldCount];

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader[i].ToString() != "")
                        {
                            array[i] = reader[i].ToString().ToUpper();
                        }
                        else
                        {
                            if (reader[i].GetType() == typeof(string) || reader[i].GetType() == typeof(char))
                            {
                                array[i] = reader[i].ToString().ToUpper();
                            }
                        }
                    }
                    dt.Rows.Add(array);
                }
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public string GetSingleData(string sSelect)
        {
            DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sSelect);
            IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);

            string sRet = "";

            while (reader.Read())
            {
                sRet = reader[0].ToString();
            }
            return sRet;
        }


        public string GetIdentityColumnName(string sTable)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT COLUMN_NAME ");
            sql.Append("FROM INFORMATION_SCHEMA.COLUMNS ");
            sql.Append("WHERE TABLE_NAME = '" + sTable + "' ");
            sql.Append("AND COLUMNPROPERTY(object_id(TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1 ");


            DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sql.ToString());
            IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);

            reader.Read();
            return reader[0].ToString();
        }


        public List<int> GetIdentityColumnValue(string sSelect)
        {
            DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sSelect);
            IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);

            List<int> listRet = new List<int>();
            while (reader.Read())
            {
                listRet.Add(Convert.ToInt32(reader[0]));
            }
            return listRet;
        }


        public string GetFilter(string Value, string Operator, string sField, string sType)
        {
            string sql = "";
            string[] valores;
            List<string> sVal = new List<string>();

            switch (Operator)
            {
                case "Entre":
                    #region Codigo_Entre

                    if (Value.Contains('-') == false)
                    {
                        Value += "-" + ValidValue(Value, sType);
                    }

                    valores = Value.Split('-');

                    sql = " BETWEEN '" + ValidValue(valores[0], sType) + "' AND '" + ValidValue(valores[1], sType) + "'";

                    #endregion
                    break;

                case "Não Entre":
                    #region Codigo_Não_Entre

                    if (Value.Contains('-') == false)
                    {
                        Value += "-" + ValidValue(Value, sType);
                    }

                    valores = Value.Split('-');

                    sql = " NOT BETWEEN '" + ValidValue(valores[0], sType) + "' AND '" + ValidValue(valores[1], sType) + "'";

                    #endregion
                    break;

                case "Maior que":
                    #region Codigo_Maior_que

                    sql = " > '" + ValidValue(Value, sType) + "'";

                    #endregion
                    break;

                case "Maior Igual que":
                    #region Codigo_Maior_Igual_que

                    sql = " >= '" + ValidValue(Value, sType) + "'";

                    #endregion
                    break;

                case "Menor que":
                    #region Codigo_Menor_que

                    sql = " < '" + ValidValue(Value, sType) + "'";

                    #endregion
                    break;

                case "Menor Igual que":
                    #region Codigo_Menor_Igual_que

                    sql = " <= '" + ValidValue(Value, sType) + "'";

                    #endregion
                    break;

                case "Na Lista":
                    #region Codigo_Na_Lista

                    valores = Value.Split(';');
                    foreach (string i in valores)
                    {
                        if (!String.IsNullOrEmpty(i))
                        {
                            sVal.Add(ValidValue(i, sType));
                        }
                    }

                    sql = " IN (";
                    foreach (string item in sVal)
                    {
                        sql += "'" + item + "' ";
                        if (sVal.IndexOf(item) == sVal.Count() - 1)
                        {
                            sql += ")";
                        }
                        else { sql += ","; }

                    }


                    #endregion
                    break;

                case "Não na Lista":
                    #region Codigo_Não_na_Lista

                    valores = Value.Split(';');

                    foreach (string i in valores)
                    {
                        if (!String.IsNullOrEmpty(i))
                        {
                            sVal.Add(ValidValue(i, sType));
                        }
                    }

                    sql = " NOT IN (";
                    foreach (string item in sVal)
                    {
                        sql += "'" + item + "' ";
                        if (sVal.IndexOf(item) == sVal.Count() - 1)
                        {
                            sql += ")";
                        }
                        else { sql += ","; }

                    }

                    #endregion
                    break;

                case "Igual a":
                    #region Codigo_Igual_que

                    sql = " = '" + ValidValue(Value, sType) + "'";

                    #endregion
                    break;

                case "Diferente que":
                    #region Codigo_Diferente_que

                    sql = " <> '" + ValidValue(Value, sType) + "'";

                    #endregion
                    break;

                case "Começando com":
                    #region Codigo_Começando_com

                    sql = " LIKE '" + ValidValue(Value, sType) + "%'";

                    #endregion
                    break;

                case "Igual na Frase":
                    #region Codigo_Igual_na_Frase

                    sql = " LIKE '%" + ValidValue(Value, sType) + "%'";

                    #endregion
                    break;

                case "Branco":
                    #region Codigo_Branco

                    sql = " = '' OR " + sField + " IS NULL";

                    #endregion
                    break;

                case "Não Branco":
                    #region Codigo_Não_Branco

                    sql = " <> '' AND " + sField + " IS NOT NULL";

                    #endregion
                    break;
            }
            return sql;

        }


        public string ValidValue(string Value, string sType)
        {
            object objValor = "";
            string strValorCorreto = "";
            try
            {
                switch (sType)
                {
                    case "int":
                        strValorCorreto = "O valor " + Value + " não é um Número Inteiro válido" + Environment.NewLine + "Caso queira Pesquisar mais que um valor,deve-se separar por ';'(ponto e virgula)"; ;
                        objValor = Convert.ToInt32(Value);
                        break;

                    case "tinyint":
                        strValorCorreto = "O valor " + Value + " não é um Número válido" + Environment.NewLine + "Caso queira Pesquisar mais que um valor,deve-se separar por ';'(ponto e virgula)"; ;
                        objValor = Convert.ToByte(Value);
                        break;

                    case "string":
                    case "char":
                    case "varchar":
                    case "nvarchar":
                        objValor = Value;
                        break;

                    case "float":
                        strValorCorreto = "O valor " + Value + " não é um Número Decimal válido";
                        objValor = Convert.ToDouble(Value);
                        break;

                    case "datetime":
                        strValorCorreto = "O valor " + Value + " não é uma Data válida";
                        objValor = Convert.ToDateTime(Convert.ToDateTime(Value).ToShortDateString());
                        break;

                    case "decimal":
                        strValorCorreto = "O valor " + Value + " não é um Número Decimal válido";
                        objValor = Convert.ToDecimal(Value);
                        break;

                    case "bool":
                    case "bit":
                        if (Value.ToUpper().Trim() == "SIM" || Value.ToUpper().Trim() == "TRUE")
                        {
                            objValor = true;
                        }
                        else if (Value.ToUpper().Trim() == "NAO" || Value.ToUpper().Trim() == "NÃO" || Value.ToUpper().Trim() == "FALSE")
                        {
                            objValor = false;
                        }
                        else
                        {
                            strValorCorreto = "O valor " + Value + " não é válido!" + Environment.NewLine + "Valores esperados - SIM, NAO, TRUE, FALSE";
                            throw new System.Exception();

                        }
                        break;

                    case "":
                        objValor = Value;
                        break;
                }

                return objValor.ToString();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Valor Inválido para Pesquisa!"
                    + Environment.NewLine
                    + Environment.NewLine
                    + strValorCorreto);
            }

        }


        public string GetFkTableName(string sTable, string sField)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT COALESCE( OBJECT_NAME(S.REFERENCED_OBJECT_ID),'') 'TABLE' ");
                sql.Append("FROM SYS.FOREIGN_KEYS S ");
                sql.Append("INNER JOIN ");
                sql.Append("SYS.FOREIGN_KEY_COLUMNS FKC ON FKC.CONSTRAINT_OBJECT_ID = S.OBJECT_ID ");
                sql.Append("INNER JOIN ");
                sql.Append("SYS.COLUMNS C1 ON FKC.PARENT_COLUMN_ID = C1.COLUMN_ID AND FKC.PARENT_OBJECT_ID = C1.OBJECT_ID ");
                sql.Append("WHERE S.PARENT_OBJECT_ID = OBJECT_ID('" + sTable + "') ");
                sql.Append("AND C1.NAME ='" + sField + "'");


                DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sql.ToString());
                IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);



                reader.Read();
                return reader[0].ToString();

            }
            catch (Exception)
            {
                return "";
            }
        }


        public void CreateViewByTable(string sTable)
        {
            string snmView = "vw_" + sTable.Replace("_", "");
            string sCampos = string.Join(",", GetTableInformation(sTable).Select(c => c.COLUMN_NAME).ToArray());
            string sIdentity = GetIdentityColumnName(sTable);
            sCampos = sCampos.Replace(sIdentity, sIdentity + " AS ID ");

            string sQuery = string.Format("CREATE VIEW [dbo].[{0}] AS SELECT {1} FROM {2} ",
                                                snmView,
                                                sCampos,
                                                sTable);

            this.UndTrabalho.dbPrincipal.ExecuteNonQuery(sQuery);
        }

        public int GetFirstIDbyTable(string sTable, string sNameID = "")
        {
            if (sNameID == "")
            {
                sNameID = GetIdentityColumnName(sTable);
            }
            string sQuery = string.Format("SELECT TOP(1) {0} FROM {1}", sNameID, sTable);
            DbCommand cmd = UndTrabalho.dbPrincipal.GetSqlStringCommand(sQuery.ToString());
            IDataReader reader = UndTrabalho.dbPrincipal.ExecuteReader(cmd);
            reader.Read();
            return Convert.ToInt32(reader[0].ToString());
        }
    }
}
