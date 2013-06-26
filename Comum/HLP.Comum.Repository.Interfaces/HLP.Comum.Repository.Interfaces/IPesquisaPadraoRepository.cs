using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HLP.Comum.Models;
using System.Data;

namespace HLP.Comum.Repository.Interfaces
{
    public interface IPesquisaPadraoRepository
    {
        List<PesquisaPadraoModel> GetTableInformation(string sViewName);

        DataTable GetData(string sSelect, bool addDefault = false, string sWhere = "", bool bOrdena = true);

        string GetSingleData(string sSelect);

        string GetIdentityColumnName(string sTable);

        List<int> GetIdentityColumnValue(string sSelect);

        string GetFilter(string Value, string Operator, string sField, string sType);

        string ValidValue(string Value, string sType);

        string GetFkTableName(string sTable, string sField);

        void CreateViewByTable(string sTable);
        int GetFirstIDbyTable(string sTable, string sNameID = "");
    }
}
